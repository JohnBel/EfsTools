using System;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands;

namespace EfsTools.Utils
{
    internal static class QcdmSubSystemCommandUtils
    {
        public static string ToString(byte[] data)
        {
            var sb = new StringBuilder();
            sb.Append("SubSystem.");
            var subCommand = (QcdmSubSystem)data[1];
            var subSubCommand = BitConverter.ToUInt16(data, 2);
            sb.Append(subCommand);
            sb.Append("(");
            switch (subCommand)
            {
                case QcdmSubSystem.DiagServ:
                {
                    var diagServSubCommand = (QcdmDiagServCommand)subSubCommand;
                    sb.AppendFormat("{0}", diagServSubCommand);
                }
                break;
                case QcdmSubSystem.Efs:
                {
                    var efsSubCommand = (QcdmEfsCommand)subSubCommand;
                    sb.AppendFormat("{0}", efsSubCommand);
                }
                break;
                default:
                    sb.AppendFormat("{0}", subSubCommand);
                    break;
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}
