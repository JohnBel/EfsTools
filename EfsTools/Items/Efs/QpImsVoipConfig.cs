using System;
using System.ComponentModel;
using System.Text;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/qp_ims_voip_config", true, 0xE1FF)]
	[Attributes(9)]
	public class QpImsVoipConfig
	{
		public QpImsVoipConfig()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte VoipConfigQos { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte VoipConfigDomainNotificationEnable { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte VoipConfigRtcp { get; set; }

		[JsonIgnore]
		[ElementsCount(128)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] VoipConfigAcceptContact { get; set; }

	    public string VoipConfigAcceptContactString
        {
	        get { return StringUtils.GetString(VoipConfigAcceptContact); }
	        set { VoipConfigAcceptContact = StringUtils.GetBytes(value, 128); }
        }
        
        [ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort VoipConfigExpires { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort VoipMinSessionExpires { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte VoipSessionTimerEnabled { get; set; }

		[JsonIgnore]
		[ElementsCount(128)]
		[ElementType("uint8")]
		[Description("")]
        public byte[] VoipConfigConfUri { get; set; }

	    public string VoipConfigConfUriString
        {
	        get { return StringUtils.GetString(VoipConfigConfUri); }
	        set { VoipConfigConfUri = StringUtils.GetBytes(value, 128); }
        }


        [ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte VoipSilentRedialEnabled { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort VoipConfigSessionExpires { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte VoipConfigSessionRefresherType { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte VoipConfigSessionRefresherMethod { get; set; }

		[JsonIgnore]
		[ElementsCount(128)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] VoipConfigInviteHeader { get; set; }

	    public string VoipConfigInviteHeaderString
        {
	        get { return StringUtils.GetString(VoipConfigInviteHeader); }
	        set { VoipConfigInviteHeader = StringUtils.GetBytes(value, 128); }
        }
    }
}
