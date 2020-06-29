using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5891)]
    [Attributes(9)]
    public sealed class Bc14HdrRevaTxPredistort
    {
        [FieldCount(16)]
        public sbyte[] Value
        {
            get;
        }
    }
}