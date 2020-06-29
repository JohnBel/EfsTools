using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4556)]
    [Attributes(9)]
    public sealed class BcxBlockTxComp0
    {
        [FieldCount(32)]
        public sbyte[] Value
        {
            get;
        }
    }
}