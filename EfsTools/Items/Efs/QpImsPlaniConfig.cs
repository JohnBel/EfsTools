using System;
using System.ComponentModel;
using System.Text;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/qp_ims_plani_config", true, 0xE1FF)]
	[Attributes(9)]
	public class QpImsPlaniConfig
    {
		public QpImsPlaniConfig()
		{
		}

	    [ElementsCount(128)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] Value { get; set; }
    }
}
