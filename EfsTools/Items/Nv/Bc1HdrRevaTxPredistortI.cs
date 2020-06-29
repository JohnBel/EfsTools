using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5884)]
    [Attributes(9)]
    public sealed class Bc1HdrRevaTxPredistort
    {
        [FieldCount(16)]
        public sbyte[] Value
        {
            get;
        }
    }
}