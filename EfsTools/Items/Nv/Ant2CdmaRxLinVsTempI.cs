using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(499)]
    [Attributes(9)]
    public sealed class Ant2CdmaRxLinVsTemp
    {
        [FieldCount(8)]
        public sbyte[] Value
        {
            get;
        }
    }
}