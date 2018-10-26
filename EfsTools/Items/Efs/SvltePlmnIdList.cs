using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Ignore]
    [Serializable]
	[EfsFile("/mmode/cmph/svlte_plmn_id_list", false, 0x81FF)]
	[Attributes(9)]
	public class SvltePlmnIdList
	{
		public SvltePlmnIdList()
		{
		}
		
	}
}
