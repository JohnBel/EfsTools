using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class TxXptDpdConfigParamsDataType
    {
        public uint XptConfig { get; set; }


        public uint ExpScale { get; set; }


        public uint SearchCenter { get; set; }


        public uint SearchWidth { get; set; }


        public uint QFactor { get; set; }


        public uint TxLinMag { get; set; }


        public uint PmOrder { get; set; }


        public uint EptEnvScaleUnity { get; set; }


        public uint IqGainUnity { get; set; }


        public uint RgiSelMaxPower { get; set; }


        public uint RgiSelOffsetLow0 { get; set; }


        public uint RgiSelOffsetLow1 { get; set; }


        public uint RgiSelOffsetLow2 { get; set; }


        public uint RgiSelOffsetHigh0 { get; set; }


        public uint RgiSelOffsetHigh1 { get; set; }


        public uint RgiSelOffsetHigh2 { get; set; }

        [FieldCount(7)]
        public uint[] Reserved2
        {
            get;
        }


        public uint EtEnvScaleUnity { get; set; }


        public uint Reserved3 { get; set; }


        public uint Reserved4 { get; set; }


        public uint Reserved5 { get; set; }


        public uint Reserved6 { get; set; }


        public uint Reserved7 { get; set; }


        public uint Reserved8 { get; set; }


        public uint Reserved9 { get; set; }


        public uint Reserved10 { get; set; }
    }
}