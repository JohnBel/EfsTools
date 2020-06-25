using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/uim/mmgsdi/refresh_vote_ok", false, 0x81FF)]
    [Attributes(9)]
    public sealed class RefreshVoteOk
    {
        public byte Value { get; set; }
    }
}