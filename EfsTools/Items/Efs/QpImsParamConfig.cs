using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(67258)]
    [EfsFile("/nv/item_files/ims/qp_ims_param_config", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsParamConfig
    {
        [JsonIgnore]
        [ElementsCount(128)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RegConfigUserName { get; set; }

        public string RegConfigUserNameString
        {
            get => StringUtils.GetString(RegConfigUserName);
            set => RegConfigUserName = StringUtils.GetBytes(value, 128);
        }

        [JsonIgnore]
        [ElementsCount(128)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RegConfigPassword { get; set; }

        public string RegConfigPasswordString
        {
            get => StringUtils.GetString(RegConfigPassword);
            set => RegConfigPassword = StringUtils.GetBytes(value, 128);
        }


        [JsonIgnore]
        [ElementsCount(128)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RegConfigPrivateUri { get; set; }

        public string RegConfigPrivateUriString
        {
            get => StringUtils.GetString(RegConfigPrivateUri);
            set => RegConfigPrivateUri = StringUtils.GetBytes(value, 128);
        }

        [JsonIgnore]
        [ElementsCount(128)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RegConfigDisplayName { get; set; }

        public string RegConfigDisplayNameString
        {
            get => StringUtils.GetString(RegConfigDisplayName);
            set => RegConfigDisplayName = StringUtils.GetBytes(value, 128);
        }

        [JsonIgnore]
        [ElementsCount(256)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RegConfigDomainName { get; set; }

        public string RegConfigDomainNameString
        {
            get => StringUtils.GetString(RegConfigDomainName);
            set => RegConfigDomainName = StringUtils.GetBytes(value, 256);
        }

        [JsonIgnore]
        [ElementsCount(32)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RegAuthSecretKey { get; set; }

        public string RegAuthSecretKeyString
        {
            get => StringUtils.GetString(RegAuthSecretKey);
            set => RegAuthSecretKey = StringUtils.GetBytes(value, 32);
        }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ThreeGppEnabled { get; set; }

        [JsonIgnore]
        [ElementsCount(32)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RegConfigOPField { get; set; }

        public string RegConfigOPFieldString
        {
            get => StringUtils.GetString(RegConfigOPField);
            set => RegConfigOPField = StringUtils.GetBytes(value, 32);
        }
    }
}