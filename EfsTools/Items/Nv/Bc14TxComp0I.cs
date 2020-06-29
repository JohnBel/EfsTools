using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3542)]
    [Attributes(9)]
    public sealed class Bc14TxComp0
    {
        [FieldCount(32)]
        public sbyte[] Value
        {
            get;
        }
    }
}