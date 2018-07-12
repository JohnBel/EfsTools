using System;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests
{
    [QcdmCommand(QcdmCommand.Spc)]
    internal class SpcCommandRequest : BaseCommandRequest, IQcdmCommandRequest
    {
        public SpcCommandRequest(string spc)
        {
            _spc = Encoding.ASCII.GetBytes(spc);
        }

        public new byte[] GetData()
        {
            var data = new byte[7];
            data[0] = (byte) Command;
            var len = Math.Min(_spc.Length, 6);
            Array.Copy(_spc, 0, data, 1, len);
            return data;
        }

        private readonly byte[] _spc;
    }
}