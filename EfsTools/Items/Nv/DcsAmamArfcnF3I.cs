using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3143)]
    [Attributes(9)]
    public sealed class DcsAmamArfcnF3
    {
        public ushort Value { get; set; }
    }
}