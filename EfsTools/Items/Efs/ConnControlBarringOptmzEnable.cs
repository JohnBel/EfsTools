using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
        [EfsFile("/nv/item_files/modem/lte/rrc/cep/conn_control_barring_optmz_enable", false, 0x81FF)]
    [Attributes(9)]
    public sealed class ConnControlBarringOptmzEnable
    {
    }
}