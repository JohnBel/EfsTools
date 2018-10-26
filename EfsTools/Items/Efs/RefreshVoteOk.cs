using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/uim/mmgsdi/refresh_vote_ok", true, 0xE1FF)]
	[Attributes(9)]
	public class RefreshVoteOk
	{
		public RefreshVoteOk()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
