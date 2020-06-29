using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6295)]
    [Attributes(9)]
    public sealed class Gsm900LinearEnvdcCalVal
    {
        public short Value { get; set; }
    }
}