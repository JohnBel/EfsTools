using System;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Qualcomm.QcdmCommands.Base;
using EfsTools.Utils;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    //typedef struct
    //{
    //  uint8 cmd_code;
    //  uint8 more;   /* Indicates how many log entries, not including the one 
    //                   returned with this packet, are queued up in the Mobile
    //                   Station.  If DIAG_DIAGVER >= 8, this should be set to 0 */
    //  uint16 len;   /* Indicates the length, in bytes, of the following log entry */
    //  uint8 log[1]; /* Contains the log entry data. */
    //}
    //diag_log_rsp_type;

    [QcdmCommand(QcdmCommand.Log)]
    [QcdmMinResponseLength(32)]
    internal class LogCommandResponse : BaseCommandResponse
    {
        private LogCommandResponse()
        {
        }

        public LogId LogId { get; private set; }
        public string Message { get; private set; }

        public string Source { get; private set; }

        public DateTime Time { get; private set; }

        public static LogCommandResponse Parse(byte[] data)
        {
            var result = new LogCommandResponse();
            result.CheckResponse(data);
            var more = data[1];
            var length = data[2] + (data[3] << 8);
            var logId = data[6] + (data[7] << 8);
            result.LogId = (LogId) logId;

            var ts = BitConverter.ToInt64(data, 8);
            result.Time = DateTimeUtils.DateTimeFromQualcommTs(ts);

            var str = Encoding.ASCII.GetString(data, 32, data.Length - 32);
            ;
            var parts = str.Split('\0');
            if (parts.Length == 1)
            {
                result.Message = parts[0].Trim();
            }
            else if (parts.Length > 1)
            {
                result.Message = parts[1].Trim();
                result.Source = parts[0].Trim();
            }

            return result;
        }
    }
}