using System;
using System.ComponentModel;
using System.Linq;
using EfsTools.Attributes;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    public enum RatMode : sbyte
    {
        None = -1, /* FOR INTERNAL USE ONLY! */
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
        private ushort _ratCount;

        public RatAcqOrder()
        {
            RawValues = new sbyte[10];
            _ratCount = 0;
        }

        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short Version { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RatCount
        {
            get => _ratCount;
            set
            {
                if (value > 10)
                    _ratCount = 10;
                else
                    _ratCount = value;
            }
        }


        [JsonIgnore]
        [ElementsCount(10)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] RawValues { get; set; }

        public string[] Values
        {
            get
            {
                var res = new string[RatCount];
                var raw = RawValues;
                for (var i = 0; i < RatCount; ++i) res[i] = $"{(RatMode) raw[i]}";
                return res;
            }
            set
            {
                var data = value.Select(s => (RatMode) Enum.Parse(typeof(RatMode), s)).ToArray();
                if (data.Length > 10)
                    RatCount = 10;
                else
                    RatCount = (ushort) data.Length;
                Array.Copy(data, 0, RawValues, 0, RatCount);
            }
        }
    }
}