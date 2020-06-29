using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Utils;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/data/3gpp/rpm_suppported_sim", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class RpmSuppportedSim
    {
        [FieldCount(60)]
        public byte[] Value { get; set; }

        public string ValueString
        {
            get => StringUtils.GetString(Value);
            set => Value = StringUtils.GetBytes(value, 60);
        }
    }
}