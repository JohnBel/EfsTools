using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(255)]
    [Attributes(45)]
    public sealed class CdmaSidNidLockout
    {
        public byte Nam { get; set; }


        public ushort Sid1 { get; set; }


        public ushort Nid1 { get; set; }


        public ushort Sid2 { get; set; }


        public ushort Nid2 { get; set; }


        public ushort Sid3 { get; set; }


        public ushort Nid3 { get; set; }


        public ushort Sid4 { get; set; }


        public ushort Nid4 { get; set; }


        public ushort Sid5 { get; set; }


        public ushort Nid5 { get; set; }


        public ushort Sid6 { get; set; }


        public ushort Nid6 { get; set; }


        public ushort Sid7 { get; set; }


        public ushort Nid7 { get; set; }


        public ushort Sid8 { get; set; }


        public ushort Nid8 { get; set; }


        public ushort Sid9 { get; set; }


        public ushort Nid9 { get; set; }


        public ushort Sid10 { get; set; }


        public ushort Nid10 { get; set; }
    }
}