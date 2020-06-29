using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5886)]
    [Attributes(9)]
    public sealed class Bc4HdrRevaTxPredistort
    {
        [FieldCount(16)]
        public sbyte[] Value
        {
            get;
        }
    }
}