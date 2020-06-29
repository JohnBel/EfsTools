using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(500)]
    [Attributes(9)]
    public sealed class Ant2CdmaRxSlpVsTemp
    {
        [FieldCount(8)]
        public sbyte[] Value
        {
            get;
        }
    }
}