using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1411)]
    [Attributes(9)]
    public sealed class Bc5VcoCoarseTuneTable
    {
        [FieldCount(48)]
        public byte[] Value
        {
            get;
        }
    }
}