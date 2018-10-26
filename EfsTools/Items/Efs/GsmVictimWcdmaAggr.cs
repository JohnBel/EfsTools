using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Ignore]
    [Serializable]
	[EfsFile("/nv/item_files/mcs/lmtsmgr/coex/blank/gsm_victim_wcdma_aggr", false, 0x81FF)]
	[Attributes(9)]
	public class GsmVictimWcdmaAggr
	{
		public GsmVictimWcdmaAggr()
		{
		}
		
	}
}
