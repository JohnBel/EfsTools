using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Serializable]
	[EfsFile("/sd/bst_tbl", false, 0x81FF)]
	[Attributes(9)]
	public class BstTbl
	{
		public BstTbl()
		{
		}
		
	    [ElementsCount(58)]
	    [ElementType("uint8")]
	    [Description("")]
	    public byte[] Value { get; set; }
	}
}
