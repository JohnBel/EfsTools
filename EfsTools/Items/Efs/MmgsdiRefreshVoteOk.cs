using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/sms/mmgsdi_refresh_vote_ok", true, 0xE1FF)]
	[Attributes(9)]
	public class MmgsdiRefreshVoteOk
    {
		public MmgsdiRefreshVoteOk()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
