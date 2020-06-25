using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/ims/qipcall_session_level_media_bw_enabled", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QipcallSessionLevelMediaBwEnabled
    {
        public byte Value { get; set; }
    }
}