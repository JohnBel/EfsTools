using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4569)]
    [Attributes(9)]
    public sealed class BcxBlockExpHdetVsAgc
    {
        [FieldCount(16)]
        public byte[] Value
        {
            get;
        }
    }
}