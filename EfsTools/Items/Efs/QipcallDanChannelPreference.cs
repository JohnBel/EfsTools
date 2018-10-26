using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/qipcall_dan_channel_preference", true, 0xE1FF)]
	[Attributes(9)]
	public class QipcallDanChannelPreference
	{
		public QipcallDanChannelPreference()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
