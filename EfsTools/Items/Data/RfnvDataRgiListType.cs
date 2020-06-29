using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class RfnvDataRgiListType
    {
        public byte Mod { get; set; }


        public byte PaState { get; set; }


        public byte ValidRgiNum { get; set; }

        [FieldCount(32)]
        public byte[] RgiList
        {
            get;
        }
    }
}