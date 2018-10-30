using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/uim/mmgsdi/refresh_retry", true, 0xE1FF)]
    [Attributes(9)]
    public class RefreshRetry
    {
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Field1 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Field2 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Field3 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Field4 { get; set; }
    }
}