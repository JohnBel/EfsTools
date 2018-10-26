using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/data/3gpp/call_orig_allowed_before_ps_attach", true, 0xE1FF)]
	[Attributes(9)]
	public class CallOrigAllowedBeforePsAttach
	{
		public CallOrigAllowedBeforePsAttach()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
