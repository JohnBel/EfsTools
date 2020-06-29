using System;
using EfsTools.Attributes;
using EfsTools.Utils;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [Subscription]
    [EfsFile("/data/ds_dsd_attach_profile.txt", false, 0x81B6)]
    [Attributes(9)]
    public sealed class DsDsdAttachProfileTxt
    {
        [FieldCount(0)]
        private byte[] _values;

        public string[] Values
        {
            get => StringUtils.GetStringLines(_values, LineEnding.Windows);
            set => _values = StringUtils.GetBytes(value, LineEnding.Windows);
        }
    }
}