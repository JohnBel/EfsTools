using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Serializable]
	[EfsFile("/data/ds_dsd_attach_profile.txt", false, 0x81B6)]
	[Attributes(9)]
	public class DsDsdAttachProfileTxt
    {
		public DsDsdAttachProfileTxt()
		{
		}

        [ElementsCount(1)]
        [ElementType("string[]")]
        [Description("")]
        public string[] Values { get; set; }
    }
}
