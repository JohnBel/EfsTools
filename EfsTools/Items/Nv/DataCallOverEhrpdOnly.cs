using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7147)]
    [Attributes(9)]
    public sealed class DataCallOverEhrpdOnly
    {
        public byte EhrpdOnlyFlag { get; set; }


        public byte MaxFailureCount { get; set; }


        public byte MaxFailureTotalCount { get; set; }


        public byte NewAttemptMaxTimer { get; set; }
    }
}