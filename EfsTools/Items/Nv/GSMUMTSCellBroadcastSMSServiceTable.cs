using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(1014)]
	[Attributes(41)]
	public class GsmUmtsCellBroadcastSmsServiceTable
    {
		public GsmUmtsCellBroadcastSmsServiceTable()
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

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Field3 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Field4 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field5 { get; set; }

		[JsonIgnore]
		[ElementsCount(30)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] Field6 { get; set; }

	    public string Field6String
	    {
	        get { return StringUtils.GetString(Field6); }
	        set { Field6 = StringUtils.GetBytes(value, 30); }
	    }


        [ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field7 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field8 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field9 { get; set; }

		
	}
}
