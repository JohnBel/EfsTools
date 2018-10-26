using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/nas/nas_srvcc_support", true, 0xE1FF)]
	[Attributes(9)]
	public class NasSrvccSupport
	{
		public NasSrvccSupport()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
