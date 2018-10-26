using System;
using System.ComponentModel;
using System.Text;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/qp_ims_reg_config_db", true, 0xE1FF)]
	[Attributes(9)]
	public class QpImsRegConfigDb
	{
		public QpImsRegConfigDb()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Version { get; set; }
		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Rat1 { get; set; }
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte ApnIndex1 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort ImsServiceInfo1 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("int8")]
		[Description("")]
		public sbyte AuthSecType1 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte IpTypeInfo1 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Rat2 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte ApnIndex2 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort ImsServiceInfo2 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("int8")]
		[Description("")]
		public sbyte AuthSecType2 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte IpTypeInfo2 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Rat3 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte ApnIndex3 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort ImsServiceInfo3 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("int8")]
		[Description("")]
		public sbyte AuthSecType3 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte IpTypeInfo3 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Rat4 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte ApnIndex4 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort ImsServiceInfo4 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("int8")]
		[Description("")]
		public sbyte AuthSecType4 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte IpTypeInfo4 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Rat5 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte ApnIndex5 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort ImsServiceInfo5 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("int8")]
		[Description("")]
		public sbyte AuthSecType5 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte IpTypeInfo5 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Rat6 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte ApnIndex6 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort ImsServiceInfo6 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("int8")]
		[Description("")]
		public sbyte AuthSecType6 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte IpTypeInfo6 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Rat7 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte ApnIndex7 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort ImsServiceInfo7 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("int8")]
		[Description("")]
		public sbyte AuthSecType7 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte IpTypeInfo7 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Rat8 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte ApnIndex8 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort ImsServiceInfo8 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("int8")]
		[Description("")]
		public sbyte AuthSecType8 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte IpTypeInfo8 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Rat9 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte ApnIndex9 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort ImsServiceInfo9 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("int8")]
		[Description("")]
		public sbyte AuthSecType9 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte IpTypeInfo9 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Rat10 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte ApnIndex10 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort ImsServiceInfo10 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("int8")]
		[Description("")]
		public sbyte AuthSecType10 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte IpTypeInfo10 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort RatApnFallback1 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort ServicePriorityWwan1 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort RatApnFallback2 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort ServicePriorityWwan2 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort RatApnFallback3 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort ServicePriorityWwan3 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort RatApnFallback4 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort ServicePriorityWwan4 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort RatApnFallback5 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort ServicePriorityWwan5 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort RatApnFallback6 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort ServicePriorityWwan6 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort RatApnFallback7 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort ServicePriorityWwan7 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort RatApnFallback8 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort ServicePriorityWwan8 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort RatApnFallback9 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort ServicePriorityWwan9 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort RatApnFallback10 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort ServicePriorityWwan10 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort AllowedImsSrvOnWlan { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte AddAllFTs { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte AcsPriority { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte ISimPriority { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte NvPriority { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte PcoPriority { get; set; }

		
		[ElementsCount(1)]
		[ElementType("int16")]
		[Description("")]
		public short ImsServiceStatus { get; set; }

		[JsonIgnore]
		[ElementsCount(50)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] ApnName1 { get; set; }

	    public string ApnName1String
        {
	        get { return StringUtils.GetString(ApnName1); }
	        set { ApnName1 = StringUtils.GetBytes(value, 50); }
        }

	    [JsonIgnore]
        [ElementsCount(50)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] ApnName2 { get; set; }

	    public string ApnName2String
        {
	        get { return StringUtils.GetString(ApnName2); }
	        set { ApnName2 = StringUtils.GetBytes(value, 50); }
        }

	    [JsonIgnore]
        [ElementsCount(50)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] ApnName3 { get; set; }

	    public string ApnName3String
        {
	        get { return StringUtils.GetString(ApnName3); }
	        set { ApnName3 = StringUtils.GetBytes(value, 50); }
        }

        [ElementsCount(754)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] ReservedBytes { get; set; }

    }
}
