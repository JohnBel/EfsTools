using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(909)]
    [Attributes(9)]
    public sealed class GsmUmtsSmsBearerPreference
    {
        public byte Value { get; set; }
    }
}