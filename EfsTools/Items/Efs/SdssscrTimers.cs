using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Serializable]
	[EfsFile("/nv/item_files/modem/mmode/sd/sdssscr_timers", false, 0x81FF)]
	[Attributes(9)]
	public class SdssscrTimers
	{
		public SdssscrTimers()
		{
		}
		
	    [ElementsCount(204)]
	    [ElementType("uint8")]
	    [Description("")]
	    public byte[] Value { get; set; }
	}
}
