using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(67314)]
    [Subscription]
    [EfsFile("/nv/item_files/ims/qp_ims_presence_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QpImsPresenceConfig
    {
        public uint PublishTimer { get; set; }


        public uint PublishExtendedTimer { get; set; }


        public uint SourceThrottlePublishTimer { get; set; }


        public uint CapabilityPollListSubscriptionExpiryTimer { get; set; }


        public byte CapabilityDiscoveryEnable { get; set; }


        public uint CapabilitesCacheExpiration { get; set; }


        public uint AvailabilityCacheExpiration { get; set; }


        public uint CapabilityPollInterval { get; set; }


        public uint MaxNumberOfEntriesInRequest { get; set; }


        public byte VoLteProvisioningStatus { get; set; }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public byte[] LastPublishedEtag { get; set; }

        public string LastPublishedEtagString
        {
            get => StringUtils.GetString(LastPublishedEtag);
            set => LastPublishedEtag = StringUtils.GetBytes(value, 128);
        }


        public uint LastPublishedTime { get; set; }


        public uint LastNegotiatedPublishExpire { get; set; }


        public byte PresenceGzip { get; set; }


        public byte PresenceNotifyDuration { get; set; }
    }
}