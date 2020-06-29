using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6296)]
    [Attributes(9)]
    public sealed class Gsm1800LinearEnvdcCalVal
    {
        public short Value { get; set; }
    }
}