using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/mmode/mid_call_srvcc_info", true, 0xE1FF)]
	[Attributes(9)]
	public class MidCallSrvccInfo
    {
		public MidCallSrvccInfo()
		{
		}
		
		[ElementsCount(8)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] Value { get; set; }
	}
}
