using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1566)]
    [Attributes(9)]
    public sealed class Bc3ExpHdetVsAgc
    {
        [FieldCount(16)]
        public byte[] Value
        {
            get;
        }
    }
}