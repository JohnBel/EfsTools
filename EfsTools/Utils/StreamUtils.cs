using System.IO;

namespace EfsTools.Utils
{
    internal static class StreamUtils
    {
        public static void CopyWithSeek(Stream source, Stream dest)
        {
            var buf = new byte[1024];
            while (source.Position < source.Length)
            {
                var read = source.Read(buf, 0, buf.Length);
                if (read == 0)
                {
                    break;
                }

                dest.Write(buf, 0, read);
            }
        }

        public static void Copy(Stream source, Stream dest)
        {
            var buf = new byte[4 * 1024];
            var read = source.Read(buf, 0, buf.Length);
            while (read > 0)
            {
                dest.Write(buf, 0, read);
                read = source.Read(buf, 0, buf.Length);
            }
        }


        public static Stream CreateLoggerStream(Logger logger)
        {
            return new LoggerStream(logger);
        }
    }
}