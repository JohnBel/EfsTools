using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/nas/exclude_ptmsi_type_field", true, 0xE1FF)]
	[Attributes(9)]
	public class ExcludePtmsiTypeField
	{
		public ExcludePtmsiTypeField()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }
	}
}
