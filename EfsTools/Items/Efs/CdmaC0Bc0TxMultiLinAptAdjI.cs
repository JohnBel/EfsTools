using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023196", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc0TxMultiLinAptAdj
    {
        public sbyte Reserved { get; set; }


        public sbyte PwrAdjPilot { get; set; }


        public sbyte PwrAdjRc1rc2 { get; set; }


        public sbyte PwrAdjRc3rc4V { get; set; }


        public sbyte PwrAdjRc3rc4D { get; set; }


        public sbyte PwrAdjRc8V { get; set; }


        public sbyte PwrAdjRc8D { get; set; }


        public sbyte PwrAdjDor0Pilot { get; set; }


        public sbyte PwrAdjDor01 { get; set; }


        public sbyte PwrAdjDor02 { get; set; }


        public sbyte PwrAdjDor03 { get; set; }


        public sbyte PwrAdjDor04 { get; set; }


        public sbyte PwrAdjDor05 { get; set; }


        public sbyte PwrAdjDoraPs0 { get; set; }


        public sbyte PwrAdjDoraPs1 { get; set; }


        public sbyte PwrAdjDoraPs2 { get; set; }


        public sbyte PwrAdjDoraPs3 { get; set; }


        public sbyte PwrAdjDoraPs4 { get; set; }


        public sbyte PwrAdjDoraPs5 { get; set; }


        public sbyte PwrAdjDoraPs6 { get; set; }


        public sbyte PwrAdjDoraPs7 { get; set; }


        public sbyte PwrAdjDoraPs8 { get; set; }


        public sbyte PwrAdjDoraPs9 { get; set; }


        public sbyte PwrAdjDoraPs10 { get; set; }


        public sbyte PwrAdjDoraPs11 { get; set; }


        public sbyte PwrAdjDoraPs12 { get; set; }
    }
}