using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/gps/cgps/sm/gnss_lpp_enable", true, 0xE1FF)]
	[Attributes(9)]
	public class GnssLppEnable
	{
		public GnssLppEnable()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }
	}
}
