using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/sms/sms_rety_limit", true, 0xE1FF)]
	[Attributes(9)]
	public class SmsRetyLimit
	{
		public SmsRetyLimit()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
