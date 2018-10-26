using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Ignore]
    [Serializable]
	[EfsFile("/nv/item_files/modem/data/epc/pdn_throttling_config.txt", false, 0x81FF)]
	[Attributes(9)]
	public class PdnThrottlingConfigTxt
	{
		public PdnThrottlingConfigTxt()
		{
		}
		
	}
}
