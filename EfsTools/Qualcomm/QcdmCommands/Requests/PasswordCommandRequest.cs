using System;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests
{
    [QcdmCommand(QcdmCommand.Password)]
    internal class PasswordCommandRequest : BaseCommandRequest, IQcdmCommandRequest
    {
        public PasswordCommandRequest(string password)
        {
            _password = Encoding.ASCII.GetBytes(password);
        }

        public new byte[] GetData()
        {
            var data = new byte[9];
            data[0] = (byte) Command;
            var len = Math.Min(_password.Length, 8);
            Array.Copy(_password, 0, data, 1, len);
            return data;
        }

        private readonly byte[] _password;
    }
}