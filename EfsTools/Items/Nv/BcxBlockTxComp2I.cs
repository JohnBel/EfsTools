using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4558)]
    [Attributes(9)]
    public sealed class BcxBlockTxComp2
    {
        [FieldCount(32)]
        public sbyte[] Value
        {
            get;
        }
    }
}