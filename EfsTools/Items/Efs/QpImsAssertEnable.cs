using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(72609)]
    [EfsFile("/nv/item_files/ims/ims_assert_enable", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QpImsAssertEnable
    {
        public byte Value { get; set; }
    }
}