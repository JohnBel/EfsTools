using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022738", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaB2TxLinVsTemp2Addl
    {
        [FieldCount(8)]
        public sbyte[] F0CompVsTemp { get; set; }

        [FieldCount(8)]
        public sbyte[] F1CompVsTemp { get; set; }

        [FieldCount(8)]
        public sbyte[] F2CompVsTemp { get; set; }

        [FieldCount(8)]
        public sbyte[] F3CompVsTemp { get; set; }

        [FieldCount(8)]
        public sbyte[] F4CompVsTemp { get; set; }

        [FieldCount(8)]
        public sbyte[] F5CompVsTemp { get; set; }

        [FieldCount(8)]
        public sbyte[] F6CompVsTemp { get; set; }

        [FieldCount(8)]
        public sbyte[] F7CompVsTemp { get; set; }

        [FieldCount(8)]
        public sbyte[] F8CompVsTemp { get; set; }

        [FieldCount(8)]
        public sbyte[] F9CompVsTemp { get; set; }

        [FieldCount(8)]
        public sbyte[] F10CompVsTemp { get; set; }

        [FieldCount(8)]
        public sbyte[] F11CompVsTemp { get; set; }

        [FieldCount(8)]
        public sbyte[] F12CompVsTemp { get; set; }

        [FieldCount(8)]
        public sbyte[] F13CompVsTemp { get; set; }

        [FieldCount(8)]
        public sbyte[] F14CompVsTemp { get; set; }

        [FieldCount(8)]
        public sbyte[] F15CompVsTemp { get; set; }
    }
}