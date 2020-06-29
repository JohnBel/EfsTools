using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
        [EfsFile("/nv/item_files/modem/data/3gpp/ps/apn_reject/apn_reject_name.txt", false, 0x81FF)]
    [Attributes(9)]
    public sealed class ApnRejectNameTxt
    {
    }
}