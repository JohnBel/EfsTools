using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2773)]
    [Attributes(9)]
    public sealed class Gsm1900PolarPathDelay
    {
        public short Value { get; set; }
    }
}