using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(453)]
    [Attributes(9)]
    public sealed class FactoryTestmodePhoneMode
    {
        public byte Value { get; set; }
    }
}