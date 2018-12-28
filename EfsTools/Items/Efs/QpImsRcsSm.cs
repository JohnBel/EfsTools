using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(71565)]
    [EfsFile("/nv/item_files/ims/qp_ims_rcs_sm", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsRcsSm
    {
        public QpImsRcsSm()
        {
            StandaloneMessageExplorerUri = new byte[128];
        }
        
        [Required]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte StandaloneMessageAuth { get; set; }

        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint StandaloneMessageMaxSize { get; set; }

        [ElementsCount(128)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] StandaloneMessageExplorerUri { get; set; }
    }
}