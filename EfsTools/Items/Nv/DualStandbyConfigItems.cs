using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
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