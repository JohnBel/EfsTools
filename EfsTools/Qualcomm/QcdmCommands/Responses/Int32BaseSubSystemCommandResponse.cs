using System;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.DiagServ
{
    internal class Int32BaseSubSystemCommandResponse<TChildClass> : BaseSubSystemCommandResponse
    {
        public int Value { get; private set; }

        public static TChildClass Parse(byte[] data)
        {
            dynamic result = Activator.CreateInstance(typeof(TChildClass));
            if (result != null)
            {
                result.CheckResponse(data);
                result.Value = BitConverter.ToInt32(data, 4);
            }
            return result;
        }
    }
}