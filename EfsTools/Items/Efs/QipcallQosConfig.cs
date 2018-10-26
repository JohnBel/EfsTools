using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/qipcall_qos_config", true, 0xE1FF)]
	[Attributes(9)]
	public class QipcallQosConfig
    {
		public QipcallQosConfig()
		{
		}
		
		[ElementsCount(32)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] Value { get; set; }

		
	}
}
