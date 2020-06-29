using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(69673)]
    [EfsFile("/nv/item_files/ims/ims_operation_mode", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class ImsOperationMode
    {
        public byte Value { get; set; }
    }
}