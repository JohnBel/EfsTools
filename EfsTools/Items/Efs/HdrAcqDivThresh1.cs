using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Serializable]
	[EfsFile("/nv/item_files/modem/hdr/srch/hdr_acq_div_thresh1", false, 0x81FF)]
	[Attributes(9)]
	public class HdrAcqDivThresh1
	{
		public HdrAcqDivThresh1()
		{
		}
	
	    [ElementsCount(1)]
	    [ElementType("uint16")]
	    [Description("")]
	    public byte Value { get; set; }
	}
}
