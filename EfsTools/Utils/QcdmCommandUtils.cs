using System.Text;
using EfsTools.Qualcomm.QcdmCommands;

namespace EfsTools.Utils
{
    internal static class QcdmCommandUtils
    {
        public static string ToString(QcdmCommand command, byte[] data)
        {
            var sb = new StringBuilder();
            if (data == null)
            {
                sb.Append(" null");
            }
            else
            {
                if (data.Length > 3 && command == QcdmCommand.SubsysCmd)
                {
                    var text = QcdmSubSystemCommandUtils.ToString(data);
                    sb.Append(text);
                }
                else
                {
                    sb.Append(command);
                }

                sb.Append(ToString(data));
            }

            return sb.ToString();
        }

        public static string ToString(byte[] data)
        {
            var sb = new StringBuilder();
            if (data == null)
            {
                sb.Append(" null");
            }
            else
            {
                sb.Append(" [");
                var addComma = false;
                foreach (var b in data)
                {
                    if (addComma)
                    {
                        sb.Append(", ");
                    }

                    addComma = true;
                    sb.AppendFormat("{0:X2}", b);
                }

                sb.Append("]");
            }

            return sb.ToString();
        }
    }
}