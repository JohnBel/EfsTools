using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1646)]
    [Attributes(9)]
    public sealed class Bc1VcoCoarseTuneTable
    {
        [FieldCount(48)]
        public byte[] Value
        {
            get;
        }
    }
}