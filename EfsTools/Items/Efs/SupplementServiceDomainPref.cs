using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/mmode/supplement_service_domain_pref", true, 0xE1FF)]
	[Attributes(9)]
	public class SupplementServiceDomainPref
	{
		public SupplementServiceDomainPref()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
