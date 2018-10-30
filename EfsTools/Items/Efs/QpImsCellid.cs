using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/ims/qp_ims_cellid", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsCellid
    {
        [ElementsCount(25)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }
    }
}