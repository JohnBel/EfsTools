using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/qipcall_qos_reservation_timer", true, 0xE1FF)]
	[Attributes(9)]
	public class QipcallQosReservationTimer
	{
		public QipcallQosReservationTimer()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint Value { get; set; }

		
	}
}
