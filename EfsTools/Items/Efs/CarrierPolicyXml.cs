using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Serializable]
	[EfsFile("/policyman/carrier_policy.xml", false, 0x81FF)]
	[Attributes(9)]
	public class CarrierPolicyXml
	{
		public CarrierPolicyXml()
		{
		}

	    [ElementsCount(1)]
	    [ElementType("string[]")]
	    [Description("")]
	    public string[] Values { get; set; }
    }
}
