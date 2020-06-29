using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(405)]
    [Attributes(9)]
    public sealed class Is2000CaiRadioConfigurationRcPreference
    {
        public ushort Value { get; set; }
    }
}