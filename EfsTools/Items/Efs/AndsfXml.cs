using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Utils;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/data/andsf.xml", false, 0x81B6)]
    [Attributes(9)]
    public sealed class AndsfXml
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0)]
        private byte[] _values;

        public string[] Values
        {
            get => StringUtils.GetStringLines(_values, LineEnding.Linux);
            set => _values = StringUtils.GetBytes(value, LineEnding.Linux);
        }
    }
}