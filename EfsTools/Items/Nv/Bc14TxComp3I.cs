using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3545)]
    [Attributes(9)]
    public sealed class Bc14TxComp3
    {
        [FieldCount(32)]
        public sbyte[] Value
        {
            get;
        }
    }
}