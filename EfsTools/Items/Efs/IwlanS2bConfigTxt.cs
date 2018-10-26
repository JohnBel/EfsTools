using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    
    [Serializable]
	[EfsFile("/data/iwlan_s2b_config.txt", false, 0x81B6)]
	[Attributes(9)]
	public class IwlanS2bConfigTxt
	{
		public IwlanS2bConfigTxt()
		{
        }

	    [ElementsCount(1)]
	    [ElementType("string[]")]
	    [Description("")]
	    public string[] Values { get; set; }
    }
}
