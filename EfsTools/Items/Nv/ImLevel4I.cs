using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(586)]
    [Attributes(9)]
    public sealed class ImLevel4
    {
        public sbyte Value { get; set; }
    }
}