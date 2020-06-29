using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3555)]
    [Attributes(9)]
    public sealed class Bc14ExpHdetVsAgc
    {
        [FieldCount(16)]
        public byte[] Value
        {
            get;
        }
    }
}