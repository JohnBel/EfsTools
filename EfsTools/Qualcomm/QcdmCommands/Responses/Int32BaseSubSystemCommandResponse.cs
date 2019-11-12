using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.DiagServ
{
    internal class Int32BaseSubSystemCommandResponse<TChildClass> : BaseSubSystemCommandResponse
    {
        public Int32BaseSubSystemCommandResponse()
            : base()
        {

        }

        public int Value { get; private set; }

        public static TChildClass Parse(byte[] data)
        {
            dynamic result = Activator.CreateInstance(typeof(TChildClass));
            result.CheckResponse(data);
            result.Value = BitConverter.ToInt32(data, 4);
            return result;
        }
    }
}