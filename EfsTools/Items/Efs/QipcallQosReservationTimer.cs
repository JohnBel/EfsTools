using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/ims/qipcall_qos_reservation_timer", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QipcallQosReservationTimer
    {
        public uint Value { get; set; }
    }
}