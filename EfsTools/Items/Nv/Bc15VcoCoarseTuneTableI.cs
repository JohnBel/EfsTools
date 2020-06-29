using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4289)]
    [Attributes(9)]
    public sealed class Bc15VcoCoarseTuneTable
    {
        [FieldCount(48)]
        public byte[] Value
        {
            get;
        }
    }
}