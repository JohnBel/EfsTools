using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(71597)]
    [EfsFile("/nv/item_files/ims/qipcall_qos_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QipcallQosConfig
    {
        /*[FieldCount(32)]
		public byte[] Value { get; set; }*/

        [Required]
        public byte Version { get; set; }


        public byte LocalQosAudio { get; set; }


        public byte LocalQosVideo { get; set; }


        public byte QosInactiveInvite { get; set; }


        public byte QosInactiveReInvite { get; set; }


        public byte QosMbrAudioCheckReq { get; set; }


        public byte QosMbrVideoCheckReq { get; set; }


        public uint MbrThreshold { get; set; }


        public byte QosOptimization { get; set; }
    }
}