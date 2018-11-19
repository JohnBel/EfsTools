using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1897)]
    [Attributes(9)]
    public class Ipv6StateMachineConfiguration
    {
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort InitSolDelay { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort SolInterval { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ResolInterval { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort MaxSolAttempts { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort MaxResolAttempts { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort PreRaExpResolTime { get; set; }
    }
}