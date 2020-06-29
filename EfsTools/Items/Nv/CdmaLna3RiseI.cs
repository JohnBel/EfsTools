using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(592)]
    [Attributes(9)]
    public sealed class CdmaLna3Rise
    {
        public sbyte Value { get; set; }
    }
}