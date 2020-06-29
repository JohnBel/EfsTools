using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1930)]
    [Attributes(9)]
    public sealed class AGpsEmergencyServicesSupport
    {
        public byte Value { get; set; }
    }
}