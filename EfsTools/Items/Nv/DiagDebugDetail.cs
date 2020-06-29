using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1895)]
    [Attributes(9)]
    public sealed class DiagDebugDetail
    {
        public sbyte Value { get; set; }
    }
}