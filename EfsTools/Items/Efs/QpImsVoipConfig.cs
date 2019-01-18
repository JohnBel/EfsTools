using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    public enum VoipConfigSessionRefresherTypeValues : byte
    {
        Uac = 0,
        Uas = 1,
        None = 2
    }

    public enum VoipConfigSessionRefresherMethodValues : byte
    {
        RefreshInvite = 0,
        RefreshUpdate = 1
    }

    [Serializable]
    [NvItemId(67257)]
    [EfsFile("/nv/item_files/ims/qp_ims_voip_config", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsVoipConfig
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte VoipConfigDisableChecksFor380Res { get; set; }

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
            get => StringUtils.GetString(VoipConfigAcceptContact);
            set => VoipConfigAcceptContact = StringUtils.GetBytes(value, 128);
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
            get => StringUtils.GetString(VoipConfigConfUri);
            set => VoipConfigConfUri = StringUtils.GetBytes(value, 128);
        }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte VoipSilentRedialEnabled { get; set; }

        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort VoipAllowSeNegotiation { get; set; }


        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte VoipConfigSessionRefresherType { get; set; }

        public string VoipConfigSessionRefresherTypeString
        {
            get => $"{(VoipConfigSessionRefresherTypeValues) VoipConfigSessionRefresherType}";
            set => VoipConfigSessionRefresherType =
                EnumUtils.ParseEnum(typeof(VoipConfigSessionRefresherTypeValues), value);
        }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte VoipConfigSessionRefresherMethod { get; set; }

        public string VoipConfigSessionRefresherMethodString
        {
            get => $"{(VoipConfigSessionRefresherMethodValues) VoipConfigSessionRefresherMethod}";
            set => VoipConfigSessionRefresherMethod =
                EnumUtils.ParseEnum(typeof(VoipConfigSessionRefresherMethodValues), value);
        }

        [JsonIgnore]
        [ElementsCount(128)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] VoipConfigInviteHeader { get; set; }

        public string VoipConfigInviteHeaderString
        {
            get => StringUtils.GetString(VoipConfigInviteHeader);
            set => VoipConfigInviteHeader = StringUtils.GetBytes(value, 128);
        }
    }
}