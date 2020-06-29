using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class GsmTxSmpsPdmDataType
    {
        [FieldCount(6)]
        public ushort[] CalSmpsPdmTbl
        {
            get;
        }

        [FieldCount(16)]
        public ushort[] GsmSmpsPdmTbl
        {
            get;
        }

        [FieldCount(16)]
        public ushort[] EdgeSmpsPdmTbl
        {
            get;
        }
    }
}