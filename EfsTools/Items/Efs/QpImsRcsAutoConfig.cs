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
    [NvItemId(70233)]
    [Subscription]
    [EfsFile("/nv/item_files/ims/qp_ims_rcs_auto_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QpImsRcsAutoConfig
    {
        [Required]
        public byte Version { get; set; }


        public byte DisableAutoConfig { get; set; }


        public byte RcsOnlyDeviceType { get; set; }


        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] RcsPdpProfilename { get; set; }

        public string RcsPdpProfilenameString
        {
            get => StringUtils.GetString(RcsPdpProfilename);
            set => RcsPdpProfilename = StringUtils.GetBytes(value, 32);
        }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] InternetPdpProfilename { get; set; }

        public string InternetPdpProfilenameString
        {
            get => StringUtils.GetString(InternetPdpProfilename);
            set => InternetPdpProfilename = StringUtils.GetBytes(value, 32);
        }


        public byte PcoConfigPriority { get; set; }


        public byte ISimConfigPriority { get; set; }


        public byte PreConfigPriority { get; set; }


        public byte AutoConfigPriority { get; set; }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] RcsClientVendor { get; set; }

        public string RcsClientVendorString
        {
            get => StringUtils.GetString(RcsClientVendor);
            set => RcsClientVendor = StringUtils.GetBytes(value, 16);
        }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] RcsClientVersion { get; set; }

        public string RcsClientVersionString
        {
            get => StringUtils.GetString(RcsClientVersion);
            set => RcsClientVersion = StringUtils.GetBytes(value, 16);
        }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] RcsTerminalVendor { get; set; }

        public string RcsTerminalVendorString
        {
            get => StringUtils.GetString(RcsTerminalVendor);
            set => RcsTerminalVendor = StringUtils.GetBytes(value, 16);
        }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] RcsTerminalModel { get; set; }

        public string RcsTerminalModelString
        {
            get => StringUtils.GetString(RcsTerminalModel);
            set => RcsTerminalModel = StringUtils.GetBytes(value, 16);
        }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] RcsTerminalSwVersion { get; set; }

        public string RcsTerminalSwVersionString
        {
            get => StringUtils.GetString(RcsTerminalSwVersion);
            set => RcsTerminalSwVersion = StringUtils.GetBytes(value, 16);
        }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 45)]
        public byte[] RcsConfigServerAddress { get; set; }

        public string RcsConfigServerAddressString
        {
            get => StringUtils.GetString(RcsConfigServerAddress);
            set => RcsConfigServerAddress = StringUtils.GetBytes(value, 45);
        }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public byte[] RcsConfigServerPort { get; set; }

        public string RcsConfigServerPortString
        {
            get => StringUtils.GetString(RcsConfigServerPort);
            set => RcsConfigServerPort = StringUtils.GetBytes(value, 5);
        }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 270)]
        public byte[] RcsLteFtList { get; set; }

        public string RcsLteFtListString
        {
            get => StringUtils.GetString(RcsLteFtList);
            set => RcsLteFtList = StringUtils.GetBytes(value, 270);
        }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 270)]
        public byte[] RcsHspaFtList { get; set; }

        public string RcsHspaFtListString
        {
            get => StringUtils.GetString(RcsHspaFtList);
            set => RcsHspaFtList = StringUtils.GetBytes(value, 270);
        }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 270)]
        public byte[] RcsWifiFtList { get; set; }

        public string RcsWifiFtListString
        {
            get => StringUtils.GetString(RcsWifiFtList);
            set => RcsWifiFtList = StringUtils.GetBytes(value, 270);
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 13)]
        public byte[] ReservedByte { get; set; }
    }
}