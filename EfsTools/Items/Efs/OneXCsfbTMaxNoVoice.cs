using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/cdma/1xcp/1xcsfb_t_max_no_voice", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class OneXCsfbTMaxNoVoice
    {
        public uint Value { get; set; }
    }
}