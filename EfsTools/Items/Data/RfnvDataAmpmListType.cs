using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class RfnvDataAmpmListType
    {
        public byte AmamAmpmIdentifier { get; set; }


        public byte ChannelIndex { get; set; }

        [FieldCount(128)]
        public short[] DataList
        {
            get;
        }
    }
}