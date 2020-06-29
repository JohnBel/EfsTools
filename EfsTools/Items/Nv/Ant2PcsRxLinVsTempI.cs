using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(508)]
    [Attributes(9)]
    public sealed class Ant2PcsRxLinVsTemp
    {
        [FieldCount(8)]
        public sbyte[] Value
        {
            get;
        }
    }
}