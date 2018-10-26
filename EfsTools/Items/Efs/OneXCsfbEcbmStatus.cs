using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/mmode/sd/1xcsfb_ecbm_status", true, 0xE1FF)]
	[Attributes(9)]
	public class OneXCsfbEcbmStatus
    {
		public OneXCsfbEcbmStatus()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
