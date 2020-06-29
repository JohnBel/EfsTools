using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class GsmTxGtrThreshDataType
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short AdvTime { get; set; }
    }
}