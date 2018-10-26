using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/nas/nas_l2g_srvcc_support", true, 0xE1FF)]
	[Attributes(9)]
	public class NasL2gSrvccSupport
	{
		public NasL2gSrvccSupport()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
