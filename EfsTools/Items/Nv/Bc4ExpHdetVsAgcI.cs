using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1487)]
    [Attributes(9)]
    public sealed class Bc4ExpHdetVsAgc
    {
        [FieldCount(16)]
        public byte[] Value
        {
            get;
        }
    }
}