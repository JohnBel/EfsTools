using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/cdma/1xcp/rej_voice_page_for_volte", true, 0xE1FF)]
	[Attributes(9)]
	public class RejVoicePageForVolte
	{
		public RejVoicePageForVolte()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
