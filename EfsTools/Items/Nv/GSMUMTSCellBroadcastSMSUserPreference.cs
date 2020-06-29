using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1017)]
    [Attributes(9)]
    public sealed class GsmUmtsCellBroadcastSmsUserPreference
    {
        public byte Value { get; set; }
    }
}