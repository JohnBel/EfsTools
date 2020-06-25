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
    [Subscription]
    [NvItemId(67263)]
    [EfsFile("/nv/item_files/ims/qp_ims_vs_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QpImsVsConfig
    {
        public byte ConfigAutomaticAnswerIncomingInvite { get; set; }


        public byte VideoFormat { get; set; }


        public byte ConfigSessionType { get; set; }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public byte[] ConfigSdpApplicationAttribute { get; set; }

        public string ConfigSdpApplicationAttributeString
        {
            get => StringUtils.GetString(ConfigSdpApplicationAttribute);
            set => ConfigSdpApplicationAttribute = StringUtils.GetBytes(value, 128);
        }


        public byte ConfigAutomaticAnswer { get; set; }


        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] //Todo: check
        public byte[] ConfigReceiverUri { get; set; }

        public string ConfigReceiverUriString
        {
            get => StringUtils.GetString(ConfigReceiverUri);
            set => ConfigReceiverUri = StringUtils.GetBytes(value, 256);
        }


        public byte LiveSteaming { get; set; }


        public byte FileSteaming { get; set; }


        public byte MsrpFileSteaming { get; set; }


        public byte VideoRecording { get; set; }


        public byte Alerting { get; set; }


        public byte CallerIDHiding { get; set; }


        public byte MessageHandling { get; set; }


        public byte QosStreamingStatus { get; set; }


        public ushort ConfigBitRate { get; set; }


        public ushort ConfigFrameRate { get; set; }


        public ushort ConfigFrameSizeWidth { get; set; }


        public ushort ConfigFrameSizeHeight { get; set; }


        public ushort ConfigRTPPort { get; set; }


        public ushort ConfigMSRPPort { get; set; }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public byte[] ConfigFilePath { get; set; }

        public string ConfigFilePathString
        {
            get => StringUtils.GetString(ConfigFilePath);
            set => ConfigFilePath = StringUtils.GetBytes(value, 128);
        }


        public byte ConfigVideoQP { get; set; }


        public byte MediaPayload { get; set; }
    }
}