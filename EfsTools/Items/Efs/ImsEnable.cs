using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/IMS_enable", true, 0xE1FF)]
	[Attributes(9)]
	public class ImsEnable
	{
		public ImsEnable()
		{
        }

	    [ElementsCount(1)]
	    [ElementType("uint8")]
	    [Description("")]
	    public byte Value { get; set; }
    }
}
