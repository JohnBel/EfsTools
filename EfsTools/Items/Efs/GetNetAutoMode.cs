using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/mmode/get_net_auto_mode", true, 0xE1FF)]
	[Attributes(9)]
	public class GetNetAutoMode
    {
		public GetNetAutoMode()
		{
		}
		
		[ElementsCount(5)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] Value { get; set; }
	}
}
