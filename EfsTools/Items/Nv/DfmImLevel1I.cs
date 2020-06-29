using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(613)]
    [Attributes(9)]
    public sealed class DfmImLevel1
    {
        public sbyte Value { get; set; }
    }
}