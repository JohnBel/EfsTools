using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6142)]
    [Attributes(9)]
    public sealed class BcxBlockVcoTune2
    {
        [FieldCount(48)]
        public byte[] Value
        {
            get;
        }
    }
}