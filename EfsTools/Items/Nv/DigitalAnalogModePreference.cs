using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    public enum DigitalAnalogPreferenceMode : ushort
    {
        None = 0xFFFF,
        CdmaThenAnalog = 0,
        DigitalOnly = 1,
        AnalogThenCdma = 2,
        AnalogOnly = 3,
        Automatic = 4,
        Emergency = 5,
        RestrictToHomeOnly = 6,
        CdmaOnly = 9,
        HdrOnly = 10,
        CdmaAndAmpsOnly = 11,
        GpsOnly = 12,
        GsmOnly = 13,
        WcdmaOnly = 14,
        WlanOnly = 15,
        AnyButHdr = 16,
        GsmAndWcdmaOnly = 17,
        DigitalLessHdrOnly = 18,
        CdmaAndHdrOnly = 19,
        CdmaAmpsAndHdrOnly = 20,
        CdmaAndWlanOnly = 21,
        HdrAndWlanOnly = 22,
        CdmaHdrAndWlanOnly = 23,
        GsmAndWlanOnly = 24,
        WcdmaAndWlanOnly = 25,
        GWAndWlanOnly = 26,
        CdmaAmpsHdrAndWlanOnly = 27,
        CdmaAmpsAndWlanOnly = 28,
        AnyButHdrAndWlan = 29,
        LteOnly = 30,
        GWL = 31,
        CdmaAndLteOnly = 32,
        HdrAndLteOnly = 33,
        GsmAndLteOnly = 34,
        WcdmaAndLteOnly = 35,
        CdmaHdrAndLteOnly = 36,
        CdmaGsmAndLteOnly = 37,
        CdmaWcdmaAndLteOnly = 38,
        HdrGsmAndLteOnly = 39,
        HdrWcdmaAndLteOnly = 40,
        CdmaLteAndWlanOnly = 41,
        HdrLteAndWlan = 42,
        GsmLteAndWlan = 43,
        WcdmaLteAndWlanOnly = 44,
        CdmaHdrLteAndWlan = 45,
        CdmaGsmLteAndWlan = 46,
        CdmaWcdmaLteAndWlan = 47,
        HdrGsmLteAndWlanOnly = 48,
        HdrWcdmaLteAndWlanOnly = 49,
        AnyButWlan = 50,
        CdmaGsmAndWcdmaOnly = 51,
        CdmaHdrAndWcdmaOnly = 52,
        TdscmaOnly = 53,
        TdscmaAndGsmOnly = 54,
        TdscmaGsmAndLteOnly = 55,
        CdmaHdrGsmOnly = 56,
        CdmaAndGsmOnly = 57,
        TdscmaGsmWcdmaAndLteOnly = 58,
        TdscmaGsmAndWcdmaOnly = 59,
        TdscmaAndLteOnly = 60,
        CdmaHdrGsmWcdmaAndLte = 61,
        CdmaGsmWcdmaAndLte = 62,
        TdscmaAndWcdmaOnly = 63,
        TdscmaWcdmaAndLteOnly = 64,
        CdmaHdrGsmTdscmaLte = 65,
        CdmaGWTdscma = 66,
        CdmaHdrGWTdscma = 67,
        CdmaHdrGsmLte = 68,
        HdrTdsWcdma = 69,
        HdrTdsWcdmaLte = 70,
        Nr5GOnly = 71
    }

    [Serializable]
    [NvItemId(10)]
    [Attributes(41)]
    public class DigitalAnalogModePreference
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Nam { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Mode { get; set; }

        public string StringMode
        {
            get => $"{(DigitalAnalogPreferenceMode)Mode}";
            set => Mode = EnumUtils.ParseEnumByte(typeof(DigitalAnalogPreferenceMode), value);
        }
    }
}