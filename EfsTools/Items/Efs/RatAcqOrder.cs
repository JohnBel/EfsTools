using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    public enum RatMode : byte
    {
        None = byte.MaxValue, /* FOR INTERNAL USE ONLY! */
        NoSrv = 0,

        /**
         * < No service; NV_MODE_INACTIVE.
         */
        AMPS = 1,

        /**
         * < Analog Mobile Phone System ( AMPS) mode.
         */
        CDMA = 2,

        /**
         * < CDMA mode.
         */
        GSM = 3,

        /**
         * < GSM mode.
         */
        HDR = 4,

        /**
         * < HDR mode.
         */
        WCDMA = 5,

        /**
         * < WCDMA mode.
         */
        GPS = 6,

        /**
         * < GPS mode.
         */
        GW = 7,

        /**
         * < GSM and WCDMA mode.
         */
        WLAN = 8,

        /**
         * < WLAN mode.
         */
        LTE = 9,

        /**
         * < LTE mode.
         */
        GWL = 10,

        /**
         * < GSM, WCDMA, and LTE mode.
         */
        TDS = 11
    }

    [Serializable]
        [Subscription]
    [EfsFile("/sd/rat_acq_order", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class RatAcqOrder
    {
        [Required]
        public short Version { get; set; }

        [JsonIgnore]
        [ConvertEndian]
        public ushort RatCount { get; set; }


        
        [FieldCount(10)]
        private readonly byte[] _rawValues = new byte[10];
        
        [JsonIgnore]
        public byte[] RawValues
        {
            get => _rawValues;
            set
            {
                if (value != null)
                {
                    var len = Math.Min(value.Length, 10);
                    Array.Copy(value, _rawValues, len);
                }
            }
        }

        public string[] Values
        {
            get
            {
                if (RatCount > 10)
                {
                    RatCount = 10;
                }

                var res = new string[RatCount];
                var raw = RawValues;
                for (var i = 0; i < RatCount; ++i)
                {
                    res[i] = $"{(RatMode) raw[i]}";
                }

                return res;
            }
            set
            {
                var data = value.Select(s => EnumUtils.ParseEnumByte(typeof(RatMode), s)).ToArray();
                RawValues = data;
                RatCount = (ushort) data.Length;
                if (RatCount > 10)
                {
                    RatCount = 10;
                }
            }
        }
    }
}