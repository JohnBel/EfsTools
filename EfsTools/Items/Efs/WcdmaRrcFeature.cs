using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/wcdma/rrc/wcdma_rrc_feature", true, 0xE1FF)]
	[Attributes(9)]
	public class WcdmaRrcFeature
	{
		public WcdmaRrcFeature()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Value { get; set; }

		
	}
}
