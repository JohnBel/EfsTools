using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/lte/rrc/cep/conn_control_barring_optmz_enable", false, 0x81FF)]
    [Attributes(9)]
    public sealed class ConnControlBarringOptmzEnable
    {
    }
}