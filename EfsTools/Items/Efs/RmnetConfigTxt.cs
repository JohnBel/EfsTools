using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Serializable]
	[EfsFile("/rmnet_config.txt", false, 0x81FF)]
	[Attributes(9)]
	public class RmnetConfigTxt
	{
		public RmnetConfigTxt()
		{
		}
		
	    [ElementsCount(1)]
	    [ElementType("string[]")]
	    [Description("")]
	    public string[] Values { get; set; }
	}
}
