using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(441)]
    [Attributes(41)]
    public sealed class BandClassPreference
    {
        public byte Nam { get; set; }


        public short Band { get; set; }
    }
}