using System;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Qualcomm.QcdmCommands.Base;
using EfsTools.Utils;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    //typedef struct
    //{
    //  uint8 cmd_code;		/*!< Command code */
    //  uint8 ts_type;		/*!< Time stamp type */
    //  uint8 num_args;		/*!< Number of arguments in message */
    //  uint8 drop_cnt;		/*!< number of messages dropped since last successful message */
    //  qword ts;			    /*!< Time stamp */
    //}
    //msg_hdr_type;

    //typedef struct
    //{
    //  uint16 line;			/*!< Line number in source file */
    //  uint16 ss_id;			/*!< Subsystem ID               */
    //  uint32 ss_mask;		/*!< Subsystem Mask             */
    //}
    //msg_desc_type;

    //typedef struct
    //{
    //  msg_hdr_type hdr;     /*!< Header */
    //  msg_desc_type desc;   /*!< line number, SSID, mask */
    //  uint32 args[1];		/*!< Array of long args, specified by
    //            'hdr.num_args' */
    //		    /*!< followed by NULL terminated format and file strings */
    //}
    //msg_ext_type;

    [QcdmCommand(QcdmCommand.ExtMsg)]
    [QcdmMinResponseLength(20)]
    internal class ExtMsgCommandResponse : BaseCommandResponse
    {
        private ExtMsgCommandResponse()
        {
        }

        public string Message { get; private set; }
        public string Source { get; private set; }

        public ushort Line { get; private set; }

        public ushort SubSystemId { get; private set; }

        public byte DropCount { get; private set; }
        public MessageId MessageId { get; private set; }
        public DateTime Time { get; private set; }

        public uint Level { get; private set; }

        public static ExtMsgCommandResponse Parse(byte[] data)
        {
            var result = new ExtMsgCommandResponse();
            result.CheckResponse(data);
            var tsType = data[1];
            var numArgs = data[2];
            result.DropCount = data[3];
            var ts = BitConverter.ToInt64(data, 4);
            result.Time = DateTimeUtils.DateTimeFromQualcommTs(ts);
            result.Line = BitConverter.ToUInt16(data, 8);
            result.SubSystemId = BitConverter.ToUInt16(data, 10);
            var subSystemMask = BitConverter.ToUInt32(data, 12);
            var args = new uint[numArgs];
            result.Level = (uint) (data[12] + (data[13] << 8));
            var messageId = data[14] + (data[15] << 8);
            result.MessageId = (MessageId) messageId;
            var flags = BitConverter.ToUInt32(data, 16);
            var index = 20;
            for (var i = 0; i < numArgs; ++i)
            {
                args[i] = BitConverter.ToUInt32(data, index);
                index += 4;
            }

            var str = Encoding.ASCII.GetString(data, index, data.Length - index);
            var parts = str.Split('\0');
            if (parts.Length > 1)
            {
                result.Message = parts[0].Trim();
            }

            if (parts.Length > 2)
            {
                result.Source = parts[1].Trim();
            }

            return result;
        }
    }
}