using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/nas/irat_search_timer", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class IratSearchTimer
    {
        public uint Value { get; set; }
    }
}