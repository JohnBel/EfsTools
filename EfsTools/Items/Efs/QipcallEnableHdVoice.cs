using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/qipcall_enable_hd_voice", true, 0xE1FF)]
	[Attributes(9)]
	public class QipcallEnableHdVoice
	{
		public QipcallEnableHdVoice()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
