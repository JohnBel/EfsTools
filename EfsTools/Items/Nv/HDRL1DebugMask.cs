using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4231)]
    [Attributes(9)]
    public sealed class HdrL1DebugMask
    {
        public ulong Field1 { get; set; }


        public ulong Field2 { get; set; }
    }
}