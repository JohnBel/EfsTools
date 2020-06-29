using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxLinV3DpdInfoType
    {
        public byte DpdTypeUsed { get; set; }


        public ushort NumDpdUsed { get; set; }

        [FieldCount(64)]
        public ushort[] DpdIdx
        {
            get;
        }
    }
}