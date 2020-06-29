using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
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

        [FieldCount(58)]
        public byte[] Value
        {
            get;
        }
    }
}