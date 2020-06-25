using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Subscription]
    [NvItemId(71545)]
    [EfsFile("/nv/item_files/ims/qp_ims_test_mode", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QpImsTestMode
    {
        public byte Value { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public sbyte[] Reserved { get; set; }
    }
}