using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023218", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc14TxPwrTempComp
    {
        public sbyte Reserved { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa0PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa0PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa1PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa1PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa2PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa2PowerSlope
        {
            get;
        }

        [FieldCount(8)]
        public sbyte[] Pa3PowerOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] Pa3PowerSlope
        {
            get;
        }
    }
}