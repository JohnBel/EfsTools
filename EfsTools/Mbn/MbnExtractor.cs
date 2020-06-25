using System;
using System.IO;
using System.Linq;
using System.Text;
using EfsTools.Resourses;
using ELFSharp.ELF;

namespace EfsTools.Mbn
{
    internal class MbnExtractorException : Exception
    {
        public MbnExtractorException(string message)
            : base(message)
        {
        }
    }

    internal static class MbnExtractor
    {
        private static readonly string MagicString = "MCFG";
        private static readonly string TrailerMagicString = "MCFG_TRL";

        public static void Extract(string inputMbnFilePath, string outputDirectory, bool noExtraData, Logger logger)
        {
            try
            {
                var elf = ELFReader.Load(inputMbnFilePath);
                var segments = elf.Segments.ToArray();
                if (segments.Length < 3)
                {
                    throw new MbnExtractorException(Strings.MbnExtractorInvalidFormatElfDataNotExist);
                }

                var segment = segments[2];
                var contents = segment.GetFileContents();
                using (var stream = new MemoryStream(contents))
                {
                    ParseImage(stream, outputDirectory, noExtraData, logger);
                }
            }
            catch (MbnExtractorException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw new MbnExtractorException(e.Message);
            }
        }

        private static McfgHeader ReadMcfgHeader(Stream contents)
        {
            var buf = new byte[MagicString.Length];
            while (contents.Position < contents.Length)
            {
                var read = contents.Read(buf, 0, MagicString.Length);
                var str = Encoding.ASCII.GetString(buf, 0, read);
                if (str == MagicString)
                {
                    break;
                }

                if (contents.Position >= contents.Length)
                {
                    throw new MbnExtractorException(Strings.MbnExtractorInvalidFormatCantFindMagicString);
                }
            }

            var result = new McfgHeader();
            result.Magic = Encoding.ASCII.GetString(buf);
            var readToBuf = contents.Read(buf, 0, 2);
            result.FormatType = BitConverter.ToUInt16(buf, 0);
            readToBuf = contents.Read(buf, 0, 2);
            result.ConfigurationType = (ConfigurationType) BitConverter.ToUInt16(buf, 0);
            readToBuf = contents.Read(buf, 0, 4);
            result.ItemsCount = BitConverter.ToUInt32(buf, 0);
            readToBuf = contents.Read(buf, 0, 2);
            result.CarrierIndex = BitConverter.ToUInt16(buf, 0);
            readToBuf = contents.Read(buf, 0, 2);
            result.Reserved = BitConverter.ToUInt16(buf, 0);
            readToBuf = contents.Read(buf, 0, 2);
            var versionId = BitConverter.ToUInt16(buf, 0);
            if (versionId != 4995)
            {
                throw new MbnExtractorException(Strings.MbnExtractorInvalidFormatInvalidHeaderVersionId);
            }

            readToBuf = contents.Read(buf, 0, 2);
            var versionSize = BitConverter.ToUInt16(buf, 0);
            if (versionSize != 4)
            {
                throw new MbnExtractorException(Strings.MbnExtractorInvalidFormatInvalidHeaderVersionValue);
            }

            readToBuf = contents.Read(buf, 0, 4);
            result.Version = BitConverter.ToUInt32(buf, 0);
            return result;
        }

        private static ItemHeader ReadItemHeader(Stream contents)
        {
            var buf = new byte[4];
            var result = new ItemHeader();
            var readToBuf = contents.Read(buf, 0, 4);
            result.Length = BitConverter.ToUInt32(buf, 0);
            readToBuf = contents.Read(buf, 0, 1);
            result.Type = (ItemType) buf[0];
            readToBuf = contents.Read(buf, 0, 1);
            result.Attributes = buf[0];
            readToBuf = contents.Read(buf, 0, 2);
            result.Reserved = BitConverter.ToUInt16(buf, 0);
            return result;
        }

        private static void ParseImage(MemoryStream contents, string outputDirectory, bool noExtraData, Logger logger)
        {
            var mcfgHeader = ReadMcfgHeader(contents);
            for (var i = 0; i < mcfgHeader.ItemsCount - 1; ++i)
            {
                var itemHeader = ReadItemHeader(contents);

                switch (itemHeader.Type)
                {
                    case ItemType.Nv:
                        ParseNv(contents, itemHeader, outputDirectory, logger);
                        break;
                    case ItemType.NvFile:
                        ParseFile(contents, itemHeader, outputDirectory, true, noExtraData, logger);
                        break;
                    case ItemType.File:
                        ParseFile(contents, itemHeader, outputDirectory, false, noExtraData, logger);
                        break;
                    default:
                        throw new MbnExtractorException(Strings.MbnExtractorInvalidFormatUnknownItemType);
                }
            }

            ReadTrailer(contents);
        }

        private static void ReadTrailer(MemoryStream contents)
        {
            var buf = new byte[4];
            var readToBuf = contents.Read(buf, 0, 4);
            var recordLength = BitConverter.ToUInt32(buf, 0);

            var pos = contents.Position;

            readToBuf = contents.Read(buf, 0, 2);
            var trailerMagic = BitConverter.ToUInt16(buf, 0);
            if (trailerMagic != 10)
            {
                throw new MbnExtractorException(Strings.MbnExtractorInvalidFormatInvalidTrailerMagic1);
            }

            readToBuf = contents.Read(buf, 0, 2);
            var reserved = BitConverter.ToUInt16(buf, 0);

            readToBuf = contents.Read(buf, 0, 2);
            var trailerMagic2 = BitConverter.ToUInt16(buf, 0);
            if (trailerMagic2 != 0xA1)
            {
                throw new MbnExtractorException(Strings.MbnExtractorInvalidFormatInvalidTrailerMagic2);
            }

            readToBuf = contents.Read(buf, 0, 2);
            var dataLength = BitConverter.ToUInt16(buf, 0);
            if (dataLength < 8)
            {
                throw new MbnExtractorException(Strings.MbnExtractorInvalidFormatInvalidTrailerSize);
            }

            buf = new byte[dataLength];
            readToBuf = contents.Read(buf, 0, dataLength);
            var magic3 = Encoding.ASCII.GetString(buf, 0, 8);

            if (magic3 != TrailerMagicString)
            {
                throw new MbnExtractorException(Strings.MbnExtractorInvalidFormatInvalidTrailerMagicValue);
            }
        }

        private static void ParseFile(MemoryStream contents, ItemHeader itemHeader, string outputDirectory,
            bool isNvFile, bool noExtraData, Logger logger)
        {
            var pos = contents.Position;
            var buf = new byte[2];
            var readToBuf = contents.Read(buf, 0, 2);
            var fileHeaderMagic = BitConverter.ToUInt16(buf, 0);
            if (fileHeaderMagic != 1)
            {
                throw new MbnExtractorException(Strings.MbnExtractorInvalidFormatInvalidInvalidFileHeaderMagic);
            }

            readToBuf = contents.Read(buf, 0, 2);
            var fileNameLength = BitConverter.ToUInt16(buf, 0);
            buf = new byte[fileNameLength];
            readToBuf = contents.Read(buf, 0, fileNameLength);
            var fileName = Encoding.ASCII.GetString(buf, 0, fileNameLength - 1);

            readToBuf = contents.Read(buf, 0, 2);
            var fileSizeMagic = BitConverter.ToUInt16(buf, 0);
            if (fileSizeMagic != 2)
            {
                throw new MbnExtractorException(Strings.MbnExtractorInvalidFormatInvalidInvalidFileSizeMagic);
            }

            readToBuf = contents.Read(buf, 0, 2);
            var dataLength = BitConverter.ToUInt16(buf, 0) - 1;
            readToBuf = contents.Read(buf, 0, 1);
            var dataMagic = buf[0];

            buf = new byte[dataLength];
            readToBuf = contents.Read(buf, 0, dataLength);
            var realLength = contents.Position - pos + 8;
            if (realLength != itemHeader.Length)
            {
                throw new MbnExtractorException(Strings.MbnExtractorInvalidFormatInvalidInvalidFileItemSize);
            }

            logger.LogInfo(isNvFile ? $"  ItemFile:{fileName}" : $"  File:{fileName}");
            if (noExtraData)
            {
                SaveToFile(fileName, buf, outputDirectory);
            }
            else
            {
                var fileNameWithAttributes = isNvFile ? $"{fileName}__E1FF_F" : $"{fileName}__81FF_0";
                SaveToFile(fileNameWithAttributes, buf, outputDirectory);
            }
        }

        private static void ParseNv(MemoryStream contents, ItemHeader itemHeader, string outputDirectory, Logger logger)
        {
            var pos = contents.Position;
            var buf = new byte[2];
            var readToBuf = contents.Read(buf, 0, 2);
            var nvId = BitConverter.ToUInt16(buf, 0);
            readToBuf = contents.Read(buf, 0, 2);
            var dataLength = BitConverter.ToUInt16(buf, 0) - 1;
            readToBuf = contents.Read(buf, 0, 1);
            var dataMagic = buf[0];
            buf = new byte[dataLength];
            readToBuf = contents.Read(buf, 0, dataLength);
            var realLength = contents.Position - pos + 8;
            if (realLength != itemHeader.Length)
            {
                throw new MbnExtractorException(Strings.MbnExtractorInvalidFormatInvalidInvalidNvItemSize);
            }

            logger.LogInfo($"  Nv:{nvId:00000}");
            var fileName = $"NvItem__{nvId:00000000}";
            SaveToFile(fileName, buf, outputDirectory);
        }

        private static void SaveToFile(string fileName, byte[] content, string outputDirectory)
        {
            var filePath = fileName.Replace("/", "\\");
            var path = filePath.StartsWith("\\") ? $"{outputDirectory}{filePath}" : $"{outputDirectory}\\{filePath}";
            var dir = Path.GetDirectoryName(path);
            if (dir != null)
            {
                Directory.CreateDirectory(dir);
            }

            using (var file = File.Create(path))
            {
                file.Write(content, 0, content.Length);
                file.Flush(true);
                file.Close();
            }
        }
    }
}