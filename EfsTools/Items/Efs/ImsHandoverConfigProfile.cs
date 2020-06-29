using System;
using EfsTools.Attributes;
using EfsTools.Utils;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/efsprofiles/imshandoverconfig", false, 0x81FF)]
    [Attributes(9)]
    public sealed class ImsHandoverConfigProfile
    {
        [FieldCount(0)]
        private byte[] _values;

        public string[] Values
        {
            get => StringUtils.GetStringLines(_values, LineEnding.Linux);
            set => _values = StringUtils.GetBytes(value, LineEnding.Linux);
        }
    }
}