using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Ignore]
    [Serializable]
	[EfsFile("/nv/item_files/modem/lte_connection_control", false, 0x81FF)]
	[Attributes(9)]
	public class LteConnectionControl
	{
		public LteConnectionControl()
		{
		}
		
	}
}
