using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6413)]
    [Attributes(9)]
    public sealed class C1Wcdma1800RxfIciICoef45
    {
        public uint Value { get; set; }
    }
}