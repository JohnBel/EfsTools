using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Ignore]
    [Serializable]
	[EfsFile("/nv/item_files/modem/utils/a2/sps_dynamic_usb_endpoint", true, 0xE1FF)]
	[Attributes(9)]
	public class SpsDynamicUsbEndpoint
	{
		public SpsDynamicUsbEndpoint()
		{
		}
		
	}
}
