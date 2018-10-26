using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/qipcall_dan_max_retry_count", true, 0xE1FF)]
	[Attributes(9)]
	public class QipcallDanMaxRetryCount
	{
		public QipcallDanMaxRetryCount()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
