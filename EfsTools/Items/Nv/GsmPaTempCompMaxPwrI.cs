using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4369)]
    [Attributes(9)]
    public sealed class GsmPaTempCompMaxPwr
    {
        [FieldCount(16)]
        public short[] Value
        {
            get;
        }
    }
}