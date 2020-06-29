using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(176)]
    [Attributes(45)]
    public sealed class ImsiMcc
    {
        public byte Nam { get; set; }


        public ushort Value { get; set; }
    }
}