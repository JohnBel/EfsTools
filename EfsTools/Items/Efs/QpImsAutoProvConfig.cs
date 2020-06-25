using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(70329)]
    [EfsFile("/nv/item_files/ims/qp_ims_auto_prov_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QpImsAutoProvConfig
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

        [Required]
        public byte Version { get; set; }


        public byte DisableAcs { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] ServiceName { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] DeviceType { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public byte[] NetType { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public byte[] RcsIdentifier { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] AcsPdpProfileName { get; set; }


        public byte AcsApnType { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 360)]
        public byte[] AcsServerAddress { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        public byte[] AcsServerPort { get; set; }
    }
}