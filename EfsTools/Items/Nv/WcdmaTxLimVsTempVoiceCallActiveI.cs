using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3512)]
    [Attributes(9)]
    public sealed class WcdmaTxLimVsTempVoiceCallActive
    {
        [FieldCount(8)]
        public byte[] Value { get; set; }
    }
}