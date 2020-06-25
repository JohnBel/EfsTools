using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6876)]
    [Attributes(25)]
    public sealed class DualStandbyConfigItems
    {
        public byte DedicatedVoiceSubs { get; set; }


        public byte DedicatedDataSubs { get; set; }


        public byte ActiveSubs { get; set; }


        public byte PrioritySubs { get; set; }


        public byte DualStandbyPref { get; set; }


        public byte Reserved { get; set; }
    }
}