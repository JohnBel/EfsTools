using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1193)]
    [Attributes(13)]
    public sealed class DataServicesMobileIpQcHanddown
    {
        public byte Value { get; set; }
    }
}