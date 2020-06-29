using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxLinV3AptsType
    {
        [FieldCount(64)]
        public uint[] Apt
        {
            get;
        }
    }
}