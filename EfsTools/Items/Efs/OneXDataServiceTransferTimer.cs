using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/cne/1XDataServiceTransferTimer", true, 0xE1FF)]
	[Attributes(9)]
	public class OneXDataServiceTransferTimer
	{
		public OneXDataServiceTransferTimer()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint Value { get; set; }

		
	}
}
