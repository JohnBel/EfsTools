using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/tdscdma/rrc/tds_rrc_version", true, 0xE1FF)]
	[Attributes(9)]
	public class TdsRrcVersion
	{
		public TdsRrcVersion()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint Value { get; set; }

		
	}
}
