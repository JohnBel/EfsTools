using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(67263)]
    [EfsFile("/nv/item_files/ims/qp_ims_vs_config", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsVsConfig
    {
        [Optional]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ConfigAutomaticAnswerIncomingInvite { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte VideoFormat { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ConfigSessionType { get; set; }
        
        [Optional]
        [JsonIgnore]
        [ElementsCount(128)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] ConfigSdpApplicationAttribute { get; set; }

        public string ConfigSdpApplicationAttributeString
        {
            get => StringUtils.GetString(ConfigSdpApplicationAttribute);
            set => ConfigSdpApplicationAttribute = StringUtils.GetBytes(value, 128);
        }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ConfigAutomaticAnswer { get; set; }


        [Optional]
        [JsonIgnore]
        [ElementsCount(256)] //Todo: check
        [ElementType("uint8")]
        [Description("")]
        public byte[] ConfigReceiverUri { get; set; }

        public string ConfigReceiverUriString
        {
            get => StringUtils.GetString(ConfigReceiverUri);
            set => ConfigReceiverUri = StringUtils.GetBytes(value, 256);
        }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte LiveSteaming { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte FileSteaming { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte MsrpFileSteaming { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte VideoRecording { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Alerting { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte CallerIDHiding { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte MessageHandling { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte QosStreamingStatus { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ConfigBitRate { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ConfigFrameRate { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ConfigFrameSizeWidth { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ConfigFrameSizeHeight { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ConfigRTPPort { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ConfigMSRPPort { get; set; }

        [Optional]
        [JsonIgnore]
        [ElementsCount(128)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] ConfigFilePath { get; set; }

        public string ConfigFilePathString
        {
            get => StringUtils.GetString(ConfigFilePath);
            set => ConfigFilePath = StringUtils.GetBytes(value, 128);
        }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ConfigVideoQP { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte MediaPayload { get; set; }
    }
}