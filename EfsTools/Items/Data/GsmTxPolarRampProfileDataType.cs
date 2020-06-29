using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class GsmTxPolarRampProfileDataType
    {
        [FieldCount(30)]
        public ushort[] RampUp
        {
            get;
        }

        [FieldCount(30)]
        public ushort[] RampDown
        {
            get;
        }
    }
}