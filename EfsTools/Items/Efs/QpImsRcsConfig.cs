using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(67260)]
    [EfsFile("/nv/item_files/ims/qp_ims_rcs_config", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsRcsConfig
    {
        [JsonIgnore]
        [ElementsCount(2048)]
        [ElementType("uint8")]
        [Description("")]
        [Optional]
        public byte[] PresenceMgrConfigHttpProxy { get; set; }

        public string PresenceMgrConfigHttpProxyString
        {
            get => StringUtils.GetString(PresenceMgrConfigHttpProxy);
            set => PresenceMgrConfigHttpProxy = StringUtils.GetBytes(value, 2048);
        }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        [Optional]
        public byte PresenceMgrConfigPresence { get; set; }

        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        [Optional]
        public ushort PresenceExpires { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        [Optional]
        public byte PublishRetryAttempt { get; set; }
    }
}