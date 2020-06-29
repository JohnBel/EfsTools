using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6874)]
    [Attributes(25)]
    public sealed class Asid1Data
    {
        public byte SessionType { get; set; }


        public sbyte Reserved { get; set; }
    }
}