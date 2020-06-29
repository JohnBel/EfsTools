using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(707)]
    [Attributes(9)]
    public sealed class DataServicesMobileIpRrqIfTraffic
    {
        public byte Value { get; set; }
    }
}