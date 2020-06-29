using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class RfnvDataPmeasListType
    {
        public byte Mod { get; set; }


        public byte ChannelIndex { get; set; }


        public byte PaState { get; set; }

        [FieldCount(32)]
        public short[] PmeasList
        {
            get;
        }
    }
}