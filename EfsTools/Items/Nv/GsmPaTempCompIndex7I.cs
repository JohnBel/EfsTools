using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1280)]
    [Attributes(9)]
    public sealed class GsmPaTempCompIndex7
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}