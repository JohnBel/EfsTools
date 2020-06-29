using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(463)]
    [Attributes(13)]
    public sealed class DataServicesMobileIpNumberProfiles
    {
        public byte Value { get; set; }
    }
}