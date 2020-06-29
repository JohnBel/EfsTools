using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/3gpp2/mip_fail_do_sess_close", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class MipFailDoSessClose
    {
        public byte Value { get; set; }
    }
}