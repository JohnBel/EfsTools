using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5185)]
    [Attributes(9)]
    public sealed class Bc10VcoTune2
    {
        [FieldCount(48)]
        public byte[] Value
        {
            get;
        }
    }
}