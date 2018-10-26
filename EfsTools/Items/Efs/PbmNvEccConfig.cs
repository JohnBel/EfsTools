using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/pbm/pbm_nv_ecc_config", true, 0xE1FF)]
	[Attributes(9)]
	public class PbmNvEccConfig
	{
		public PbmNvEccConfig()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
