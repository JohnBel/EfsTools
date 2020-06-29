using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/cdma/1xcp/1xcsfb_t_max_no_c2k_param", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class OneXCsfbTMaxNoC2kParam
    {
        public ushort Value { get; set; }
    }
}