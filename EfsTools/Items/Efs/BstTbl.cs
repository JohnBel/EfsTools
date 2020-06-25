using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/sd/bst_tbl", false, 0x81FF)]
    [Attributes(9)]
    public sealed class BstTbl
    {
        /*[JsonIgnore]
		[ConvertEndian]
		public ushort Length
        {
            get => _length;
            set
            {
                if (value > 40)
                {
                    _length = 40;
                }
                else
                {
                    _length = value;
                }
            }
        }

        private ushort _length;*/

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 58)]
        public byte[] Value
        {
            get;
        }
    }
}