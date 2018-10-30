using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/ims/qp_ims_config", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsConfig
    {
        public QpImsConfig()
        {
            Reserved = new byte[501];
        }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte TipTirMode { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IrRestrictedType { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint OmaDmServicesMask { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte WfcStatus { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte CallModePreference { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ImsOperationSubmode { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IWfcRoaming { get; set; }

        [Optional]
        [ElementsCount(501)]
        [ElementType("int8")]
        [Description("")]
        public byte[] Reserved { get; set; }
    }
}