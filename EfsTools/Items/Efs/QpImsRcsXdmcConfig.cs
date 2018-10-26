using System;
using System.ComponentModel;
using System.Text;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/qp_ims_rcs_xdmc_config", true, 0xE1FF)]
	[Attributes(9)]
	public class QpImsRcsXdmcConfig
    {
		public QpImsRcsXdmcConfig()
		{
		}

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Field1 { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Field2 { get; set; }

        [ElementsCount(1022)]
		[ElementType("uint8")]
		[Description("")]
        public byte[] Field3 { get; set; }
    }
}
