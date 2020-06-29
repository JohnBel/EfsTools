using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(854)]
    [Attributes(41)]
    public sealed class DataServicesMobileIpDmuPkoId
    {
        public byte Index { get; set; }


        public byte PkoId { get; set; }
    }
}