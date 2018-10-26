using System;
using System.ComponentModel;
using System.Text;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/qp_ims_sip_extended_0_config", true, 0xE1FF)]
	[Attributes(9)]
	public class QpImsSipExtended0Config
	{
		public QpImsSipExtended0Config()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Version { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort SipLocalPort { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint TimerSipRegValue { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint TimerSipSubscribeValue { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint TimerT1Value { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint TimerT2Value { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint TimerT3Value { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint TimerT4Value { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint TimerTfValue { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort TimerTJValue { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte TcpThresholdValue { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte CompactFormEnabled { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte SigCompEnabled { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte FmcConfig { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte IpSecIntScheme { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte IpSecEncAlgo { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte AuthScheme { get; set; }

		[JsonIgnore]
		[ElementsCount(256)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] InitialAuthConfig { get; set; }

	    public string InitialAuthConfigString
        {
	        get { return StringUtils.GetString(InitialAuthConfig); }
	        set { InitialAuthConfig = StringUtils.GetBytes(value, 256); }
        }

	    [JsonIgnore]
        [ElementsCount(256)]
		[ElementType("uint8")]
		[Description("")]
        public byte[] AuthHeaderValue { get; set; }

	    public string AuthHeaderValueString
        {
	        get { return StringUtils.GetString(AuthHeaderValue); }
	        set { AuthHeaderValue = StringUtils.GetBytes(value, 256); }
        }


        [ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte ProxyRouteValue { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint KeepAliveEnabled { get; set; }

		[ElementsCount(467)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] ReservedBytes { get; set; }
    }
}
