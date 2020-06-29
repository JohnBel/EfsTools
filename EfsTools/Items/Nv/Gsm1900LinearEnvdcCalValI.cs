using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6297)]
    [Attributes(9)]
    public sealed class Gsm1900LinearEnvdcCalVal
    {
        public short Value { get; set; }
    }
}