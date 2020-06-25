using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/cdma/1xcp/1xcsfb_n_max_reg_retry_cnt", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class OneXCsfbNMaxRegRetryCnt
    {
        public byte Value { get; set; }
    }
}