using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Serializable]
	[EfsFile("/efsprofiles/overideconfig", false, 0x81FF)]
	[Attributes(9)]
	public class OverideConfig
    {
		public OverideConfig()
		{
		}

        [ElementsCount(1)]
        [ElementType("string[]")]
        [Description("")]
        public string[] Values { get; set; }
    }
}
