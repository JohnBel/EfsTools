using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/ims/qp_ims_presence_config", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsPresenceConfig
    {
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint PublishTimer { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint PublishExtendedTimer { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint SourceThrottlePublishTimer { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint CapabilityPollListSubscriptionExpiryTimer { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte CapabilityDiscoveryEnable { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint CapabilitesCacheExpiration { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint AvailabilityCacheExpiration { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint CapabilityPollInterval { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint MaxNumberOfEntriesInRequest { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte VoLteProvisioningStatus { get; set; }

        [JsonIgnore]
        [ElementsCount(128)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] LastPublishedEtag { get; set; }

        public string LastPublishedEtagString
        {
            get => StringUtils.GetString(LastPublishedEtag);
            set => LastPublishedEtag = StringUtils.GetBytes(value, 128);
        }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint LastPublishedTime { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint LastNegotiatedPublishExpire { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte PresenceGzip { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte PresenceNotifyDuration { get; set; }
    }
}