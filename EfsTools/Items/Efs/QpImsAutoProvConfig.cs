using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(70329)]
    [EfsFile("/nv/item_files/ims/qp_ims_auto_prov_config", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsAutoProvConfig
    {
        public QpImsAutoProvConfig()
        {
            ServiceName = new byte[256];
            DeviceType = new byte[256];
            NetType = new byte[128];
            RcsIdentifier = new byte[128];
            AcsPdpProfileName = new byte[256];
            AcsServerAddress = new byte[360];
            AcsServerPort = new byte[40];
        }
        
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte DisableAcs { get; set; }
        
        [ElementsCount(256)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] ServiceName { get; set; }

        [ElementsCount(256)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] DeviceType { get; set; }

        [ElementsCount(128)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] NetType { get; set; }

        [ElementsCount(128)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RcsIdentifier { get; set; }

        [ElementsCount(256)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] AcsPdpProfileName { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte AcsApnType { get; set; }

        [ElementsCount(360)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] AcsServerAddress { get; set; }

        [ElementsCount(40)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] AcsServerPort { get; set; }
    }
}