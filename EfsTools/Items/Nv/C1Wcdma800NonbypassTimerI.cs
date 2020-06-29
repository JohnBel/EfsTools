using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3845)]
    [Attributes(9)]
    public sealed class C1Wcdma800NonbypassTimer
    {
        public byte Value { get; set; }
    }
}