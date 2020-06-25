using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5090)]
    [Attributes(9)]
    public sealed class WcdmaHsupaCmController
    {
        public byte Value { get; set; }
    }
}