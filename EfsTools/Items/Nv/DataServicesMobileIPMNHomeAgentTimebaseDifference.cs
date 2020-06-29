using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(494)]
    [Attributes(41)]
    public sealed class DataServicesMobileIpMnHomeAgentTimebaseDifference
    {
        public byte Index { get; set; }


        public uint TimeDelta { get; set; }
    }
}