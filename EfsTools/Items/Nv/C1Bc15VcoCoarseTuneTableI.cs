using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4348)]
    [Attributes(9)]
    public sealed class C1Bc15VcoCoarseTuneTable
    {
        public byte[] Value { get; set; }
    }
}