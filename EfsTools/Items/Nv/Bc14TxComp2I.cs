using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3544)]
    [Attributes(9)]
    public sealed class Bc14TxComp2
    {
        [FieldCount(32)]
        public sbyte[] Value
        {
            get;
        }
    }
}