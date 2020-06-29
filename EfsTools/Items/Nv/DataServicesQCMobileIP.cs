using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(459)]
    [Attributes(9)]
    public sealed class DataServicesQcMobileIp
    {
        public byte Value { get; set; }
    }
}