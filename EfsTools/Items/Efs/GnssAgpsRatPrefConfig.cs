using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/gps/cgps/sm/gnss_agps_rat_pref_config", true, 0xE1FF)]
	[Attributes(9)]
	public class GnssAgpsRatPrefConfig
	{
		public GnssAgpsRatPrefConfig()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field1 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Field2 { get; set; }

		
	}
}
