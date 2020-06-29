using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class RfnvDataTxPwrErrListType
    {
        public byte Mod { get; set; }


        public byte ChannelIndex { get; set; }

        [FieldCount(16)]
        public short[] PwrErrList
        {
            get;
        }
    }
}