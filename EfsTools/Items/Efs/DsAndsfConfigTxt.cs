using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Serializable]
	[EfsFile("/data/ds_andsf_config.txt", false, 0x81B6)]
	[Attributes(9)]
	public class DsAndsfConfigTxt
    {
		public DsAndsfConfigTxt()
		{
		}

        [ElementsCount(1)]
        [ElementType("string[]")]
        [Description("")]
        public string[] Values { get; set; }
    }
}
