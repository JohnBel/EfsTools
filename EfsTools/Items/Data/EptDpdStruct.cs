using System.Runtime.InteropServices;
using BinarySerialization;
using System;

using BinarySerialization;
namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class EptDpdStruct
    {
        [FieldCount(4)]
        public int[] Am
        {
            get;
        }

        [FieldCount(3)]
        public int[] Pm
        {
            get;
        }

        [FieldCount(3)]
        public byte[] PmShift
        {
            get;
        }


        public sbyte Status { get; set; }
    }
}