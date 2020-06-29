using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6040)]
    [Attributes(9)]
    public sealed class C1Wcdma800RxfIciQCoef45
    {
        public uint Value { get; set; }
    }
}