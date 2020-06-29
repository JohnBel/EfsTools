using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(67258)]
    [EfsFile("/nv/item_files/ims/qp_ims_param_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QpImsParamConfig
    {
        [JsonIgnore]
        [FieldCount(128)]
        public byte[] RegConfigUserName { get; set; }

        public string RegConfigUserNameString
        {
            get => StringUtils.GetString(RegConfigUserName);
            set => RegConfigUserName = StringUtils.GetBytes(value, 128);
        }

        [JsonIgnore]
        [FieldCount(128)]
        public byte[] RegConfigPassword { get; set; }

        public string RegConfigPasswordString
        {
            get => StringUtils.GetString(RegConfigPassword);
            set => RegConfigPassword = StringUtils.GetBytes(value, 128);
        }


        [JsonIgnore]
        [FieldCount(128)]
        public byte[] RegConfigPrivateUri { get; set; }

        public string RegConfigPrivateUriString
        {
            get => StringUtils.GetString(RegConfigPrivateUri);
            set => RegConfigPrivateUri = StringUtils.GetBytes(value, 128);
        }

        [JsonIgnore]
        [FieldCount(128)]
        public byte[] RegConfigDisplayName { get; set; }

        public string RegConfigDisplayNameString
        {
            get => StringUtils.GetString(RegConfigDisplayName);
            set => RegConfigDisplayName = StringUtils.GetBytes(value, 128);
        }

        [JsonIgnore]
        [FieldCount(256)]
        public byte[] RegConfigDomainName { get; set; }

        public string RegConfigDomainNameString
        {
            get => StringUtils.GetString(RegConfigDomainName);
            set => RegConfigDomainName = StringUtils.GetBytes(value, 256);
        }

        [JsonIgnore]
        [FieldCount(32)]
        public byte[] RegAuthSecretKey { get; set; }

        public string RegAuthSecretKeyString
        {
            get => StringUtils.GetString(RegAuthSecretKey);
            set => RegAuthSecretKey = StringUtils.GetBytes(value, 32);
        }


        public byte ThreeGppEnabled { get; set; }

        [JsonIgnore]
        [FieldCount(32)]
        public byte[] RegConfigOPField { get; set; }

        public string RegConfigOPFieldString
        {
            get => StringUtils.GetString(RegConfigOPField);
            set => RegConfigOPField = StringUtils.GetBytes(value, 32);
        }
    }
}