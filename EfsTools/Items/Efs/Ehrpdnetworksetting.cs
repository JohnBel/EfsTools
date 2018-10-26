using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Ignore]
    [Serializable]
	[EfsFile("/nv/item_files/modem/hdr/cp/scp/ehrpdnetworksetting", false, 0x81FF)]
	[Attributes(9)]
	public class Ehrpdnetworksetting
	{
		public Ehrpdnetworksetting()
		{
		}
		
	}
}
