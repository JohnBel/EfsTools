using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Ignore]
    [Serializable]
	[EfsFile("/nv/item_files/data/3gpp2/ehrpd_to_hrpd_fallback", false, 0x81FF)]
	[Attributes(9)]
	public class EhrpdToHrpdFallback
	{
		public EhrpdToHrpdFallback()
		{
		}
		
	}
}
