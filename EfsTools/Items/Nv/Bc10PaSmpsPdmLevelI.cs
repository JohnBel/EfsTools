using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6869)]
    [Attributes(9)]
    public sealed class Bc10PaSmpsPdmLevel
    {
        [FieldCount(64)]
        public short[] Value
        {
            get;
        }
    }
}