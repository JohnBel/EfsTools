using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3625)]
    [Attributes(9)]
    public sealed class C1Bc14RxCalChanLru
    {
        [FieldCount(16)]
        public byte[] Value
        {
            get;
        }
    }
}