using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6294)]
    [Attributes(9)]
    public sealed class Gsm850LinearEnvdcCalVal
    {
        public short Value { get; set; }
    }
}