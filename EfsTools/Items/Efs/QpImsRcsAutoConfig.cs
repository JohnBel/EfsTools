using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/ims/qp_ims_rcs_auto_config", false, 0x81FF)]
    [Attributes(9)]
    public class QpImsRcsAutoConfig
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte DisableAutoConfig { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RcsOnlyDeviceType { get; set; }


        [JsonIgnore]
        [ElementsCount(32)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RcsPdpProfilename { get; set; }

        public string RcsPdpProfilenameString
        {
            get => StringUtils.GetString(RcsPdpProfilename);
            set => RcsPdpProfilename = StringUtils.GetBytes(value, 32);
        }

        [JsonIgnore]
        [ElementsCount(32)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] InternetPdpProfilename { get; set; }

        public string InternetPdpProfilenameString
        {
            get => StringUtils.GetString(InternetPdpProfilename);
            set => InternetPdpProfilename = StringUtils.GetBytes(value, 32);
        }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte PcoConfigPriority { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ISimConfigPriority { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte PreConfigPriority { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte AutoConfigPriority { get; set; }

        [JsonIgnore]
        [ElementsCount(16)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RcsClientVendor { get; set; }

        public string RcsClientVendorString
        {
            get => StringUtils.GetString(RcsClientVendor);
            set => RcsClientVendor = StringUtils.GetBytes(value, 16);
        }

        [JsonIgnore]
        [ElementsCount(16)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RcsClientVersion { get; set; }

        public string RcsClientVersionString
        {
            get => StringUtils.GetString(RcsClientVersion);
            set => RcsClientVersion = StringUtils.GetBytes(value, 16);
        }

        [JsonIgnore]
        [ElementsCount(16)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RcsTerminalVendor { get; set; }

        public string RcsTerminalVendorString
        {
            get => StringUtils.GetString(RcsTerminalVendor);
            set => RcsTerminalVendor = StringUtils.GetBytes(value, 16);
        }

        [JsonIgnore]
        [ElementsCount(16)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RcsTerminalModel { get; set; }

        public string RcsTerminalModelString
        {
            get => StringUtils.GetString(RcsTerminalModel);
            set => RcsTerminalModel = StringUtils.GetBytes(value, 16);
        }

        [JsonIgnore]
        [ElementsCount(16)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RcsTerminalSwVersion { get; set; }

        public string RcsTerminalSwVersionString
        {
            get => StringUtils.GetString(RcsTerminalSwVersion);
            set => RcsTerminalSwVersion = StringUtils.GetBytes(value, 16);
        }

        [JsonIgnore]
        [ElementsCount(45)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RcsConfigServerAddress { get; set; }

        public string RcsConfigServerAddressString
        {
            get => StringUtils.GetString(RcsConfigServerAddress);
            set => RcsConfigServerAddress = StringUtils.GetBytes(value, 45);
        }

        [JsonIgnore]
        [ElementsCount(5)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RcsConfigServerPort { get; set; }

        public string RcsConfigServerPortString
        {
            get => StringUtils.GetString(RcsConfigServerPort);
            set => RcsConfigServerPort = StringUtils.GetBytes(value, 5);
        }

        [JsonIgnore]
        [ElementsCount(270)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RcsLteFtList { get; set; }

        public string RcsLteFtListString
        {
            get => StringUtils.GetString(RcsLteFtList);
            set => RcsLteFtList = StringUtils.GetBytes(value, 270);
        }

        [JsonIgnore]
        [ElementsCount(270)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RcsHspaFtList { get; set; }

        public string RcsHspaFtListString
        {
            get => StringUtils.GetString(RcsHspaFtList);
            set => RcsHspaFtList = StringUtils.GetBytes(value, 270);
        }

        [JsonIgnore]
        [ElementsCount(270)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RcsWifiFtList { get; set; }

        public string RcsWifiFtListString
        {
            get => StringUtils.GetString(RcsWifiFtList);
            set => RcsWifiFtList = StringUtils.GetBytes(value, 270);
        }

        [ElementsCount(13)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] ReservedByte { get; set; }
    }
}