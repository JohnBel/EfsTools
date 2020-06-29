using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(849)]
    [Attributes(41)]
    public sealed class NetworkSelectionModePreference
    {
        public byte Nam { get; set; }


        public ushort NetSelMode { get; set; }
    }
}