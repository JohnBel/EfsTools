using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3629)]
    [Attributes(9)]
    public sealed class DtmMultislotClass
    {
        public byte Value { get; set; }
    }
}