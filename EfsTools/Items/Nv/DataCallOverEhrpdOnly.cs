using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
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