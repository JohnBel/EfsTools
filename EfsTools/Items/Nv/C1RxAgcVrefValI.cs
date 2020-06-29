using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(971)]
    [Attributes(9)]
    public sealed class C1RxAgcVrefVal
    {
        public byte Value { get; set; }
    }
}