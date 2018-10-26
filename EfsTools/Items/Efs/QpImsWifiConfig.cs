using System;
using System.ComponentModel;
using System.Text;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/qp_ims_wifi_config", true, 0xE1FF)]
	[Attributes(9)]
	public class QpImsWifiConfig
    {
		public QpImsWifiConfig()
		{
		}
		
		[ElementsCount(512)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] Value { get; set; }
    }
}
