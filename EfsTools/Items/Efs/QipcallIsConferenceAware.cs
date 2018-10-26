using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/qipcall_is_conference_aware", true, 0xE1FF)]
	[Attributes(9)]
	public class QipcallIsConferenceAware
	{
		public QipcallIsConferenceAware()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
