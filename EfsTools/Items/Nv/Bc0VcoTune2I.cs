using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3237)]
    [Attributes(9)]
    public sealed class Bc0VcoTune2
    {
        [FieldCount(48)]
        public byte[] Value
        {
            get;
        }
    }
}