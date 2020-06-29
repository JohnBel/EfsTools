using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1016)]
    [Attributes(9)]
    public sealed class GsmUmtsCellBroadcastSmsCarrierConfiguration
    {
        public byte Value { get; set; }
    }
}