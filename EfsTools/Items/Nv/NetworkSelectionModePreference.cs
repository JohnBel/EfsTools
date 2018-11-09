using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(849)]
    [Attributes(41)]
    public class NetworkSelectionModePreference
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Nam { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort NetSelMode { get; set; }
    }
}