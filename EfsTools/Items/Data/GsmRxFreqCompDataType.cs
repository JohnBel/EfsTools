using System;
using BinarySerialization;

namespace EfsTools.Items.Data
{
    [Serializable]
    public sealed class GsmRxFreqCompDataType
    {
        [FieldCount(16)]
        public short[] FreqCompData
        {
            get;
        }
    }
}