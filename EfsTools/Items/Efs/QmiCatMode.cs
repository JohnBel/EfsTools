using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/qmi/cat/qmi_cat_mode", true, 0xE1FF)]
	[Attributes(9)]
	public class QmiCatMode
	{
		public QmiCatMode()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
