using System;
using System.ComponentModel;
using System.Linq;
using EfsTools.Attributes;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    public enum RatMode : byte
    {
        None = byte.MaxValue, /* FOR INTERNAL USE ONLY! */
        NoSrv = 0, /**< No service; NV_MODE_INACTIVE. */
        AMPS = 1, /**< Analog Mobile Phone System (AMPS) mode. */
        CDMA = 2, /**< CDMA mode. */
        GSM = 3, /**< GSM mode. */
        HDR = 4, /**< HDR mode. */
        WCDMA = 5, /**< WCDMA mode. */
        GPS = 6, /**< GPS mode. */
        GW = 7, /**< GSM and WCDMA mode. */
        WLAN = 8, /**< WLAN mode. */
        LTE = 9, /**< LTE mode. */
        GWL = 10, /**< GSM, WCDMA, and LTE mode. */
        TDS = 11
    }

    [Serializable]
    [EfsFile("/sd/rat_acq_order", true, 0xE1FF)]
    [Attributes(9)]
    public class RatAcqOrder
    {
        public RatAcqOrder()
        {
        }

        [Required]
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short Version { get; set; }

        [JsonIgnore]
        [ConvertEndian]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RatCount { get; set; }


        [JsonIgnore]
        [ElementsCount(10)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RawValues
        {
            get
            {
                return _rawValues;
            }
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
                for (var i = 0; i < RatCount; ++i) res[i] = $"{(RatMode) raw[i]}";
                return res;
            }
            set
            {
                var data = value.Select(s => (byte) Enum.Parse(typeof(RatMode), s)).ToArray();
                RawValues = data;
                RatCount = (ushort)data.Length;
                if (RatCount > 10)
                {
                    RatCount = 10;
                }
            }
        }

        private readonly byte[] _rawValues = new byte[10];
    }
}