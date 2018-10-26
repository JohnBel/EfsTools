using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Serializable]
	[EfsFile("/nv/item_files/modem/mmode/ue_based_cw", true, 0xE1FF)]
	[Attributes(9)]
	public class UeBasedCw
	{
		public UeBasedCw()
		{
		}

	    [ElementsCount(1)]
	    [ElementType("uint16")]
	    [Description("")]
	    public byte Value { get; set; }
    }
}
