using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3932)]
    [Attributes(9)]
    public sealed class C0Bc11RxCalChanLru
    {
        [FieldCount(16)]
        public byte[] Value
        {
            get;
        }
    }
}