using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/qipcall_rtp_link_aliveness_timer", true, 0xE1FF)]
	[Attributes(9)]
	public class QipcallRtpLinkAlivenessTimer
	{
		public QipcallRtpLinkAlivenessTimer()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint Value { get; set; }

		
	}
}
