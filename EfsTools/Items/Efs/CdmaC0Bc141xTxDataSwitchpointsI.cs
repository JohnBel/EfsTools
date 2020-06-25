using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00022858", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc141xTxDataSwitchpoints
    {
        public short Sch1G1G0Fall { get; set; }


        public short Sch1G0G1Rise { get; set; }


        public short Sch1G2G1Fall { get; set; }


        public short Sch1G1G2Rise { get; set; }


        public short Sch1G3G2Fall { get; set; }


        public short Sch1G2G3Rise { get; set; }


        public short Sch1FallTimeHyst { get; set; }


        public short Sch2G1G0Fall { get; set; }


        public short Sch2G0G1Rise { get; set; }


        public short Sch2G2G1Fall { get; set; }


        public short Sch2G1G2Rise { get; set; }


        public short Sch2G3G2Fall { get; set; }


        public short Sch2G2G3Rise { get; set; }


        public short Sch2FallTimeHyst { get; set; }


        public short Sch3G1G0Fall { get; set; }


        public short Sch3G0G1Rise { get; set; }


        public short Sch3G2G1Fall { get; set; }


        public short Sch3G1G2Rise { get; set; }


        public short Sch3G3G2Fall { get; set; }


        public short Sch3G2G3Rise { get; set; }


        public short Sch3FallTimeHyst { get; set; }


        public short Sch4G1G0Fall { get; set; }


        public short Sch4G0G1Rise { get; set; }


        public short Sch4G2G1Fall { get; set; }


        public short Sch4G1G2Rise { get; set; }


        public short Sch4G3G2Fall { get; set; }


        public short Sch4G2G3Rise { get; set; }


        public short Sch4FallTimeHyst { get; set; }


        public short Sch5G1G0Fall { get; set; }


        public short Sch5G0G1Rise { get; set; }


        public short Sch5G2G1Fall { get; set; }


        public short Sch5G1G2Rise { get; set; }


        public short Sch5G3G2Fall { get; set; }


        public short Sch5G2G3Rise { get; set; }


        public short Sch5FallTimeHyst { get; set; }


        public short Sch6G1G0Fall { get; set; }


        public short Sch6G0G1Rise { get; set; }


        public short Sch6G2G1Fall { get; set; }


        public short Sch6G1G2Rise { get; set; }


        public short Sch6G3G2Fall { get; set; }


        public short Sch6G2G3Rise { get; set; }


        public short Sch6FallTimeHyst { get; set; }
    }
}