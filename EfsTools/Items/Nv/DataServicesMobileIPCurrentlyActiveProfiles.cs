using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(464)]
    [Attributes(13)]
    public sealed class DataServicesMobileIpCurrentlyActiveProfiles
    {
        public byte Value { get; set; }
    }
}