using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(71565)]
    [EfsFile("/nv/item_files/ims/qp_ims_rcs_sm", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QpImsRcsSm
    {
        public QpImsRcsSm()
        {
            StandaloneMessageExplorerUri = new byte[128];
        }

        [Required]
        public byte Version { get; set; }


        public byte StandaloneMessageAuth { get; set; }


        public uint StandaloneMessageMaxSize { get; set; }

        [FieldCount(128)]
        public byte[] StandaloneMessageExplorerUri { get; set; }
    }
}