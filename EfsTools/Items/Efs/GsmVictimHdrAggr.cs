using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [EfsFile("/nv/item_files/mcs/lmtsmgr/coex/blank/gsm_victim_hdr_aggr", false, 0x81FF)]
    [Attributes(9)]
    public class GsmVictimHdrAggr
    {
    }
}