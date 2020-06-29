using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5194)]
    [Attributes(9)]
    public sealed class Bc10TxPdm0
    {
        [FieldCount(64)]
        public short[] Value
        {
            get;
        }
    }
}