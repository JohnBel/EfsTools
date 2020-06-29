using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3068)]
    [Attributes(9)]
    public sealed class Gsm1900PaEnStart
    {
        public short Value { get; set; }
    }
}