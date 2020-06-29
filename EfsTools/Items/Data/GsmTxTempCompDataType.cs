using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class GsmTxTempCompDataType
    {
        [FieldCount(16)]
        public short[] TempCompPclPwrScaling
        {
            get;
        }

        [FieldCount(16)]
        public ushort[] HotTempCompPclPwrOffsetGsmk
        {
            get;
        }

        [FieldCount(16)]
        public ushort[] ColdTempCompPclPwrOffsetGsmk
        {
            get;
        }

        [FieldCount(16)]
        public ushort[] HotTempCompPclPwrOffset8psk
        {
            get;
        }

        [FieldCount(16)]
        public ushort[] ColdTempCompPclPwrOffset8psk
        {
            get;
        }
    }
}