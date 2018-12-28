using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(441)]
    [Attributes(41)]
    public class BandClassPreference
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Nam { get; set; }

        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short Band { get; set; }
    }
}