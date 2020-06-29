using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(970)]
    [Attributes(9)]
    public sealed class C0RxAgcVrefVal
    {
        public byte Value { get; set; }
    }
}