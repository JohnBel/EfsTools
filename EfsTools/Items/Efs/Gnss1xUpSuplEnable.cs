using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/gps/cgps/sm/gnss_1x_up_supl_enable", true, 0xE1FF)]
	[Attributes(9)]
	public class Gnss1xUpSuplEnable
	{
		public Gnss1xUpSuplEnable()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }
	}
}
