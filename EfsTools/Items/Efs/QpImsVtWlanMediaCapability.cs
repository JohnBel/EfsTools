using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/qp_ims_vt_WLAN_media_capability", false, 0x81FF)]
	[Attributes(9)]
	public class QpImsVtWlanMediaCapability
	{
		public QpImsVtWlanMediaCapability()
		{
		}
		
		[ElementsCount(582)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] Value { get; set; }
    }
}
