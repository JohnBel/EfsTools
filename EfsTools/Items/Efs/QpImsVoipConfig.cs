using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
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
        [Subscription]
    [NvItemId(67257)]
    [EfsFile("/nv/item_files/ims/qp_ims_voip_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QpImsVoipConfig
    {
        public byte VoipConfigDisableChecksFor380Res { get; set; }


        public byte VoipConfigDomainNotificationEnable { get; set; }


        public byte VoipConfigRtcp { get; set; }

        [JsonIgnore]
        [FieldCount(128)]
        public byte[] VoipConfigAcceptContact { get; set; }

        public string VoipConfigAcceptContactString
        {
            get => StringUtils.GetString(VoipConfigAcceptContact);
            set => VoipConfigAcceptContact = StringUtils.GetBytes(value, 128);
        }


        public ushort VoipConfigExpires { get; set; }


        public ushort VoipMinSessionExpires { get; set; }


        public byte VoipSessionTimerEnabled { get; set; }

        [JsonIgnore]
        [FieldCount(128)]
        public byte[] VoipConfigConfUri { get; set; }

        public string VoipConfigConfUriString
        {
            get => StringUtils.GetString(VoipConfigConfUri);
            set => VoipConfigConfUri = StringUtils.GetBytes(value, 128);
        }


        public byte VoipSilentRedialEnabled { get; set; }


        public ushort VoipAllowSeNegotiation { get; set; }


        [JsonIgnore]
        public byte VoipConfigSessionRefresherType { get; set; }

        public string VoipConfigSessionRefresherTypeString
        {
            get => $"{(VoipConfigSessionRefresherTypeValues) VoipConfigSessionRefresherType}";
            set =>
                VoipConfigSessionRefresherType =
                    EnumUtils.ParseEnumByte(typeof(VoipConfigSessionRefresherTypeValues), value);
        }

        [JsonIgnore]
        public byte VoipConfigSessionRefresherMethod { get; set; }

        public string VoipConfigSessionRefresherMethodString
        {
            get => $"{(VoipConfigSessionRefresherMethodValues) VoipConfigSessionRefresherMethod}";
            set =>
                VoipConfigSessionRefresherMethod =
                    EnumUtils.ParseEnumByte(typeof(VoipConfigSessionRefresherMethodValues), value);
        }

        [JsonIgnore]
        [FieldCount(128)]
        public byte[] VoipConfigInviteHeader { get; set; }

        public string VoipConfigInviteHeaderString
        {
            get => StringUtils.GetString(VoipConfigInviteHeader);
            set => VoipConfigInviteHeader = StringUtils.GetBytes(value, 128);
        }
    }
}