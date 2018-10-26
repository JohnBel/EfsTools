using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/qipcall_callerid_mode", true, 0xE1FF)]
	[Attributes(9)]
	public class QipcallCalleridMode
	{
		public QipcallCalleridMode()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Value { get; set; }

		
	}
}
