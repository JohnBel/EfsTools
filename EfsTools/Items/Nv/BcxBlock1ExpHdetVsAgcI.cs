using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6074)]
    [Attributes(9)]
    public sealed class BcxBlock1ExpHdetVsAgc
    {
        [FieldCount(16)]
        public byte[] Value
        {
            get;
        }
    }
}