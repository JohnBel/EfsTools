using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/qipcall_is_conf_server_refer_recipient", true, 0xE1FF)]
	[Attributes(9)]
	public class QipcallIsConfServerReferRecipient
	{
		public QipcallIsConfServerReferRecipient()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }
		
	}
}
