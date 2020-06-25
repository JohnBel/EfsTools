using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/lte/rrc/cep/conn_control_param_cfg", false, 0x81FF)]
    [Attributes(9)]
    public sealed class ConnControlParamCfg
    {
    }
}