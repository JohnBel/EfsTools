using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5883)]
    [Attributes(9)]
    public sealed class Bc0HdrRevaTxPredistort
    {
        [FieldCount(16)]
        public sbyte[] Value
        {
            get;
        }
    }
}