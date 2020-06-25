using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2951)]
    [Attributes(9)]
    public sealed class WcdmaDchAgcUpdateTxAgcTime
    {
        public short Value { get; set; }
    }
}