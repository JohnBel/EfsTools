using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3616)]
    [Attributes(9)]
    public sealed class C1Bc14VcoCoarseTuneTable
    {
        [FieldCount(16)]
        public byte[] Value
        {
            get;
        }
    }
}