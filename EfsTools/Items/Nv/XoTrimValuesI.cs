using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4212)]
    [Attributes(9)]
    public sealed class XoTrimValues
    {
        public byte Current { get; set; }


        public byte Table { get; set; }
    }
}