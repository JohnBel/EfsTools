using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/lte/lte_3gpp_release_ver", true, 0xE1FF)]
	[Attributes(9)]
	public class Lte3gppReleaseVer
	{
		public Lte3gppReleaseVer()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
