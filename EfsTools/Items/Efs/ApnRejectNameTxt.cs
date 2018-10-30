using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [EfsFile("/nv/item_files/modem/data/3gpp/ps/apn_reject/apn_reject_name.txt", false, 0x81FF)]
    [Attributes(9)]
    public class ApnRejectNameTxt
    {
    }
}