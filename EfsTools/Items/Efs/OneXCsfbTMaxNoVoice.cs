using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/cdma/1xcp/1xcsfb_t_max_no_voice", true, 0xE1FF)]
	[Attributes(9)]
	public class OneXCsfbTMaxNoVoice
    {
		public OneXCsfbTMaxNoVoice()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint Value { get; set; }

		
	}
}
