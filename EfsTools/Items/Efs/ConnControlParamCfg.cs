using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [EfsFile("/nv/item_files/modem/lte/rrc/cep/conn_control_param_cfg", false, 0x81FF)]
    [Attributes(9)]
    public class ConnControlParamCfg
    {
    }
}