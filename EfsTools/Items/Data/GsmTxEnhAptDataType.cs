using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class GsmTxEnhAptDataType
    {
        public byte PclThresholdVal { get; set; }


        public ushort VbattThresholdLowPwr { get; set; }


        public ushort VbattThresholdHighPwr { get; set; }
    }
}