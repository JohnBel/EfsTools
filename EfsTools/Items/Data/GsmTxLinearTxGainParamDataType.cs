using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class GsmTxLinearTxGainParamDataType
    {
        public ushort GsmLinearTxGainVal { get; set; }


        public ushort EdgeLinearTxGainVal { get; set; }

        [                                 FieldCount(16)]
        public byte[] CharpredistEnvGain
        {
            get;
        }
    }
}