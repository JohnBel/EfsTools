using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/qipcall_dan_hysterisis_timer_duration", true, 0xE1FF)]
	[Attributes(9)]
	public class QipcallDanHysterisisTimerDuration
	{
		public QipcallDanHysterisisTimerDuration()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint Value { get; set; }

		
	}
}
