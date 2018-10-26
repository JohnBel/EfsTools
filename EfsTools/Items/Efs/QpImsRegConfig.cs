using System;
using System.ComponentModel;
using System.Text;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/qp_ims_reg_config", true, 0xE1FF)]
	[Attributes(9)]
	public class QpImsRegConfig
	{
		public QpImsRegConfig()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("0 Power on, 1 On Call)")]
		public byte RegOnMode { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("0 IETF, 1 EARLY, 2 IMS with IPSec, 3, IMS without IPSec, 4 No IMS")]
		public byte RegModeConfig { get; set; }

		[JsonIgnore]
		[ElementsCount(32)]
		[ElementType("uint8")]
		[Description("In NI 5.0 or later, APN name is used instead of the profile number.Please confirm with test labs for exact APN info")]
        public byte[] RegManagerPdpProfileName { get; set; }

	    public string RegManagerPdpProfileNameString
        {
	        get { return StringUtils.GetString(RegManagerPdpProfileName); }
	        set { RegManagerPdpProfileName = StringUtils.GetBytes(value, 32); }
        }


        [ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte RegEventPacket { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte RegPcoeEnabled { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte RegDhcpEnabled { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte RegPreConfigEnabled { get; set; }

		[JsonIgnore]
		[ElementsCount(256)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] RegManagerPreConfigServerBase { get; set; }

	    public string RegManagerPreConfigServerBaseString
        {
	        get { return StringUtils.GetString(RegManagerPreConfigServerBase); }
	        set { RegManagerPreConfigServerBase = StringUtils.GetBytes(value, 256); }
	    }


        [ElementsCount(1)]
		[ElementType("uint8")]
		[Description("RegRatConfig = CONFIG_RAT_LTE")]
		public byte RegRatConfig { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte RegQosProfile { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte RegWlanEnabled { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort RegUserNameImsi { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte RegResponseforOptions { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte RegConfigMaxDiscoveryCount { get; set; }

		[JsonIgnore]
		[ElementsCount(32)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] RegManagerDiscoverySchedule { get; set; }

	    public string RegManagerDiscoveryScheduleString
        {
	        get { return StringUtils.GetString(RegManagerDiscoverySchedule); }
	        set { RegManagerDiscoverySchedule = StringUtils.GetBytes(value, 32); }
	    }


        [JsonIgnore]
	    [ElementsCount(32)]
		[ElementType("uint8")]
		[Description("")]
        public byte[] RegManagerCdmaPdpProfileName { get; set; }

	    public string RegManagerCdmaPdpProfileNameString
        {
	        get { return StringUtils.GetString(RegManagerCdmaPdpProfileName); }
	        set { RegManagerCdmaPdpProfileName = StringUtils.GetBytes(value, 32); }
	    }


        [ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte RegConfigPdnRecoveryDelayTimerVal { get; set; }


        [JsonIgnore]
	    [ElementsCount(32)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] RegManagerPdpFailureSchedule { get; set; }

	    public string RegManagerPdpFailureScheduleString
        {
	        get { return StringUtils.GetString(RegManagerPdpFailureSchedule); }
	        set { RegManagerPdpFailureSchedule = StringUtils.GetBytes(value, 32); }
	    }


        [ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte RegConfigMaxIntermediatePDPRetries { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte RegConfigEhrpdRecoveryTime { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte RegConfigRegistrationAttempts { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte RegConfigDelayAttemptTimer { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte RegConfigTestMode { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort RegPcScfPort { get; set; }

		
	}
}
