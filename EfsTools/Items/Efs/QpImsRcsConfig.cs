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
    [NvItemId(67260)]
    [EfsFile("/nv/item_files/ims/qp_ims_rcs_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QpImsRcsConfig
    {
        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] //Todo: check
        public byte[] PresenceMgrConfigHttpProxy { get; set; }

        public string PresenceMgrConfigHttpProxyString
        {
            get => StringUtils.GetString(PresenceMgrConfigHttpProxy);
            set => PresenceMgrConfigHttpProxy = StringUtils.GetBytes(value, 256);
        }


        public byte PresenceMgrConfigPresence { get; set; }


        public ushort PresenceExpires { get; set; }


        public byte PublishRetryAttempt { get; set; }
    }
}