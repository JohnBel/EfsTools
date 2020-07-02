using System;
using BinarySerialization;
using Newtonsoft.Json;
using EfsTools.Items.Base;
using EfsTools.Attributes;
using EfsTools.Utils;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1918)]
    [Attributes(9)]
   public sealed class AGpsDefaultQosTime : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(1930)]
    [Attributes(9)]
   public sealed class AGpsEmergencyServicesSupport : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1920)]
    [Attributes(9)]
   public sealed class AGpsPositioningModesSupported : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(848)]
    [Attributes(41)]
   public sealed class AcquisitionOrderPreference : ItemBase
    {
        public byte Nam { get; set; }


        public ushort Value { get; set; }
    }

    [Serializable]
    [NvItemId(385)]
    [Attributes(9)]
   public sealed class AgcPhaseOffset : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(587)]
    [Attributes(9)]
   public sealed class AgcValue3Min : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(588)]
    [Attributes(9)]
   public sealed class AgcValue4Min : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(504)]
    [Attributes(9)]
    public sealed class Ant2CdmaLna12OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(503)]
    [Attributes(9)]
    public sealed class Ant2CdmaLnaOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(498)]
    [Attributes(9)]
    public sealed class Ant2CdmaRxCompVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(496)]
    [Attributes(9)]
   public sealed class Ant2CdmaRxLinOff0 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(497)]
    [Attributes(9)]
    public sealed class Ant2CdmaRxLinSlp : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(499)]
    [Attributes(9)]
    public sealed class Ant2CdmaRxLinVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(500)]
    [Attributes(9)]
    public sealed class Ant2CdmaRxSlpVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(502)]
    [Attributes(9)]
   public sealed class Ant2LnaRange12Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(501)]
    [Attributes(9)]
   public sealed class Ant2LnaRangeOffset : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(513)]
    [Attributes(9)]
    public sealed class Ant2PcsCdmaLna12OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(512)]
    [Attributes(9)]
    public sealed class Ant2PcsCdmaLnaOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(511)]
    [Attributes(9)]
   public sealed class Ant2PcsLnaRange12Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(510)]
    [Attributes(9)]
   public sealed class Ant2PcsLnaRangeOffset : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(507)]
    [Attributes(9)]
    public sealed class Ant2PcsRxCompVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(505)]
    [Attributes(9)]
   public sealed class Ant2PcsRxLinOff0 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(506)]
    [Attributes(9)]
    public sealed class Ant2PcsRxLinSlp : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(508)]
    [Attributes(9)]
    public sealed class Ant2PcsRxLinVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(509)]
    [Attributes(9)]
    public sealed class Ant2PcsRxSlpVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6874)]
    [Attributes(25)]
   public sealed class Asid1Data : ItemBase
    {
        public byte SessionType { get; set; }


        public sbyte Reserved { get; set; }
    }

    [Serializable]
    [NvItemId(6875)]
    [Attributes(25)]
   public sealed class Asid2Data : ItemBase
    {
        public byte SessionType { get; set; }


        public sbyte Reserved { get; set; }
    }

    [Serializable]
    [NvItemId(1907)]
    [Attributes(9)]
   public sealed class AuthenticationRequirePasswordEncryption : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(74)]
    [Attributes(9)]
   public sealed class AutoAnswerSetting : ItemBase
    {
        public byte Enable { get; set; }


        public byte Rings { get; set; }
    }

    [Serializable]
    [NvItemId(75)]
    [Attributes(9)]
   public sealed class AutoRedialSetting : ItemBase
    {
        public byte Enable { get; set; }


        public byte Rings { get; set; }
    }

    [Serializable]
    [NvItemId(441)]
    [Attributes(41)]
   public sealed class BandClassPreference : ItemBase
    {
        public byte Nam { get; set; }


        public short Band { get; set; }
    }

    [Serializable]
    [NvItemId(71)]
    [Attributes(9)]
   public sealed class Banner : ItemBase
    {
        [JsonIgnore] [FieldCount(13)] private byte[] _value;

        public string ValueString
        {
            get => StringUtils.GetString(_value);
            set => _value = StringUtils.GetBytes(value, 13);
        }
    }

    [Serializable]
    [NvItemId(1734)]
    [Attributes(9)]
   public sealed class Bc0EncBtf : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(1733)]
    [Attributes(9)]
    public sealed class Bc0ExpHdetVsAgc : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5722)]
    [Attributes(9)]
    public sealed class Bc0ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1713)]
    [Attributes(9)]
   public sealed class Bc0Gps1RfDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1731)]
    [Attributes(9)]
   public sealed class Bc0HdetOff : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5738)]
    [Attributes(9)]
   public sealed class Bc0HdetOffV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1732)]
    [Attributes(9)]
   public sealed class Bc0HdetSpn : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5754)]
    [Attributes(9)]
   public sealed class Bc0HdetSpnV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3386)]
    [Attributes(9)]
   public sealed class Bc0HdrG0ImFall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3388)]
    [Attributes(9)]
   public sealed class Bc0HdrG0ImLevel : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3387)]
    [Attributes(9)]
   public sealed class Bc0HdrG0ImRise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1879)]
    [Attributes(9)]
   public sealed class Bc0HdrImFall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1890)]
    [Attributes(9)]
   public sealed class Bc0HdrImLevel : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1880)]
    [Attributes(9)]
   public sealed class Bc0HdrImRise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2814)]
    [Attributes(9)]
    public sealed class Bc0HdrP1RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5128)]
    [Attributes(9)]
    public sealed class Bc0HdrP2RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5138)]
    [Attributes(9)]
    public sealed class Bc0HdrP3RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5883)]
    [Attributes(9)]
    public sealed class Bc0HdrRevaTxPredistort : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6275)]
    [Attributes(9)]
   public sealed class Bc0IntelliceiverRcTuneCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1736)]
    [Attributes(9)]
    public sealed class Bc0P1RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5108)]
    [Attributes(9)]
    public sealed class Bc0P2RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5118)]
    [Attributes(9)]
    public sealed class Bc0P3RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1726)]
    [Attributes(9)]
   public sealed class Bc0PaR1Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1725)]
    [Attributes(9)]
   public sealed class Bc0PaR1Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1728)]
    [Attributes(9)]
   public sealed class Bc0PaR2Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1727)]
    [Attributes(9)]
   public sealed class Bc0PaR2Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1730)]
    [Attributes(9)]
   public sealed class Bc0PaR3Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1729)]
    [Attributes(9)]
   public sealed class Bc0PaR3Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4880)]
    [Attributes(9)]
   public sealed class Bc0PaRMap : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6863)]
    [Attributes(9)]
   public sealed class Bc0PaSmpsPdmLevel : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6219)]
    [Attributes(9)]
   public sealed class Bc0SubclassMask : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(1720)]
    [Attributes(9)]
   public sealed class Bc0TxComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1721)]
    [Attributes(9)]
   public sealed class Bc0TxComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1722)]
    [Attributes(9)]
   public sealed class Bc0TxComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1723)]
    [Attributes(9)]
   public sealed class Bc0TxComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1724)]
    [Attributes(9)]
    public sealed class Bc0TxLimVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1715)]
    [Attributes(9)]
    public sealed class Bc0TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4831)]
    [Attributes(9)]
   public sealed class Bc0TxLin0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4832)]
    [Attributes(9)]
   public sealed class Bc0TxLin1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4833)]
    [Attributes(9)]
   public sealed class Bc0TxLin2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4834)]
    [Attributes(9)]
   public sealed class Bc0TxLin3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1716)]
    [Attributes(9)]
   public sealed class Bc0TxLinMaster0 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(1717)]
    [Attributes(9)]
   public sealed class Bc0TxLinMaster1 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(1718)]
    [Attributes(9)]
   public sealed class Bc0TxLinMaster2 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(1719)]
    [Attributes(9)]
   public sealed class Bc0TxLinMaster3 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(4795)]
    [Attributes(9)]
   public sealed class Bc0TxPdm0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4796)]
    [Attributes(9)]
   public sealed class Bc0TxPdm1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4797)]
    [Attributes(9)]
   public sealed class Bc0TxPdm2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4798)]
    [Attributes(9)]
   public sealed class Bc0TxPdm3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4997)]
    [Attributes(9)]
   public sealed class Bc0TxPwrComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4998)]
    [Attributes(9)]
   public sealed class Bc0TxPwrComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4999)]
    [Attributes(9)]
   public sealed class Bc0TxPwrComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5000)]
    [Attributes(9)]
   public sealed class Bc0TxPwrComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1735)]
    [Attributes(9)]
   public sealed class Bc0VcoCoarseTuneTable : FortyEightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3237)]
    [Attributes(9)]
   public sealed class Bc0VcoTune2 : FortyEightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5183)]
    [Attributes(9)]
   public sealed class Bc10EncBtf : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5182)]
    [Attributes(9)]
    public sealed class Bc10ExpHdetVsAgc : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5732)]
    [Attributes(9)]
    public sealed class Bc10ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5167)]
    [Attributes(9)]
   public sealed class Bc10Gps1RfDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5180)]
    [Attributes(9)]
   public sealed class Bc10HdetOff : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5748)]
    [Attributes(9)]
   public sealed class Bc10HdetOffV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5181)]
    [Attributes(9)]
   public sealed class Bc10HdetSpn : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5764)]
    [Attributes(9)]
   public sealed class Bc10HdetSpnV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5187)]
    [Attributes(9)]
    public sealed class Bc10HdrP1RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5377)]
    [Attributes(9)]
    public sealed class Bc10HdrP2RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5378)]
    [Attributes(9)]
    public sealed class Bc10HdrP3RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5889)]
    [Attributes(9)]
    public sealed class Bc10HdrRevaTxPredistort : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6285)]
    [Attributes(9)]
   public sealed class Bc10IntelliceiverRcTuneCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5186)]
    [Attributes(9)]
    public sealed class Bc10P1RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5375)]
    [Attributes(9)]
    public sealed class Bc10P2RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5376)]
    [Attributes(9)]
    public sealed class Bc10P3RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5175)]
    [Attributes(9)]
   public sealed class Bc10PaR1Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5174)]
    [Attributes(9)]
   public sealed class Bc10PaR1Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5177)]
    [Attributes(9)]
   public sealed class Bc10PaR2Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5176)]
    [Attributes(9)]
   public sealed class Bc10PaR2Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5179)]
    [Attributes(9)]
   public sealed class Bc10PaR3Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5178)]
    [Attributes(9)]
   public sealed class Bc10PaR3Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5202)]
    [Attributes(9)]
   public sealed class Bc10PaRMap : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6869)]
    [Attributes(9)]
   public sealed class Bc10PaSmpsPdmLevel : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6229)]
    [Attributes(9)]
   public sealed class Bc10SubclassMask : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5169)]
    [Attributes(9)]
   public sealed class Bc10TxComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5170)]
    [Attributes(9)]
   public sealed class Bc10TxComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5171)]
    [Attributes(9)]
   public sealed class Bc10TxComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5172)]
    [Attributes(9)]
   public sealed class Bc10TxComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5173)]
    [Attributes(9)]
    public sealed class Bc10TxLimVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5168)]
    [Attributes(9)]
    public sealed class Bc10TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5198)]
    [Attributes(9)]
   public sealed class Bc10TxLin0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5199)]
    [Attributes(9)]
   public sealed class Bc10TxLin1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5200)]
    [Attributes(9)]
   public sealed class Bc10TxLin2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5201)]
    [Attributes(9)]
   public sealed class Bc10TxLin3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5163)]
    [Attributes(9)]
   public sealed class Bc10TxLinMaster0 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(5164)]
    [Attributes(9)]
   public sealed class Bc10TxLinMaster1 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(5165)]
    [Attributes(9)]
   public sealed class Bc10TxLinMaster2 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(5166)]
    [Attributes(9)]
   public sealed class Bc10TxLinMaster3 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(5194)]
    [Attributes(9)]
   public sealed class Bc10TxPdm0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5195)]
    [Attributes(9)]
   public sealed class Bc10TxPdm1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5196)]
    [Attributes(9)]
   public sealed class Bc10TxPdm2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5197)]
    [Attributes(9)]
   public sealed class Bc10TxPdm3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5203)]
    [Attributes(9)]
   public sealed class Bc10TxPwrComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5204)]
    [Attributes(9)]
   public sealed class Bc10TxPwrComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5205)]
    [Attributes(9)]
   public sealed class Bc10TxPwrComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5206)]
    [Attributes(9)]
   public sealed class Bc10TxPwrComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5184)]
    [Attributes(9)]
   public sealed class Bc10VcoCoarseTuneTable : FortyEightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5185)]
    [Attributes(9)]
   public sealed class Bc10VcoTune2 : FortyEightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3873)]
    [Attributes(9)]
   public sealed class Bc11EncBtf : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3872)]
    [Attributes(9)]
    public sealed class Bc11ExpHdetVsAgc : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5733)]
    [Attributes(9)]
    public sealed class Bc11ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3853)]
    [Attributes(9)]
   public sealed class Bc11Gps1RfDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3870)]
    [Attributes(9)]
   public sealed class Bc11HdetOff : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5749)]
    [Attributes(9)]
   public sealed class Bc11HdetOffV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3871)]
    [Attributes(9)]
   public sealed class Bc11HdetSpn : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5765)]
    [Attributes(9)]
   public sealed class Bc11HdetSpnV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3931)]
    [Attributes(9)]
    public sealed class Bc11HdrP1RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5134)]
    [Attributes(9)]
    public sealed class Bc11HdrP2RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5144)]
    [Attributes(9)]
    public sealed class Bc11HdrP3RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5890)]
    [Attributes(9)]
    public sealed class Bc11HdrRevaTxPredistort : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6286)]
    [Attributes(9)]
   public sealed class Bc11IntelliceiverRcTuneCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3875)]
    [Attributes(9)]
    public sealed class Bc11P1RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5114)]
    [Attributes(9)]
    public sealed class Bc11P2RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5124)]
    [Attributes(9)]
    public sealed class Bc11P3RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3865)]
    [Attributes(9)]
   public sealed class Bc11PaR1Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3864)]
    [Attributes(9)]
   public sealed class Bc11PaR1Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3867)]
    [Attributes(9)]
   public sealed class Bc11PaR2Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3866)]
    [Attributes(9)]
   public sealed class Bc11PaR2Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3869)]
    [Attributes(9)]
   public sealed class Bc11PaR3Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3868)]
    [Attributes(9)]
   public sealed class Bc11PaR3Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4886)]
    [Attributes(9)]
   public sealed class Bc11PaRMap : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6230)]
    [Attributes(9)]
   public sealed class Bc11SubclassMask : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3859)]
    [Attributes(9)]
   public sealed class Bc11TxComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3860)]
    [Attributes(9)]
   public sealed class Bc11TxComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3861)]
    [Attributes(9)]
   public sealed class Bc11TxComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3862)]
    [Attributes(9)]
   public sealed class Bc11TxComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3863)]
    [Attributes(9)]
    public sealed class Bc11TxLimVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3854)]
    [Attributes(9)]
    public sealed class Bc11TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4855)]
    [Attributes(9)]
   public sealed class Bc11TxLin0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4856)]
    [Attributes(9)]
   public sealed class Bc11TxLin1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4857)]
    [Attributes(9)]
   public sealed class Bc11TxLin2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4858)]
    [Attributes(9)]
   public sealed class Bc11TxLin3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3855)]
    [Attributes(9)]
   public sealed class Bc11TxLinMaster0 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(3856)]
    [Attributes(9)]
   public sealed class Bc11TxLinMaster1 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(3857)]
    [Attributes(9)]
   public sealed class Bc11TxLinMaster2 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(3858)]
    [Attributes(9)]
   public sealed class Bc11TxLinMaster3 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(4819)]
    [Attributes(9)]
   public sealed class Bc11TxPdm0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4820)]
    [Attributes(9)]
   public sealed class Bc11TxPdm1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4821)]
    [Attributes(9)]
   public sealed class Bc11TxPdm2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4822)]
    [Attributes(9)]
   public sealed class Bc11TxPdm3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5017)]
    [Attributes(9)]
   public sealed class Bc11TxPwrComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5018)]
    [Attributes(9)]
   public sealed class Bc11TxPwrComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5019)]
    [Attributes(9)]
   public sealed class Bc11TxPwrComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5020)]
    [Attributes(9)]
   public sealed class Bc11TxPwrComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3874)]
    [Attributes(9)]
   public sealed class Bc11VcoCoarseTuneTable : FortyEightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3930)]
    [Attributes(9)]
   public sealed class Bc11VcoTune2 : FortyEightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5734)]
    [Attributes(9)]
    public sealed class Bc12ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5750)]
    [Attributes(9)]
   public sealed class Bc12HdetOffV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5766)]
    [Attributes(9)]
   public sealed class Bc12HdetSpnV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6287)]
    [Attributes(9)]
   public sealed class Bc12IntelliceiverRcTuneCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6231)]
    [Attributes(9)]
   public sealed class Bc12SubclassMask : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5735)]
    [Attributes(9)]
    public sealed class Bc13ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5751)]
    [Attributes(9)]
   public sealed class Bc13HdetOffV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5767)]
    [Attributes(9)]
   public sealed class Bc13HdetSpnV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6288)]
    [Attributes(9)]
   public sealed class Bc13IntelliceiverRcTuneCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6232)]
    [Attributes(9)]
   public sealed class Bc13SubclassMask : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3556)]
    [Attributes(9)]
   public sealed class Bc14EncBtf : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3555)]
    [Attributes(9)]
    public sealed class Bc14ExpHdetVsAgc : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5736)]
    [Attributes(9)]
    public sealed class Bc14ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3540)]
    [Attributes(9)]
   public sealed class Bc14Gps1RfDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3553)]
    [Attributes(9)]
   public sealed class Bc14HdetOff : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5752)]
    [Attributes(9)]
   public sealed class Bc14HdetOffV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3554)]
    [Attributes(9)]
   public sealed class Bc14HdetSpn : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5768)]
    [Attributes(9)]
   public sealed class Bc14HdetSpnV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3560)]
    [Attributes(9)]
    public sealed class Bc14HdrP1RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5135)]
    [Attributes(9)]
    public sealed class Bc14HdrP2RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5145)]
    [Attributes(9)]
    public sealed class Bc14HdrP3RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5891)]
    [Attributes(9)]
    public sealed class Bc14HdrRevaTxPredistort : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6289)]
    [Attributes(9)]
   public sealed class Bc14IntelliceiverRcTuneCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3559)]
    [Attributes(9)]
    public sealed class Bc14P1RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5115)]
    [Attributes(9)]
    public sealed class Bc14P2RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5125)]
    [Attributes(9)]
    public sealed class Bc14P3RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3548)]
    [Attributes(9)]
   public sealed class Bc14PaR1Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3547)]
    [Attributes(9)]
   public sealed class Bc14PaR1Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3550)]
    [Attributes(9)]
   public sealed class Bc14PaR2Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3549)]
    [Attributes(9)]
   public sealed class Bc14PaR2Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3552)]
    [Attributes(9)]
   public sealed class Bc14PaR3Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3551)]
    [Attributes(9)]
   public sealed class Bc14PaR3Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4887)]
    [Attributes(9)]
   public sealed class Bc14PaRMap : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6870)]
    [Attributes(9)]
   public sealed class Bc14PaSmpsPdmLevel : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6233)]
    [Attributes(9)]
   public sealed class Bc14SubclassMask : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3542)]
    [Attributes(9)]
   public sealed class Bc14TxComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3543)]
    [Attributes(9)]
   public sealed class Bc14TxComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3544)]
    [Attributes(9)]
   public sealed class Bc14TxComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3545)]
    [Attributes(9)]
   public sealed class Bc14TxComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3546)]
    [Attributes(9)]
    public sealed class Bc14TxLimVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3541)]
    [Attributes(9)]
    public sealed class Bc14TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4859)]
    [Attributes(9)]
   public sealed class Bc14TxLin0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4860)]
    [Attributes(9)]
   public sealed class Bc14TxLin1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4861)]
    [Attributes(9)]
   public sealed class Bc14TxLin2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4862)]
    [Attributes(9)]
   public sealed class Bc14TxLin3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3536)]
    [Attributes(9)]
   public sealed class Bc14TxLinMaster0 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(3537)]
    [Attributes(9)]
   public sealed class Bc14TxLinMaster1 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(3538)]
    [Attributes(9)]
   public sealed class Bc14TxLinMaster2 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(3539)]
    [Attributes(9)]
   public sealed class Bc14TxLinMaster3 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(4823)]
    [Attributes(9)]
   public sealed class Bc14TxPdm0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4824)]
    [Attributes(9)]
   public sealed class Bc14TxPdm1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4825)]
    [Attributes(9)]
   public sealed class Bc14TxPdm2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4826)]
    [Attributes(9)]
   public sealed class Bc14TxPdm3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5021)]
    [Attributes(9)]
   public sealed class Bc14TxPwrComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5022)]
    [Attributes(9)]
   public sealed class Bc14TxPwrComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5023)]
    [Attributes(9)]
   public sealed class Bc14TxPwrComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5024)]
    [Attributes(9)]
   public sealed class Bc14TxPwrComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3557)]
    [Attributes(9)]
   public sealed class Bc14VcoCoarseTuneTable : FortyEightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3558)]
    [Attributes(9)]
   public sealed class Bc14VcoTune2 : FortyEightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4288)]
    [Attributes(9)]
   public sealed class Bc15EncBtf : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(4287)]
    [Attributes(9)]
    public sealed class Bc15ExpHdetVsAgc : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5737)]
    [Attributes(9)]
    public sealed class Bc15ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4272)]
    [Attributes(9)]
   public sealed class Bc15Gps1RfDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4285)]
    [Attributes(9)]
   public sealed class Bc15HdetOff : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5753)]
    [Attributes(9)]
   public sealed class Bc15HdetOffV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4286)]
    [Attributes(9)]
   public sealed class Bc15HdetSpn : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5769)]
    [Attributes(9)]
   public sealed class Bc15HdetSpnV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4292)]
    [Attributes(9)]
    public sealed class Bc15HdrP1RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5136)]
    [Attributes(9)]
    public sealed class Bc15HdrP2RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5146)]
    [Attributes(9)]
    public sealed class Bc15HdrP3RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5892)]
    [Attributes(9)]
    public sealed class Bc15HdrRevaTxPredistort : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6290)]
    [Attributes(9)]
   public sealed class Bc15IntelliceiverRcTuneCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4291)]
    [Attributes(9)]
    public sealed class Bc15P1RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5116)]
    [Attributes(9)]
    public sealed class Bc15P2RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5126)]
    [Attributes(9)]
    public sealed class Bc15P3RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4280)]
    [Attributes(9)]
   public sealed class Bc15PaR1Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4279)]
    [Attributes(9)]
   public sealed class Bc15PaR1Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4282)]
    [Attributes(9)]
   public sealed class Bc15PaR2Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4281)]
    [Attributes(9)]
   public sealed class Bc15PaR2Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4284)]
    [Attributes(9)]
   public sealed class Bc15PaR3Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4283)]
    [Attributes(9)]
   public sealed class Bc15PaR3Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4888)]
    [Attributes(9)]
   public sealed class Bc15PaRMap : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6871)]
    [Attributes(9)]
   public sealed class Bc15PaSmpsPdmLevel : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6234)]
    [Attributes(9)]
   public sealed class Bc15SubclassMask : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(4274)]
    [Attributes(9)]
   public sealed class Bc15TxComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4275)]
    [Attributes(9)]
   public sealed class Bc15TxComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4276)]
    [Attributes(9)]
   public sealed class Bc15TxComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4277)]
    [Attributes(9)]
   public sealed class Bc15TxComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4278)]
    [Attributes(9)]
    public sealed class Bc15TxLimVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4273)]
    [Attributes(9)]
    public sealed class Bc15TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4863)]
    [Attributes(9)]
   public sealed class Bc15TxLin0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4864)]
    [Attributes(9)]
   public sealed class Bc15TxLin1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4865)]
    [Attributes(9)]
   public sealed class Bc15TxLin2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4866)]
    [Attributes(9)]
   public sealed class Bc15TxLin3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4268)]
    [Attributes(9)]
   public sealed class Bc15TxLinMaster0 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(4269)]
    [Attributes(9)]
   public sealed class Bc15TxLinMaster1 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(4270)]
    [Attributes(9)]
   public sealed class Bc15TxLinMaster2 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(4271)]
    [Attributes(9)]
   public sealed class Bc15TxLinMaster3 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(4827)]
    [Attributes(9)]
   public sealed class Bc15TxPdm0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4828)]
    [Attributes(9)]
   public sealed class Bc15TxPdm1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4829)]
    [Attributes(9)]
   public sealed class Bc15TxPdm2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4830)]
    [Attributes(9)]
   public sealed class Bc15TxPdm3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5025)]
    [Attributes(9)]
   public sealed class Bc15TxPwrComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5026)]
    [Attributes(9)]
   public sealed class Bc15TxPwrComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5027)]
    [Attributes(9)]
   public sealed class Bc15TxPwrComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5028)]
    [Attributes(9)]
   public sealed class Bc15TxPwrComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4289)]
    [Attributes(9)]
   public sealed class Bc15VcoCoarseTuneTable : FortyEightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4290)]
    [Attributes(9)]
   public sealed class Bc15VcoTune2 : FortyEightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1645)]
    [Attributes(9)]
   public sealed class Bc1EncBtf : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(1644)]
    [Attributes(9)]
    public sealed class Bc1ExpHdetVsAgc : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5723)]
    [Attributes(9)]
    public sealed class Bc1ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1624)]
    [Attributes(9)]
   public sealed class Bc1Gps1RfDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1642)]
    [Attributes(9)]
   public sealed class Bc1HdetOff : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5739)]
    [Attributes(9)]
   public sealed class Bc1HdetOffV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1643)]
    [Attributes(9)]
   public sealed class Bc1HdetSpn : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5755)]
    [Attributes(9)]
   public sealed class Bc1HdetSpnV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2815)]
    [Attributes(9)]
    public sealed class Bc1HdrP1RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5129)]
    [Attributes(9)]
    public sealed class Bc1HdrP2RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5139)]
    [Attributes(9)]
    public sealed class Bc1HdrP3RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5884)]
    [Attributes(9)]
    public sealed class Bc1HdrRevaTxPredistort : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6276)]
    [Attributes(9)]
   public sealed class Bc1IntelliceiverRcTuneCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1647)]
    [Attributes(9)]
    public sealed class Bc1P1RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5109)]
    [Attributes(9)]
    public sealed class Bc1P2RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5119)]
    [Attributes(9)]
    public sealed class Bc1P3RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1637)]
    [Attributes(9)]
   public sealed class Bc1PaR1Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1636)]
    [Attributes(9)]
   public sealed class Bc1PaR1Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1639)]
    [Attributes(9)]
   public sealed class Bc1PaR2Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1638)]
    [Attributes(9)]
   public sealed class Bc1PaR2Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1641)]
    [Attributes(9)]
   public sealed class Bc1PaR3Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1640)]
    [Attributes(9)]
   public sealed class Bc1PaR3Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4881)]
    [Attributes(9)]
   public sealed class Bc1PaRMap : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6864)]
    [Attributes(9)]
   public sealed class Bc1PaSmpsPdmLevel : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6220)]
    [Attributes(9)]
   public sealed class Bc1SubclassMask : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(1631)]
    [Attributes(9)]
   public sealed class Bc1TxComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1632)]
    [Attributes(9)]
   public sealed class Bc1TxComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1633)]
    [Attributes(9)]
   public sealed class Bc1TxComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1634)]
    [Attributes(9)]
   public sealed class Bc1TxComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1635)]
    [Attributes(9)]
    public sealed class Bc1TxLimVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1626)]
    [Attributes(9)]
    public sealed class Bc1TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4835)]
    [Attributes(9)]
   public sealed class Bc1TxLin0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4836)]
    [Attributes(9)]
   public sealed class Bc1TxLin1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4837)]
    [Attributes(9)]
   public sealed class Bc1TxLin2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4838)]
    [Attributes(9)]
   public sealed class Bc1TxLin3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1627)]
    [Attributes(9)]
   public sealed class Bc1TxLinMaster0 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(1628)]
    [Attributes(9)]
   public sealed class Bc1TxLinMaster1 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(1629)]
    [Attributes(9)]
   public sealed class Bc1TxLinMaster2 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(1630)]
    [Attributes(9)]
   public sealed class Bc1TxLinMaster3 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(4799)]
    [Attributes(9)]
   public sealed class Bc1TxPdm0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4800)]
    [Attributes(9)]
   public sealed class Bc1TxPdm1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4801)]
    [Attributes(9)]
   public sealed class Bc1TxPdm2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4802)]
    [Attributes(9)]
   public sealed class Bc1TxPdm3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5001)]
    [Attributes(9)]
   public sealed class Bc1TxPwrComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5002)]
    [Attributes(9)]
   public sealed class Bc1TxPwrComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5003)]
    [Attributes(9)]
   public sealed class Bc1TxPwrComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5004)]
    [Attributes(9)]
   public sealed class Bc1TxPwrComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1646)]
    [Attributes(9)]
   public sealed class Bc1VcoCoarseTuneTable : FortyEightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3238)]
    [Attributes(9)]
   public sealed class Bc1VcoTune2 : FortyEightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5724)]
    [Attributes(9)]
    public sealed class Bc2ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5740)]
    [Attributes(9)]
   public sealed class Bc2HdetOffV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5756)]
    [Attributes(9)]
   public sealed class Bc2HdetSpnV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6277)]
    [Attributes(9)]
   public sealed class Bc2IntelliceiverRcTuneCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6221)]
    [Attributes(9)]
   public sealed class Bc2SubclassMask : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(1567)]
    [Attributes(9)]
   public sealed class Bc3EncBtf : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(1566)]
    [Attributes(9)]
    public sealed class Bc3ExpHdetVsAgc : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5725)]
    [Attributes(9)]
    public sealed class Bc3ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1545)]
    [Attributes(9)]
   public sealed class Bc3Gps1RfDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1564)]
    [Attributes(9)]
   public sealed class Bc3HdetOff : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5741)]
    [Attributes(9)]
   public sealed class Bc3HdetOffV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1565)]
    [Attributes(9)]
   public sealed class Bc3HdetSpn : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5757)]
    [Attributes(9)]
   public sealed class Bc3HdetSpnV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2816)]
    [Attributes(9)]
    public sealed class Bc3HdrP1RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5130)]
    [Attributes(9)]
    public sealed class Bc3HdrP2RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5140)]
    [Attributes(9)]
    public sealed class Bc3HdrP3RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5885)]
    [Attributes(9)]
    public sealed class Bc3HdrRevaTxPredistort : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6278)]
    [Attributes(9)]
   public sealed class Bc3IntelliceiverRcTuneCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1569)]
    [Attributes(9)]
    public sealed class Bc3P1RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5110)]
    [Attributes(9)]
    public sealed class Bc3P2RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5120)]
    [Attributes(9)]
    public sealed class Bc3P3RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1559)]
    [Attributes(9)]
   public sealed class Bc3PaR1Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1558)]
    [Attributes(9)]
   public sealed class Bc3PaR1Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1561)]
    [Attributes(9)]
   public sealed class Bc3PaR2Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1560)]
    [Attributes(9)]
   public sealed class Bc3PaR2Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1563)]
    [Attributes(9)]
   public sealed class Bc3PaR3Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1562)]
    [Attributes(9)]
   public sealed class Bc3PaR3Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4882)]
    [Attributes(9)]
   public sealed class Bc3PaRMap : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6865)]
    [Attributes(9)]
   public sealed class Bc3PaSmpsPdmLevel : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6222)]
    [Attributes(9)]
   public sealed class Bc3SubclassMask : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(1552)]
    [Attributes(9)]
   public sealed class Bc3TxComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1553)]
    [Attributes(9)]
   public sealed class Bc3TxComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1554)]
    [Attributes(9)]
   public sealed class Bc3TxComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1555)]
    [Attributes(9)]
   public sealed class Bc3TxComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1557)]
    [Attributes(9)]
    public sealed class Bc3TxLimVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1547)]
    [Attributes(9)]
    public sealed class Bc3TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4839)]
    [Attributes(9)]
   public sealed class Bc3TxLin0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4840)]
    [Attributes(9)]
   public sealed class Bc3TxLin1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4841)]
    [Attributes(9)]
   public sealed class Bc3TxLin2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4842)]
    [Attributes(9)]
   public sealed class Bc3TxLin3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1548)]
    [Attributes(9)]
   public sealed class Bc3TxLinMaster0 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(1549)]
    [Attributes(9)]
   public sealed class Bc3TxLinMaster1 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(1550)]
    [Attributes(9)]
   public sealed class Bc3TxLinMaster2 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(1551)]
    [Attributes(9)]
   public sealed class Bc3TxLinMaster3 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(4803)]
    [Attributes(9)]
   public sealed class Bc3TxPdm0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4804)]
    [Attributes(9)]
   public sealed class Bc3TxPdm1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4805)]
    [Attributes(9)]
   public sealed class Bc3TxPdm2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4806)]
    [Attributes(9)]
   public sealed class Bc3TxPdm3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5005)]
    [Attributes(9)]
   public sealed class Bc3TxPwrComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5006)]
    [Attributes(9)]
   public sealed class Bc3TxPwrComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5007)]
    [Attributes(9)]
   public sealed class Bc3TxPwrComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5008)]
    [Attributes(9)]
   public sealed class Bc3TxPwrComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1568)]
    [Attributes(9)]
   public sealed class Bc3VcoCoarseTuneTable : FortyEightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3239)]
    [Attributes(9)]
   public sealed class Bc3VcoTune2 : FortyEightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1488)]
    [Attributes(9)]
   public sealed class Bc4EncBtf : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(1487)]
    [Attributes(9)]
    public sealed class Bc4ExpHdetVsAgc : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5726)]
    [Attributes(9)]
    public sealed class Bc4ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1467)]
    [Attributes(9)]
   public sealed class Bc4Gps1RfDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1485)]
    [Attributes(9)]
   public sealed class Bc4HdetOff : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5742)]
    [Attributes(9)]
   public sealed class Bc4HdetOffV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1486)]
    [Attributes(9)]
   public sealed class Bc4HdetSpn : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5758)]
    [Attributes(9)]
   public sealed class Bc4HdetSpnV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2817)]
    [Attributes(9)]
    public sealed class Bc4HdrP1RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5131)]
    [Attributes(9)]
    public sealed class Bc4HdrP2RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5141)]
    [Attributes(9)]
    public sealed class Bc4HdrP3RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5886)]
    [Attributes(9)]
    public sealed class Bc4HdrRevaTxPredistort : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6279)]
    [Attributes(9)]
   public sealed class Bc4IntelliceiverRcTuneCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1490)]
    [Attributes(9)]
    public sealed class Bc4P1RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5111)]
    [Attributes(9)]
    public sealed class Bc4P2RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5121)]
    [Attributes(9)]
    public sealed class Bc4P3RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1480)]
    [Attributes(9)]
   public sealed class Bc4PaR1Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1479)]
    [Attributes(9)]
   public sealed class Bc4PaR1Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1482)]
    [Attributes(9)]
   public sealed class Bc4PaR2Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1481)]
    [Attributes(9)]
   public sealed class Bc4PaR2Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1484)]
    [Attributes(9)]
   public sealed class Bc4PaR3Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1483)]
    [Attributes(9)]
   public sealed class Bc4PaR3Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4883)]
    [Attributes(9)]
   public sealed class Bc4PaRMap : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6866)]
    [Attributes(9)]
   public sealed class Bc4PaSmpsPdmLevel : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6223)]
    [Attributes(9)]
   public sealed class Bc4SubclassMask : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(1474)]
    [Attributes(9)]
   public sealed class Bc4TxComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1475)]
    [Attributes(9)]
   public sealed class Bc4TxComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1476)]
    [Attributes(9)]
   public sealed class Bc4TxComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1477)]
    [Attributes(9)]
   public sealed class Bc4TxComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1478)]
    [Attributes(9)]
    public sealed class Bc4TxLimVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1469)]
    [Attributes(9)]
    public sealed class Bc4TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4843)]
    [Attributes(9)]
   public sealed class Bc4TxLin0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4844)]
    [Attributes(9)]
   public sealed class Bc4TxLin1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4845)]
    [Attributes(9)]
   public sealed class Bc4TxLin2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4846)]
    [Attributes(9)]
   public sealed class Bc4TxLin3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1470)]
    [Attributes(9)]
   public sealed class Bc4TxLinMaster0 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(1471)]
    [Attributes(9)]
   public sealed class Bc4TxLinMaster1 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(1472)]
    [Attributes(9)]
   public sealed class Bc4TxLinMaster2 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(1473)]
    [Attributes(9)]
   public sealed class Bc4TxLinMaster3 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(4807)]
    [Attributes(9)]
   public sealed class Bc4TxPdm0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4808)]
    [Attributes(9)]
   public sealed class Bc4TxPdm1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4809)]
    [Attributes(9)]
   public sealed class Bc4TxPdm2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4810)]
    [Attributes(9)]
   public sealed class Bc4TxPdm3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5030)]
    [Attributes(9)]
   public sealed class Bc4TxPwrComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5031)]
    [Attributes(9)]
   public sealed class Bc4TxPwrComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5032)]
    [Attributes(9)]
   public sealed class Bc4TxPwrComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5033)]
    [Attributes(9)]
   public sealed class Bc4TxPwrComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1489)]
    [Attributes(9)]
   public sealed class Bc4VcoCoarseTuneTable : FortyEightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3240)]
    [Attributes(9)]
   public sealed class Bc4VcoTune2 : FortyEightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1410)]
    [Attributes(9)]
   public sealed class Bc5EncBtf : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(1409)]
    [Attributes(9)]
    public sealed class Bc5ExpHdetVsAgc : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5727)]
    [Attributes(9)]
    public sealed class Bc5ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1389)]
    [Attributes(9)]
   public sealed class Bc5Gps1RfDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1407)]
    [Attributes(9)]
   public sealed class Bc5HdetOff : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5743)]
    [Attributes(9)]
   public sealed class Bc5HdetOffV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1408)]
    [Attributes(9)]
   public sealed class Bc5HdetSpn : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5759)]
    [Attributes(9)]
   public sealed class Bc5HdetSpnV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2818)]
    [Attributes(9)]
    public sealed class Bc5HdrP1RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5132)]
    [Attributes(9)]
    public sealed class Bc5HdrP2RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5142)]
    [Attributes(9)]
    public sealed class Bc5HdrP3RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5888)]
    [Attributes(9)]
    public sealed class Bc5HdrRevaTxPredistort : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6280)]
    [Attributes(9)]
   public sealed class Bc5IntelliceiverRcTuneCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1412)]
    [Attributes(9)]
    public sealed class Bc5P1RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5112)]
    [Attributes(9)]
    public sealed class Bc5P2RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5122)]
    [Attributes(9)]
    public sealed class Bc5P3RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1402)]
    [Attributes(9)]
   public sealed class Bc5PaR1Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1401)]
    [Attributes(9)]
   public sealed class Bc5PaR1Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1404)]
    [Attributes(9)]
   public sealed class Bc5PaR2Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1403)]
    [Attributes(9)]
   public sealed class Bc5PaR2Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1406)]
    [Attributes(9)]
   public sealed class Bc5PaR3Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1405)]
    [Attributes(9)]
   public sealed class Bc5PaR3Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4884)]
    [Attributes(9)]
   public sealed class Bc5PaRMap : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6867)]
    [Attributes(9)]
   public sealed class Bc5PaSmpsPdmLevel : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6224)]
    [Attributes(9)]
   public sealed class Bc5SubclassMask : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(1396)]
    [Attributes(9)]
   public sealed class Bc5TxComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1397)]
    [Attributes(9)]
   public sealed class Bc5TxComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1398)]
    [Attributes(9)]
   public sealed class Bc5TxComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1399)]
    [Attributes(9)]
   public sealed class Bc5TxComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1400)]
    [Attributes(9)]
    public sealed class Bc5TxLimVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1391)]
    [Attributes(9)]
    public sealed class Bc5TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4847)]
    [Attributes(9)]
   public sealed class Bc5TxLin0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4848)]
    [Attributes(9)]
   public sealed class Bc5TxLin1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4849)]
    [Attributes(9)]
   public sealed class Bc5TxLin2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4850)]
    [Attributes(9)]
   public sealed class Bc5TxLin3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1392)]
    [Attributes(9)]
   public sealed class Bc5TxLinMaster0 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(1393)]
    [Attributes(9)]
   public sealed class Bc5TxLinMaster1 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(1394)]
    [Attributes(9)]
   public sealed class Bc5TxLinMaster2 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(1395)]
    [Attributes(9)]
   public sealed class Bc5TxLinMaster3 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(4811)]
    [Attributes(9)]
   public sealed class Bc5TxPdm0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4812)]
    [Attributes(9)]
   public sealed class Bc5TxPdm1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4813)]
    [Attributes(9)]
   public sealed class Bc5TxPdm2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4814)]
    [Attributes(9)]
   public sealed class Bc5TxPdm3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5009)]
    [Attributes(9)]
   public sealed class Bc5TxPwrComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5010)]
    [Attributes(9)]
   public sealed class Bc5TxPwrComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5011)]
    [Attributes(9)]
   public sealed class Bc5TxPwrComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5012)]
    [Attributes(9)]
   public sealed class Bc5TxPwrComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1411)]
    [Attributes(9)]
   public sealed class Bc5VcoCoarseTuneTable : FortyEightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3241)]
    [Attributes(9)]
   public sealed class Bc5VcoTune2 : FortyEightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1240)]
    [Attributes(9)]
   public sealed class Bc6EncBtf : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(1217)]
    [Attributes(9)]
    public sealed class Bc6ExpHdetVsAgc : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5728)]
    [Attributes(9)]
    public sealed class Bc6ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1349)]
    [Attributes(9)]
   public sealed class Bc6Gps1RfDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1218)]
    [Attributes(9)]
   public sealed class Bc6HdetOff : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5744)]
    [Attributes(9)]
   public sealed class Bc6HdetOffV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1219)]
    [Attributes(9)]
   public sealed class Bc6HdetSpn : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5760)]
    [Attributes(9)]
   public sealed class Bc6HdetSpnV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2819)]
    [Attributes(9)]
    public sealed class Bc6HdrP1RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5133)]
    [Attributes(9)]
    public sealed class Bc6HdrP2RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5143)]
    [Attributes(9)]
    public sealed class Bc6HdrP3RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5887)]
    [Attributes(9)]
    public sealed class Bc6HdrRevaTxPredistort : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6281)]
    [Attributes(9)]
   public sealed class Bc6IntelliceiverRcTuneCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1224)]
    [Attributes(9)]
   public sealed class Bc6Lna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1223)]
    [Attributes(9)]
   public sealed class Bc6Lna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1228)]
    [Attributes(9)]
   public sealed class Bc6Lna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1227)]
    [Attributes(9)]
   public sealed class Bc6Lna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1242)]
    [Attributes(9)]
   public sealed class Bc6Lna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1244)]
    [Attributes(9)]
   public sealed class Bc6Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1243)]
    [Attributes(9)]
   public sealed class Bc6Lna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1247)]
    [Attributes(9)]
   public sealed class Bc6Lna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1248)]
    [Attributes(9)]
   public sealed class Bc6Lna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1229)]
    [Attributes(9)]
   public sealed class Bc6LnaRange12Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1222)]
    [Attributes(9)]
   public sealed class Bc6LnaRangePol : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1261)]
    [Attributes(9)]
    public sealed class Bc6P1RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5113)]
    [Attributes(9)]
    public sealed class Bc6P2RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5123)]
    [Attributes(9)]
    public sealed class Bc6P3RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1221)]
    [Attributes(9)]
   public sealed class Bc6PaR1Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1220)]
    [Attributes(9)]
   public sealed class Bc6PaR1Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1356)]
    [Attributes(9)]
   public sealed class Bc6PaR2Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1355)]
    [Attributes(9)]
   public sealed class Bc6PaR2Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1358)]
    [Attributes(9)]
   public sealed class Bc6PaR3Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1357)]
    [Attributes(9)]
   public sealed class Bc6PaR3Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4885)]
    [Attributes(9)]
   public sealed class Bc6PaRMap : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6868)]
    [Attributes(9)]
   public sealed class Bc6PaSmpsPdmLevel : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6225)]
    [Attributes(9)]
   public sealed class Bc6SubclassMask : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(1214)]
    [Attributes(9)]
   public sealed class Bc6TxComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1215)]
    [Attributes(9)]
   public sealed class Bc6TxComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1353)]
    [Attributes(9)]
   public sealed class Bc6TxComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1354)]
    [Attributes(9)]
   public sealed class Bc6TxComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1216)]
    [Attributes(9)]
    public sealed class Bc6TxLimVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1210)]
    [Attributes(9)]
    public sealed class Bc6TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4851)]
    [Attributes(9)]
   public sealed class Bc6TxLin0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4852)]
    [Attributes(9)]
   public sealed class Bc6TxLin1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4853)]
    [Attributes(9)]
   public sealed class Bc6TxLin2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4854)]
    [Attributes(9)]
   public sealed class Bc6TxLin3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1212)]
    [Attributes(9)]
   public sealed class Bc6TxLinMaster0 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(1213)]
    [Attributes(9)]
   public sealed class Bc6TxLinMaster1 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(1351)]
    [Attributes(9)]
   public sealed class Bc6TxLinMaster2 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(1352)]
    [Attributes(9)]
   public sealed class Bc6TxLinMaster3 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(4815)]
    [Attributes(9)]
   public sealed class Bc6TxPdm0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4816)]
    [Attributes(9)]
   public sealed class Bc6TxPdm1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4817)]
    [Attributes(9)]
   public sealed class Bc6TxPdm2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4818)]
    [Attributes(9)]
   public sealed class Bc6TxPdm3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5013)]
    [Attributes(9)]
   public sealed class Bc6TxPwrComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5014)]
    [Attributes(9)]
   public sealed class Bc6TxPwrComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5015)]
    [Attributes(9)]
   public sealed class Bc6TxPwrComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5016)]
    [Attributes(9)]
   public sealed class Bc6TxPwrComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1272)]
    [Attributes(9)]
   public sealed class Bc6VcoCoarseTuneTable : FortyEightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3242)]
    [Attributes(9)]
   public sealed class Bc6VcoTune2 : FortyEightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5729)]
    [Attributes(9)]
    public sealed class Bc7ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5745)]
    [Attributes(9)]
   public sealed class Bc7HdetOffV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5761)]
    [Attributes(9)]
   public sealed class Bc7HdetSpnV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6282)]
    [Attributes(9)]
   public sealed class Bc7IntelliceiverRcTuneCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6226)]
    [Attributes(9)]
   public sealed class Bc7SubclassMask : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5730)]
    [Attributes(9)]
    public sealed class Bc8ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5746)]
    [Attributes(9)]
   public sealed class Bc8HdetOffV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5762)]
    [Attributes(9)]
   public sealed class Bc8HdetSpnV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6283)]
    [Attributes(9)]
   public sealed class Bc8IntelliceiverRcTuneCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6227)]
    [Attributes(9)]
   public sealed class Bc8SubclassMask : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5731)]
    [Attributes(9)]
    public sealed class Bc9ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5747)]
    [Attributes(9)]
   public sealed class Bc9HdetOffV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5763)]
    [Attributes(9)]
   public sealed class Bc9HdetSpnV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6284)]
    [Attributes(9)]
   public sealed class Bc9IntelliceiverRcTuneCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6228)]
    [Attributes(9)]
   public sealed class Bc9SubclassMask : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6209)]
    [Attributes(9)]
   public sealed class BcxBlock1BandClass : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6075)]
    [Attributes(9)]
   public sealed class BcxBlock1EncBtf : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6074)]
    [Attributes(9)]
    public sealed class BcxBlock1ExpHdetVsAgc : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6205)]
    [Attributes(9)]
    public sealed class BcxBlock1ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6072)]
    [Attributes(9)]
   public sealed class BcxBlock1HdetOff : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6206)]
    [Attributes(9)]
   public sealed class BcxBlock1HdetOffV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6073)]
    [Attributes(9)]
   public sealed class BcxBlock1HdetSpn : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6207)]
    [Attributes(9)]
   public sealed class BcxBlock1HdetSpnV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6176)]
    [Attributes(9)]
    public sealed class BcxBlock1HdrP1RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6134)]
    [Attributes(9)]
    public sealed class BcxBlock1HdrP2RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6135)]
    [Attributes(9)]
    public sealed class BcxBlock1HdrP3RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6292)]
    [Attributes(9)]
   public sealed class BcxBlock1IntelliceiverRcTuneCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6077)]
    [Attributes(9)]
    public sealed class BcxBlock1P1RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6132)]
    [Attributes(9)]
    public sealed class BcxBlock1P2RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6133)]
    [Attributes(9)]
    public sealed class BcxBlock1P3RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6067)]
    [Attributes(9)]
   public sealed class BcxBlock1PaR1Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6066)]
    [Attributes(9)]
   public sealed class BcxBlock1PaR1Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6069)]
    [Attributes(9)]
   public sealed class BcxBlock1PaR2Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6068)]
    [Attributes(9)]
   public sealed class BcxBlock1PaR2Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6071)]
    [Attributes(9)]
   public sealed class BcxBlock1PaR3Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6070)]
    [Attributes(9)]
   public sealed class BcxBlock1PaR3Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6198)]
    [Attributes(9)]
   public sealed class BcxBlock1PaRMap : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6211)]
    [Attributes(9)]
   public sealed class BcxBlock1SubclassMask : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6061)]
    [Attributes(9)]
   public sealed class BcxBlock1TxComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6062)]
    [Attributes(9)]
   public sealed class BcxBlock1TxComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6063)]
    [Attributes(9)]
   public sealed class BcxBlock1TxComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6064)]
    [Attributes(9)]
   public sealed class BcxBlock1TxComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6065)]
    [Attributes(9)]
    public sealed class BcxBlock1TxLimVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6056)]
    [Attributes(9)]
    public sealed class BcxBlock1TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6194)]
    [Attributes(9)]
   public sealed class BcxBlock1TxLin0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6195)]
    [Attributes(9)]
   public sealed class BcxBlock1TxLin1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6196)]
    [Attributes(9)]
   public sealed class BcxBlock1TxLin2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6197)]
    [Attributes(9)]
   public sealed class BcxBlock1TxLin3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6057)]
    [Attributes(9)]
   public sealed class BcxBlock1TxLinMaster0 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(6058)]
    [Attributes(9)]
   public sealed class BcxBlock1TxLinMaster1 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(6059)]
    [Attributes(9)]
   public sealed class BcxBlock1TxLinMaster2 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(6060)]
    [Attributes(9)]
   public sealed class BcxBlock1TxLinMaster3 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(6190)]
    [Attributes(9)]
   public sealed class BcxBlock1TxPdm0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6191)]
    [Attributes(9)]
   public sealed class BcxBlock1TxPdm1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6192)]
    [Attributes(9)]
   public sealed class BcxBlock1TxPdm2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6193)]
    [Attributes(9)]
   public sealed class BcxBlock1TxPdm3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6199)]
    [Attributes(9)]
   public sealed class BcxBlock1TxPwrComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6200)]
    [Attributes(9)]
   public sealed class BcxBlock1TxPwrComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6201)]
    [Attributes(9)]
   public sealed class BcxBlock1TxPwrComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6202)]
    [Attributes(9)]
   public sealed class BcxBlock1TxPwrComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6076)]
    [Attributes(9)]
   public sealed class BcxBlock1VcoCoarseTuneTable : FortyEightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6178)]
    [Attributes(9)]
   public sealed class BcxBlock1VcoTune2 : FortyEightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6208)]
    [Attributes(9)]
   public sealed class BcxBlockBandClass : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4570)]
    [Attributes(9)]
   public sealed class BcxBlockEncBtf : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(4569)]
    [Attributes(9)]
    public sealed class BcxBlockExpHdetVsAgc : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6169)]
    [Attributes(9)]
    public sealed class BcxBlockExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4567)]
    [Attributes(9)]
   public sealed class BcxBlockHdetOff : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6170)]
    [Attributes(9)]
   public sealed class BcxBlockHdetOffV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4568)]
    [Attributes(9)]
   public sealed class BcxBlockHdetSpn : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6171)]
    [Attributes(9)]
   public sealed class BcxBlockHdetSpnV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6140)]
    [Attributes(9)]
    public sealed class BcxBlockHdrP1RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5137)]
    [Attributes(9)]
    public sealed class BcxBlockHdrP2RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5147)]
    [Attributes(9)]
    public sealed class BcxBlockHdrP3RiseFallOff : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6291)]
    [Attributes(9)]
   public sealed class BcxBlockIntelliceiverRcTuneCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4572)]
    [Attributes(9)]
    public sealed class BcxBlockP1RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5117)]
    [Attributes(9)]
    public sealed class BcxBlockP2RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5127)]
    [Attributes(9)]
    public sealed class BcxBlockP3RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4562)]
    [Attributes(9)]
   public sealed class BcxBlockPaR1Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4561)]
    [Attributes(9)]
   public sealed class BcxBlockPaR1Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4564)]
    [Attributes(9)]
   public sealed class BcxBlockPaR2Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4563)]
    [Attributes(9)]
   public sealed class BcxBlockPaR2Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4566)]
    [Attributes(9)]
   public sealed class BcxBlockPaR3Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4565)]
    [Attributes(9)]
   public sealed class BcxBlockPaR3Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6162)]
    [Attributes(9)]
   public sealed class BcxBlockPaRMap : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6210)]
    [Attributes(9)]
   public sealed class BcxBlockSubclassMask : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(4556)]
    [Attributes(9)]
   public sealed class BcxBlockTxComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4557)]
    [Attributes(9)]
   public sealed class BcxBlockTxComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4558)]
    [Attributes(9)]
   public sealed class BcxBlockTxComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4559)]
    [Attributes(9)]
   public sealed class BcxBlockTxComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4560)]
    [Attributes(9)]
    public sealed class BcxBlockTxLimVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4551)]
    [Attributes(9)]
    public sealed class BcxBlockTxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6158)]
    [Attributes(9)]
   public sealed class BcxBlockTxLin0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6159)]
    [Attributes(9)]
   public sealed class BcxBlockTxLin1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6160)]
    [Attributes(9)]
   public sealed class BcxBlockTxLin2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6161)]
    [Attributes(9)]
   public sealed class BcxBlockTxLin3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4552)]
    [Attributes(9)]
   public sealed class BcxBlockTxLinMaster0 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(4553)]
    [Attributes(9)]
   public sealed class BcxBlockTxLinMaster1 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(4554)]
    [Attributes(9)]
   public sealed class BcxBlockTxLinMaster2 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(4555)]
    [Attributes(9)]
   public sealed class BcxBlockTxLinMaster3 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(6154)]
    [Attributes(9)]
   public sealed class BcxBlockTxPdm0 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6155)]
    [Attributes(9)]
   public sealed class BcxBlockTxPdm1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6156)]
    [Attributes(9)]
   public sealed class BcxBlockTxPdm2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6157)]
    [Attributes(9)]
   public sealed class BcxBlockTxPdm3 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6163)]
    [Attributes(9)]
   public sealed class BcxBlockTxPwrComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6164)]
    [Attributes(9)]
   public sealed class BcxBlockTxPwrComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6165)]
    [Attributes(9)]
   public sealed class BcxBlockTxPwrComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6166)]
    [Attributes(9)]
   public sealed class BcxBlockTxPwrComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4571)]
    [Attributes(9)]
   public sealed class BcxBlockVcoCoarseTuneTable : FortyEightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6142)]
    [Attributes(9)]
   public sealed class BcxBlockVcoTune2 : FortyEightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(374)]
    [Attributes(9)]
   public sealed class BroadcastSmsConfiguration : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(375)]
    [Attributes(9)]
   public sealed class BroadcastSmsUserPreferences : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2839)]
    [Attributes(9)]
   public sealed class BtActive : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(380)]
    [Attributes(9)]
   public sealed class BypassTimer : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5577)]
    [Attributes(9)]
   public sealed class C0Bc0Im2Cal : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1747)]
    [Attributes(9)]
   public sealed class C0Bc0Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3253)]
    [Attributes(9)]
    public sealed class C0Bc0Im2Lpm1 : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3259)]
    [Attributes(9)]
    public sealed class C0Bc0Im2Lpm2 : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1748)]
    [Attributes(9)]
   public sealed class C0Bc0Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1751)]
    [Attributes(9)]
   public sealed class C0Bc0Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1760)]
    [Attributes(9)]
   public sealed class C0Bc0ImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1761)]
    [Attributes(9)]
   public sealed class C0Bc0ImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1762)]
    [Attributes(9)]
   public sealed class C0Bc0ImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1763)]
    [Attributes(9)]
   public sealed class C0Bc0ImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3265)]
    [Attributes(9)]
    public sealed class C0Bc0IntelliceiverCal : SevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3469)]
    [Attributes(9)]
    public sealed class C0Bc0IntelliceiverDetThresh : TenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1753)]
    [Attributes(9)]
   public sealed class C0Bc0Lna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1743)]
    [Attributes(9)]
   public sealed class C0Bc0Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1739)]
    [Attributes(9)]
    public sealed class C0Bc0Lna1OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1752)]
    [Attributes(9)]
   public sealed class C0Bc0Lna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1755)]
    [Attributes(9)]
   public sealed class C0Bc0Lna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1744)]
    [Attributes(9)]
   public sealed class C0Bc0Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1740)]
    [Attributes(9)]
    public sealed class C0Bc0Lna2OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1754)]
    [Attributes(9)]
   public sealed class C0Bc0Lna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1757)]
    [Attributes(9)]
   public sealed class C0Bc0Lna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1745)]
    [Attributes(9)]
   public sealed class C0Bc0Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1741)]
    [Attributes(9)]
    public sealed class C0Bc0Lna3OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1756)]
    [Attributes(9)]
   public sealed class C0Bc0Lna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1759)]
    [Attributes(9)]
   public sealed class C0Bc0Lna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1746)]
    [Attributes(9)]
   public sealed class C0Bc0Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1742)]
    [Attributes(9)]
    public sealed class C0Bc0Lna4OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1758)]
    [Attributes(9)]
   public sealed class C0Bc0Lna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3271)]
    [Attributes(9)]
    public sealed class C0Bc0LnaSwitchpointsLpm1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3277)]
    [Attributes(9)]
    public sealed class C0Bc0LnaSwitchpointsLpm2 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5433)]
    [Attributes(9)]
   public sealed class C0Bc0LoCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1738)]
    [Attributes(9)]
    public sealed class C0Bc0RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2791)]
    [Attributes(9)]
    public sealed class C0Bc0RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1737)]
    [Attributes(9)]
    public sealed class C0Bc0TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1749)]
    [Attributes(9)]
   public sealed class C0Bc0VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1750)]
    [Attributes(9)]
    public sealed class C0Bc0VgaGainOffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5587)]
    [Attributes(9)]
   public sealed class C0Bc10Im2Cal : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5218)]
    [Attributes(9)]
   public sealed class C0Bc10Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5237)]
    [Attributes(9)]
    public sealed class C0Bc10Im2Lpm1 : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5238)]
    [Attributes(9)]
    public sealed class C0Bc10Im2Lpm2 : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5219)]
    [Attributes(9)]
   public sealed class C0Bc10Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5222)]
    [Attributes(9)]
   public sealed class C0Bc10Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5231)]
    [Attributes(9)]
   public sealed class C0Bc10ImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5232)]
    [Attributes(9)]
   public sealed class C0Bc10ImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5233)]
    [Attributes(9)]
   public sealed class C0Bc10ImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5234)]
    [Attributes(9)]
   public sealed class C0Bc10ImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5239)]
    [Attributes(9)]
    public sealed class C0Bc10IntelliceiverCal : SevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5240)]
    [Attributes(9)]
    public sealed class C0Bc10IntelliceiverDetThresh : TenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5224)]
    [Attributes(9)]
   public sealed class C0Bc10Lna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5210)]
    [Attributes(9)]
   public sealed class C0Bc10Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5214)]
    [Attributes(9)]
    public sealed class C0Bc10Lna1OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5223)]
    [Attributes(9)]
   public sealed class C0Bc10Lna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5226)]
    [Attributes(9)]
   public sealed class C0Bc10Lna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5211)]
    [Attributes(9)]
   public sealed class C0Bc10Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5215)]
    [Attributes(9)]
    public sealed class C0Bc10Lna2OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5225)]
    [Attributes(9)]
   public sealed class C0Bc10Lna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5228)]
    [Attributes(9)]
   public sealed class C0Bc10Lna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5212)]
    [Attributes(9)]
   public sealed class C0Bc10Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5216)]
    [Attributes(9)]
    public sealed class C0Bc10Lna3OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5227)]
    [Attributes(9)]
   public sealed class C0Bc10Lna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5230)]
    [Attributes(9)]
   public sealed class C0Bc10Lna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5213)]
    [Attributes(9)]
   public sealed class C0Bc10Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5217)]
    [Attributes(9)]
    public sealed class C0Bc10Lna4OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5229)]
    [Attributes(9)]
   public sealed class C0Bc10Lna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5235)]
    [Attributes(9)]
    public sealed class C0Bc10LnaSwitchpointsLpm1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5236)]
    [Attributes(9)]
    public sealed class C0Bc10LnaSwitchpointsLpm2 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5443)]
    [Attributes(9)]
   public sealed class C0Bc10LoCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5208)]
    [Attributes(9)]
    public sealed class C0Bc10RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5209)]
    [Attributes(9)]
    public sealed class C0Bc10RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5207)]
    [Attributes(9)]
    public sealed class C0Bc10TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5220)]
    [Attributes(9)]
   public sealed class C0Bc10VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5221)]
    [Attributes(9)]
    public sealed class C0Bc10VgaGainOffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5588)]
    [Attributes(9)]
   public sealed class C0Bc11Im2Cal : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3886)]
    [Attributes(9)]
   public sealed class C0Bc11Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3935)]
    [Attributes(9)]
    public sealed class C0Bc11Im2Lpm1 : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3936)]
    [Attributes(9)]
    public sealed class C0Bc11Im2Lpm2 : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3887)]
    [Attributes(9)]
   public sealed class C0Bc11Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3890)]
    [Attributes(9)]
   public sealed class C0Bc11Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3899)]
    [Attributes(9)]
   public sealed class C0Bc11ImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3900)]
    [Attributes(9)]
   public sealed class C0Bc11ImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3901)]
    [Attributes(9)]
   public sealed class C0Bc11ImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3902)]
    [Attributes(9)]
   public sealed class C0Bc11ImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3937)]
    [Attributes(9)]
    public sealed class C0Bc11IntelliceiverCal : SevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3940)]
    [Attributes(9)]
    public sealed class C0Bc11IntelliceiverDetThresh : TenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3892)]
    [Attributes(9)]
   public sealed class C0Bc11Lna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3882)]
    [Attributes(9)]
   public sealed class C0Bc11Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3878)]
    [Attributes(9)]
    public sealed class C0Bc11Lna1OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3891)]
    [Attributes(9)]
   public sealed class C0Bc11Lna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3894)]
    [Attributes(9)]
   public sealed class C0Bc11Lna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3883)]
    [Attributes(9)]
   public sealed class C0Bc11Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3879)]
    [Attributes(9)]
    public sealed class C0Bc11Lna2OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3893)]
    [Attributes(9)]
   public sealed class C0Bc11Lna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3896)]
    [Attributes(9)]
   public sealed class C0Bc11Lna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3884)]
    [Attributes(9)]
   public sealed class C0Bc11Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3880)]
    [Attributes(9)]
    public sealed class C0Bc11Lna3OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3895)]
    [Attributes(9)]
   public sealed class C0Bc11Lna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3898)]
    [Attributes(9)]
   public sealed class C0Bc11Lna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3885)]
    [Attributes(9)]
   public sealed class C0Bc11Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3881)]
    [Attributes(9)]
    public sealed class C0Bc11Lna4OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3897)]
    [Attributes(9)]
   public sealed class C0Bc11Lna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3938)]
    [Attributes(9)]
    public sealed class C0Bc11LnaSwitchpointsLpm1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3939)]
    [Attributes(9)]
    public sealed class C0Bc11LnaSwitchpointsLpm2 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5444)]
    [Attributes(9)]
   public sealed class C0Bc11LoCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3877)]
    [Attributes(9)]
    public sealed class C0Bc11RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3932)]
    [Attributes(9)]
    public sealed class C0Bc11RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3876)]
    [Attributes(9)]
    public sealed class C0Bc11TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3888)]
    [Attributes(9)]
   public sealed class C0Bc11VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3889)]
    [Attributes(9)]
    public sealed class C0Bc11VgaGainOffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5589)]
    [Attributes(9)]
   public sealed class C0Bc12Im2Cal : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5445)]
    [Attributes(9)]
   public sealed class C0Bc12LoCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5590)]
    [Attributes(9)]
   public sealed class C0Bc13Im2Cal : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5446)]
    [Attributes(9)]
   public sealed class C0Bc13LoCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5591)]
    [Attributes(9)]
   public sealed class C0Bc14Im2Cal : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3572)]
    [Attributes(9)]
   public sealed class C0Bc14Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3621)]
    [Attributes(9)]
    public sealed class C0Bc14Im2Lpm1 : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3622)]
    [Attributes(9)]
    public sealed class C0Bc14Im2Lpm2 : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3573)]
    [Attributes(9)]
   public sealed class C0Bc14Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3576)]
    [Attributes(9)]
   public sealed class C0Bc14Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3585)]
    [Attributes(9)]
   public sealed class C0Bc14ImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3586)]
    [Attributes(9)]
   public sealed class C0Bc14ImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3587)]
    [Attributes(9)]
   public sealed class C0Bc14ImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3588)]
    [Attributes(9)]
   public sealed class C0Bc14ImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3623)]
    [Attributes(9)]
    public sealed class C0Bc14IntelliceiverCal : SevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3624)]
    [Attributes(9)]
    public sealed class C0Bc14IntelliceiverDetThresh : TenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3578)]
    [Attributes(9)]
   public sealed class C0Bc14Lna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3564)]
    [Attributes(9)]
   public sealed class C0Bc14Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3568)]
    [Attributes(9)]
    public sealed class C0Bc14Lna1OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3577)]
    [Attributes(9)]
   public sealed class C0Bc14Lna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3580)]
    [Attributes(9)]
   public sealed class C0Bc14Lna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3565)]
    [Attributes(9)]
   public sealed class C0Bc14Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3569)]
    [Attributes(9)]
    public sealed class C0Bc14Lna2OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3579)]
    [Attributes(9)]
   public sealed class C0Bc14Lna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3582)]
    [Attributes(9)]
   public sealed class C0Bc14Lna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3566)]
    [Attributes(9)]
   public sealed class C0Bc14Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3570)]
    [Attributes(9)]
    public sealed class C0Bc14Lna3OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3581)]
    [Attributes(9)]
   public sealed class C0Bc14Lna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3584)]
    [Attributes(9)]
   public sealed class C0Bc14Lna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3567)]
    [Attributes(9)]
   public sealed class C0Bc14Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3571)]
    [Attributes(9)]
    public sealed class C0Bc14Lna4OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3583)]
    [Attributes(9)]
   public sealed class C0Bc14Lna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3619)]
    [Attributes(9)]
    public sealed class C0Bc14LnaSwitchpointsLpm1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3620)]
    [Attributes(9)]
    public sealed class C0Bc14LnaSwitchpointsLpm2 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5447)]
    [Attributes(9)]
   public sealed class C0Bc14LoCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3562)]
    [Attributes(9)]
    public sealed class C0Bc14RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3563)]
    [Attributes(9)]
    public sealed class C0Bc14RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3561)]
    [Attributes(9)]
    public sealed class C0Bc14TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3574)]
    [Attributes(9)]
   public sealed class C0Bc14VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3575)]
    [Attributes(9)]
    public sealed class C0Bc14VgaGainOffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5592)]
    [Attributes(9)]
   public sealed class C0Bc15Im2Cal : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4304)]
    [Attributes(9)]
   public sealed class C0Bc15Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4353)]
    [Attributes(9)]
    public sealed class C0Bc15Im2Lpm1 : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4354)]
    [Attributes(9)]
    public sealed class C0Bc15Im2Lpm2 : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4305)]
    [Attributes(9)]
   public sealed class C0Bc15Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4308)]
    [Attributes(9)]
   public sealed class C0Bc15Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4317)]
    [Attributes(9)]
   public sealed class C0Bc15ImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4318)]
    [Attributes(9)]
   public sealed class C0Bc15ImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4319)]
    [Attributes(9)]
   public sealed class C0Bc15ImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4320)]
    [Attributes(9)]
   public sealed class C0Bc15ImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4355)]
    [Attributes(9)]
    public sealed class C0Bc15IntelliceiverCal : SevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4356)]
    [Attributes(9)]
    public sealed class C0Bc15IntelliceiverDetThresh : TenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4310)]
    [Attributes(9)]
   public sealed class C0Bc15Lna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4296)]
    [Attributes(9)]
   public sealed class C0Bc15Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4300)]
    [Attributes(9)]
    public sealed class C0Bc15Lna1OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4309)]
    [Attributes(9)]
   public sealed class C0Bc15Lna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4312)]
    [Attributes(9)]
   public sealed class C0Bc15Lna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4297)]
    [Attributes(9)]
   public sealed class C0Bc15Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4301)]
    [Attributes(9)]
    public sealed class C0Bc15Lna2OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4311)]
    [Attributes(9)]
   public sealed class C0Bc15Lna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4314)]
    [Attributes(9)]
   public sealed class C0Bc15Lna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4298)]
    [Attributes(9)]
   public sealed class C0Bc15Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4302)]
    [Attributes(9)]
    public sealed class C0Bc15Lna3OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4313)]
    [Attributes(9)]
   public sealed class C0Bc15Lna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4316)]
    [Attributes(9)]
   public sealed class C0Bc15Lna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4299)]
    [Attributes(9)]
   public sealed class C0Bc15Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4303)]
    [Attributes(9)]
    public sealed class C0Bc15Lna4OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4315)]
    [Attributes(9)]
   public sealed class C0Bc15Lna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4351)]
    [Attributes(9)]
    public sealed class C0Bc15LnaSwitchpointsLpm1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4352)]
    [Attributes(9)]
    public sealed class C0Bc15LnaSwitchpointsLpm2 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5448)]
    [Attributes(9)]
   public sealed class C0Bc15LoCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4294)]
    [Attributes(9)]
    public sealed class C0Bc15RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4295)]
    [Attributes(9)]
    public sealed class C0Bc15RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4293)]
    [Attributes(9)]
    public sealed class C0Bc15TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4306)]
    [Attributes(9)]
   public sealed class C0Bc15VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4307)]
    [Attributes(9)]
    public sealed class C0Bc15VgaGainOffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5578)]
    [Attributes(9)]
   public sealed class C0Bc1Im2Cal : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1668)]
    [Attributes(9)]
   public sealed class C0Bc1Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3254)]
    [Attributes(9)]
    public sealed class C0Bc1Im2Lpm1 : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3260)]
    [Attributes(9)]
    public sealed class C0Bc1Im2Lpm2 : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1669)]
    [Attributes(9)]
   public sealed class C0Bc1Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1672)]
    [Attributes(9)]
   public sealed class C0Bc1Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1681)]
    [Attributes(9)]
   public sealed class C0Bc1ImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1682)]
    [Attributes(9)]
   public sealed class C0Bc1ImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1683)]
    [Attributes(9)]
   public sealed class C0Bc1ImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1684)]
    [Attributes(9)]
   public sealed class C0Bc1ImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3266)]
    [Attributes(9)]
    public sealed class C0Bc1IntelliceiverCal : SevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3470)]
    [Attributes(9)]
    public sealed class C0Bc1IntelliceiverDetThresh : TenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1674)]
    [Attributes(9)]
   public sealed class C0Bc1Lna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1654)]
    [Attributes(9)]
   public sealed class C0Bc1Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1650)]
    [Attributes(9)]
    public sealed class C0Bc1Lna1OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1673)]
    [Attributes(9)]
   public sealed class C0Bc1Lna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1676)]
    [Attributes(9)]
   public sealed class C0Bc1Lna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1655)]
    [Attributes(9)]
   public sealed class C0Bc1Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1651)]
    [Attributes(9)]
    public sealed class C0Bc1Lna2OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1675)]
    [Attributes(9)]
   public sealed class C0Bc1Lna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1678)]
    [Attributes(9)]
   public sealed class C0Bc1Lna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1666)]
    [Attributes(9)]
   public sealed class C0Bc1Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1652)]
    [Attributes(9)]
    public sealed class C0Bc1Lna3OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1677)]
    [Attributes(9)]
   public sealed class C0Bc1Lna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1680)]
    [Attributes(9)]
   public sealed class C0Bc1Lna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1667)]
    [Attributes(9)]
   public sealed class C0Bc1Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1653)]
    [Attributes(9)]
    public sealed class C0Bc1Lna4OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1679)]
    [Attributes(9)]
   public sealed class C0Bc1Lna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3272)]
    [Attributes(9)]
    public sealed class C0Bc1LnaSwitchpointsLpm1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3278)]
    [Attributes(9)]
    public sealed class C0Bc1LnaSwitchpointsLpm2 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5434)]
    [Attributes(9)]
   public sealed class C0Bc1LoCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1649)]
    [Attributes(9)]
    public sealed class C0Bc1RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2793)]
    [Attributes(9)]
    public sealed class C0Bc1RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1648)]
    [Attributes(9)]
    public sealed class C0Bc1TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1670)]
    [Attributes(9)]
   public sealed class C0Bc1VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1671)]
    [Attributes(9)]
    public sealed class C0Bc1VgaGainOffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5579)]
    [Attributes(9)]
   public sealed class C0Bc2Im2Cal : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5435)]
    [Attributes(9)]
   public sealed class C0Bc2LoCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5580)]
    [Attributes(9)]
   public sealed class C0Bc3Im2Cal : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1580)]
    [Attributes(9)]
   public sealed class C0Bc3Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3255)]
    [Attributes(9)]
    public sealed class C0Bc3Im2Lpm1 : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3261)]
    [Attributes(9)]
    public sealed class C0Bc3Im2Lpm2 : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1581)]
    [Attributes(9)]
   public sealed class C0Bc3Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1584)]
    [Attributes(9)]
   public sealed class C0Bc3Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1593)]
    [Attributes(9)]
   public sealed class C0Bc3ImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1594)]
    [Attributes(9)]
   public sealed class C0Bc3ImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1595)]
    [Attributes(9)]
   public sealed class C0Bc3ImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1596)]
    [Attributes(9)]
   public sealed class C0Bc3ImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3267)]
    [Attributes(9)]
    public sealed class C0Bc3IntelliceiverCal : SevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3471)]
    [Attributes(9)]
    public sealed class C0Bc3IntelliceiverDetThresh : TenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1586)]
    [Attributes(9)]
   public sealed class C0Bc3Lna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1576)]
    [Attributes(9)]
   public sealed class C0Bc3Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1572)]
    [Attributes(9)]
    public sealed class C0Bc3Lna1OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1585)]
    [Attributes(9)]
   public sealed class C0Bc3Lna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1588)]
    [Attributes(9)]
   public sealed class C0Bc3Lna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1577)]
    [Attributes(9)]
   public sealed class C0Bc3Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1573)]
    [Attributes(9)]
    public sealed class C0Bc3Lna2OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1587)]
    [Attributes(9)]
   public sealed class C0Bc3Lna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1590)]
    [Attributes(9)]
   public sealed class C0Bc3Lna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1578)]
    [Attributes(9)]
   public sealed class C0Bc3Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1574)]
    [Attributes(9)]
    public sealed class C0Bc3Lna3OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1589)]
    [Attributes(9)]
   public sealed class C0Bc3Lna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1592)]
    [Attributes(9)]
   public sealed class C0Bc3Lna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1579)]
    [Attributes(9)]
   public sealed class C0Bc3Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1575)]
    [Attributes(9)]
    public sealed class C0Bc3Lna4OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1591)]
    [Attributes(9)]
   public sealed class C0Bc3Lna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3273)]
    [Attributes(9)]
    public sealed class C0Bc3LnaSwitchpointsLpm1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3279)]
    [Attributes(9)]
    public sealed class C0Bc3LnaSwitchpointsLpm2 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5436)]
    [Attributes(9)]
   public sealed class C0Bc3LoCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1571)]
    [Attributes(9)]
    public sealed class C0Bc3RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2795)]
    [Attributes(9)]
    public sealed class C0Bc3RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1570)]
    [Attributes(9)]
    public sealed class C0Bc3TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1582)]
    [Attributes(9)]
   public sealed class C0Bc3VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1583)]
    [Attributes(9)]
    public sealed class C0Bc3VgaGainOffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5581)]
    [Attributes(9)]
   public sealed class C0Bc4Im2Cal : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1501)]
    [Attributes(9)]
   public sealed class C0Bc4Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3256)]
    [Attributes(9)]
    public sealed class C0Bc4Im2Lpm1 : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3262)]
    [Attributes(9)]
    public sealed class C0Bc4Im2Lpm2 : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1502)]
    [Attributes(9)]
   public sealed class C0Bc4Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1505)]
    [Attributes(9)]
   public sealed class C0Bc4Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1514)]
    [Attributes(9)]
   public sealed class C0Bc4ImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1515)]
    [Attributes(9)]
   public sealed class C0Bc4ImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1516)]
    [Attributes(9)]
   public sealed class C0Bc4ImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1517)]
    [Attributes(9)]
   public sealed class C0Bc4ImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3268)]
    [Attributes(9)]
    public sealed class C0Bc4IntelliceiverCal : SevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3472)]
    [Attributes(9)]
    public sealed class C0Bc4IntelliceiverDetThresh : TenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1507)]
    [Attributes(9)]
   public sealed class C0Bc4Lna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1497)]
    [Attributes(9)]
   public sealed class C0Bc4Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1506)]
    [Attributes(9)]
   public sealed class C0Bc4Lna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1509)]
    [Attributes(9)]
   public sealed class C0Bc4Lna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1498)]
    [Attributes(9)]
   public sealed class C0Bc4Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1494)]
    [Attributes(9)]
    public sealed class C0Bc4Lna2OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1508)]
    [Attributes(9)]
   public sealed class C0Bc4Lna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1511)]
    [Attributes(9)]
   public sealed class C0Bc4Lna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1499)]
    [Attributes(9)]
   public sealed class C0Bc4Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1495)]
    [Attributes(9)]
    public sealed class C0Bc4Lna3OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1510)]
    [Attributes(9)]
   public sealed class C0Bc4Lna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1513)]
    [Attributes(9)]
   public sealed class C0Bc4Lna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1500)]
    [Attributes(9)]
   public sealed class C0Bc4Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1496)]
    [Attributes(9)]
    public sealed class C0Bc4Lna4OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1512)]
    [Attributes(9)]
   public sealed class C0Bc4Lna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3274)]
    [Attributes(9)]
    public sealed class C0Bc4LnaSwitchpointsLpm1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3280)]
    [Attributes(9)]
    public sealed class C0Bc4LnaSwitchpointsLpm2 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5437)]
    [Attributes(9)]
   public sealed class C0Bc4LoCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1492)]
    [Attributes(9)]
    public sealed class C0Bc4RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2797)]
    [Attributes(9)]
    public sealed class C0Bc4RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1491)]
    [Attributes(9)]
    public sealed class C0Bc4TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1503)]
    [Attributes(9)]
   public sealed class C0Bc4VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1504)]
    [Attributes(9)]
    public sealed class C0Bc4VgaGainOffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1493)]
    [Attributes(9)]
    public sealed class C0Bc4VsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5582)]
    [Attributes(9)]
   public sealed class C0Bc5Im2Cal : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1423)]
    [Attributes(9)]
   public sealed class C0Bc5Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3257)]
    [Attributes(9)]
    public sealed class C0Bc5Im2Lpm1 : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3263)]
    [Attributes(9)]
    public sealed class C0Bc5Im2Lpm2 : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1424)]
    [Attributes(9)]
   public sealed class C0Bc5Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1427)]
    [Attributes(9)]
   public sealed class C0Bc5Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1436)]
    [Attributes(9)]
   public sealed class C0Bc5ImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1437)]
    [Attributes(9)]
   public sealed class C0Bc5ImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1438)]
    [Attributes(9)]
   public sealed class C0Bc5ImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1439)]
    [Attributes(9)]
   public sealed class C0Bc5ImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3269)]
    [Attributes(9)]
    public sealed class C0Bc5IntelliceiverCal : SevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3473)]
    [Attributes(9)]
    public sealed class C0Bc5IntelliceiverDetThresh : TenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1429)]
    [Attributes(9)]
   public sealed class C0Bc5Lna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1419)]
    [Attributes(9)]
   public sealed class C0Bc5Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1415)]
    [Attributes(9)]
    public sealed class C0Bc5Lna1OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1428)]
    [Attributes(9)]
   public sealed class C0Bc5Lna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1431)]
    [Attributes(9)]
   public sealed class C0Bc5Lna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1420)]
    [Attributes(9)]
   public sealed class C0Bc5Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1416)]
    [Attributes(9)]
    public sealed class C0Bc5Lna2OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1430)]
    [Attributes(9)]
   public sealed class C0Bc5Lna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1433)]
    [Attributes(9)]
   public sealed class C0Bc5Lna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1421)]
    [Attributes(9)]
   public sealed class C0Bc5Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1417)]
    [Attributes(9)]
    public sealed class C0Bc5Lna3OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1432)]
    [Attributes(9)]
   public sealed class C0Bc5Lna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1435)]
    [Attributes(9)]
   public sealed class C0Bc5Lna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1422)]
    [Attributes(9)]
   public sealed class C0Bc5Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1418)]
    [Attributes(9)]
    public sealed class C0Bc5Lna4OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1434)]
    [Attributes(9)]
   public sealed class C0Bc5Lna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3275)]
    [Attributes(9)]
    public sealed class C0Bc5LnaSwitchpointsLpm1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3281)]
    [Attributes(9)]
    public sealed class C0Bc5LnaSwitchpointsLpm2 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5438)]
    [Attributes(9)]
   public sealed class C0Bc5LoCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1414)]
    [Attributes(9)]
    public sealed class C0Bc5RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2799)]
    [Attributes(9)]
    public sealed class C0Bc5RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1413)]
    [Attributes(9)]
    public sealed class C0Bc5TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1425)]
    [Attributes(9)]
   public sealed class C0Bc5VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1426)]
    [Attributes(9)]
    public sealed class C0Bc5VgaGainOffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1266)]
    [Attributes(9)]
   public sealed class C0Bc6DigitalMisCompAOffset : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(1268)]
    [Attributes(9)]
   public sealed class C0Bc6DigitalMisCompBOffset : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5583)]
    [Attributes(9)]
   public sealed class C0Bc6Im2Cal : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1251)]
    [Attributes(9)]
   public sealed class C0Bc6Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3258)]
    [Attributes(9)]
    public sealed class C0Bc6Im2Lpm1 : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3264)]
    [Attributes(9)]
    public sealed class C0Bc6Im2Lpm2 : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1253)]
    [Attributes(9)]
   public sealed class C0Bc6Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1270)]
    [Attributes(9)]
   public sealed class C0Bc6Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1230)]
    [Attributes(9)]
   public sealed class C0Bc6ImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1231)]
    [Attributes(9)]
   public sealed class C0Bc6ImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1232)]
    [Attributes(9)]
   public sealed class C0Bc6ImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1233)]
    [Attributes(9)]
   public sealed class C0Bc6ImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3270)]
    [Attributes(9)]
    public sealed class C0Bc6IntelliceiverCal : SevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3474)]
    [Attributes(9)]
    public sealed class C0Bc6IntelliceiverDetThresh : TenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1364)]
    [Attributes(9)]
   public sealed class C0Bc6Lna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1360)]
    [Attributes(9)]
   public sealed class C0Bc6Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1234)]
    [Attributes(9)]
    public sealed class C0Bc6Lna1OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1363)]
    [Attributes(9)]
   public sealed class C0Bc6Lna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1366)]
    [Attributes(9)]
   public sealed class C0Bc6Lna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1361)]
    [Attributes(9)]
   public sealed class C0Bc6Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1359)]
    [Attributes(9)]
    public sealed class C0Bc6Lna2OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1365)]
    [Attributes(9)]
   public sealed class C0Bc6Lna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1368)]
    [Attributes(9)]
   public sealed class C0Bc6Lna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1362)]
    [Attributes(9)]
   public sealed class C0Bc6Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1245)]
    [Attributes(9)]
    public sealed class C0Bc6Lna3OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1367)]
    [Attributes(9)]
   public sealed class C0Bc6Lna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1370)]
    [Attributes(9)]
   public sealed class C0Bc6Lna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1249)]
    [Attributes(9)]
   public sealed class C0Bc6Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1262)]
    [Attributes(9)]
    public sealed class C0Bc6Lna4OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1369)]
    [Attributes(9)]
   public sealed class C0Bc6Lna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1225)]
    [Attributes(9)]
   public sealed class C0Bc6LnaRangeOffset : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3276)]
    [Attributes(9)]
    public sealed class C0Bc6LnaSwitchpointsLpm1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3282)]
    [Attributes(9)]
    public sealed class C0Bc6LnaSwitchpointsLpm2 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5439)]
    [Attributes(9)]
   public sealed class C0Bc6LoCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1264)]
    [Attributes(9)]
    public sealed class C0Bc6P1RiseFallOffset : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1211)]
    [Attributes(9)]
    public sealed class C0Bc6RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2801)]
    [Attributes(9)]
    public sealed class C0Bc6RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1306)]
    [Attributes(9)]
    public sealed class C0Bc6TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1255)]
    [Attributes(9)]
   public sealed class C0Bc6VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1257)]
    [Attributes(9)]
    public sealed class C0Bc6VgaGainOffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1259)]
    [Attributes(9)]
    public sealed class C0Bc6VgaGainOffsetVsTemp : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5584)]
    [Attributes(9)]
   public sealed class C0Bc7Im2Cal : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5440)]
    [Attributes(9)]
   public sealed class C0Bc7LoCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5585)]
    [Attributes(9)]
   public sealed class C0Bc8Im2Cal : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5441)]
    [Attributes(9)]
   public sealed class C0Bc8LoCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5586)]
    [Attributes(9)]
   public sealed class C0Bc9Im2Cal : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5442)]
    [Attributes(9)]
   public sealed class C0Bc9LoCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6204)]
    [Attributes(9)]
   public sealed class C0BcxBlock1Im2Cal : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6088)]
    [Attributes(9)]
   public sealed class C0BcxBlock1Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6179)]
    [Attributes(9)]
    public sealed class C0BcxBlock1Im2Lpm1 : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6180)]
    [Attributes(9)]
    public sealed class C0BcxBlock1Im2Lpm2 : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6089)]
    [Attributes(9)]
   public sealed class C0BcxBlock1Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6092)]
    [Attributes(9)]
   public sealed class C0BcxBlock1Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6101)]
    [Attributes(9)]
   public sealed class C0BcxBlock1ImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6102)]
    [Attributes(9)]
   public sealed class C0BcxBlock1ImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6103)]
    [Attributes(9)]
   public sealed class C0BcxBlock1ImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6104)]
    [Attributes(9)]
   public sealed class C0BcxBlock1ImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6181)]
    [Attributes(9)]
    public sealed class C0BcxBlock1IntelliceiverCal : SevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6185)]
    [Attributes(9)]
    public sealed class C0BcxBlock1IntelliceiverDetThresh : TenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6094)]
    [Attributes(9)]
   public sealed class C0BcxBlock1Lna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6084)]
    [Attributes(9)]
   public sealed class C0BcxBlock1Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6080)]
    [Attributes(9)]
    public sealed class C0BcxBlock1Lna1OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6093)]
    [Attributes(9)]
   public sealed class C0BcxBlock1Lna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6096)]
    [Attributes(9)]
   public sealed class C0BcxBlock1Lna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6085)]
    [Attributes(9)]
   public sealed class C0BcxBlock1Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6081)]
    [Attributes(9)]
    public sealed class C0BcxBlock1Lna2OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6095)]
    [Attributes(9)]
   public sealed class C0BcxBlock1Lna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6098)]
    [Attributes(9)]
   public sealed class C0BcxBlock1Lna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6086)]
    [Attributes(9)]
   public sealed class C0BcxBlock1Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6082)]
    [Attributes(9)]
    public sealed class C0BcxBlock1Lna3OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6097)]
    [Attributes(9)]
   public sealed class C0BcxBlock1Lna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6100)]
    [Attributes(9)]
   public sealed class C0BcxBlock1Lna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6087)]
    [Attributes(9)]
   public sealed class C0BcxBlock1Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6083)]
    [Attributes(9)]
    public sealed class C0BcxBlock1Lna4OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6099)]
    [Attributes(9)]
   public sealed class C0BcxBlock1Lna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6182)]
    [Attributes(9)]
    public sealed class C0BcxBlock1LnaSwitchpointsLpm1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6183)]
    [Attributes(9)]
    public sealed class C0BcxBlock1LnaSwitchpointsLpm2 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6203)]
    [Attributes(9)]
   public sealed class C0BcxBlock1LoCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6079)]
    [Attributes(9)]
    public sealed class C0BcxBlock1RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6174)]
    [Attributes(9)]
    public sealed class C0BcxBlock1RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6078)]
    [Attributes(9)]
    public sealed class C0BcxBlock1TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6090)]
    [Attributes(9)]
   public sealed class C0BcxBlock1VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6091)]
    [Attributes(9)]
    public sealed class C0BcxBlock1VgaGainOffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6168)]
    [Attributes(9)]
   public sealed class C0BcxBlockIm2Cal : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4583)]
    [Attributes(9)]
   public sealed class C0BcxBlockIm2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6143)]
    [Attributes(9)]
    public sealed class C0BcxBlockIm2Lpm1 : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6144)]
    [Attributes(9)]
    public sealed class C0BcxBlockIm2Lpm2 : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4584)]
    [Attributes(9)]
   public sealed class C0BcxBlockIm2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4587)]
    [Attributes(9)]
   public sealed class C0BcxBlockIm2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4596)]
    [Attributes(9)]
   public sealed class C0BcxBlockImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4597)]
    [Attributes(9)]
   public sealed class C0BcxBlockImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4598)]
    [Attributes(9)]
   public sealed class C0BcxBlockImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4599)]
    [Attributes(9)]
   public sealed class C0BcxBlockImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6145)]
    [Attributes(9)]
    public sealed class C0BcxBlockIntelliceiverCal : SevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6149)]
    [Attributes(9)]
    public sealed class C0BcxBlockIntelliceiverDetThresh : TenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4589)]
    [Attributes(9)]
   public sealed class C0BcxBlockLna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4579)]
    [Attributes(9)]
   public sealed class C0BcxBlockLna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4575)]
    [Attributes(9)]
    public sealed class C0BcxBlockLna1OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4588)]
    [Attributes(9)]
   public sealed class C0BcxBlockLna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4591)]
    [Attributes(9)]
   public sealed class C0BcxBlockLna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4580)]
    [Attributes(9)]
   public sealed class C0BcxBlockLna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4576)]
    [Attributes(9)]
    public sealed class C0BcxBlockLna2OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4590)]
    [Attributes(9)]
   public sealed class C0BcxBlockLna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4593)]
    [Attributes(9)]
   public sealed class C0BcxBlockLna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4581)]
    [Attributes(9)]
   public sealed class C0BcxBlockLna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4577)]
    [Attributes(9)]
    public sealed class C0BcxBlockLna3OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4592)]
    [Attributes(9)]
   public sealed class C0BcxBlockLna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4595)]
    [Attributes(9)]
   public sealed class C0BcxBlockLna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4582)]
    [Attributes(9)]
   public sealed class C0BcxBlockLna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4578)]
    [Attributes(9)]
    public sealed class C0BcxBlockLna4OffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4594)]
    [Attributes(9)]
   public sealed class C0BcxBlockLna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6146)]
    [Attributes(9)]
    public sealed class C0BcxBlockLnaSwitchpointsLpm1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6147)]
    [Attributes(9)]
    public sealed class C0BcxBlockLnaSwitchpointsLpm2 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6167)]
    [Attributes(9)]
   public sealed class C0BcxBlockLoCal : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4574)]
    [Attributes(9)]
    public sealed class C0BcxBlockRxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6138)]
    [Attributes(9)]
    public sealed class C0BcxBlockRxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4573)]
    [Attributes(9)]
    public sealed class C0BcxBlockTxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4585)]
    [Attributes(9)]
   public sealed class C0BcxBlockVgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4586)]
    [Attributes(9)]
    public sealed class C0BcxBlockVgaGainOffsetVsFreq : FortyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(972)]
    [Attributes(9)]
   public sealed class C0GrpDelayAdj : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(970)]
    [Attributes(9)]
   public sealed class C0RxAgcVrefVal : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1774)]
    [Attributes(9)]
   public sealed class C1Bc0Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1775)]
    [Attributes(9)]
   public sealed class C1Bc0Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1778)]
    [Attributes(9)]
   public sealed class C1Bc0Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1787)]
    [Attributes(9)]
   public sealed class C1Bc0ImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1788)]
    [Attributes(9)]
   public sealed class C1Bc0ImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1789)]
    [Attributes(9)]
   public sealed class C1Bc0ImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1790)]
    [Attributes(9)]
   public sealed class C1Bc0ImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1780)]
    [Attributes(9)]
   public sealed class C1Bc0Lna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1770)]
    [Attributes(9)]
   public sealed class C1Bc0Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1766)]
    [Attributes(9)]
    public sealed class C1Bc0Lna1OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1779)]
    [Attributes(9)]
   public sealed class C1Bc0Lna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1782)]
    [Attributes(9)]
   public sealed class C1Bc0Lna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1771)]
    [Attributes(9)]
   public sealed class C1Bc0Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1767)]
    [Attributes(9)]
    public sealed class C1Bc0Lna2OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1781)]
    [Attributes(9)]
   public sealed class C1Bc0Lna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1784)]
    [Attributes(9)]
   public sealed class C1Bc0Lna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1772)]
    [Attributes(9)]
   public sealed class C1Bc0Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1768)]
    [Attributes(9)]
    public sealed class C1Bc0Lna3OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1783)]
    [Attributes(9)]
   public sealed class C1Bc0Lna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1786)]
    [Attributes(9)]
   public sealed class C1Bc0Lna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1773)]
    [Attributes(9)]
   public sealed class C1Bc0Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1769)]
    [Attributes(9)]
    public sealed class C1Bc0Lna4OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1785)]
    [Attributes(9)]
   public sealed class C1Bc0Lna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1765)]
    [Attributes(9)]
    public sealed class C1Bc0RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2792)]
    [Attributes(9)]
    public sealed class C1Bc0RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1764)]
    [Attributes(9)]
    public sealed class C1Bc0TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1898)]
    [Attributes(9)]
    public sealed class C1Bc0VcoCoarseTuneTable : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1776)]
    [Attributes(9)]
   public sealed class C1Bc0VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1777)]
    [Attributes(9)]
    public sealed class C1Bc0VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5252)]
    [Attributes(9)]
   public sealed class C1Bc10Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5253)]
    [Attributes(9)]
   public sealed class C1Bc10Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5256)]
    [Attributes(9)]
   public sealed class C1Bc10Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5265)]
    [Attributes(9)]
   public sealed class C1Bc10ImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5266)]
    [Attributes(9)]
   public sealed class C1Bc10ImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5267)]
    [Attributes(9)]
   public sealed class C1Bc10ImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5268)]
    [Attributes(9)]
   public sealed class C1Bc10ImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5258)]
    [Attributes(9)]
   public sealed class C1Bc10Lna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5248)]
    [Attributes(9)]
   public sealed class C1Bc10Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5244)]
    [Attributes(9)]
    public sealed class C1Bc10Lna1OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5257)]
    [Attributes(9)]
   public sealed class C1Bc10Lna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5260)]
    [Attributes(9)]
   public sealed class C1Bc10Lna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5249)]
    [Attributes(9)]
   public sealed class C1Bc10Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5245)]
    [Attributes(9)]
    public sealed class C1Bc10Lna2OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5259)]
    [Attributes(9)]
   public sealed class C1Bc10Lna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5262)]
    [Attributes(9)]
   public sealed class C1Bc10Lna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5250)]
    [Attributes(9)]
   public sealed class C1Bc10Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5246)]
    [Attributes(9)]
    public sealed class C1Bc10Lna3OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5261)]
    [Attributes(9)]
   public sealed class C1Bc10Lna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5264)]
    [Attributes(9)]
   public sealed class C1Bc10Lna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5251)]
    [Attributes(9)]
   public sealed class C1Bc10Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5247)]
    [Attributes(9)]
    public sealed class C1Bc10Lna4OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5263)]
    [Attributes(9)]
   public sealed class C1Bc10Lna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5242)]
    [Attributes(9)]
    public sealed class C1Bc10RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5243)]
    [Attributes(9)]
    public sealed class C1Bc10RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5241)]
    [Attributes(9)]
    public sealed class C1Bc10TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5269)]
    [Attributes(9)]
    public sealed class C1Bc10VcoCoarseTuneTable : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5254)]
    [Attributes(9)]
   public sealed class C1Bc10VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5255)]
    [Attributes(9)]
    public sealed class C1Bc10VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3913)]
    [Attributes(9)]
   public sealed class C1Bc11Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3914)]
    [Attributes(9)]
   public sealed class C1Bc11Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3917)]
    [Attributes(9)]
   public sealed class C1Bc11Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3926)]
    [Attributes(9)]
   public sealed class C1Bc11ImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3927)]
    [Attributes(9)]
   public sealed class C1Bc11ImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3928)]
    [Attributes(9)]
   public sealed class C1Bc11ImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3929)]
    [Attributes(9)]
   public sealed class C1Bc11ImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3919)]
    [Attributes(9)]
   public sealed class C1Bc11Lna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3909)]
    [Attributes(9)]
   public sealed class C1Bc11Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3905)]
    [Attributes(9)]
    public sealed class C1Bc11Lna1OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3918)]
    [Attributes(9)]
   public sealed class C1Bc11Lna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3921)]
    [Attributes(9)]
   public sealed class C1Bc11Lna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3910)]
    [Attributes(9)]
   public sealed class C1Bc11Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3906)]
    [Attributes(9)]
    public sealed class C1Bc11Lna2OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3920)]
    [Attributes(9)]
   public sealed class C1Bc11Lna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3923)]
    [Attributes(9)]
   public sealed class C1Bc11Lna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3911)]
    [Attributes(9)]
   public sealed class C1Bc11Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3907)]
    [Attributes(9)]
    public sealed class C1Bc11Lna3OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3922)]
    [Attributes(9)]
   public sealed class C1Bc11Lna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3925)]
    [Attributes(9)]
   public sealed class C1Bc11Lna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3912)]
    [Attributes(9)]
   public sealed class C1Bc11Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3908)]
    [Attributes(9)]
    public sealed class C1Bc11Lna4OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3924)]
    [Attributes(9)]
   public sealed class C1Bc11Lna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3904)]
    [Attributes(9)]
    public sealed class C1Bc11RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3933)]
    [Attributes(9)]
    public sealed class C1Bc11RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3903)]
    [Attributes(9)]
    public sealed class C1Bc11TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3942)]
    [Attributes(9)]
    public sealed class C1Bc11VcoCoarseTuneTable : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3915)]
    [Attributes(9)]
   public sealed class C1Bc11VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3916)]
    [Attributes(9)]
    public sealed class C1Bc11VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3599)]
    [Attributes(9)]
   public sealed class C1Bc14Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3600)]
    [Attributes(9)]
   public sealed class C1Bc14Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3603)]
    [Attributes(9)]
   public sealed class C1Bc14Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3612)]
    [Attributes(9)]
   public sealed class C1Bc14ImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3613)]
    [Attributes(9)]
   public sealed class C1Bc14ImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3614)]
    [Attributes(9)]
   public sealed class C1Bc14ImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3615)]
    [Attributes(9)]
   public sealed class C1Bc14ImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3605)]
    [Attributes(9)]
   public sealed class C1Bc14Lna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3595)]
    [Attributes(9)]
   public sealed class C1Bc14Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3591)]
    [Attributes(9)]
    public sealed class C1Bc14Lna1OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3604)]
    [Attributes(9)]
   public sealed class C1Bc14Lna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3607)]
    [Attributes(9)]
   public sealed class C1Bc14Lna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3596)]
    [Attributes(9)]
   public sealed class C1Bc14Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3592)]
    [Attributes(9)]
    public sealed class C1Bc14Lna2OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3606)]
    [Attributes(9)]
   public sealed class C1Bc14Lna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3609)]
    [Attributes(9)]
   public sealed class C1Bc14Lna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3597)]
    [Attributes(9)]
   public sealed class C1Bc14Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3593)]
    [Attributes(9)]
    public sealed class C1Bc14Lna3OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3608)]
    [Attributes(9)]
   public sealed class C1Bc14Lna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3611)]
    [Attributes(9)]
   public sealed class C1Bc14Lna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3598)]
    [Attributes(9)]
   public sealed class C1Bc14Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3594)]
    [Attributes(9)]
    public sealed class C1Bc14Lna4OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3610)]
    [Attributes(9)]
   public sealed class C1Bc14Lna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3590)]
    [Attributes(9)]
    public sealed class C1Bc14RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3625)]
    [Attributes(9)]
    public sealed class C1Bc14RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3589)]
    [Attributes(9)]
    public sealed class C1Bc14TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3616)]
    [Attributes(9)]
    public sealed class C1Bc14VcoCoarseTuneTable : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3601)]
    [Attributes(9)]
   public sealed class C1Bc14VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3602)]
    [Attributes(9)]
    public sealed class C1Bc14VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4331)]
    [Attributes(9)]
   public sealed class C1Bc15Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4332)]
    [Attributes(9)]
   public sealed class C1Bc15Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4335)]
    [Attributes(9)]
   public sealed class C1Bc15Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4344)]
    [Attributes(9)]
   public sealed class C1Bc15ImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4345)]
    [Attributes(9)]
   public sealed class C1Bc15ImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4346)]
    [Attributes(9)]
   public sealed class C1Bc15ImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4347)]
    [Attributes(9)]
   public sealed class C1Bc15ImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4337)]
    [Attributes(9)]
   public sealed class C1Bc15Lna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4327)]
    [Attributes(9)]
   public sealed class C1Bc15Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4323)]
    [Attributes(9)]
    public sealed class C1Bc15Lna1OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4336)]
    [Attributes(9)]
   public sealed class C1Bc15Lna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4339)]
    [Attributes(9)]
   public sealed class C1Bc15Lna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4328)]
    [Attributes(9)]
   public sealed class C1Bc15Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4324)]
    [Attributes(9)]
   public sealed class C1Bc15Lna2OffsetVsFreq : FourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4338)]
    [Attributes(9)]
   public sealed class C1Bc15Lna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4341)]
    [Attributes(9)]
   public sealed class C1Bc15Lna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4329)]
    [Attributes(9)]
   public sealed class C1Bc15Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4325)]
    [Attributes(9)]
   public sealed class C1Bc15Lna3OffsetVsFreq : FourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4340)]
    [Attributes(9)]
   public sealed class C1Bc15Lna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4343)]
    [Attributes(9)]
   public sealed class C1Bc15Lna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4330)]
    [Attributes(9)]
   public sealed class C1Bc15Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4326)]
    [Attributes(9)]
   public sealed class C1Bc15Lna4OffsetVsFreq : FourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4342)]
    [Attributes(9)]
   public sealed class C1Bc15Lna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4322)]
    [Attributes(9)]
   public sealed class C1Bc15RxCalChan : FourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4357)]
    [Attributes(9)]
   public sealed class C1Bc15RxCalChanLru : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4321)]
    [Attributes(9)]
   public sealed class C1Bc15TxCalChan : FourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4348)]
    [Attributes(9)]
   public sealed class C1Bc15VcoCoarseTuneTable : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4333)]
    [Attributes(9)]
   public sealed class C1Bc15VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4334)]
    [Attributes(9)]
   public sealed class C1Bc15VgaGainOffsetVsFreq : FourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1696)]
    [Attributes(9)]
   public sealed class C1Bc1Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1697)]
    [Attributes(9)]
   public sealed class C1Bc1Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1700)]
    [Attributes(9)]
   public sealed class C1Bc1Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1709)]
    [Attributes(9)]
   public sealed class C1Bc1ImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1710)]
    [Attributes(9)]
   public sealed class C1Bc1ImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1711)]
    [Attributes(9)]
   public sealed class C1Bc1ImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1712)]
    [Attributes(9)]
   public sealed class C1Bc1ImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1702)]
    [Attributes(9)]
   public sealed class C1Bc1Lna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1692)]
    [Attributes(9)]
   public sealed class C1Bc1Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1687)]
    [Attributes(9)]
   public sealed class C1Bc1Lna1OffsetVsFreq : FourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1701)]
    [Attributes(9)]
   public sealed class C1Bc1Lna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1704)]
    [Attributes(9)]
   public sealed class C1Bc1Lna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1693)]
    [Attributes(9)]
   public sealed class C1Bc1Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1689)]
    [Attributes(9)]
   public sealed class C1Bc1Lna2OffsetVsFreq : FourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1703)]
    [Attributes(9)]
   public sealed class C1Bc1Lna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1706)]
    [Attributes(9)]
   public sealed class C1Bc1Lna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1694)]
    [Attributes(9)]
   public sealed class C1Bc1Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1690)]
    [Attributes(9)]
   public sealed class C1Bc1Lna3OffsetVsFreq : FourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1705)]
    [Attributes(9)]
   public sealed class C1Bc1Lna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1708)]
    [Attributes(9)]
   public sealed class C1Bc1Lna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1695)]
    [Attributes(9)]
   public sealed class C1Bc1Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1691)]
    [Attributes(9)]
   public sealed class C1Bc1Lna4OffsetVsFreq : FourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1707)]
    [Attributes(9)]
   public sealed class C1Bc1Lna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1686)]
    [Attributes(9)]
   public sealed class C1Bc1RxCalChan : FourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2794)]
    [Attributes(9)]
   public sealed class C1Bc1RxCalChanLru : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1685)]
    [Attributes(9)]
   public sealed class C1Bc1TxCalChan : FourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1899)]
    [Attributes(9)]
   public sealed class C1Bc1VcoCoarseTuneTable : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1698)]
    [Attributes(9)]
   public sealed class C1Bc1VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1699)]
    [Attributes(9)]
   public sealed class C1Bc1VgaGainOffsetVsFreq : FourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1607)]
    [Attributes(9)]
   public sealed class C1Bc3Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1608)]
    [Attributes(9)]
   public sealed class C1Bc3Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1611)]
    [Attributes(9)]
   public sealed class C1Bc3Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1620)]
    [Attributes(9)]
   public sealed class C1Bc3ImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1621)]
    [Attributes(9)]
   public sealed class C1Bc3ImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1622)]
    [Attributes(9)]
   public sealed class C1Bc3ImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1623)]
    [Attributes(9)]
   public sealed class C1Bc3ImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1613)]
    [Attributes(9)]
   public sealed class C1Bc3Lna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1603)]
    [Attributes(9)]
   public sealed class C1Bc3Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1599)]
    [Attributes(9)]
   public sealed class C1Bc3Lna1OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1612)]
    [Attributes(9)]
   public sealed class C1Bc3Lna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1615)]
    [Attributes(9)]
   public sealed class C1Bc3Lna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1604)]
    [Attributes(9)]
   public sealed class C1Bc3Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1600)]
    [Attributes(9)]
   public sealed class C1Bc3Lna2OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1614)]
    [Attributes(9)]
   public sealed class C1Bc3Lna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1617)]
    [Attributes(9)]
   public sealed class C1Bc3Lna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1605)]
    [Attributes(9)]
   public sealed class C1Bc3Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1601)]
    [Attributes(9)]
   public sealed class C1Bc3Lna3OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1616)]
    [Attributes(9)]
   public sealed class C1Bc3Lna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1619)]
    [Attributes(9)]
   public sealed class C1Bc3Lna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1606)]
    [Attributes(9)]
   public sealed class C1Bc3Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1602)]
    [Attributes(9)]
   public sealed class C1Bc3Lna4OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1618)]
    [Attributes(9)]
   public sealed class C1Bc3Lna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1598)]
    [Attributes(9)]
   public sealed class C1Bc3RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2796)]
    [Attributes(9)]
   public sealed class C1Bc3RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1597)]
    [Attributes(9)]
   public sealed class C1Bc3TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1900)]
    [Attributes(9)]
   public sealed class C1Bc3VcoCoarseTuneTable : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1609)]
    [Attributes(9)]
   public sealed class C1Bc3VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1610)]
    [Attributes(9)]
   public sealed class C1Bc3VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1528)]
    [Attributes(9)]
   public sealed class C1Bc4Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1529)]
    [Attributes(9)]
   public sealed class C1Bc4Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1532)]
    [Attributes(9)]
   public sealed class C1Bc4Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1541)]
    [Attributes(9)]
   public sealed class C1Bc4ImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1542)]
    [Attributes(9)]
   public sealed class C1Bc4ImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1543)]
    [Attributes(9)]
   public sealed class C1Bc4ImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1544)]
    [Attributes(9)]
   public sealed class C1Bc4ImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1534)]
    [Attributes(9)]
   public sealed class C1Bc4Lna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1524)]
    [Attributes(9)]
   public sealed class C1Bc4Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1520)]
    [Attributes(9)]
   public sealed class C1Bc4Lna1OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1533)]
    [Attributes(9)]
   public sealed class C1Bc4Lna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1536)]
    [Attributes(9)]
   public sealed class C1Bc4Lna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1525)]
    [Attributes(9)]
   public sealed class C1Bc4Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1521)]
    [Attributes(9)]
   public sealed class C1Bc4Lna2OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1535)]
    [Attributes(9)]
   public sealed class C1Bc4Lna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1538)]
    [Attributes(9)]
   public sealed class C1Bc4Lna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1526)]
    [Attributes(9)]
   public sealed class C1Bc4Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1522)]
    [Attributes(9)]
   public sealed class C1Bc4Lna3OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1537)]
    [Attributes(9)]
   public sealed class C1Bc4Lna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1540)]
    [Attributes(9)]
   public sealed class C1Bc4Lna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1527)]
    [Attributes(9)]
   public sealed class C1Bc4Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1523)]
    [Attributes(9)]
   public sealed class C1Bc4Lna4OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1539)]
    [Attributes(9)]
   public sealed class C1Bc4Lna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1519)]
    [Attributes(9)]
   public sealed class C1Bc4RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2798)]
    [Attributes(9)]
   public sealed class C1Bc4RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1518)]
    [Attributes(9)]
   public sealed class C1Bc4TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1901)]
    [Attributes(9)]
   public sealed class C1Bc4VcoCoarseTuneTable : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1530)]
    [Attributes(9)]
   public sealed class C1Bc4VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1531)]
    [Attributes(9)]
   public sealed class C1Bc4VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1450)]
    [Attributes(9)]
   public sealed class C1Bc5Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1451)]
    [Attributes(9)]
   public sealed class C1Bc5Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1454)]
    [Attributes(9)]
   public sealed class C1Bc5Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1463)]
    [Attributes(9)]
   public sealed class C1Bc5ImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1464)]
    [Attributes(9)]
   public sealed class C1Bc5ImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1465)]
    [Attributes(9)]
   public sealed class C1Bc5ImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1466)]
    [Attributes(9)]
   public sealed class C1Bc5ImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1456)]
    [Attributes(9)]
   public sealed class C1Bc5Lna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1446)]
    [Attributes(9)]
   public sealed class C1Bc5Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1442)]
    [Attributes(9)]
   public sealed class C1Bc5Lna1OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1455)]
    [Attributes(9)]
   public sealed class C1Bc5Lna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1458)]
    [Attributes(9)]
   public sealed class C1Bc5Lna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1447)]
    [Attributes(9)]
   public sealed class C1Bc5Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1443)]
    [Attributes(9)]
   public sealed class C1Bc5Lna2OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1457)]
    [Attributes(9)]
   public sealed class C1Bc5Lna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1460)]
    [Attributes(9)]
   public sealed class C1Bc5Lna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1448)]
    [Attributes(9)]
   public sealed class C1Bc5Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1444)]
    [Attributes(9)]
   public sealed class C1Bc5Lna3OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1459)]
    [Attributes(9)]
   public sealed class C1Bc5Lna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1462)]
    [Attributes(9)]
   public sealed class C1Bc5Lna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1449)]
    [Attributes(9)]
   public sealed class C1Bc5Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1445)]
    [Attributes(9)]
   public sealed class C1Bc5Lna4OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1461)]
    [Attributes(9)]
   public sealed class C1Bc5Lna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1441)]
    [Attributes(9)]
   public sealed class C1Bc5RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2800)]
    [Attributes(9)]
   public sealed class C1Bc5RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1440)]
    [Attributes(9)]
   public sealed class C1Bc5TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1902)]
    [Attributes(9)]
   public sealed class C1Bc5VcoCoarseTuneTable : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1452)]
    [Attributes(9)]
   public sealed class C1Bc5VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1453)]
    [Attributes(9)]
   public sealed class C1Bc5VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1267)]
    [Attributes(9)]
   public sealed class C1Bc6DigitalMisCompAOffset : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(1269)]
    [Attributes(9)]
   public sealed class C1Bc6DigitalMisCompBOffset : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(1252)]
    [Attributes(9)]
   public sealed class C1Bc6Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1254)]
    [Attributes(9)]
   public sealed class C1Bc6Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1271)]
    [Attributes(9)]
   public sealed class C1Bc6Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1385)]
    [Attributes(9)]
   public sealed class C1Bc6ImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1386)]
    [Attributes(9)]
   public sealed class C1Bc6ImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1387)]
    [Attributes(9)]
   public sealed class C1Bc6ImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1388)]
    [Attributes(9)]
   public sealed class C1Bc6ImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1378)]
    [Attributes(9)]
   public sealed class C1Bc6Lna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1374)]
    [Attributes(9)]
   public sealed class C1Bc6Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1235)]
    [Attributes(9)]
   public sealed class C1Bc6Lna1OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1377)]
    [Attributes(9)]
   public sealed class C1Bc6Lna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1380)]
    [Attributes(9)]
   public sealed class C1Bc6Lna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1375)]
    [Attributes(9)]
   public sealed class C1Bc6Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1373)]
    [Attributes(9)]
   public sealed class C1Bc6Lna2OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1379)]
    [Attributes(9)]
   public sealed class C1Bc6Lna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1382)]
    [Attributes(9)]
   public sealed class C1Bc6Lna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1376)]
    [Attributes(9)]
   public sealed class C1Bc6Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1246)]
    [Attributes(9)]
   public sealed class C1Bc6Lna3OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1381)]
    [Attributes(9)]
   public sealed class C1Bc6Lna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1384)]
    [Attributes(9)]
   public sealed class C1Bc6Lna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1250)]
    [Attributes(9)]
   public sealed class C1Bc6Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1263)]
    [Attributes(9)]
   public sealed class C1Bc6Lna4OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1383)]
    [Attributes(9)]
   public sealed class C1Bc6Lna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1226)]
    [Attributes(9)]
   public sealed class C1Bc6LnaRangeOffset : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1265)]
    [Attributes(9)]
   public sealed class C1Bc6P1RiseFallOffset : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1372)]
    [Attributes(9)]
   public sealed class C1Bc6RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2802)]
    [Attributes(9)]
   public sealed class C1Bc6RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1371)]
    [Attributes(9)]
   public sealed class C1Bc6TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1903)]
    [Attributes(9)]
   public sealed class C1Bc6VcoCoarseTuneTable : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1256)]
    [Attributes(9)]
   public sealed class C1Bc6VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1258)]
    [Attributes(9)]
   public sealed class C1Bc6VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1260)]
    [Attributes(9)]
   public sealed class C1Bc6VgaGainOffsetVsTemp : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6115)]
    [Attributes(9)]
   public sealed class C1BcxBlock1Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6116)]
    [Attributes(9)]
   public sealed class C1BcxBlock1Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6119)]
    [Attributes(9)]
   public sealed class C1BcxBlock1Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6128)]
    [Attributes(9)]
   public sealed class C1BcxBlock1ImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6129)]
    [Attributes(9)]
   public sealed class C1BcxBlock1ImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6130)]
    [Attributes(9)]
   public sealed class C1BcxBlock1ImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6131)]
    [Attributes(9)]
   public sealed class C1BcxBlock1ImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6121)]
    [Attributes(9)]
   public sealed class C1BcxBlock1Lna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6111)]
    [Attributes(9)]
   public sealed class C1BcxBlock1Lna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6107)]
    [Attributes(9)]
   public sealed class C1BcxBlock1Lna1OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6120)]
    [Attributes(9)]
   public sealed class C1BcxBlock1Lna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6123)]
    [Attributes(9)]
   public sealed class C1BcxBlock1Lna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6112)]
    [Attributes(9)]
   public sealed class C1BcxBlock1Lna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6108)]
    [Attributes(9)]
   public sealed class C1BcxBlock1Lna2OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6122)]
    [Attributes(9)]
   public sealed class C1BcxBlock1Lna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6125)]
    [Attributes(9)]
   public sealed class C1BcxBlock1Lna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6113)]
    [Attributes(9)]
   public sealed class C1BcxBlock1Lna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6109)]
    [Attributes(9)]
   public sealed class C1BcxBlock1Lna3OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6124)]
    [Attributes(9)]
   public sealed class C1BcxBlock1Lna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6127)]
    [Attributes(9)]
   public sealed class C1BcxBlock1Lna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6114)]
    [Attributes(9)]
   public sealed class C1BcxBlock1Lna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6110)]
    [Attributes(9)]
   public sealed class C1BcxBlock1Lna4OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6126)]
    [Attributes(9)]
   public sealed class C1BcxBlock1Lna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6106)]
    [Attributes(9)]
   public sealed class C1BcxBlock1RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6175)]
    [Attributes(9)]
   public sealed class C1BcxBlock1RxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6105)]
    [Attributes(9)]
   public sealed class C1BcxBlock1TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6173)]
    [Attributes(9)]
   public sealed class C1BcxBlock1VcoCoarseTuneTable : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6117)]
    [Attributes(9)]
   public sealed class C1BcxBlock1VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6118)]
    [Attributes(9)]
   public sealed class C1BcxBlock1VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4610)]
    [Attributes(9)]
   public sealed class C1BcxBlockIm2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4611)]
    [Attributes(9)]
   public sealed class C1BcxBlockIm2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4614)]
    [Attributes(9)]
   public sealed class C1BcxBlockIm2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4623)]
    [Attributes(9)]
   public sealed class C1BcxBlockImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4624)]
    [Attributes(9)]
   public sealed class C1BcxBlockImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4625)]
    [Attributes(9)]
   public sealed class C1BcxBlockImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4626)]
    [Attributes(9)]
   public sealed class C1BcxBlockImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4616)]
    [Attributes(9)]
   public sealed class C1BcxBlockLna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4606)]
    [Attributes(9)]
   public sealed class C1BcxBlockLna1Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4602)]
    [Attributes(9)]
   public sealed class C1BcxBlockLna1OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4615)]
    [Attributes(9)]
   public sealed class C1BcxBlockLna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4618)]
    [Attributes(9)]
   public sealed class C1BcxBlockLna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4607)]
    [Attributes(9)]
   public sealed class C1BcxBlockLna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4603)]
    [Attributes(9)]
   public sealed class C1BcxBlockLna2OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4617)]
    [Attributes(9)]
   public sealed class C1BcxBlockLna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4620)]
    [Attributes(9)]
   public sealed class C1BcxBlockLna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4608)]
    [Attributes(9)]
   public sealed class C1BcxBlockLna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4604)]
    [Attributes(9)]
   public sealed class C1BcxBlockLna3OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4619)]
    [Attributes(9)]
   public sealed class C1BcxBlockLna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4622)]
    [Attributes(9)]
   public sealed class C1BcxBlockLna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4609)]
    [Attributes(9)]
   public sealed class C1BcxBlockLna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4605)]
    [Attributes(9)]
   public sealed class C1BcxBlockLna4OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4621)]
    [Attributes(9)]
   public sealed class C1BcxBlockLna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4601)]
    [Attributes(9)]
   public sealed class C1BcxBlockRxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6139)]
    [Attributes(9)]
   public sealed class C1BcxBlockRxCalChanLru : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4600)]
    [Attributes(9)]
   public sealed class C1BcxBlockTxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6137)]
    [Attributes(9)]
   public sealed class C1BcxBlockVcoCoarseTuneTable : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4612)]
    [Attributes(9)]
   public sealed class C1BcxBlockVgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4613)]
    [Attributes(9)]
   public sealed class C1BcxBlockVgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(984)]
    [Attributes(9)]
   public sealed class C1CdmaDaccIaccum0 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(987)]
    [Attributes(9)]
   public sealed class C1CdmaDaccIaccum1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(990)]
    [Attributes(9)]
   public sealed class C1CdmaDaccIaccum2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(993)]
    [Attributes(9)]
   public sealed class C1CdmaDaccIaccum3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(996)]
    [Attributes(9)]
   public sealed class C1CdmaDaccIaccum4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(999)]
    [Attributes(9)]
   public sealed class C1CdmaDaccQaccum0 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1002)]
    [Attributes(9)]
   public sealed class C1CdmaDaccQaccum1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1005)]
    [Attributes(9)]
   public sealed class C1CdmaDaccQaccum2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1008)]
    [Attributes(9)]
   public sealed class C1CdmaDaccQaccum3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1011)]
    [Attributes(9)]
   public sealed class C1CdmaDaccQaccum4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1022)]
    [Attributes(9)]
   public sealed class C1CdmaIm2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1020)]
    [Attributes(9)]
   public sealed class C1CdmaIm2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1024)]
    [Attributes(9)]
   public sealed class C1CdmaIm2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1049)]
    [Attributes(9)]
   public sealed class C1CdmaImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1050)]
    [Attributes(9)]
   public sealed class C1CdmaImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1051)]
    [Attributes(9)]
   public sealed class C1CdmaImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1052)]
    [Attributes(9)]
   public sealed class C1CdmaImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1041)]
    [Attributes(9)]
   public sealed class C1CdmaLna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1033)]
    [Attributes(9)]
   public sealed class C1CdmaLna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1042)]
    [Attributes(9)]
   public sealed class C1CdmaLna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(952)]
    [Attributes(9)]
   public sealed class C1CdmaLna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(953)]
    [Attributes(9)]
   public sealed class C1CdmaLna2OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1034)]
    [Attributes(9)]
   public sealed class C1CdmaLna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1043)]
    [Attributes(9)]
   public sealed class C1CdmaLna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(956)]
    [Attributes(9)]
   public sealed class C1CdmaLna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(957)]
    [Attributes(9)]
   public sealed class C1CdmaLna3OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1035)]
    [Attributes(9)]
   public sealed class C1CdmaLna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1044)]
    [Attributes(9)]
   public sealed class C1CdmaLna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(960)]
    [Attributes(9)]
   public sealed class C1CdmaLna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(961)]
    [Attributes(9)]
   public sealed class C1CdmaLna4OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1036)]
    [Attributes(9)]
   public sealed class C1CdmaLna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(948)]
    [Attributes(9)]
   public sealed class C1CdmaLnaOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(949)]
    [Attributes(9)]
   public sealed class C1CdmaLnaOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(964)]
    [Attributes(9)]
   public sealed class C1CdmaP1RiseFallOffset : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(974)]
    [Attributes(9)]
   public sealed class C1CdmaVgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(975)]
    [Attributes(9)]
   public sealed class C1CdmaVgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(976)]
    [Attributes(9)]
   public sealed class C1CdmaVgaGainOffsetVsTemp : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(980)]
    [Attributes(9)]
   public sealed class C1DigitalMisCompAOffset : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(982)]
    [Attributes(9)]
   public sealed class C1DigitalMisCompBOffset : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(986)]
    [Attributes(9)]
   public sealed class C1GpsDaccIaccum0 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(989)]
    [Attributes(9)]
   public sealed class C1GpsDaccIaccum1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(992)]
    [Attributes(9)]
   public sealed class C1GpsDaccIaccum2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(995)]
    [Attributes(9)]
   public sealed class C1GpsDaccIaccum3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(998)]
    [Attributes(9)]
   public sealed class C1GpsDaccIaccum4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1001)]
    [Attributes(9)]
   public sealed class C1GpsDaccQaccum0 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1004)]
    [Attributes(9)]
   public sealed class C1GpsDaccQaccum1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1007)]
    [Attributes(9)]
   public sealed class C1GpsDaccQaccum2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1010)]
    [Attributes(9)]
   public sealed class C1GpsDaccQaccum3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1013)]
    [Attributes(9)]
   public sealed class C1GpsDaccQaccum4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(981)]
    [Attributes(9)]
   public sealed class C1GpsMisCompAOffset : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(983)]
    [Attributes(9)]
   public sealed class C1GpsMisCompBOffset : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(973)]
    [Attributes(9)]
   public sealed class C1GrpDelayAdj : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(985)]
    [Attributes(9)]
   public sealed class C1PcsDaccIaccum0 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(988)]
    [Attributes(9)]
   public sealed class C1PcsDaccIaccum1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(991)]
    [Attributes(9)]
   public sealed class C1PcsDaccIaccum2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(994)]
    [Attributes(9)]
   public sealed class C1PcsDaccIaccum3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(997)]
    [Attributes(9)]
   public sealed class C1PcsDaccIaccum4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1000)]
    [Attributes(9)]
   public sealed class C1PcsDaccQaccum0 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1003)]
    [Attributes(9)]
   public sealed class C1PcsDaccQaccum1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1006)]
    [Attributes(9)]
   public sealed class C1PcsDaccQaccum2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1009)]
    [Attributes(9)]
   public sealed class C1PcsDaccQaccum3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1012)]
    [Attributes(9)]
   public sealed class C1PcsDaccQaccum4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1023)]
    [Attributes(9)]
   public sealed class C1PcsIm2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1021)]
    [Attributes(9)]
   public sealed class C1PcsIm2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1025)]
    [Attributes(9)]
   public sealed class C1PcsIm2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1053)]
    [Attributes(9)]
   public sealed class C1PcsImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1054)]
    [Attributes(9)]
   public sealed class C1PcsImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1055)]
    [Attributes(9)]
   public sealed class C1PcsImLevel3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1056)]
    [Attributes(9)]
   public sealed class C1PcsImLevel4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1045)]
    [Attributes(9)]
   public sealed class C1PcsLna1Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1037)]
    [Attributes(9)]
   public sealed class C1PcsLna1Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1046)]
    [Attributes(9)]
   public sealed class C1PcsLna2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(954)]
    [Attributes(9)]
   public sealed class C1PcsLna2Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(955)]
    [Attributes(9)]
   public sealed class C1PcsLna2OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1038)]
    [Attributes(9)]
   public sealed class C1PcsLna2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1047)]
    [Attributes(9)]
   public sealed class C1PcsLna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(958)]
    [Attributes(9)]
   public sealed class C1PcsLna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(959)]
    [Attributes(9)]
   public sealed class C1PcsLna3OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1039)]
    [Attributes(9)]
   public sealed class C1PcsLna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1048)]
    [Attributes(9)]
   public sealed class C1PcsLna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(962)]
    [Attributes(9)]
   public sealed class C1PcsLna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(963)]
    [Attributes(9)]
   public sealed class C1PcsLna4OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1040)]
    [Attributes(9)]
   public sealed class C1PcsLna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(950)]
    [Attributes(9)]
   public sealed class C1PcsLnaOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(951)]
    [Attributes(9)]
   public sealed class C1PcsLnaOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(965)]
    [Attributes(9)]
   public sealed class C1PcsP1RiseFallOffset : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(977)]
    [Attributes(9)]
   public sealed class C1PcsVgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(978)]
    [Attributes(9)]
   public sealed class C1PcsVgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(979)]
    [Attributes(9)]
   public sealed class C1PcsVgaGainOffsetVsTemp : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3818)]
    [Attributes(9)]
   public sealed class C1RfAntselUmts1900 : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3788)]
    [Attributes(9)]
   public sealed class C1RfAntselUmts2100 : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3848)]
    [Attributes(9)]
   public sealed class C1RfAntselUmts800 : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(966)]
    [Attributes(9)]
   public sealed class C1RxAgcValue1Minmax : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(967)]
    [Attributes(9)]
   public sealed class C1RxAgcValue2Minmax : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(968)]
    [Attributes(9)]
   public sealed class C1RxAgcValue3Minmax : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(969)]
    [Attributes(9)]
   public sealed class C1RxAgcValue4Minmax : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(971)]
    [Attributes(9)]
   public sealed class C1RxAgcVrefVal : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7092)]
    [Attributes(9)]
   public sealed class C1Wcdma1500BypassTimer : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7088)]
    [Attributes(9)]
   public sealed class C1Wcdma1500Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7089)]
    [Attributes(9)]
   public sealed class C1Wcdma1500Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7090)]
    [Attributes(9)]
   public sealed class C1Wcdma1500Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7079)]
    [Attributes(9)]
   public sealed class C1Wcdma1500ImLevel2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7080)]
    [Attributes(9)]
   public sealed class C1Wcdma1500ImLevel3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7081)]
    [Attributes(9)]
   public sealed class C1Wcdma1500ImLevel4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7078)]
    [Attributes(9)]
   public sealed class C1Wcdma1500ImLevel : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7085)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaOffsetVsFreq2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7086)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaOffsetVsFreq3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7087)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaOffsetVsFreq4 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7094)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7097)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaPhaseCtl : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7075)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaRangeFall2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7076)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaRangeFall3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7077)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaRangeFall4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7074)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaRangeFall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7082)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaRangeOffset2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7083)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaRangeOffset3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7084)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaRangeOffset4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7093)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaRangeOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7071)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaRangeRise2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7072)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaRangeRise3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7073)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaRangeRise4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7070)]
    [Attributes(9)]
   public sealed class C1Wcdma1500LnaRangeRise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7091)]
    [Attributes(9)]
   public sealed class C1Wcdma1500NonbypassTimer : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7095)]
    [Attributes(9)]
   public sealed class C1Wcdma1500RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7100)]
    [Attributes(9)]
   public sealed class C1Wcdma1500RxfIciICoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7105)]
    [Attributes(9)]
   public sealed class C1Wcdma1500RxfIciICoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7106)]
    [Attributes(9)]
   public sealed class C1Wcdma1500RxfIciICoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7107)]
    [Attributes(9)]
   public sealed class C1Wcdma1500RxfIciICoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7101)]
    [Attributes(9)]
   public sealed class C1Wcdma1500RxfIciICoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7102)]
    [Attributes(9)]
   public sealed class C1Wcdma1500RxfIciICoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7103)]
    [Attributes(9)]
   public sealed class C1Wcdma1500RxfIciICoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7104)]
    [Attributes(9)]
   public sealed class C1Wcdma1500RxfIciICoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7116)]
    [Attributes(9)]
   public sealed class C1Wcdma1500RxfIciIqTrunc : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7108)]
    [Attributes(9)]
   public sealed class C1Wcdma1500RxfIciQCoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7113)]
    [Attributes(9)]
   public sealed class C1Wcdma1500RxfIciQCoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7114)]
    [Attributes(9)]
   public sealed class C1Wcdma1500RxfIciQCoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7115)]
    [Attributes(9)]
   public sealed class C1Wcdma1500RxfIciQCoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7109)]
    [Attributes(9)]
   public sealed class C1Wcdma1500RxfIciQCoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7110)]
    [Attributes(9)]
   public sealed class C1Wcdma1500RxfIciQCoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7111)]
    [Attributes(9)]
   public sealed class C1Wcdma1500RxfIciQCoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7112)]
    [Attributes(9)]
   public sealed class C1Wcdma1500RxfIciQCoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7098)]
    [Attributes(9)]
   public sealed class C1Wcdma1500RxfMisCompACoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7099)]
    [Attributes(9)]
   public sealed class C1Wcdma1500RxfMisCompBCoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7067)]
    [Attributes(9)]
   public sealed class C1Wcdma1500VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7068)]
    [Attributes(9)]
   public sealed class C1Wcdma1500VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7069)]
    [Attributes(9)]
   public sealed class C1Wcdma1500VgaGainOffsetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4459)]
    [Attributes(9)]
   public sealed class C1Wcdma1800BypassTimer : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4455)]
    [Attributes(9)]
   public sealed class C1Wcdma1800Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4456)]
    [Attributes(9)]
   public sealed class C1Wcdma1800Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4457)]
    [Attributes(9)]
   public sealed class C1Wcdma1800Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4446)]
    [Attributes(9)]
   public sealed class C1Wcdma1800ImLevel2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4447)]
    [Attributes(9)]
   public sealed class C1Wcdma1800ImLevel3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4448)]
    [Attributes(9)]
   public sealed class C1Wcdma1800ImLevel4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4445)]
    [Attributes(9)]
   public sealed class C1Wcdma1800ImLevel : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4452)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaOffsetVsFreq2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4453)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaOffsetVsFreq3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4454)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaOffsetVsFreq4 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4461)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5104)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaPhaseCtl : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4442)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaRangeFall2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4443)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaRangeFall3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4444)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaRangeFall4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4441)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaRangeFall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4449)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaRangeOffset2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4450)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaRangeOffset3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4451)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaRangeOffset4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4460)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaRangeOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4438)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaRangeRise2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4439)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaRangeRise3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4440)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaRangeRise4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4437)]
    [Attributes(9)]
   public sealed class C1Wcdma1800LnaRangeRise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4458)]
    [Attributes(9)]
   public sealed class C1Wcdma1800NonbypassTimer : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4462)]
    [Attributes(9)]
   public sealed class C1Wcdma1800RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6411)]
    [Attributes(9)]
   public sealed class C1Wcdma1800RxfIciICoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6416)]
    [Attributes(9)]
   public sealed class C1Wcdma1800RxfIciICoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6417)]
    [Attributes(9)]
   public sealed class C1Wcdma1800RxfIciICoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6418)]
    [Attributes(9)]
   public sealed class C1Wcdma1800RxfIciICoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6412)]
    [Attributes(9)]
   public sealed class C1Wcdma1800RxfIciICoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6413)]
    [Attributes(9)]
   public sealed class C1Wcdma1800RxfIciICoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6414)]
    [Attributes(9)]
   public sealed class C1Wcdma1800RxfIciICoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6415)]
    [Attributes(9)]
   public sealed class C1Wcdma1800RxfIciICoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6427)]
    [Attributes(9)]
   public sealed class C1Wcdma1800RxfIciIqTrunc : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6419)]
    [Attributes(9)]
   public sealed class C1Wcdma1800RxfIciQCoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6424)]
    [Attributes(9)]
   public sealed class C1Wcdma1800RxfIciQCoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6425)]
    [Attributes(9)]
   public sealed class C1Wcdma1800RxfIciQCoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6426)]
    [Attributes(9)]
   public sealed class C1Wcdma1800RxfIciQCoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6420)]
    [Attributes(9)]
   public sealed class C1Wcdma1800RxfIciQCoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6421)]
    [Attributes(9)]
   public sealed class C1Wcdma1800RxfIciQCoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6422)]
    [Attributes(9)]
   public sealed class C1Wcdma1800RxfIciQCoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6423)]
    [Attributes(9)]
   public sealed class C1Wcdma1800RxfIciQCoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6392)]
    [Attributes(9)]
   public sealed class C1Wcdma1800RxfMisCompACoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6393)]
    [Attributes(9)]
   public sealed class C1Wcdma1800RxfMisCompBCoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4434)]
    [Attributes(9)]
   public sealed class C1Wcdma1800VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4435)]
    [Attributes(9)]
   public sealed class C1Wcdma1800VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4436)]
    [Attributes(9)]
   public sealed class C1Wcdma1800VgaGainOffsetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3814)]
    [Attributes(9)]
   public sealed class C1Wcdma1900BypassTimer : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3810)]
    [Attributes(9)]
   public sealed class C1Wcdma1900Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3811)]
    [Attributes(9)]
   public sealed class C1Wcdma1900Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3812)]
    [Attributes(9)]
   public sealed class C1Wcdma1900Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3801)]
    [Attributes(9)]
   public sealed class C1Wcdma1900ImLevel2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3802)]
    [Attributes(9)]
   public sealed class C1Wcdma1900ImLevel3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3803)]
    [Attributes(9)]
   public sealed class C1Wcdma1900ImLevel4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3800)]
    [Attributes(9)]
   public sealed class C1Wcdma1900ImLevel : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3807)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaOffsetVsFreq2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3808)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaOffsetVsFreq3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3809)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaOffsetVsFreq4 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3816)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5096)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaPhaseCtl : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3797)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeFall2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3798)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeFall3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3799)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeFall4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3796)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeFall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3804)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeOffset2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3805)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeOffset3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3806)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeOffset4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3815)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3793)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeRise2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3794)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeRise3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3795)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeRise4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3792)]
    [Attributes(9)]
   public sealed class C1Wcdma1900LnaRangeRise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3813)]
    [Attributes(9)]
   public sealed class C1Wcdma1900NonbypassTimer : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3817)]
    [Attributes(9)]
   public sealed class C1Wcdma1900RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5962)]
    [Attributes(9)]
   public sealed class C1Wcdma1900RxfIciICoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5967)]
    [Attributes(9)]
   public sealed class C1Wcdma1900RxfIciICoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5968)]
    [Attributes(9)]
   public sealed class C1Wcdma1900RxfIciICoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5969)]
    [Attributes(9)]
   public sealed class C1Wcdma1900RxfIciICoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5963)]
    [Attributes(9)]
   public sealed class C1Wcdma1900RxfIciICoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5964)]
    [Attributes(9)]
   public sealed class C1Wcdma1900RxfIciICoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5965)]
    [Attributes(9)]
   public sealed class C1Wcdma1900RxfIciICoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5966)]
    [Attributes(9)]
   public sealed class C1Wcdma1900RxfIciICoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5979)]
    [Attributes(9)]
   public sealed class C1Wcdma1900RxfIciIqTrunc : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5970)]
    [Attributes(9)]
   public sealed class C1Wcdma1900RxfIciQCoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5975)]
    [Attributes(9)]
   public sealed class C1Wcdma1900RxfIciQCoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5976)]
    [Attributes(9)]
   public sealed class C1Wcdma1900RxfIciQCoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5977)]
    [Attributes(9)]
   public sealed class C1Wcdma1900RxfIciQCoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5971)]
    [Attributes(9)]
   public sealed class C1Wcdma1900RxfIciQCoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5972)]
    [Attributes(9)]
   public sealed class C1Wcdma1900RxfIciQCoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5973)]
    [Attributes(9)]
   public sealed class C1Wcdma1900RxfIciQCoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5974)]
    [Attributes(9)]
   public sealed class C1Wcdma1900RxfIciQCoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5902)]
    [Attributes(9)]
   public sealed class C1Wcdma1900RxfMisCompACoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5903)]
    [Attributes(9)]
   public sealed class C1Wcdma1900RxfMisCompBCoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3789)]
    [Attributes(9)]
   public sealed class C1Wcdma1900VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3790)]
    [Attributes(9)]
   public sealed class C1Wcdma1900VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3791)]
    [Attributes(9)]
   public sealed class C1Wcdma1900VgaGainOffsetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3764)]
    [Attributes(9)]
   public sealed class C1Wcdma2100BypassTimer : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3784)]
    [Attributes(9)]
   public sealed class C1Wcdma2100Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3785)]
    [Attributes(9)]
   public sealed class C1Wcdma2100Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3786)]
    [Attributes(9)]
   public sealed class C1Wcdma2100Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3775)]
    [Attributes(9)]
   public sealed class C1Wcdma2100ImLevel2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3776)]
    [Attributes(9)]
   public sealed class C1Wcdma2100ImLevel3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3777)]
    [Attributes(9)]
   public sealed class C1Wcdma2100ImLevel4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3762)]
    [Attributes(9)]
   public sealed class C1Wcdma2100ImLevel : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3781)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaOffsetVsFreq2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3782)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaOffsetVsFreq3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3783)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaOffsetVsFreq4 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3766)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3772)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeFall2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3773)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeFall3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3774)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeFall4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3761)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeFall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7220)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeOffset2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3778)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeOffset2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7221)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeOffset3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3779)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeOffset3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7222)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeOffset4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3780)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeOffset4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7223)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeOffset5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7219)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeOffsetCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3765)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3769)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeRise2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3770)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeRise3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3771)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeRise4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3760)]
    [Attributes(9)]
   public sealed class C1Wcdma2100LnaRangeRise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3763)]
    [Attributes(9)]
   public sealed class C1Wcdma2100NonbypassTimer : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3787)]
    [Attributes(9)]
   public sealed class C1Wcdma2100RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7150)]
    [Attributes(9)]
   public sealed class C1Wcdma2100RxfIciCalDataCar0 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7151)]
    [Attributes(9)]
   public sealed class C1Wcdma2100RxfIciCalDataCar1 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5928)]
    [Attributes(9)]
   public sealed class C1Wcdma2100RxfIciICoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5933)]
    [Attributes(9)]
   public sealed class C1Wcdma2100RxfIciICoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5934)]
    [Attributes(9)]
   public sealed class C1Wcdma2100RxfIciICoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5935)]
    [Attributes(9)]
   public sealed class C1Wcdma2100RxfIciICoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5929)]
    [Attributes(9)]
   public sealed class C1Wcdma2100RxfIciICoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5930)]
    [Attributes(9)]
   public sealed class C1Wcdma2100RxfIciICoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5931)]
    [Attributes(9)]
   public sealed class C1Wcdma2100RxfIciICoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5932)]
    [Attributes(9)]
   public sealed class C1Wcdma2100RxfIciICoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5945)]
    [Attributes(9)]
   public sealed class C1Wcdma2100RxfIciIqTrunc : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5936)]
    [Attributes(9)]
   public sealed class C1Wcdma2100RxfIciQCoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5941)]
    [Attributes(9)]
   public sealed class C1Wcdma2100RxfIciQCoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5942)]
    [Attributes(9)]
   public sealed class C1Wcdma2100RxfIciQCoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5943)]
    [Attributes(9)]
   public sealed class C1Wcdma2100RxfIciQCoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5937)]
    [Attributes(9)]
   public sealed class C1Wcdma2100RxfIciQCoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5938)]
    [Attributes(9)]
   public sealed class C1Wcdma2100RxfIciQCoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5939)]
    [Attributes(9)]
   public sealed class C1Wcdma2100RxfIciQCoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5940)]
    [Attributes(9)]
   public sealed class C1Wcdma2100RxfIciQCoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5898)]
    [Attributes(9)]
   public sealed class C1Wcdma2100RxfMisCompACoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5899)]
    [Attributes(9)]
   public sealed class C1Wcdma2100RxfMisCompBCoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7224)]
    [Attributes(9)]
   public sealed class C1Wcdma2100VgaGainOffsetCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3759)]
    [Attributes(9)]
   public sealed class C1Wcdma2100VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3767)]
    [Attributes(9)]
   public sealed class C1Wcdma2100VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3768)]
    [Attributes(9)]
   public sealed class C1Wcdma2100VgaGainOffsetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3846)]
    [Attributes(9)]
   public sealed class C1Wcdma800BypassTimer : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3842)]
    [Attributes(9)]
   public sealed class C1Wcdma800Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3843)]
    [Attributes(9)]
   public sealed class C1Wcdma800Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3844)]
    [Attributes(9)]
   public sealed class C1Wcdma800Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3831)]
    [Attributes(9)]
   public sealed class C1Wcdma800ImLevel2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3832)]
    [Attributes(9)]
   public sealed class C1Wcdma800ImLevel3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3833)]
    [Attributes(9)]
   public sealed class C1Wcdma800ImLevel4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3830)]
    [Attributes(9)]
   public sealed class C1Wcdma800ImLevel : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3839)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaOffsetVsFreq2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3840)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaOffsetVsFreq3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3841)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaOffsetVsFreq4 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3838)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5098)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaPhaseCtl : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3827)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaRangeFall2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3828)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaRangeFall3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3829)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaRangeFall4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3826)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaRangeFall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3835)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaRangeOffset2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3836)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaRangeOffset3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3837)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaRangeOffset4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3834)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaRangeOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3823)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaRangeRise2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3824)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaRangeRise3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3825)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaRangeRise4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3822)]
    [Attributes(9)]
   public sealed class C1Wcdma800LnaRangeRise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3845)]
    [Attributes(9)]
   public sealed class C1Wcdma800NonbypassTimer : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3847)]
    [Attributes(9)]
   public sealed class C1Wcdma800RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7160)]
    [Attributes(9)]
   public sealed class C1Wcdma800RxfIciCalDataCar0 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7161)]
    [Attributes(9)]
   public sealed class C1Wcdma800RxfIciCalDataCar1 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6030)]
    [Attributes(9)]
   public sealed class C1Wcdma800RxfIciICoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6035)]
    [Attributes(9)]
   public sealed class C1Wcdma800RxfIciICoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6036)]
    [Attributes(9)]
   public sealed class C1Wcdma800RxfIciICoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6037)]
    [Attributes(9)]
   public sealed class C1Wcdma800RxfIciICoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6031)]
    [Attributes(9)]
   public sealed class C1Wcdma800RxfIciICoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6032)]
    [Attributes(9)]
   public sealed class C1Wcdma800RxfIciICoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6033)]
    [Attributes(9)]
   public sealed class C1Wcdma800RxfIciICoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6034)]
    [Attributes(9)]
   public sealed class C1Wcdma800RxfIciICoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6047)]
    [Attributes(9)]
   public sealed class C1Wcdma800RxfIciIqTrunc : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6038)]
    [Attributes(9)]
   public sealed class C1Wcdma800RxfIciQCoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6043)]
    [Attributes(9)]
   public sealed class C1Wcdma800RxfIciQCoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6044)]
    [Attributes(9)]
   public sealed class C1Wcdma800RxfIciQCoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6045)]
    [Attributes(9)]
   public sealed class C1Wcdma800RxfIciQCoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6039)]
    [Attributes(9)]
   public sealed class C1Wcdma800RxfIciQCoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6040)]
    [Attributes(9)]
   public sealed class C1Wcdma800RxfIciQCoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6041)]
    [Attributes(9)]
   public sealed class C1Wcdma800RxfIciQCoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6042)]
    [Attributes(9)]
   public sealed class C1Wcdma800RxfIciQCoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5910)]
    [Attributes(9)]
   public sealed class C1Wcdma800RxfMisCompACoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5911)]
    [Attributes(9)]
   public sealed class C1Wcdma800RxfMisCompBCoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3819)]
    [Attributes(9)]
   public sealed class C1Wcdma800VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3820)]
    [Attributes(9)]
   public sealed class C1Wcdma800VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3821)]
    [Attributes(9)]
   public sealed class C1Wcdma800VgaGainOffsetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4488)]
    [Attributes(9)]
   public sealed class C1Wcdma900BypassTimer : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4484)]
    [Attributes(9)]
   public sealed class C1Wcdma900Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4485)]
    [Attributes(9)]
   public sealed class C1Wcdma900Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4486)]
    [Attributes(9)]
   public sealed class C1Wcdma900Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4475)]
    [Attributes(9)]
   public sealed class C1Wcdma900ImLevel2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4476)]
    [Attributes(9)]
   public sealed class C1Wcdma900ImLevel3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4477)]
    [Attributes(9)]
   public sealed class C1Wcdma900ImLevel4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4474)]
    [Attributes(9)]
   public sealed class C1Wcdma900ImLevel : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4481)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaOffsetVsFreq2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4482)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaOffsetVsFreq3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4483)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaOffsetVsFreq4 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4490)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5102)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaPhaseCtl : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4471)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeFall2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4472)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeFall3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4473)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeFall4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4470)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeFall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4478)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeOffset2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4479)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeOffset3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4480)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeOffset4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4489)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4467)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeRise2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4468)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeRise3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4469)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeRise4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4466)]
    [Attributes(9)]
   public sealed class C1Wcdma900LnaRangeRise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4487)]
    [Attributes(9)]
   public sealed class C1Wcdma900NonbypassTimer : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4491)]
    [Attributes(9)]
   public sealed class C1Wcdma900RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6452)]
    [Attributes(9)]
   public sealed class C1Wcdma900RxfIciICoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6457)]
    [Attributes(9)]
   public sealed class C1Wcdma900RxfIciICoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6458)]
    [Attributes(9)]
   public sealed class C1Wcdma900RxfIciICoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6459)]
    [Attributes(9)]
   public sealed class C1Wcdma900RxfIciICoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6453)]
    [Attributes(9)]
   public sealed class C1Wcdma900RxfIciICoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6454)]
    [Attributes(9)]
   public sealed class C1Wcdma900RxfIciICoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6455)]
    [Attributes(9)]
   public sealed class C1Wcdma900RxfIciICoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6456)]
    [Attributes(9)]
   public sealed class C1Wcdma900RxfIciICoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6468)]
    [Attributes(9)]
   public sealed class C1Wcdma900RxfIciIqTrunc : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6460)]
    [Attributes(9)]
   public sealed class C1Wcdma900RxfIciQCoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6465)]
    [Attributes(9)]
   public sealed class C1Wcdma900RxfIciQCoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6466)]
    [Attributes(9)]
   public sealed class C1Wcdma900RxfIciQCoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6467)]
    [Attributes(9)]
   public sealed class C1Wcdma900RxfIciQCoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6461)]
    [Attributes(9)]
   public sealed class C1Wcdma900RxfIciQCoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6462)]
    [Attributes(9)]
   public sealed class C1Wcdma900RxfIciQCoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6463)]
    [Attributes(9)]
   public sealed class C1Wcdma900RxfIciQCoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6464)]
    [Attributes(9)]
   public sealed class C1Wcdma900RxfIciQCoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6433)]
    [Attributes(9)]
   public sealed class C1Wcdma900RxfMisCompACoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6434)]
    [Attributes(9)]
   public sealed class C1Wcdma900RxfMisCompBCoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4463)]
    [Attributes(9)]
   public sealed class C1Wcdma900VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4464)]
    [Attributes(9)]
   public sealed class C1Wcdma900VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4465)]
    [Attributes(9)]
   public sealed class C1Wcdma900VgaGainOffsetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4517)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4BypassTimer : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4513)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4514)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4515)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4504)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4ImLevel2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4505)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4ImLevel3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4506)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4ImLevel4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4503)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4ImLevel : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4510)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaOffsetVsFreq2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4511)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaOffsetVsFreq3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4512)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaOffsetVsFreq4 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4519)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5100)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaPhaseCtl : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4500)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaRangeFall2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4501)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaRangeFall3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4502)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaRangeFall4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4499)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaRangeFall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4507)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaRangeOffset2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4508)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaRangeOffset3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4509)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaRangeOffset4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4518)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaRangeOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4496)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaRangeRise2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4497)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaRangeRise3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4498)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaRangeRise4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4495)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4LnaRangeRise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4516)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4NonbypassTimer : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4520)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5996)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4RxfIciICoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6001)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4RxfIciICoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6002)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4RxfIciICoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6003)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4RxfIciICoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5997)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4RxfIciICoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5998)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4RxfIciICoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5999)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4RxfIciICoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6000)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4RxfIciICoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6013)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4RxfIciIqTrunc : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6004)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4RxfIciQCoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6009)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4RxfIciQCoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6010)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4RxfIciQCoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6011)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4RxfIciQCoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6005)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4RxfIciQCoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6006)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4RxfIciQCoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6007)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4RxfIciQCoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6008)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4RxfIciQCoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5906)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4RxfMisCompACoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5907)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4RxfMisCompBCoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4492)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4493)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4494)]
    [Attributes(9)]
   public sealed class C1WcdmaBc4VgaGainOffsetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7209)]
    [Attributes(9)]
   public sealed class C1WcdmaDc1LnaRangeOffset2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7211)]
    [Attributes(9)]
   public sealed class C1WcdmaDc1LnaRangeOffset3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7213)]
    [Attributes(9)]
   public sealed class C1WcdmaDc1LnaRangeOffset4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7215)]
    [Attributes(9)]
   public sealed class C1WcdmaDc1LnaRangeOffset5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7207)]
    [Attributes(9)]
   public sealed class C1WcdmaDc1LnaRangeOffsetCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7203)]
    [Attributes(9)]
   public sealed class C1WcdmaDc1RxfIciCalDataCar0 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7205)]
    [Attributes(9)]
   public sealed class C1WcdmaDc1RxfIciCalDataCar1 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7217)]
    [Attributes(9)]
   public sealed class C1WcdmaDc1VgaGainOffsetCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7210)]
    [Attributes(9)]
   public sealed class C1WcdmaDc2LnaRangeOffset2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7212)]
    [Attributes(9)]
   public sealed class C1WcdmaDc2LnaRangeOffset3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7214)]
    [Attributes(9)]
   public sealed class C1WcdmaDc2LnaRangeOffset4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7216)]
    [Attributes(9)]
   public sealed class C1WcdmaDc2LnaRangeOffset5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7208)]
    [Attributes(9)]
   public sealed class C1WcdmaDc2LnaRangeOffsetCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7204)]
    [Attributes(9)]
   public sealed class C1WcdmaDc2RxfIciCalDataCar0 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7206)]
    [Attributes(9)]
   public sealed class C1WcdmaDc2RxfIciCalDataCar1 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7218)]
    [Attributes(9)]
   public sealed class C1WcdmaDc2VgaGainOffsetCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4957)]
    [Attributes(9)]
   public sealed class C1WcdmaLnaPhaseCtl : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(70)]
    [Attributes(9)]
   public sealed class CallFadeAlert : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(200)]
    [Attributes(9)]
   public sealed class CdmaAdjFactor : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(635)]
    [Attributes(9)]
   public sealed class CdmaDaccEstIoffset : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(639)]
    [Attributes(9)]
   public sealed class CdmaDaccEstQoffset : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(683)]
    [Attributes(9)]
   public sealed class CdmaDaccGainMult : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(643)]
    [Attributes(9)]
   public sealed class CdmaDaccIaccum0 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(647)]
    [Attributes(9)]
   public sealed class CdmaDaccIaccum1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(651)]
    [Attributes(9)]
   public sealed class CdmaDaccIaccum2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(655)]
    [Attributes(9)]
   public sealed class CdmaDaccIaccum3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(659)]
    [Attributes(9)]
   public sealed class CdmaDaccIaccum4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(663)]
    [Attributes(9)]
   public sealed class CdmaDaccQaccum0 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(667)]
    [Attributes(9)]
   public sealed class CdmaDaccQaccum1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(671)]
    [Attributes(9)]
   public sealed class CdmaDaccQaccum2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(675)]
    [Attributes(9)]
   public sealed class CdmaDaccQaccum3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(679)]
    [Attributes(9)]
   public sealed class CdmaDaccQaccum4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(878)]
    [Attributes(9)]
   public sealed class CdmaDynamicRange : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(446)]
    [Attributes(9)]
   public sealed class CdmaEncBtf : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(140)]
    [Attributes(9)]
   public sealed class CdmaErrSlpVsHdet : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(139)]
    [Attributes(9)]
   public sealed class CdmaExpHdetVsAgc : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(312)]
    [Attributes(9)]
   public sealed class CdmaHdetAdcRange : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(687)]
    [Attributes(9)]
   public sealed class CdmaIm2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(689)]
    [Attributes(9)]
   public sealed class CdmaIm2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(837)]
    [Attributes(9)]
   public sealed class CdmaIm2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(384)]
    [Attributes(9)]
   public sealed class CdmaLna12OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(590)]
    [Attributes(9)]
   public sealed class CdmaLna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(591)]
    [Attributes(9)]
   public sealed class CdmaLna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(593)]
    [Attributes(9)]
   public sealed class CdmaLna3OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(592)]
    [Attributes(9)]
   public sealed class CdmaLna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(598)]
    [Attributes(9)]
   public sealed class CdmaLna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(599)]
    [Attributes(9)]
   public sealed class CdmaLna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(601)]
    [Attributes(9)]
   public sealed class CdmaLna4OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(600)]
    [Attributes(9)]
   public sealed class CdmaLna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(383)]
    [Attributes(9)]
   public sealed class CdmaLnaOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(879)]
    [Attributes(9)]
   public sealed class CdmaMinRxRssi : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(36)]
    [Attributes(41)]
   public sealed class CdmaMobileTerminatedForeignNidRegistrationFlag : ItemBase
    {
        public CdmaMobileTerminatedForeignNidRegistrationFlag()
        {
            Enabled = new sbyte[2];
        }


        public byte Name { get; set; }


        [FieldCount(2)]
        public sbyte[] Enabled { get; set; }
    }

    [Serializable]
    [NvItemId(35)]
    [Attributes(41)]
   public sealed class CdmaMobileTerminatedForeignSidRegistrationFlag : ItemBase
    {
        public CdmaMobileTerminatedForeignSidRegistrationFlag()
        {
            Enabled = new sbyte[2];
        }


        public byte Name { get; set; }


        [FieldCount(2)]
        public sbyte[] Enabled { get; set; }
    }

    [Serializable]
    [NvItemId(34)]
    [Attributes(41)]
   public sealed class CdmaMobileTerminatedHomeSidRegistrationFlag : ItemBase
    {
        public CdmaMobileTerminatedHomeSidRegistrationFlag()
        {
            Enabled = new sbyte[2];
        }


        public byte Name { get; set; }

        [FieldCount(2)]
        public sbyte[] Enabled { get; set; }
    }

    [Serializable]
    [NvItemId(901)]
    [Attributes(9)]
   public sealed class CdmaP1RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1018)]
    [Attributes(9)]
   public sealed class CdmaReceiveDiversity : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1308)]
    [Attributes(9)]
   public sealed class CdmaRxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3515)]
    [Attributes(9)]
   public sealed class CdmaRxChainSelectThreshold : TwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(129)]
    [Attributes(9)]
   public sealed class CdmaRxCompVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(619)]
    [Attributes(9)]
   public sealed class CdmaRxfCgIoffset : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(623)]
    [Attributes(9)]
   public sealed class CdmaRxfCgQoffset : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(627)]
    [Attributes(9)]
   public sealed class CdmaRxfFgIoffset : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(631)]
    [Attributes(9)]
   public sealed class CdmaRxfFgQoffset : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(127)]
    [Attributes(9)]
   public sealed class CdmaRxLinOff0 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(128)]
    [Attributes(9)]
   public sealed class CdmaRxLinSlp : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(199)]
    [Attributes(9)]
   public sealed class CdmaRxLinVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(202)]
    [Attributes(9)]
   public sealed class CdmaRxSlpVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(255)]
    [Attributes(45)]
   public sealed class CdmaSidNidLockout : ItemBase
    {
        public byte Nam { get; set; }


        public ushort Sid1 { get; set; }


        public ushort Nid1 { get; set; }


        public ushort Sid2 { get; set; }


        public ushort Nid2 { get; set; }


        public ushort Sid3 { get; set; }


        public ushort Nid3 { get; set; }


        public ushort Sid4 { get; set; }


        public ushort Nid4 { get; set; }


        public ushort Sid5 { get; set; }


        public ushort Nid5 { get; set; }


        public ushort Sid6 { get; set; }


        public ushort Nid6 { get; set; }


        public ushort Sid7 { get; set; }


        public ushort Nid7 { get; set; }


        public ushort Sid8 { get; set; }


        public ushort Nid8 { get; set; }


        public ushort Sid9 { get; set; }


        public ushort Nid9 { get; set; }


        public ushort Sid10 { get; set; }


        public ushort Nid10 { get; set; }
    }

    [Serializable]
    [NvItemId(4102)]
    [Attributes(9)]
   public sealed class CdmaSO68Enabled : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4192)]
    [Attributes(9)]
   public sealed class CdmaSO70Enable : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7166)]
    [Attributes(9)]
   public sealed class CdmaSo73Enabled : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1307)]
    [Attributes(9)]
   public sealed class CdmaTxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(130)]
    [Attributes(9)]
   public sealed class CdmaTxCompVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(131)]
    [Attributes(9)]
   public sealed class CdmaTxCompVsVolt : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(138)]
    [Attributes(9)]
   public sealed class CdmaTxLimVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(136)]
    [Attributes(9)]
   public sealed class CdmaTxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(137)]
    [Attributes(9)]
   public sealed class CdmaTxLimVsVolt : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(367)]
    [Attributes(9)]
   public sealed class CdmaTxLinMaster0 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(368)]
    [Attributes(9)]
   public sealed class CdmaTxLinMaster1 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(369)]
    [Attributes(9)]
   public sealed class CdmaTxLinMaster2 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(370)]
    [Attributes(9)]
   public sealed class CdmaTxLinMaster3 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(132)]
    [Attributes(9)]
   public sealed class CdmaTxLinMasterOff0 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(133)]
    [Attributes(9)]
   public sealed class CdmaTxLinMasterSlp : ThirtySevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(134)]
    [Attributes(9)]
   public sealed class CdmaTxLinVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(135)]
    [Attributes(9)]
   public sealed class CdmaTxLinVsVolt : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(203)]
    [Attributes(9)]
   public sealed class CdmaTxSlpVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(693)]
    [Attributes(9)]
   public sealed class CdmaVgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(696)]
    [Attributes(9)]
   public sealed class CdmaVgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(699)]
    [Attributes(9)]
   public sealed class CdmaVgaGainOffsetVsTemp : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2822)]
    [Attributes(9)]
   public sealed class ChgUsbNvdisable : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4261)]
    [Attributes(9)]
   public sealed class CpuBasedFlowControl : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6253)]
    [Attributes(9)]
   public sealed class CSimSupport : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6830)]
    [Attributes(9)]
   public sealed class CstoVoipFallbackTimer : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7147)]
    [Attributes(9)]
   public sealed class DataCallOverEhrpdOnly : ItemBase
    {
        public byte EhrpdOnlyFlag { get; set; }


        public byte MaxFailureCount { get; set; }


        public byte MaxFailureTotalCount { get; set; }


        public byte NewAttemptMaxTimer { get; set; }
    }

    [Serializable]
    [NvItemId(297)]
    [Attributes(9)]
   public sealed class DataMdrMode : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(429)]
    [Attributes(9)]
   public sealed class DataScRmEnabled : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(241)]
    [Attributes(9)]
   public sealed class DataServiceOptionSet : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(464)]
    [Attributes(13)]
   public sealed class DataServicesMobileIpCurrentlyActiveProfiles : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(889)]
    [Attributes(41)]
   public sealed class DataServicesMobileIpDmuMnAuthentication : ItemBase
    {
        public byte Field1 { get; set; }


        public byte Field2 { get; set; }


        public sbyte Field3 { get; set; }


        public byte Field4 { get; set; }
    }

    [Serializable]
    [NvItemId(854)]
    [Attributes(41)]
   public sealed class DataServicesMobileIpDmuPkoId : ItemBase
    {
        public byte Index { get; set; }


        public byte PkoId { get; set; }
    }

    [Serializable]
    [NvItemId(714)]
    [Attributes(13)]
   public sealed class DataServicesMobileIpEnableProfile : ItemBase
    {
        public DataServicesMobileIpEnableProfile()
        {
            EnableProfs = new byte[6];
        }

        [FieldCount(6)]
        public byte[] EnableProfs { get; set; }
    }

    [Serializable]
    [NvItemId(494)]
    [Attributes(41)]
   public sealed class DataServicesMobileIpMnHomeAgentTimebaseDifference : ItemBase
    {
        public byte Index { get; set; }


        public uint TimeDelta { get; set; }
    }

    [Serializable]
    [NvItemId(463)]
    [Attributes(13)]
   public sealed class DataServicesMobileIpNumberProfiles : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1193)]
    [Attributes(13)]
   public sealed class DataServicesMobileIpQcHanddown : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(462)]
    [Attributes(9)]
   public sealed class DataServicesMobileIpRegistrationExpirationAttemptReregistration : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(460)]
    [Attributes(9)]
   public sealed class DataServicesMobileIpRegistrationRetries : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(461)]
    [Attributes(9)]
   public sealed class DataServicesMobileIpRegistrationRetriesInitialInterval : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(707)]
    [Attributes(9)]
   public sealed class DataServicesMobileIpRrqIfTraffic : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(459)]
    [Attributes(9)]
   public sealed class DataServicesQcMobileIp : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(450)]
    [Attributes(9)]
   public sealed class DataThrottleEnabled : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5449)]
    [Attributes(9)]
   public sealed class DcCal : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4149)]
    [Attributes(9)]
   public sealed class Dcs8pskMultislot2TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4150)]
    [Attributes(9)]
   public sealed class Dcs8pskMultislot3TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4151)]
    [Attributes(9)]
   public sealed class Dcs8pskMultislot4TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4152)]
    [Attributes(9)]
   public sealed class Dcs8pskMultislot5TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2759)]
    [Attributes(9)]
   public sealed class DcsAmamArfcnF1 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2763)]
    [Attributes(9)]
   public sealed class DcsAmamArfcnF2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3143)]
    [Attributes(9)]
   public sealed class DcsAmamArfcnF3 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2745)]
    [Attributes(9)]
   public sealed class DcsAmamDynamicRange : TwoInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2529)]
    [Attributes(9)]
   public sealed class DcsAmamMasterTblSeg1F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2561)]
    [Attributes(9)]
   public sealed class DcsAmamMasterTblSeg1F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3086)]
    [Attributes(9)]
   public sealed class DcsAmamMasterTblSeg1F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2530)]
    [Attributes(9)]
   public sealed class DcsAmamMasterTblSeg2F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2562)]
    [Attributes(9)]
   public sealed class DcsAmamMasterTblSeg2F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3087)]
    [Attributes(9)]
   public sealed class DcsAmamMasterTblSeg2F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2531)]
    [Attributes(9)]
   public sealed class DcsAmamMasterTblSeg3F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2563)]
    [Attributes(9)]
   public sealed class DcsAmamMasterTblSeg3F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3088)]
    [Attributes(9)]
   public sealed class DcsAmamMasterTblSeg3F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2532)]
    [Attributes(9)]
   public sealed class DcsAmamMasterTblSeg4F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2564)]
    [Attributes(9)]
   public sealed class DcsAmamMasterTblSeg4F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3089)]
    [Attributes(9)]
   public sealed class DcsAmamMasterTblSeg4F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2533)]
    [Attributes(9)]
   public sealed class DcsAmamMasterTblSeg5F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2565)]
    [Attributes(9)]
   public sealed class DcsAmamMasterTblSeg5F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3090)]
    [Attributes(9)]
   public sealed class DcsAmamMasterTblSeg5F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2534)]
    [Attributes(9)]
   public sealed class DcsAmamMasterTblSeg6F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2566)]
    [Attributes(9)]
   public sealed class DcsAmamMasterTblSeg6F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3091)]
    [Attributes(9)]
   public sealed class DcsAmamMasterTblSeg6F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2535)]
    [Attributes(9)]
   public sealed class DcsAmamMasterTblSeg7F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2567)]
    [Attributes(9)]
   public sealed class DcsAmamMasterTblSeg7F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3092)]
    [Attributes(9)]
   public sealed class DcsAmamMasterTblSeg7F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2536)]
    [Attributes(9)]
   public sealed class DcsAmamMasterTblSeg8F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2568)]
    [Attributes(9)]
   public sealed class DcsAmamMasterTblSeg8F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3093)]
    [Attributes(9)]
   public sealed class DcsAmamMasterTblSeg8F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2756)]
    [Attributes(9)]
   public sealed class DcsAmamSysGainDcCorr : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2593)]
    [Attributes(9)]
   public sealed class DcsAmpmMasterTblSeg1F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2625)]
    [Attributes(9)]
   public sealed class DcsAmpmMasterTblSeg1F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3118)]
    [Attributes(9)]
   public sealed class DcsAmpmMasterTblSeg1F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2594)]
    [Attributes(9)]
   public sealed class DcsAmpmMasterTblSeg2F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2626)]
    [Attributes(9)]
   public sealed class DcsAmpmMasterTblSeg2F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3119)]
    [Attributes(9)]
   public sealed class DcsAmpmMasterTblSeg2F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2595)]
    [Attributes(9)]
   public sealed class DcsAmpmMasterTblSeg3F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2627)]
    [Attributes(9)]
   public sealed class DcsAmpmMasterTblSeg3F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3120)]
    [Attributes(9)]
   public sealed class DcsAmpmMasterTblSeg3F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2596)]
    [Attributes(9)]
   public sealed class DcsAmpmMasterTblSeg4F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2628)]
    [Attributes(9)]
   public sealed class DcsAmpmMasterTblSeg4F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3121)]
    [Attributes(9)]
   public sealed class DcsAmpmMasterTblSeg4F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2597)]
    [Attributes(9)]
   public sealed class DcsAmpmMasterTblSeg5F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2629)]
    [Attributes(9)]
   public sealed class DcsAmpmMasterTblSeg5F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3122)]
    [Attributes(9)]
   public sealed class DcsAmpmMasterTblSeg5F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2598)]
    [Attributes(9)]
   public sealed class DcsAmpmMasterTblSeg6F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2630)]
    [Attributes(9)]
   public sealed class DcsAmpmMasterTblSeg6F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3123)]
    [Attributes(9)]
   public sealed class DcsAmpmMasterTblSeg6F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2599)]
    [Attributes(9)]
   public sealed class DcsAmpmMasterTblSeg7F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2631)]
    [Attributes(9)]
   public sealed class DcsAmpmMasterTblSeg7F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3124)]
    [Attributes(9)]
   public sealed class DcsAmpmMasterTblSeg7F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2600)]
    [Attributes(9)]
   public sealed class DcsAmpmMasterTblSeg8F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2632)]
    [Attributes(9)]
   public sealed class DcsAmpmMasterTblSeg8F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3125)]
    [Attributes(9)]
   public sealed class DcsAmpmMasterTblSeg8F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3066)]
    [Attributes(9)]
   public sealed class DcsAntTimingRelToPaEnStart : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3073)]
    [Attributes(9)]
   public sealed class DcsAntTimingRelToPaEnStop : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2744)]
    [Attributes(9)]
   public sealed class DcsAutocalPwrDacF1 : ItemBase
    {
        public short Value1 { get; set; }


        public ushort Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(2767)]
    [Attributes(9)]
   public sealed class DcsAutocalPwrDacF2 : ItemBase
    {
        public short Value1 { get; set; }


        public ushort Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(3147)]
    [Attributes(9)]
   public sealed class DcsAutocalPwrDacF3 : ItemBase
    {
        public short Value1 { get; set; }


        public ushort Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(2779)]
    [Attributes(9)]
   public sealed class DcsBasebandBwVal : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2320)]
    [Attributes(9)]
   public sealed class DcsC0TxFreqComp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2323)]
    [Attributes(9)]
   public sealed class DcsC1TxFreqComp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(725)]
    [Attributes(9)]
   public sealed class DcsCalArfcn : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2751)]
    [Attributes(9)]
   public sealed class DcsCalpathRsb : FourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2326)]
    [Attributes(9)]
   public sealed class DcsEnableTxFreqCompVsPcl : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3506)]
    [Attributes(9)]
   public sealed class DcsGainrange5Switchpoints : TwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(917)]
    [Attributes(9)]
   public sealed class DcsGainrangeSwitchpoints : SixSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4133)]
    [Attributes(9)]
   public sealed class DcsGmskMultislot2TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4134)]
    [Attributes(9)]
   public sealed class DcsGmskMultislot3TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4135)]
    [Attributes(9)]
   public sealed class DcsGmskMultislot4TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4136)]
    [Attributes(9)]
   public sealed class DcsGmskMultislot5TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2775)]
    [Attributes(9)]
   public sealed class DcsOpllBwVal : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3065)]
    [Attributes(9)]
   public sealed class DcsPaEnStart : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3072)]
    [Attributes(9)]
   public sealed class DcsPaEnStop : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(803)]
    [Attributes(9)]
   public sealed class DcsPaGainSlope : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(821)]
    [Attributes(9)]
   public sealed class DcsPaStartTimeOffset : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(822)]
    [Attributes(9)]
   public sealed class DcsPaStopTimeOffset : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1287)]
    [Attributes(9)]
   public sealed class DcsPaTempCompIndex0 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1297)]
    [Attributes(9)]
   public sealed class DcsPaTempCompIndex10 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1298)]
    [Attributes(9)]
   public sealed class DcsPaTempCompIndex11 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1299)]
    [Attributes(9)]
   public sealed class DcsPaTempCompIndex12 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1300)]
    [Attributes(9)]
   public sealed class DcsPaTempCompIndex13 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1301)]
    [Attributes(9)]
   public sealed class DcsPaTempCompIndex14 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(935)]
    [Attributes(9)]
   public sealed class DcsPaTempCompIndex15 : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1288)]
    [Attributes(9)]
   public sealed class DcsPaTempCompIndex1 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1289)]
    [Attributes(9)]
   public sealed class DcsPaTempCompIndex2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1290)]
    [Attributes(9)]
   public sealed class DcsPaTempCompIndex3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1291)]
    [Attributes(9)]
   public sealed class DcsPaTempCompIndex4 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1292)]
    [Attributes(9)]
   public sealed class DcsPaTempCompIndex5 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1293)]
    [Attributes(9)]
   public sealed class DcsPaTempCompIndex6 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1294)]
    [Attributes(9)]
   public sealed class DcsPaTempCompIndex7 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1295)]
    [Attributes(9)]
   public sealed class DcsPaTempCompIndex8 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1296)]
    [Attributes(9)]
   public sealed class DcsPaTempCompIndex9 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1304)]
    [Attributes(9)]
   public sealed class DcsPaTempCompInt8Index15 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4370)]
    [Attributes(9)]
   public sealed class DcsPaTempCompMaxPwr : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2771)]
    [Attributes(9)]
   public sealed class DcsPolarPathDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3509)]
    [Attributes(9)]
   public sealed class DcsPolarRampProfile : SixtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3060)]
    [Attributes(9)]
   public sealed class DcsPowerLevels : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2122)]
    [Attributes(9)]
   public sealed class DcsPrdi00 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2123)]
    [Attributes(9)]
   public sealed class DcsPrdi01 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2124)]
    [Attributes(9)]
   public sealed class DcsPrdi02 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2125)]
    [Attributes(9)]
   public sealed class DcsPrdi03 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2126)]
    [Attributes(9)]
   public sealed class DcsPrdi04 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2127)]
    [Attributes(9)]
   public sealed class DcsPrdi05 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2128)]
    [Attributes(9)]
   public sealed class DcsPrdi06 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2129)]
    [Attributes(9)]
   public sealed class DcsPrdi07 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2130)]
    [Attributes(9)]
   public sealed class DcsPrdi08 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2131)]
    [Attributes(9)]
   public sealed class DcsPrdi09 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2132)]
    [Attributes(9)]
   public sealed class DcsPrdi10 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2133)]
    [Attributes(9)]
   public sealed class DcsPrdi11 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2134)]
    [Attributes(9)]
   public sealed class DcsPrdi12 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(816)]
    [Attributes(9)]
   public sealed class DcsPrechargeDur : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(814)]
    [Attributes(9)]
   public sealed class DcsPrecharge : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2109)]
    [Attributes(9)]
   public sealed class DcsPrui00 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2110)]
    [Attributes(9)]
   public sealed class DcsPrui01 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2111)]
    [Attributes(9)]
   public sealed class DcsPrui02 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2112)]
    [Attributes(9)]
   public sealed class DcsPrui03 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2113)]
    [Attributes(9)]
   public sealed class DcsPrui04 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2114)]
    [Attributes(9)]
   public sealed class DcsPrui05 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2115)]
    [Attributes(9)]
   public sealed class DcsPrui06 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2116)]
    [Attributes(9)]
   public sealed class DcsPrui07 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2117)]
    [Attributes(9)]
   public sealed class DcsPrui08 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2118)]
    [Attributes(9)]
   public sealed class DcsPrui09 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2119)]
    [Attributes(9)]
   public sealed class DcsPrui10 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2120)]
    [Attributes(9)]
   public sealed class DcsPrui11 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2121)]
    [Attributes(9)]
   public sealed class DcsPrui12 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3152)]
    [Attributes(9)]
   public sealed class DcsRtr6250Rsb : EightUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(730)]
    [Attributes(9)]
   public sealed class DcsRxGainRange1FreqComp : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4375)]
    [Attributes(9)]
   public sealed class DcsRxGainRange1TempComp : ThreeInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(731)]
    [Attributes(9)]
   public sealed class DcsRxGainRange2FreqComp : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4379)]
    [Attributes(9)]
   public sealed class DcsRxGainRange2TempComp : ThreeInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(732)]
    [Attributes(9)]
   public sealed class DcsRxGainRange3FreqComp : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4383)]
    [Attributes(9)]
   public sealed class DcsRxGainRange3TempComp : ThreeInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(733)]
    [Attributes(9)]
   public sealed class DcsRxGainRange4FreqComp : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4387)]
    [Attributes(9)]
   public sealed class DcsRxGainRange4TempComp : ThreeInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3503)]
    [Attributes(9)]
   public sealed class DcsRxGainRange5FreqComp : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4391)]
    [Attributes(9)]
   public sealed class DcsRxGainRange5TempComp : ThreeInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(786)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampDownIndex00 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(787)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampDownIndex01 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(788)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampDownIndex02 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(789)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampDownIndex03 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(790)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampDownIndex04 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(791)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampDownIndex05 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(792)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampDownIndex06 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(793)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampDownIndex07 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(794)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampDownIndex08 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(795)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampDownIndex09 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(796)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampDownIndex10 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(797)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampDownIndex11 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(798)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampDownIndex12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(799)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampDownIndex13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(800)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampDownIndex14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(801)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampDownIndex15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(770)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampUpIndex00 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(771)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampUpIndex01 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(772)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampUpIndex02 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(773)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampUpIndex03 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(774)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampUpIndex04 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(775)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampUpIndex05 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(776)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampUpIndex06 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(777)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampUpIndex07 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(778)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampUpIndex08 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(779)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampUpIndex09 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(780)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampUpIndex10 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(781)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampUpIndex11 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(782)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampUpIndex12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(783)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampUpIndex13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(784)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampUpIndex14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(785)]
    [Attributes(9)]
   public sealed class DcsTxBurstRampUpIndex15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(805)]
    [Attributes(9)]
   public sealed class DcsTxFreqComp : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4180)]
    [Attributes(9)]
   public sealed class DcsTxRsbCorr : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(808)]
    [Attributes(9)]
   public sealed class DcsVbattHiPaComp : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(809)]
    [Attributes(9)]
   public sealed class DcsVbattLoPaComp : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2312)]
    [Attributes(9)]
   public sealed class DcsVhThBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2311)]
    [Attributes(9)]
   public sealed class DcsVhThBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2310)]
    [Attributes(9)]
   public sealed class DcsVhThBrdi15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2309)]
    [Attributes(9)]
   public sealed class DcsVhThBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2308)]
    [Attributes(9)]
   public sealed class DcsVhThBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2307)]
    [Attributes(9)]
   public sealed class DcsVhThBrui15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2490)]
    [Attributes(9)]
   public sealed class DcsVhThPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2489)]
    [Attributes(9)]
   public sealed class DcsVhThPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2488)]
    [Attributes(9)]
   public sealed class DcsVhThPrdi15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2487)]
    [Attributes(9)]
   public sealed class DcsVhThPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2486)]
    [Attributes(9)]
   public sealed class DcsVhThPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2485)]
    [Attributes(9)]
   public sealed class DcsVhThPrui15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2204)]
    [Attributes(9)]
   public sealed class DcsVhTlBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2203)]
    [Attributes(9)]
   public sealed class DcsVhTlBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2202)]
    [Attributes(9)]
   public sealed class DcsVhTlBrdi15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2201)]
    [Attributes(9)]
   public sealed class DcsVhTlBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2200)]
    [Attributes(9)]
   public sealed class DcsVhTlBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2199)]
    [Attributes(9)]
   public sealed class DcsVhTlBrui15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2382)]
    [Attributes(9)]
   public sealed class DcsVhTlPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2381)]
    [Attributes(9)]
   public sealed class DcsVhTlPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2380)]
    [Attributes(9)]
   public sealed class DcsVhTlPrdi15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2379)]
    [Attributes(9)]
   public sealed class DcsVhTlPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2378)]
    [Attributes(9)]
   public sealed class DcsVhTlPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2377)]
    [Attributes(9)]
   public sealed class DcsVhTlPrui15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2258)]
    [Attributes(9)]
   public sealed class DcsVhTmBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2257)]
    [Attributes(9)]
   public sealed class DcsVhTmBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2256)]
    [Attributes(9)]
   public sealed class DcsVhTmBrdi15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2255)]
    [Attributes(9)]
   public sealed class DcsVhTmBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2254)]
    [Attributes(9)]
   public sealed class DcsVhTmBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2253)]
    [Attributes(9)]
   public sealed class DcsVhTmBrui15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2436)]
    [Attributes(9)]
   public sealed class DcsVhTmPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2435)]
    [Attributes(9)]
   public sealed class DcsVhTmPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2434)]
    [Attributes(9)]
   public sealed class DcsVhTmPrdi15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2433)]
    [Attributes(9)]
   public sealed class DcsVhTmPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2432)]
    [Attributes(9)]
   public sealed class DcsVhTmPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2431)]
    [Attributes(9)]
   public sealed class DcsVhTmPrui15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2276)]
    [Attributes(9)]
   public sealed class DcsVlThBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2275)]
    [Attributes(9)]
   public sealed class DcsVlThBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2274)]
    [Attributes(9)]
   public sealed class DcsVlThBrdi15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2273)]
    [Attributes(9)]
   public sealed class DcsVlThBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2272)]
    [Attributes(9)]
   public sealed class DcsVlThBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2271)]
    [Attributes(9)]
   public sealed class DcsVlThBrui15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2454)]
    [Attributes(9)]
   public sealed class DcsVlThPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2453)]
    [Attributes(9)]
   public sealed class DcsVlThPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2452)]
    [Attributes(9)]
   public sealed class DcsVlThPrdi15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2451)]
    [Attributes(9)]
   public sealed class DcsVlThPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2450)]
    [Attributes(9)]
   public sealed class DcsVlThPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2449)]
    [Attributes(9)]
   public sealed class DcsVlThPrui15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2168)]
    [Attributes(9)]
   public sealed class DcsVlTlBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2167)]
    [Attributes(9)]
   public sealed class DcsVlTlBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2166)]
    [Attributes(9)]
   public sealed class DcsVlTlBrdi15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2165)]
    [Attributes(9)]
   public sealed class DcsVlTlBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2164)]
    [Attributes(9)]
   public sealed class DcsVlTlBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2163)]
    [Attributes(9)]
   public sealed class DcsVlTlBrui15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2346)]
    [Attributes(9)]
   public sealed class DcsVlTlPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2345)]
    [Attributes(9)]
   public sealed class DcsVlTlPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2344)]
    [Attributes(9)]
   public sealed class DcsVlTlPrdi15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2343)]
    [Attributes(9)]
   public sealed class DcsVlTlPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2342)]
    [Attributes(9)]
   public sealed class DcsVlTlPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2341)]
    [Attributes(9)]
   public sealed class DcsVlTlPrui15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2222)]
    [Attributes(9)]
   public sealed class DcsVlTmBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2221)]
    [Attributes(9)]
   public sealed class DcsVlTmBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2220)]
    [Attributes(9)]
   public sealed class DcsVlTmBrdi15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2219)]
    [Attributes(9)]
   public sealed class DcsVlTmBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2218)]
    [Attributes(9)]
   public sealed class DcsVlTmBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2217)]
    [Attributes(9)]
   public sealed class DcsVlTmBrui15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2400)]
    [Attributes(9)]
   public sealed class DcsVlTmPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2399)]
    [Attributes(9)]
   public sealed class DcsVlTmPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2398)]
    [Attributes(9)]
   public sealed class DcsVlTmPrdi15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2397)]
    [Attributes(9)]
   public sealed class DcsVlTmPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2396)]
    [Attributes(9)]
   public sealed class DcsVlTmPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2395)]
    [Attributes(9)]
   public sealed class DcsVlTmPrui15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2294)]
    [Attributes(9)]
   public sealed class DcsVmThBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2293)]
    [Attributes(9)]
   public sealed class DcsVmThBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2292)]
    [Attributes(9)]
   public sealed class DcsVmThBrdi15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2291)]
    [Attributes(9)]
   public sealed class DcsVmThBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2290)]
    [Attributes(9)]
   public sealed class DcsVmThBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2289)]
    [Attributes(9)]
   public sealed class DcsVmThBrui15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2472)]
    [Attributes(9)]
   public sealed class DcsVmThPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2471)]
    [Attributes(9)]
   public sealed class DcsVmThPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2470)]
    [Attributes(9)]
   public sealed class DcsVmThPrdi15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2469)]
    [Attributes(9)]
   public sealed class DcsVmThPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2468)]
    [Attributes(9)]
   public sealed class DcsVmThPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2467)]
    [Attributes(9)]
   public sealed class DcsVmThPrui15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2186)]
    [Attributes(9)]
   public sealed class DcsVmTlBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2185)]
    [Attributes(9)]
   public sealed class DcsVmTlBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2184)]
    [Attributes(9)]
   public sealed class DcsVmTlBrdi15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2183)]
    [Attributes(9)]
   public sealed class DcsVmTlBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2182)]
    [Attributes(9)]
   public sealed class DcsVmTlBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2181)]
    [Attributes(9)]
   public sealed class DcsVmTlBrui15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2364)]
    [Attributes(9)]
   public sealed class DcsVmTlPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2363)]
    [Attributes(9)]
   public sealed class DcsVmTlPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2362)]
    [Attributes(9)]
   public sealed class DcsVmTlPrdi15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2361)]
    [Attributes(9)]
   public sealed class DcsVmTlPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2360)]
    [Attributes(9)]
   public sealed class DcsVmTlPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2359)]
    [Attributes(9)]
   public sealed class DcsVmTlPrui15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2240)]
    [Attributes(9)]
   public sealed class DcsVmTmBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2239)]
    [Attributes(9)]
   public sealed class DcsVmTmBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2238)]
    [Attributes(9)]
   public sealed class DcsVmTmBrdi15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2237)]
    [Attributes(9)]
   public sealed class DcsVmTmBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2236)]
    [Attributes(9)]
   public sealed class DcsVmTmBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2235)]
    [Attributes(9)]
   public sealed class DcsVmTmBrui15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2418)]
    [Attributes(9)]
   public sealed class DcsVmTmPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2417)]
    [Attributes(9)]
   public sealed class DcsVmTmPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2416)]
    [Attributes(9)]
   public sealed class DcsVmTmPrdi15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2415)]
    [Attributes(9)]
   public sealed class DcsVmTmPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2414)]
    [Attributes(9)]
   public sealed class DcsVmTmPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2413)]
    [Attributes(9)]
   public sealed class DcsVmTmPrui15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4399)]
    [Attributes(9)]
   public sealed class DetectHWReset : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(610)]
    [Attributes(9)]
   public sealed class DfmAgcAccMin1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(612)]
    [Attributes(9)]
   public sealed class DfmAgcDcGain : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(611)]
    [Attributes(9)]
   public sealed class DfmAgcImGain : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(613)]
    [Attributes(9)]
   public sealed class DfmImLevel1 : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(606)]
    [Attributes(9)]
   public sealed class DfmLnaFall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(607)]
    [Attributes(9)]
   public sealed class DfmLnaOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(609)]
    [Attributes(9)]
   public sealed class DfmLnaOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(608)]
    [Attributes(9)]
   public sealed class DfmLnaRise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(617)]
    [Attributes(9)]
   public sealed class DfmLnaS0PhaseOffset : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(618)]
    [Attributes(9)]
   public sealed class DfmLnaS1PhaseOffset : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1892)]
    [Attributes(9)]
   public sealed class DiagDebugControl : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1895)]
    [Attributes(9)]
   public sealed class DiagDebugDetail : SByteItemBase
    {
    }

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
   public sealed class DigitalAnalogModePreference : ItemBase
    {
        public byte Nam { get; set; }

        [JsonIgnore]
        public ushort Mode { get; set; }

        public string StringMode
        {
            get => $"{(DigitalAnalogPreferenceMode) Mode}";
            set => Mode = EnumUtils.ParseEnumByte(typeof(DigitalAnalogPreferenceMode), value);
        }
    }

    [Serializable]
    [NvItemId(615)]
    [Attributes(9)]
   public sealed class DigitalFgTrkOffsetScaler : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(702)]
    [Attributes(9)]
   public sealed class DigitalMisCompAOffset : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(705)]
    [Attributes(9)]
   public sealed class DigitalMisCompBOffset : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(817)]
    [Attributes(9)]
   public sealed class DigitalPllLockTimer : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5280)]
    [Attributes(9)]
   public sealed class DisableCmCallType : UInt64ItemBase
    {
    }

    [Serializable]
    [NvItemId(4396)]
    [Attributes(9)]
   public sealed class DsMobileIpDeregistrationRetries : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3628)]
    [Attributes(9)]
   public sealed class DtmFeatureSupport : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3629)]
    [Attributes(9)]
   public sealed class DtmMultislotClass : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6876)]
    [Attributes(25)]
   public sealed class DualStandbyConfigItems : ItemBase
    {
        public byte DedicatedVoiceSubs { get; set; }


        public byte DedicatedDataSubs { get; set; }


        public byte ActiveSubs { get; set; }


        public byte PrioritySubs { get; set; }


        public byte DualStandbyPref { get; set; }


        public byte Reserved { get; set; }
    }

    [Serializable]
    [NvItemId(3630)]
    [Attributes(9)]
   public sealed class EdaFeatureSupport : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6476)]
    [Attributes(9)]
   public sealed class Edge1800LinearTxGainParam : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5552)]
    [Attributes(9)]
   public sealed class Edge1800PmeasG0F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5556)]
    [Attributes(9)]
   public sealed class Edge1800PmeasG0F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5560)]
    [Attributes(9)]
   public sealed class Edge1800PmeasG0F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5553)]
    [Attributes(9)]
   public sealed class Edge1800PmeasG1F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5557)]
    [Attributes(9)]
   public sealed class Edge1800PmeasG1F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5561)]
    [Attributes(9)]
   public sealed class Edge1800PmeasG1F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5554)]
    [Attributes(9)]
   public sealed class Edge1800PmeasG2F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5558)]
    [Attributes(9)]
   public sealed class Edge1800PmeasG2F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5562)]
    [Attributes(9)]
   public sealed class Edge1800PmeasG2F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5555)]
    [Attributes(9)]
   public sealed class Edge1800PmeasG3F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5559)]
    [Attributes(9)]
   public sealed class Edge1800PmeasG3F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5563)]
    [Attributes(9)]
   public sealed class Edge1800PmeasG3F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5504)]
    [Attributes(9)]
   public sealed class Edge1800RgiG0F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5508)]
    [Attributes(9)]
   public sealed class Edge1800RgiG0F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5512)]
    [Attributes(9)]
   public sealed class Edge1800RgiG0F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5505)]
    [Attributes(9)]
   public sealed class Edge1800RgiG1F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5509)]
    [Attributes(9)]
   public sealed class Edge1800RgiG1F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5513)]
    [Attributes(9)]
   public sealed class Edge1800RgiG1F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5506)]
    [Attributes(9)]
   public sealed class Edge1800RgiG2F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5510)]
    [Attributes(9)]
   public sealed class Edge1800RgiG2F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5514)]
    [Attributes(9)]
   public sealed class Edge1800RgiG2F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5507)]
    [Attributes(9)]
   public sealed class Edge1800RgiG3F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5511)]
    [Attributes(9)]
   public sealed class Edge1800RgiG3F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5515)]
    [Attributes(9)]
   public sealed class Edge1800RgiG3F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6477)]
    [Attributes(9)]
   public sealed class Edge1900LinearTxGainParam : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5564)]
    [Attributes(9)]
   public sealed class Edge1900PmeasG0F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5568)]
    [Attributes(9)]
   public sealed class Edge1900PmeasG0F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5572)]
    [Attributes(9)]
   public sealed class Edge1900PmeasG0F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5565)]
    [Attributes(9)]
   public sealed class Edge1900PmeasG1F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5569)]
    [Attributes(9)]
   public sealed class Edge1900PmeasG1F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5573)]
    [Attributes(9)]
   public sealed class Edge1900PmeasG1F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5566)]
    [Attributes(9)]
   public sealed class Edge1900PmeasG2F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5570)]
    [Attributes(9)]
   public sealed class Edge1900PmeasG2F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5574)]
    [Attributes(9)]
   public sealed class Edge1900PmeasG2F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5567)]
    [Attributes(9)]
   public sealed class Edge1900PmeasG3F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5571)]
    [Attributes(9)]
   public sealed class Edge1900PmeasG3F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5575)]
    [Attributes(9)]
   public sealed class Edge1900PmeasG3F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5516)]
    [Attributes(9)]
   public sealed class Edge1900RgiG0F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5520)]
    [Attributes(9)]
   public sealed class Edge1900RgiG0F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5524)]
    [Attributes(9)]
   public sealed class Edge1900RgiG0F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5517)]
    [Attributes(9)]
   public sealed class Edge1900RgiG1F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5521)]
    [Attributes(9)]
   public sealed class Edge1900RgiG1F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5525)]
    [Attributes(9)]
   public sealed class Edge1900RgiG1F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5518)]
    [Attributes(9)]
   public sealed class Edge1900RgiG2F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5522)]
    [Attributes(9)]
   public sealed class Edge1900RgiG2F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5526)]
    [Attributes(9)]
   public sealed class Edge1900RgiG2F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5519)]
    [Attributes(9)]
   public sealed class Edge1900RgiG3F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5523)]
    [Attributes(9)]
   public sealed class Edge1900RgiG3F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5527)]
    [Attributes(9)]
   public sealed class Edge1900RgiG3F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6475)]
    [Attributes(9)]
   public sealed class Edge850LinearTxGainParam : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5528)]
    [Attributes(9)]
   public sealed class Edge850PmeasG0F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5532)]
    [Attributes(9)]
   public sealed class Edge850PmeasG0F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5536)]
    [Attributes(9)]
   public sealed class Edge850PmeasG0F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5529)]
    [Attributes(9)]
   public sealed class Edge850PmeasG1F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5533)]
    [Attributes(9)]
   public sealed class Edge850PmeasG1F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5537)]
    [Attributes(9)]
   public sealed class Edge850PmeasG1F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5530)]
    [Attributes(9)]
   public sealed class Edge850PmeasG2F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5534)]
    [Attributes(9)]
   public sealed class Edge850PmeasG2F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5538)]
    [Attributes(9)]
   public sealed class Edge850PmeasG2F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5531)]
    [Attributes(9)]
   public sealed class Edge850PmeasG3F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5535)]
    [Attributes(9)]
   public sealed class Edge850PmeasG3F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5539)]
    [Attributes(9)]
   public sealed class Edge850PmeasG3F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5480)]
    [Attributes(9)]
   public sealed class Edge850RgiG0F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5484)]
    [Attributes(9)]
   public sealed class Edge850RgiG0F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5488)]
    [Attributes(9)]
   public sealed class Edge850RgiG0F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5481)]
    [Attributes(9)]
   public sealed class Edge850RgiG1F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5485)]
    [Attributes(9)]
   public sealed class Edge850RgiG1F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5489)]
    [Attributes(9)]
   public sealed class Edge850RgiG1F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5482)]
    [Attributes(9)]
   public sealed class Edge850RgiG2F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5486)]
    [Attributes(9)]
   public sealed class Edge850RgiG2F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5490)]
    [Attributes(9)]
   public sealed class Edge850RgiG2F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5483)]
    [Attributes(9)]
   public sealed class Edge850RgiG3F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5487)]
    [Attributes(9)]
   public sealed class Edge850RgiG3F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5491)]
    [Attributes(9)]
   public sealed class Edge850RgiG3F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5540)]
    [Attributes(9)]
   public sealed class Edge900PmeasG0F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5544)]
    [Attributes(9)]
   public sealed class Edge900PmeasG0F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5548)]
    [Attributes(9)]
   public sealed class Edge900PmeasG0F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5541)]
    [Attributes(9)]
   public sealed class Edge900PmeasG1F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5545)]
    [Attributes(9)]
   public sealed class Edge900PmeasG1F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5549)]
    [Attributes(9)]
   public sealed class Edge900PmeasG1F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5542)]
    [Attributes(9)]
   public sealed class Edge900PmeasG2F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5546)]
    [Attributes(9)]
   public sealed class Edge900PmeasG2F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5550)]
    [Attributes(9)]
   public sealed class Edge900PmeasG2F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5543)]
    [Attributes(9)]
   public sealed class Edge900PmeasG3F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5547)]
    [Attributes(9)]
   public sealed class Edge900PmeasG3F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5551)]
    [Attributes(9)]
   public sealed class Edge900PmeasG3F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5492)]
    [Attributes(9)]
   public sealed class Edge900RgiG0F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5496)]
    [Attributes(9)]
   public sealed class Edge900RgiG0F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5500)]
    [Attributes(9)]
   public sealed class Edge900RgiG0F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5493)]
    [Attributes(9)]
   public sealed class Edge900RgiG1F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5497)]
    [Attributes(9)]
   public sealed class Edge900RgiG1F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5501)]
    [Attributes(9)]
   public sealed class Edge900RgiG1F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5494)]
    [Attributes(9)]
   public sealed class Edge900RgiG2F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5498)]
    [Attributes(9)]
   public sealed class Edge900RgiG2F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5502)]
    [Attributes(9)]
   public sealed class Edge900RgiG2F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5495)]
    [Attributes(9)]
   public sealed class Edge900RgiG3F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5499)]
    [Attributes(9)]
   public sealed class Edge900RgiG3F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5503)]
    [Attributes(9)]
   public sealed class Edge900RgiG3F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2508)]
    [Attributes(9)]
   public sealed class EdgeFeatureSupport : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5478)]
    [Attributes(9)]
   public sealed class EdgeLinearTxGainParam : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2509)]
    [Attributes(9)]
   public sealed class EdgeMultislotClass : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4209)]
    [Attributes(9)]
   public sealed class EDtmFeatureSupport : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6248)]
    [Attributes(9)]
   public sealed class EhrpdEnabled : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6844)]
    [Attributes(9)]
   public sealed class EnhancedHplmnSrchTbl : ItemBase
    {
        [JsonIgnore]
        [FieldCount(100)]
        public byte[] Value { get; set; }

        public string ValueString
        {
            get => StringUtils.GetString(Value);
            set => Value = StringUtils.GetBytes(value, 100);
        }
    }

    [Serializable]
    [NvItemId(5479)]
    [Attributes(9)]
   public sealed class EnhTherm : TwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3461)]
    [Attributes(9)]
   public sealed class EnsEnabled : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(285)]
    [Attributes(41)]
   public sealed class EvrcVoiceServiceOptions : ItemBase
    {
        public byte Nam { get; set; }


        public byte EvrcCapabilityEnabled { get; set; }


        public ushort HomePageVoiceSo { get; set; }


        public ushort HomeOrigVoiceSo { get; set; }


        public ushort RoamOrigVoiceSo { get; set; }
    }

    [Serializable]
    [NvItemId(946)]
    [Attributes(41)]
   public sealed class ExpandBandPreference16To32Bits : ItemBase
    {
        public byte Nam { get; set; }


        public short Value { get; set; }
    }

    [Serializable]
    [NvItemId(2497)]
    [Attributes(9)]
   public sealed class FactoryData1 : ItemBase
    {
        [FieldCount(128)]
        public byte[] Value { get; set; }
    }

    [Serializable]
    [NvItemId(2498)]
    [Attributes(9)]
   public sealed class FactoryData2 : ItemBase
    {
        [FieldCount(128)]
        public byte[] Value { get; set; }
    }

    [Serializable]
    [NvItemId(2499)]
    [Attributes(9)]
   public sealed class FactoryData3 : ItemBase
    {
        [FieldCount(128)]
        public byte[] Value { get; set; }
    }

    [Serializable]
    [NvItemId(2500)]
    [Attributes(9)]
   public sealed class FactoryData4 : ItemBase
    {
        [FieldCount(128)]
        public byte[] Value { get; set; }
    }

    [Serializable]
    [NvItemId(453)]
    [Attributes(9)]
   public sealed class FactoryTestmodePhoneMode : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(905)]
    [Attributes(9)]
   public sealed class FatalErrorOption : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(146)]
    [Attributes(9)]
   public sealed class FmAgcAdjVsFreq : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(147)]
    [Attributes(9)]
   public sealed class FmAgcAdjVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(194)]
    [Attributes(9)]
   public sealed class FmAgc : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(122)]
    [Attributes(9)]
   public sealed class FmAgcSetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(121)]
    [Attributes(9)]
   public sealed class FmAgcSetVsPwr : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(123)]
    [Attributes(9)]
   public sealed class FmAgcSetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(637)]
    [Attributes(9)]
   public sealed class FmDaccEstIoffset : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(641)]
    [Attributes(9)]
   public sealed class FmDaccEstQoffset : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(685)]
    [Attributes(9)]
   public sealed class FmDaccGainMult : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(645)]
    [Attributes(9)]
   public sealed class FmDaccIaccum0 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(649)]
    [Attributes(9)]
   public sealed class FmDaccIaccum1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(653)]
    [Attributes(9)]
   public sealed class FmDaccIaccum2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(657)]
    [Attributes(9)]
   public sealed class FmDaccIaccum3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(661)]
    [Attributes(9)]
   public sealed class FmDaccIaccum4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(665)]
    [Attributes(9)]
   public sealed class FmDaccQaccum0 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(669)]
    [Attributes(9)]
   public sealed class FmDaccQaccum1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(673)]
    [Attributes(9)]
   public sealed class FmDaccQaccum2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(677)]
    [Attributes(9)]
   public sealed class FmDaccQaccum3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(681)]
    [Attributes(9)]
   public sealed class FmDaccQaccum4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(125)]
    [Attributes(9)]
   public sealed class FmErrSlpVsPwr : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(124)]
    [Attributes(9)]
   public sealed class FmExpHdetVsPwr : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(206)]
    [Attributes(9)]
   public sealed class FmExpHdetVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(616)]
    [Attributes(9)]
   public sealed class FmFgTrkOffsetScaler : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(126)]
    [Attributes(9)]
   public sealed class FmFreqSenseGain : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(311)]
    [Attributes(9)]
   public sealed class FmHdetAdcRange : SixByteItemBase
    {
    }

    [Serializable]
    [NvItemId(190)]
    [Attributes(9)]
   public sealed class FmLnaCtl : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(701)]
    [Attributes(9)]
   public sealed class FmMisCompAOffset : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(704)]
    [Attributes(9)]
   public sealed class FmMisCompBOffset : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(877)]
    [Attributes(9)]
   public sealed class FmPaMacHigh : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(95)]
    [Attributes(9)]
   public sealed class FmRssi : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(621)]
    [Attributes(9)]
   public sealed class FmRxfCgIoffset : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(625)]
    [Attributes(9)]
   public sealed class FmRxfCgQoffset : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(629)]
    [Attributes(9)]
   public sealed class FmRxfFgIoffset : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(633)]
    [Attributes(9)]
   public sealed class FmRxfFgQoffset : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(692)]
    [Attributes(9)]
   public sealed class FmVgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(695)]
    [Attributes(9)]
   public sealed class FmVgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(698)]
    [Attributes(9)]
   public sealed class FmVgaGainOffsetVsTemp : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1031)]
    [Attributes(9)]
   public sealed class ForceUemsCrGsmR99Version : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1030)]
    [Attributes(9)]
   public sealed class ForceUesgSnrGsmR99Version : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(92)]
    [Attributes(9)]
   public sealed class FrTempOffset : SixtyFourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7165)]
    [Attributes(9)]
   public sealed class GnssOemFeatureMask : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(947)]
    [Attributes(9)]
   public sealed class GprsEnableAniteGcf51010 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(911)]
    [Attributes(9)]
   public sealed class GprsMultiSlotClass : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(444)]
    [Attributes(9)]
   public sealed class Gps1CdmaRfDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(443)]
    [Attributes(9)]
   public sealed class Gps1GpsRfDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(449)]
    [Attributes(9)]
   public sealed class Gps1GpsRfLoss : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(638)]
    [Attributes(9)]
   public sealed class GpsDaccEstIoffset : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(642)]
    [Attributes(9)]
   public sealed class GpsDaccEstQoffset : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(686)]
    [Attributes(9)]
   public sealed class GpsDaccGainMult : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(646)]
    [Attributes(9)]
   public sealed class GpsDaccIaccum0 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(650)]
    [Attributes(9)]
   public sealed class GpsDaccIaccum1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(654)]
    [Attributes(9)]
   public sealed class GpsDaccIaccum2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(658)]
    [Attributes(9)]
   public sealed class GpsDaccIaccum3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(662)]
    [Attributes(9)]
   public sealed class GpsDaccIaccum4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(666)]
    [Attributes(9)]
   public sealed class GpsDaccQaccum0 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(670)]
    [Attributes(9)]
   public sealed class GpsDaccQaccum1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(674)]
    [Attributes(9)]
   public sealed class GpsDaccQaccum2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(678)]
    [Attributes(9)]
   public sealed class GpsDaccQaccum3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(682)]
    [Attributes(9)]
   public sealed class GpsDaccQaccum4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6273)]
    [Attributes(9)]
   public sealed class GpsDefaultOperatingMode : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6274)]
    [Attributes(9)]
   public sealed class GpsDefaultTbf : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(4200)]
    [Attributes(9)]
   public sealed class GpsDrxModeSel : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(614)]
    [Attributes(9)]
   public sealed class GpsFgTrkOffsetScaler : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(703)]
    [Attributes(9)]
   public sealed class GpsMisCompAOffset : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(706)]
    [Attributes(9)]
   public sealed class GpsMisCompBOffset : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(1032)]
    [Attributes(9)]
   public sealed class GpsRfConfig : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(622)]
    [Attributes(9)]
   public sealed class GpsRxfCgIoffset : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(626)]
    [Attributes(9)]
   public sealed class GpsRxfCgQoffset : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(630)]
    [Attributes(9)]
   public sealed class GpsRxfFgIoffset : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(634)]
    [Attributes(9)]
   public sealed class GpsRxfFgQoffset : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5625)]
    [Attributes(9)]
   public sealed class Gsm1800AmamLinearPaRangeaF1Seg1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5626)]
    [Attributes(9)]
   public sealed class Gsm1800AmamLinearPaRangeaF1Seg2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5629)]
    [Attributes(9)]
   public sealed class Gsm1800AmamLinearPaRangeaF2Seg1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5630)]
    [Attributes(9)]
   public sealed class Gsm1800AmamLinearPaRangeaF2Seg2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5633)]
    [Attributes(9)]
   public sealed class Gsm1800AmamLinearPaRangeaF3Seg1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5634)]
    [Attributes(9)]
   public sealed class Gsm1800AmamLinearPaRangeaF3Seg2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5627)]
    [Attributes(9)]
   public sealed class Gsm1800AmamLinearPaRangebF1Seg1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5628)]
    [Attributes(9)]
   public sealed class Gsm1800AmamLinearPaRangebF1Seg2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5631)]
    [Attributes(9)]
   public sealed class Gsm1800AmamLinearPaRangebF2Seg1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5632)]
    [Attributes(9)]
   public sealed class Gsm1800AmamLinearPaRangebF2Seg2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5635)]
    [Attributes(9)]
   public sealed class Gsm1800AmamLinearPaRangebF3Seg1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5636)]
    [Attributes(9)]
   public sealed class Gsm1800AmamLinearPaRangebF3Seg2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5673)]
    [Attributes(9)]
   public sealed class Gsm1800AmpmLinearPaRangeaF1Seg1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5674)]
    [Attributes(9)]
   public sealed class Gsm1800AmpmLinearPaRangeaF1Seg2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5677)]
    [Attributes(9)]
   public sealed class Gsm1800AmpmLinearPaRangeaF2Seg1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5678)]
    [Attributes(9)]
   public sealed class Gsm1800AmpmLinearPaRangeaF2Seg2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5681)]
    [Attributes(9)]
   public sealed class Gsm1800AmpmLinearPaRangeaF3Seg1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5682)]
    [Attributes(9)]
   public sealed class Gsm1800AmpmLinearPaRangeaF3Seg2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5675)]
    [Attributes(9)]
   public sealed class Gsm1800AmpmLinearPaRangebF1Seg1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5676)]
    [Attributes(9)]
   public sealed class Gsm1800AmpmLinearPaRangebF1Seg2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5679)]
    [Attributes(9)]
   public sealed class Gsm1800AmpmLinearPaRangebF2Seg1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5680)]
    [Attributes(9)]
   public sealed class Gsm1800AmpmLinearPaRangebF2Seg2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5683)]
    [Attributes(9)]
   public sealed class Gsm1800AmpmLinearPaRangebF3Seg1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5684)]
    [Attributes(9)]
   public sealed class Gsm1800AmpmLinearPaRangebF3Seg2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5390)]
    [Attributes(9)]
   public sealed class Gsm1800EdgePaLoToMid : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5391)]
    [Attributes(9)]
   public sealed class Gsm1800EdgePaMidToHi : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5272)]
    [Attributes(9)]
   public sealed class Gsm1800KvCalChan : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5068)]
    [Attributes(9)]
   public sealed class Gsm1800KvCal : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5382)]
    [Attributes(9)]
   public sealed class Gsm1800KvVsTemp : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6296)]
    [Attributes(9)]
   public sealed class Gsm1800LinearEnvdcCalVal : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6350)]
    [Attributes(9)]
   public sealed class Gsm1800LinearPaR0TempComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6375)]
    [Attributes(9)]
   public sealed class Gsm1800LinearPaR0VbattHiComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6374)]
    [Attributes(9)]
   public sealed class Gsm1800LinearPaR0VbattLoComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6351)]
    [Attributes(9)]
   public sealed class Gsm1800LinearPaR1TempComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6377)]
    [Attributes(9)]
   public sealed class Gsm1800LinearPaR1VbattHiComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6376)]
    [Attributes(9)]
   public sealed class Gsm1800LinearPaR1VbattLoComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6352)]
    [Attributes(9)]
   public sealed class Gsm1800LinearPaR2TempComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6379)]
    [Attributes(9)]
   public sealed class Gsm1800LinearPaR2VbattHiComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6378)]
    [Attributes(9)]
   public sealed class Gsm1800LinearPaR2VbattLoComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6353)]
    [Attributes(9)]
   public sealed class Gsm1800LinearPaR3TempComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6381)]
    [Attributes(9)]
   public sealed class Gsm1800LinearPaR3VbattHiComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6380)]
    [Attributes(9)]
   public sealed class Gsm1800LinearPaR3VbattLoComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5397)]
    [Attributes(9)]
   public sealed class Gsm1800LinearPaTempComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6473)]
    [Attributes(9)]
   public sealed class Gsm1800LinearTxGainParam : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5287)]
    [Attributes(9)]
   public sealed class Gsm1800PadacDcOffset : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5369)]
    [Attributes(9)]
   public sealed class Gsm1800PaPredistSwpt1 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5370)]
    [Attributes(9)]
   public sealed class Gsm1800PaPredistSwpt2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5355)]
    [Attributes(9)]
   public sealed class Gsm1800PaR1ToR2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5356)]
    [Attributes(9)]
   public sealed class Gsm1800PaR2ToR4 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5339)]
    [Attributes(9)]
   public sealed class Gsm1800PmeasG0F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5343)]
    [Attributes(9)]
   public sealed class Gsm1800PmeasG0F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5423)]
    [Attributes(9)]
   public sealed class Gsm1800PmeasG0F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5340)]
    [Attributes(9)]
   public sealed class Gsm1800PmeasG1F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5344)]
    [Attributes(9)]
   public sealed class Gsm1800PmeasG1F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5424)]
    [Attributes(9)]
   public sealed class Gsm1800PmeasG1F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5341)]
    [Attributes(9)]
   public sealed class Gsm1800PmeasG2F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5345)]
    [Attributes(9)]
   public sealed class Gsm1800PmeasG2F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5425)]
    [Attributes(9)]
   public sealed class Gsm1800PmeasG2F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5342)]
    [Attributes(9)]
   public sealed class Gsm1800PmeasG3F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5346)]
    [Attributes(9)]
   public sealed class Gsm1800PmeasG3F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5426)]
    [Attributes(9)]
   public sealed class Gsm1800PmeasG3F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5307)]
    [Attributes(9)]
   public sealed class Gsm1800RgiG0F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5311)]
    [Attributes(9)]
   public sealed class Gsm1800RgiG0F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5407)]
    [Attributes(9)]
   public sealed class Gsm1800RgiG0F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5308)]
    [Attributes(9)]
   public sealed class Gsm1800RgiG1F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5312)]
    [Attributes(9)]
   public sealed class Gsm1800RgiG1F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5408)]
    [Attributes(9)]
   public sealed class Gsm1800RgiG1F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5309)]
    [Attributes(9)]
   public sealed class Gsm1800RgiG2F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5313)]
    [Attributes(9)]
   public sealed class Gsm1800RgiG2F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5409)]
    [Attributes(9)]
   public sealed class Gsm1800RgiG2F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5310)]
    [Attributes(9)]
   public sealed class Gsm1800RgiG3F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5314)]
    [Attributes(9)]
   public sealed class Gsm1800RgiG3F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5410)]
    [Attributes(9)]
   public sealed class Gsm1800RgiG3F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5093)]
    [Attributes(9)]
   public sealed class Gsm1800SmpsPdmTbl : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5699)]
    [Attributes(9)]
   public sealed class Gsm1800TxAgcSettingForPred : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4153)]
    [Attributes(9)]
   public sealed class Gsm19008pskMultislot2TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4154)]
    [Attributes(9)]
   public sealed class Gsm19008pskMultislot3TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4155)]
    [Attributes(9)]
   public sealed class Gsm19008pskMultislot4TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4156)]
    [Attributes(9)]
   public sealed class Gsm19008pskMultislot5TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2761)]
    [Attributes(9)]
   public sealed class Gsm1900AmamArfcnF1 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2765)]
    [Attributes(9)]
   public sealed class Gsm1900AmamArfcnF2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3145)]
    [Attributes(9)]
   public sealed class Gsm1900AmamArfcnF3 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2749)]
    [Attributes(9)]
   public sealed class Gsm1900AmamDynamicRange : TwoInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5637)]
    [Attributes(9)]
   public sealed class Gsm1900AmamLinearPaRangeaF1Seg1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5638)]
    [Attributes(9)]
   public sealed class Gsm1900AmamLinearPaRangeaF1Seg2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5641)]
    [Attributes(9)]
   public sealed class Gsm1900AmamLinearPaRangeaF2Seg1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5642)]
    [Attributes(9)]
   public sealed class Gsm1900AmamLinearPaRangeaF2Seg2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5645)]
    [Attributes(9)]
   public sealed class Gsm1900AmamLinearPaRangeaF3Seg1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5646)]
    [Attributes(9)]
   public sealed class Gsm1900AmamLinearPaRangeaF3Seg2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5639)]
    [Attributes(9)]
   public sealed class Gsm1900AmamLinearPaRangebF1Seg1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5640)]
    [Attributes(9)]
   public sealed class Gsm1900AmamLinearPaRangebF1Seg2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5643)]
    [Attributes(9)]
   public sealed class Gsm1900AmamLinearPaRangebF2Seg1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5644)]
    [Attributes(9)]
   public sealed class Gsm1900AmamLinearPaRangebF2Seg2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5647)]
    [Attributes(9)]
   public sealed class Gsm1900AmamLinearPaRangebF3Seg1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5648)]
    [Attributes(9)]
   public sealed class Gsm1900AmamLinearPaRangebF3Seg2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2545)]
    [Attributes(9)]
   public sealed class Gsm1900AmamMasterTblSeg1F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2577)]
    [Attributes(9)]
   public sealed class Gsm1900AmamMasterTblSeg1F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3102)]
    [Attributes(9)]
   public sealed class Gsm1900AmamMasterTblSeg1F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2546)]
    [Attributes(9)]
   public sealed class Gsm1900AmamMasterTblSeg2F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2578)]
    [Attributes(9)]
   public sealed class Gsm1900AmamMasterTblSeg2F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3103)]
    [Attributes(9)]
   public sealed class Gsm1900AmamMasterTblSeg2F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2547)]
    [Attributes(9)]
   public sealed class Gsm1900AmamMasterTblSeg3F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2579)]
    [Attributes(9)]
   public sealed class Gsm1900AmamMasterTblSeg3F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3104)]
    [Attributes(9)]
   public sealed class Gsm1900AmamMasterTblSeg3F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2548)]
    [Attributes(9)]
   public sealed class Gsm1900AmamMasterTblSeg4F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2580)]
    [Attributes(9)]
   public sealed class Gsm1900AmamMasterTblSeg4F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3105)]
    [Attributes(9)]
   public sealed class Gsm1900AmamMasterTblSeg4F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2549)]
    [Attributes(9)]
   public sealed class Gsm1900AmamMasterTblSeg5F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2581)]
    [Attributes(9)]
   public sealed class Gsm1900AmamMasterTblSeg5F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3106)]
    [Attributes(9)]
   public sealed class Gsm1900AmamMasterTblSeg5F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2550)]
    [Attributes(9)]
   public sealed class Gsm1900AmamMasterTblSeg6F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2582)]
    [Attributes(9)]
   public sealed class Gsm1900AmamMasterTblSeg6F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3107)]
    [Attributes(9)]
   public sealed class Gsm1900AmamMasterTblSeg6F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2551)]
    [Attributes(9)]
   public sealed class Gsm1900AmamMasterTblSeg7F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2583)]
    [Attributes(9)]
   public sealed class Gsm1900AmamMasterTblSeg7F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3108)]
    [Attributes(9)]
   public sealed class Gsm1900AmamMasterTblSeg7F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2552)]
    [Attributes(9)]
   public sealed class Gsm1900AmamMasterTblSeg8F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2584)]
    [Attributes(9)]
   public sealed class Gsm1900AmamMasterTblSeg8F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3109)]
    [Attributes(9)]
   public sealed class Gsm1900AmamMasterTblSeg8F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2757)]
    [Attributes(9)]
   public sealed class Gsm1900AmamSysGainDcCorr : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5685)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmLinearPaRangeaF1Seg1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5686)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmLinearPaRangeaF1Seg2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5689)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmLinearPaRangeaF2Seg1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5690)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmLinearPaRangeaF2Seg2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5693)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmLinearPaRangeaF3Seg1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5694)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmLinearPaRangeaF3Seg2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5687)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmLinearPaRangebF1Seg1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5688)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmLinearPaRangebF1Seg2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5691)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmLinearPaRangebF2Seg1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5692)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmLinearPaRangebF2Seg2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5695)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmLinearPaRangebF3Seg1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5696)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmLinearPaRangebF3Seg2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2609)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmMasterTblSeg1F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2641)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmMasterTblSeg1F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3134)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmMasterTblSeg1F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2610)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmMasterTblSeg2F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2642)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmMasterTblSeg2F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3135)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmMasterTblSeg2F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2611)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmMasterTblSeg3F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2643)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmMasterTblSeg3F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3136)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmMasterTblSeg3F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2612)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmMasterTblSeg4F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2644)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmMasterTblSeg4F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3137)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmMasterTblSeg4F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2613)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmMasterTblSeg5F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2645)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmMasterTblSeg5F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3138)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmMasterTblSeg5F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2614)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmMasterTblSeg6F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2646)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmMasterTblSeg6F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3139)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmMasterTblSeg6F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2615)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmMasterTblSeg7F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2647)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmMasterTblSeg7F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3140)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmMasterTblSeg7F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2616)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmMasterTblSeg8F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2648)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmMasterTblSeg8F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3141)]
    [Attributes(9)]
   public sealed class Gsm1900AmpmMasterTblSeg8F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3069)]
    [Attributes(9)]
   public sealed class Gsm1900AntTimingRelToPaEnStart : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3077)]
    [Attributes(9)]
   public sealed class Gsm1900AntTimingRelToPaEnStop : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2748)]
    [Attributes(9)]
   public sealed class Gsm1900AutocalPwrDacF1 : ItemBase
    {
        public short Value1 { get; set; }


        public ushort Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(2769)]
    [Attributes(9)]
   public sealed class Gsm1900AutocalPwrDacF2 : ItemBase
    {
        public short Value1 { get; set; }


        public ushort Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(3149)]
    [Attributes(9)]
   public sealed class Gsm1900AutocalPwrDacF3 : ItemBase
    {
        public short Value1 { get; set; }


        public ushort Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(2781)]
    [Attributes(9)]
   public sealed class Gsm1900BasebandBwVal : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2321)]
    [Attributes(9)]
   public sealed class Gsm1900C0TxFreqComp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2324)]
    [Attributes(9)]
   public sealed class Gsm1900C1TxFreqComp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1057)]
    [Attributes(9)]
   public sealed class Gsm1900CalArfcn : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2753)]
    [Attributes(9)]
   public sealed class Gsm1900CalpathRsb : FourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4872)]
    [Attributes(9)]
   public sealed class Gsm1900CarrierSuppression : TwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5392)]
    [Attributes(9)]
   public sealed class Gsm1900EdgePaLoToMid : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5393)]
    [Attributes(9)]
   public sealed class Gsm1900EdgePaMidToHi : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2327)]
    [Attributes(9)]
   public sealed class Gsm1900EnableTxFreqCompVsPcl : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3508)]
    [Attributes(9)]
   public sealed class Gsm1900Gainrange5Switchpoints : TwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1100)]
    [Attributes(9)]
   public sealed class Gsm1900GainrangeSwitchpoints : SixSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4137)]
    [Attributes(9)]
   public sealed class Gsm1900GmskMultislot2TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4138)]
    [Attributes(9)]
   public sealed class Gsm1900GmskMultislot3TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4139)]
    [Attributes(9)]
   public sealed class Gsm1900GmskMultislot4TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4140)]
    [Attributes(9)]
   public sealed class Gsm1900GmskMultislot5TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5273)]
    [Attributes(9)]
   public sealed class Gsm1900KvCalChan : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5069)]
    [Attributes(9)]
   public sealed class Gsm1900KvCal : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5383)]
    [Attributes(9)]
   public sealed class Gsm1900KvVsTemp : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6297)]
    [Attributes(9)]
   public sealed class Gsm1900LinearEnvdcCalVal : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6354)]
    [Attributes(9)]
   public sealed class Gsm1900LinearPaR0TempComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6383)]
    [Attributes(9)]
   public sealed class Gsm1900LinearPaR0VbattHiComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6382)]
    [Attributes(9)]
   public sealed class Gsm1900LinearPaR0VbattLoComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6355)]
    [Attributes(9)]
   public sealed class Gsm1900LinearPaR1TempComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6385)]
    [Attributes(9)]
   public sealed class Gsm1900LinearPaR1VbattHiComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6384)]
    [Attributes(9)]
   public sealed class Gsm1900LinearPaR1VbattLoComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6356)]
    [Attributes(9)]
   public sealed class Gsm1900LinearPaR2TempComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6387)]
    [Attributes(9)]
   public sealed class Gsm1900LinearPaR2VbattHiComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6386)]
    [Attributes(9)]
   public sealed class Gsm1900LinearPaR2VbattLoComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6357)]
    [Attributes(9)]
   public sealed class Gsm1900LinearPaR3TempComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6389)]
    [Attributes(9)]
   public sealed class Gsm1900LinearPaR3VbattHiComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6388)]
    [Attributes(9)]
   public sealed class Gsm1900LinearPaR3VbattLoComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5398)]
    [Attributes(9)]
   public sealed class Gsm1900LinearPaTempComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6474)]
    [Attributes(9)]
   public sealed class Gsm1900LinearTxGainParam : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2777)]
    [Attributes(9)]
   public sealed class Gsm1900OpllBwVal : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5288)]
    [Attributes(9)]
   public sealed class Gsm1900PadacDcOffset : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3068)]
    [Attributes(9)]
   public sealed class Gsm1900PaEnStart : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3076)]
    [Attributes(9)]
   public sealed class Gsm1900PaEnStop : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1094)]
    [Attributes(9)]
   public sealed class Gsm1900PaGainSlope : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5371)]
    [Attributes(9)]
   public sealed class Gsm1900PaPredistSwpt1 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5372)]
    [Attributes(9)]
   public sealed class Gsm1900PaPredistSwpt2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5357)]
    [Attributes(9)]
   public sealed class Gsm1900PaR1ToR2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5358)]
    [Attributes(9)]
   public sealed class Gsm1900PaR2ToR4 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1098)]
    [Attributes(9)]
   public sealed class Gsm1900PaStartTimeOffset : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1099)]
    [Attributes(9)]
   public sealed class Gsm1900PaStopTimeOffset : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1326)]
    [Attributes(9)]
   public sealed class Gsm1900PaTempCompIndex00 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1327)]
    [Attributes(9)]
   public sealed class Gsm1900PaTempCompIndex01 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1328)]
    [Attributes(9)]
   public sealed class Gsm1900PaTempCompIndex02 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1329)]
    [Attributes(9)]
   public sealed class Gsm1900PaTempCompIndex03 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1330)]
    [Attributes(9)]
   public sealed class Gsm1900PaTempCompIndex04 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1331)]
    [Attributes(9)]
   public sealed class Gsm1900PaTempCompIndex05 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1332)]
    [Attributes(9)]
   public sealed class Gsm1900PaTempCompIndex06 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1333)]
    [Attributes(9)]
   public sealed class Gsm1900PaTempCompIndex07 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1334)]
    [Attributes(9)]
   public sealed class Gsm1900PaTempCompIndex08 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1335)]
    [Attributes(9)]
   public sealed class Gsm1900PaTempCompIndex09 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1336)]
    [Attributes(9)]
   public sealed class Gsm1900PaTempCompIndex10 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1337)]
    [Attributes(9)]
   public sealed class Gsm1900PaTempCompIndex11 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1338)]
    [Attributes(9)]
   public sealed class Gsm1900PaTempCompIndex12 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1339)]
    [Attributes(9)]
   public sealed class Gsm1900PaTempCompIndex13 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1340)]
    [Attributes(9)]
   public sealed class Gsm1900PaTempCompIndex14 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4371)]
    [Attributes(9)]
   public sealed class Gsm1900PaTempCompMaxPwr : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5347)]
    [Attributes(9)]
   public sealed class Gsm1900PmeasG0F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5351)]
    [Attributes(9)]
   public sealed class Gsm1900PmeasG0F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5427)]
    [Attributes(9)]
   public sealed class Gsm1900PmeasG0F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5348)]
    [Attributes(9)]
   public sealed class Gsm1900PmeasG1F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5352)]
    [Attributes(9)]
   public sealed class Gsm1900PmeasG1F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5428)]
    [Attributes(9)]
   public sealed class Gsm1900PmeasG1F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5349)]
    [Attributes(9)]
   public sealed class Gsm1900PmeasG2F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5353)]
    [Attributes(9)]
   public sealed class Gsm1900PmeasG2F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5429)]
    [Attributes(9)]
   public sealed class Gsm1900PmeasG2F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5350)]
    [Attributes(9)]
   public sealed class Gsm1900PmeasG3F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5354)]
    [Attributes(9)]
   public sealed class Gsm1900PmeasG3F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5430)]
    [Attributes(9)]
   public sealed class Gsm1900PmeasG3F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2773)]
    [Attributes(9)]
   public sealed class Gsm1900PolarPathDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3510)]
    [Attributes(9)]
   public sealed class Gsm1900PolarRampProfile : SixtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3062)]
    [Attributes(9)]
   public sealed class Gsm1900PowerLevels : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2502)]
    [Attributes(9)]
   public sealed class Gsm1900Prdi00 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2503)]
    [Attributes(9)]
   public sealed class Gsm1900Prdi01 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2148)]
    [Attributes(9)]
   public sealed class Gsm1900Prdi02 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2149)]
    [Attributes(9)]
   public sealed class Gsm1900Prdi03 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2150)]
    [Attributes(9)]
   public sealed class Gsm1900Prdi04 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2151)]
    [Attributes(9)]
   public sealed class Gsm1900Prdi05 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2152)]
    [Attributes(9)]
   public sealed class Gsm1900Prdi06 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2153)]
    [Attributes(9)]
   public sealed class Gsm1900Prdi07 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2505)]
    [Attributes(9)]
   public sealed class Gsm1900Prdi08 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2154)]
    [Attributes(9)]
   public sealed class Gsm1900Prdi09 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2155)]
    [Attributes(9)]
   public sealed class Gsm1900Prdi10 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2504)]
    [Attributes(9)]
   public sealed class Gsm1900Prdi11 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2156)]
    [Attributes(9)]
   public sealed class Gsm1900Prdi12 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3399)]
    [Attributes(9)]
   public sealed class Gsm1900PrechargeDur : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3398)]
    [Attributes(9)]
   public sealed class Gsm1900Precharge : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2135)]
    [Attributes(9)]
   public sealed class Gsm1900Prui00 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2136)]
    [Attributes(9)]
   public sealed class Gsm1900Prui01 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2137)]
    [Attributes(9)]
   public sealed class Gsm1900Prui02 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2138)]
    [Attributes(9)]
   public sealed class Gsm1900Prui03 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2139)]
    [Attributes(9)]
   public sealed class Gsm1900Prui04 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2140)]
    [Attributes(9)]
   public sealed class Gsm1900Prui05 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2141)]
    [Attributes(9)]
   public sealed class Gsm1900Prui06 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2142)]
    [Attributes(9)]
   public sealed class Gsm1900Prui07 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2143)]
    [Attributes(9)]
   public sealed class Gsm1900Prui08 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2144)]
    [Attributes(9)]
   public sealed class Gsm1900Prui09 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2145)]
    [Attributes(9)]
   public sealed class Gsm1900Prui10 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2146)]
    [Attributes(9)]
   public sealed class Gsm1900Prui11 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2147)]
    [Attributes(9)]
   public sealed class Gsm1900Prui12 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5315)]
    [Attributes(9)]
   public sealed class Gsm1900RgiG0F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5319)]
    [Attributes(9)]
   public sealed class Gsm1900RgiG0F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5411)]
    [Attributes(9)]
   public sealed class Gsm1900RgiG0F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5316)]
    [Attributes(9)]
   public sealed class Gsm1900RgiG1F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5320)]
    [Attributes(9)]
   public sealed class Gsm1900RgiG1F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5412)]
    [Attributes(9)]
   public sealed class Gsm1900RgiG1F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5317)]
    [Attributes(9)]
   public sealed class Gsm1900RgiG2F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5321)]
    [Attributes(9)]
   public sealed class Gsm1900RgiG2F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5413)]
    [Attributes(9)]
   public sealed class Gsm1900RgiG2F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5318)]
    [Attributes(9)]
   public sealed class Gsm1900RgiG3F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5322)]
    [Attributes(9)]
   public sealed class Gsm1900RgiG3F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5414)]
    [Attributes(9)]
   public sealed class Gsm1900RgiG3F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3154)]
    [Attributes(9)]
   public sealed class Gsm1900Rtr6250Rsb : EightUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1058)]
    [Attributes(9)]
   public sealed class Gsm1900RxGainRange1FreqComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4376)]
    [Attributes(9)]
   public sealed class Gsm1900RxGainRange1TempComp : ThreeInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1059)]
    [Attributes(9)]
   public sealed class Gsm1900RxGainRange2FreqComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4380)]
    [Attributes(9)]
   public sealed class Gsm1900RxGainRange2TempComp : ThreeInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1060)]
    [Attributes(9)]
   public sealed class Gsm1900RxGainRange3FreqComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4384)]
    [Attributes(9)]
   public sealed class Gsm1900RxGainRange3TempComp : ThreeInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1061)]
    [Attributes(9)]
   public sealed class Gsm1900RxGainRange4FreqComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4388)]
    [Attributes(9)]
   public sealed class Gsm1900RxGainRange4TempComp : ThreeInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3505)]
    [Attributes(9)]
   public sealed class Gsm1900RxGainRange5FreqComp : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4392)]
    [Attributes(9)]
   public sealed class Gsm1900RxGainRange5TempComp : ThreeInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5094)]
    [Attributes(9)]
   public sealed class Gsm1900SmpsPdmTbl : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5700)]
    [Attributes(9)]
   public sealed class Gsm1900TxAgcSettingForPred : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1078)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampDownIndex00 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1079)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampDownIndex01 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1080)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampDownIndex02 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1081)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampDownIndex03 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1082)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampDownIndex04 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1083)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampDownIndex05 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1084)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampDownIndex06 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1085)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampDownIndex07 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1086)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampDownIndex08 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1087)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampDownIndex09 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1088)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampDownIndex10 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1089)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampDownIndex11 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1090)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampDownIndex12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1091)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampDownIndex13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1092)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampDownIndex14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1093)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampDownIndex15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1062)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampUpIndex00 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1063)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampUpIndex01 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1064)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampUpIndex02 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1065)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampUpIndex03 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1066)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampUpIndex04 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1067)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampUpIndex05 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1068)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampUpIndex06 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1069)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampUpIndex07 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1070)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampUpIndex08 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1071)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampUpIndex09 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1072)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampUpIndex10 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1073)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampUpIndex11 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1074)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampUpIndex12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1075)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampUpIndex13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1076)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampUpIndex14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1077)]
    [Attributes(9)]
   public sealed class Gsm1900TxBurstRampUpIndex15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1095)]
    [Attributes(9)]
   public sealed class Gsm1900TxFreqComp : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4182)]
    [Attributes(9)]
   public sealed class Gsm1900TxRsbCorr : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1096)]
    [Attributes(9)]
   public sealed class Gsm1900VbattHiPaComp : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1097)]
    [Attributes(9)]
   public sealed class Gsm1900VbattLoPaComp : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2318)]
    [Attributes(9)]
   public sealed class Gsm1900VhThBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2317)]
    [Attributes(9)]
   public sealed class Gsm1900VhThBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2316)]
    [Attributes(9)]
   public sealed class Gsm1900VhThBrdi15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2315)]
    [Attributes(9)]
   public sealed class Gsm1900VhThBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2314)]
    [Attributes(9)]
   public sealed class Gsm1900VhThBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2313)]
    [Attributes(9)]
   public sealed class Gsm1900VhThBrui15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2496)]
    [Attributes(9)]
   public sealed class Gsm1900VhThPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2495)]
    [Attributes(9)]
   public sealed class Gsm1900VhThPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2494)]
    [Attributes(9)]
   public sealed class Gsm1900VhThPrdi15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2493)]
    [Attributes(9)]
   public sealed class Gsm1900VhThPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2492)]
    [Attributes(9)]
   public sealed class Gsm1900VhThPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2491)]
    [Attributes(9)]
   public sealed class Gsm1900VhThPrui15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2210)]
    [Attributes(9)]
   public sealed class Gsm1900VhTlBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2209)]
    [Attributes(9)]
   public sealed class Gsm1900VhTlBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2208)]
    [Attributes(9)]
   public sealed class Gsm1900VhTlBrdi15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2207)]
    [Attributes(9)]
   public sealed class Gsm1900VhTlBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2206)]
    [Attributes(9)]
   public sealed class Gsm1900VhTlBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2205)]
    [Attributes(9)]
   public sealed class Gsm1900VhTlBrui15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2388)]
    [Attributes(9)]
   public sealed class Gsm1900VhTlPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2387)]
    [Attributes(9)]
   public sealed class Gsm1900VhTlPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2386)]
    [Attributes(9)]
   public sealed class Gsm1900VhTlPrdi15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2385)]
    [Attributes(9)]
   public sealed class Gsm1900VhTlPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2384)]
    [Attributes(9)]
   public sealed class Gsm1900VhTlPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2383)]
    [Attributes(9)]
   public sealed class Gsm1900VhTlPrui15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2264)]
    [Attributes(9)]
   public sealed class Gsm1900VhTmBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2263)]
    [Attributes(9)]
   public sealed class Gsm1900VhTmBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2262)]
    [Attributes(9)]
   public sealed class Gsm1900VhTmBrdi15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2261)]
    [Attributes(9)]
   public sealed class Gsm1900VhTmBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2260)]
    [Attributes(9)]
   public sealed class Gsm1900VhTmBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2259)]
    [Attributes(9)]
   public sealed class Gsm1900VhTmBrui15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2442)]
    [Attributes(9)]
   public sealed class Gsm1900VhTmPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2441)]
    [Attributes(9)]
   public sealed class Gsm1900VhTmPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2440)]
    [Attributes(9)]
   public sealed class Gsm1900VhTmPrdi15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2439)]
    [Attributes(9)]
   public sealed class Gsm1900VhTmPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2438)]
    [Attributes(9)]
   public sealed class Gsm1900VhTmPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2437)]
    [Attributes(9)]
   public sealed class Gsm1900VhTmPrui15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2282)]
    [Attributes(9)]
   public sealed class Gsm1900VlThBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2281)]
    [Attributes(9)]
   public sealed class Gsm1900VlThBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2280)]
    [Attributes(9)]
   public sealed class Gsm1900VlThBrdi15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2279)]
    [Attributes(9)]
   public sealed class Gsm1900VlThBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2278)]
    [Attributes(9)]
   public sealed class Gsm1900VlThBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2277)]
    [Attributes(9)]
   public sealed class Gsm1900VlThBrui15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2460)]
    [Attributes(9)]
   public sealed class Gsm1900VlThPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2459)]
    [Attributes(9)]
   public sealed class Gsm1900VlThPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2458)]
    [Attributes(9)]
   public sealed class Gsm1900VlThPrdi15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2457)]
    [Attributes(9)]
   public sealed class Gsm1900VlThPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2456)]
    [Attributes(9)]
   public sealed class Gsm1900VlThPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2455)]
    [Attributes(9)]
   public sealed class Gsm1900VlThPrui15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2174)]
    [Attributes(9)]
   public sealed class Gsm1900VlTlBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2173)]
    [Attributes(9)]
   public sealed class Gsm1900VlTlBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2172)]
    [Attributes(9)]
   public sealed class Gsm1900VlTlBrdi15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2171)]
    [Attributes(9)]
   public sealed class Gsm1900VlTlBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2170)]
    [Attributes(9)]
   public sealed class Gsm1900VlTlBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2169)]
    [Attributes(9)]
   public sealed class Gsm1900VlTlBrui15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2352)]
    [Attributes(9)]
   public sealed class Gsm1900VlTlPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2351)]
    [Attributes(9)]
   public sealed class Gsm1900VlTlPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2350)]
    [Attributes(9)]
   public sealed class Gsm1900VlTlPrdi15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2349)]
    [Attributes(9)]
   public sealed class Gsm1900VlTlPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2348)]
    [Attributes(9)]
   public sealed class Gsm1900VlTlPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2347)]
    [Attributes(9)]
   public sealed class Gsm1900VlTlPrui15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2228)]
    [Attributes(9)]
   public sealed class Gsm1900VlTmBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2227)]
    [Attributes(9)]
   public sealed class Gsm1900VlTmBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2226)]
    [Attributes(9)]
   public sealed class Gsm1900VlTmBrdi15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2225)]
    [Attributes(9)]
   public sealed class Gsm1900VlTmBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2224)]
    [Attributes(9)]
   public sealed class Gsm1900VlTmBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2223)]
    [Attributes(9)]
   public sealed class Gsm1900VlTmBrui15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2406)]
    [Attributes(9)]
   public sealed class Gsm1900VlTmPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2405)]
    [Attributes(9)]
   public sealed class Gsm1900VlTmPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2404)]
    [Attributes(9)]
   public sealed class Gsm1900VlTmPrdi15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2403)]
    [Attributes(9)]
   public sealed class Gsm1900VlTmPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2402)]
    [Attributes(9)]
   public sealed class Gsm1900VlTmPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2401)]
    [Attributes(9)]
   public sealed class Gsm1900VlTmPrui15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2300)]
    [Attributes(9)]
   public sealed class Gsm1900VmThBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2299)]
    [Attributes(9)]
   public sealed class Gsm1900VmThBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2298)]
    [Attributes(9)]
   public sealed class Gsm1900VmThBrdi15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2297)]
    [Attributes(9)]
   public sealed class Gsm1900VmThBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2296)]
    [Attributes(9)]
   public sealed class Gsm1900VmThBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2295)]
    [Attributes(9)]
   public sealed class Gsm1900VmThBrui15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2478)]
    [Attributes(9)]
   public sealed class Gsm1900VmThPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2477)]
    [Attributes(9)]
   public sealed class Gsm1900VmThPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2476)]
    [Attributes(9)]
   public sealed class Gsm1900VmThPrdi15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2475)]
    [Attributes(9)]
   public sealed class Gsm1900VmThPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2474)]
    [Attributes(9)]
   public sealed class Gsm1900VmThPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2473)]
    [Attributes(9)]
   public sealed class Gsm1900VmThPrui15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2192)]
    [Attributes(9)]
   public sealed class Gsm1900VmTlBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2191)]
    [Attributes(9)]
   public sealed class Gsm1900VmTlBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2190)]
    [Attributes(9)]
   public sealed class Gsm1900VmTlBrdi15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2189)]
    [Attributes(9)]
   public sealed class Gsm1900VmTlBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2188)]
    [Attributes(9)]
   public sealed class Gsm1900VmTlBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2187)]
    [Attributes(9)]
   public sealed class Gsm1900VmTlBrui15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2370)]
    [Attributes(9)]
   public sealed class Gsm1900VmTlPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2369)]
    [Attributes(9)]
   public sealed class Gsm1900VmTlPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2368)]
    [Attributes(9)]
   public sealed class Gsm1900VmTlPrdi15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2367)]
    [Attributes(9)]
   public sealed class Gsm1900VmTlPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2366)]
    [Attributes(9)]
   public sealed class Gsm1900VmTlPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2365)]
    [Attributes(9)]
   public sealed class Gsm1900VmTlPrui15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2246)]
    [Attributes(9)]
   public sealed class Gsm1900VmTmBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2245)]
    [Attributes(9)]
   public sealed class Gsm1900VmTmBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2244)]
    [Attributes(9)]
   public sealed class Gsm1900VmTmBrdi15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2243)]
    [Attributes(9)]
   public sealed class Gsm1900VmTmBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2242)]
    [Attributes(9)]
   public sealed class Gsm1900VmTmBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2241)]
    [Attributes(9)]
   public sealed class Gsm1900VmTmBrui15 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2424)]
    [Attributes(9)]
   public sealed class Gsm1900VmTmPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2423)]
    [Attributes(9)]
   public sealed class Gsm1900VmTmPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2422)]
    [Attributes(9)]
   public sealed class Gsm1900VmTmPrdi15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2421)]
    [Attributes(9)]
   public sealed class Gsm1900VmTmPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2420)]
    [Attributes(9)]
   public sealed class Gsm1900VmTmPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2419)]
    [Attributes(9)]
   public sealed class Gsm1900VmTmPrui15 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4141)]
    [Attributes(9)]
   public sealed class Gsm8508pskMultislot2TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4142)]
    [Attributes(9)]
   public sealed class Gsm8508pskMultislot3TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4143)]
    [Attributes(9)]
   public sealed class Gsm8508pskMultislot4TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4144)]
    [Attributes(9)]
   public sealed class Gsm8508pskMultislot5TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2760)]
    [Attributes(9)]
   public sealed class Gsm850AmamArfcnF1 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2764)]
    [Attributes(9)]
   public sealed class Gsm850AmamArfcnF2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3144)]
    [Attributes(9)]
   public sealed class Gsm850AmamArfcnF3 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2747)]
    [Attributes(9)]
   public sealed class Gsm850AmamDynamicRange : TwoInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5601)]
    [Attributes(9)]
   public sealed class Gsm850AmamLinearPaRangeaF1Seg1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5602)]
    [Attributes(9)]
   public sealed class Gsm850AmamLinearPaRangeaF1Seg2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5605)]
    [Attributes(9)]
   public sealed class Gsm850AmamLinearPaRangeaF2Seg1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5606)]
    [Attributes(9)]
   public sealed class Gsm850AmamLinearPaRangeaF2Seg2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5609)]
    [Attributes(9)]
   public sealed class Gsm850AmamLinearPaRangeaF3Seg1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5610)]
    [Attributes(9)]
   public sealed class Gsm850AmamLinearPaRangeaF3Seg2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5603)]
    [Attributes(9)]
   public sealed class Gsm850AmamLinearPaRangebF1Seg1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5604)]
    [Attributes(9)]
   public sealed class Gsm850AmamLinearPaRangebF1Seg2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5607)]
    [Attributes(9)]
   public sealed class Gsm850AmamLinearPaRangebF2Seg1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5608)]
    [Attributes(9)]
   public sealed class Gsm850AmamLinearPaRangebF2Seg2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5611)]
    [Attributes(9)]
   public sealed class Gsm850AmamLinearPaRangebF3Seg1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5612)]
    [Attributes(9)]
   public sealed class Gsm850AmamLinearPaRangebF3Seg2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2537)]
    [Attributes(9)]
   public sealed class Gsm850AmamMasterTblSeg1F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2569)]
    [Attributes(9)]
   public sealed class Gsm850AmamMasterTblSeg1F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3094)]
    [Attributes(9)]
   public sealed class Gsm850AmamMasterTblSeg1F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2538)]
    [Attributes(9)]
   public sealed class Gsm850AmamMasterTblSeg2F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2570)]
    [Attributes(9)]
   public sealed class Gsm850AmamMasterTblSeg2F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3095)]
    [Attributes(9)]
   public sealed class Gsm850AmamMasterTblSeg2F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2539)]
    [Attributes(9)]
   public sealed class Gsm850AmamMasterTblSeg3F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2571)]
    [Attributes(9)]
   public sealed class Gsm850AmamMasterTblSeg3F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3096)]
    [Attributes(9)]
   public sealed class Gsm850AmamMasterTblSeg3F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2540)]
    [Attributes(9)]
   public sealed class Gsm850AmamMasterTblSeg4F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2572)]
    [Attributes(9)]
   public sealed class Gsm850AmamMasterTblSeg4F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3097)]
    [Attributes(9)]
   public sealed class Gsm850AmamMasterTblSeg4F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2541)]
    [Attributes(9)]
   public sealed class Gsm850AmamMasterTblSeg5F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2573)]
    [Attributes(9)]
   public sealed class Gsm850AmamMasterTblSeg5F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3098)]
    [Attributes(9)]
   public sealed class Gsm850AmamMasterTblSeg5F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2542)]
    [Attributes(9)]
   public sealed class Gsm850AmamMasterTblSeg6F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2574)]
    [Attributes(9)]
   public sealed class Gsm850AmamMasterTblSeg6F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3099)]
    [Attributes(9)]
   public sealed class Gsm850AmamMasterTblSeg6F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2543)]
    [Attributes(9)]
   public sealed class Gsm850AmamMasterTblSeg7F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2575)]
    [Attributes(9)]
   public sealed class Gsm850AmamMasterTblSeg7F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3100)]
    [Attributes(9)]
   public sealed class Gsm850AmamMasterTblSeg7F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2544)]
    [Attributes(9)]
   public sealed class Gsm850AmamMasterTblSeg8F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2576)]
    [Attributes(9)]
   public sealed class Gsm850AmamMasterTblSeg8F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3101)]
    [Attributes(9)]
   public sealed class Gsm850AmamMasterTblSeg8F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2755)]
    [Attributes(9)]
   public sealed class Gsm850AmamSysGainDcCorr : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5649)]
    [Attributes(9)]
   public sealed class Gsm850AmpmLinearPaRangeaF1Seg1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5650)]
    [Attributes(9)]
   public sealed class Gsm850AmpmLinearPaRangeaF1Seg2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5653)]
    [Attributes(9)]
   public sealed class Gsm850AmpmLinearPaRangeaF2Seg1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5654)]
    [Attributes(9)]
   public sealed class Gsm850AmpmLinearPaRangeaF2Seg2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5657)]
    [Attributes(9)]
   public sealed class Gsm850AmpmLinearPaRangeaF3Seg1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5658)]
    [Attributes(9)]
   public sealed class Gsm850AmpmLinearPaRangeaF3Seg2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5651)]
    [Attributes(9)]
   public sealed class Gsm850AmpmLinearPaRangebF1Seg1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5652)]
    [Attributes(9)]
   public sealed class Gsm850AmpmLinearPaRangebF1Seg2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5655)]
    [Attributes(9)]
   public sealed class Gsm850AmpmLinearPaRangebF2Seg1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5656)]
    [Attributes(9)]
   public sealed class Gsm850AmpmLinearPaRangebF2Seg2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5659)]
    [Attributes(9)]
   public sealed class Gsm850AmpmLinearPaRangebF3Seg1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5660)]
    [Attributes(9)]
   public sealed class Gsm850AmpmLinearPaRangebF3Seg2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2601)]
    [Attributes(9)]
   public sealed class Gsm850AmpmMasterTblSeg1F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2633)]
    [Attributes(9)]
   public sealed class Gsm850AmpmMasterTblSeg1F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3126)]
    [Attributes(9)]
   public sealed class Gsm850AmpmMasterTblSeg1F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2602)]
    [Attributes(9)]
   public sealed class Gsm850AmpmMasterTblSeg2F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2634)]
    [Attributes(9)]
   public sealed class Gsm850AmpmMasterTblSeg2F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3127)]
    [Attributes(9)]
   public sealed class Gsm850AmpmMasterTblSeg2F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2603)]
    [Attributes(9)]
   public sealed class Gsm850AmpmMasterTblSeg3F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2635)]
    [Attributes(9)]
   public sealed class Gsm850AmpmMasterTblSeg3F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3128)]
    [Attributes(9)]
   public sealed class Gsm850AmpmMasterTblSeg3F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2604)]
    [Attributes(9)]
   public sealed class Gsm850AmpmMasterTblSeg4F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2636)]
    [Attributes(9)]
   public sealed class Gsm850AmpmMasterTblSeg4F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3129)]
    [Attributes(9)]
   public sealed class Gsm850AmpmMasterTblSeg4F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2605)]
    [Attributes(9)]
   public sealed class Gsm850AmpmMasterTblSeg5F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2637)]
    [Attributes(9)]
   public sealed class Gsm850AmpmMasterTblSeg5F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3130)]
    [Attributes(9)]
   public sealed class Gsm850AmpmMasterTblSeg5F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2606)]
    [Attributes(9)]
   public sealed class Gsm850AmpmMasterTblSeg6F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2638)]
    [Attributes(9)]
   public sealed class Gsm850AmpmMasterTblSeg6F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3131)]
    [Attributes(9)]
   public sealed class Gsm850AmpmMasterTblSeg6F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2607)]
    [Attributes(9)]
   public sealed class Gsm850AmpmMasterTblSeg7F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2639)]
    [Attributes(9)]
   public sealed class Gsm850AmpmMasterTblSeg7F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3132)]
    [Attributes(9)]
   public sealed class Gsm850AmpmMasterTblSeg7F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2608)]
    [Attributes(9)]
   public sealed class Gsm850AmpmMasterTblSeg8F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2640)]
    [Attributes(9)]
   public sealed class Gsm850AmpmMasterTblSeg8F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3133)]
    [Attributes(9)]
   public sealed class Gsm850AmpmMasterTblSeg8F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3150)]
    [Attributes(9)]
   public sealed class Gsm850AntTimingRelToPaEnStart : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3075)]
    [Attributes(9)]
   public sealed class Gsm850AntTimingRelToPaEnStop : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2746)]
    [Attributes(9)]
   public sealed class Gsm850AutocalPwrDacF1 : ItemBase
    {
        public short Value1 { get; set; }


        public ushort Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(2768)]
    [Attributes(9)]
   public sealed class Gsm850AutocalPwrDacF2 : ItemBase
    {
        public short Value1 { get; set; }


        public ushort Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(3148)]
    [Attributes(9)]
   public sealed class Gsm850AutocalPwrDacF3 : ItemBase
    {
        public short Value1 { get; set; }


        public ushort Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(2780)]
    [Attributes(9)]
   public sealed class Gsm850BasebandBwVal : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1101)]
    [Attributes(9)]
   public sealed class Gsm850CalArfcn : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2752)]
    [Attributes(9)]
   public sealed class Gsm850CalpathRsb : FourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4870)]
    [Attributes(9)]
   public sealed class Gsm850CarrierSuppression : TwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5388)]
    [Attributes(9)]
   public sealed class Gsm850EdgePaLoToMid : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5389)]
    [Attributes(9)]
   public sealed class Gsm850EdgePaMidToHi : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5387)]
    [Attributes(9)]
   public sealed class Gsm850EdgePaUltraLoToLo : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3507)]
    [Attributes(9)]
   public sealed class Gsm850Gainrange5Switchpoints : TwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1142)]
    [Attributes(9)]
   public sealed class Gsm850GainrangeSwitchpoints : SixSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4125)]
    [Attributes(9)]
   public sealed class Gsm850GmskMultislot2TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4126)]
    [Attributes(9)]
   public sealed class Gsm850GmskMultislot3TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4127)]
    [Attributes(9)]
   public sealed class Gsm850GmskMultislot4TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4128)]
    [Attributes(9)]
   public sealed class Gsm850GmskMultislot5TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5270)]
    [Attributes(9)]
   public sealed class Gsm850KvCalChan : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5066)]
    [Attributes(9)]
   public sealed class Gsm850KvCal : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5380)]
    [Attributes(9)]
   public sealed class Gsm850KvVsTemp : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6294)]
    [Attributes(9)]
   public sealed class Gsm850LinearEnvdcCalVal : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6342)]
    [Attributes(9)]
   public sealed class Gsm850LinearPaR0TempComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6359)]
    [Attributes(9)]
   public sealed class Gsm850LinearPaR0VbattHiComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6358)]
    [Attributes(9)]
   public sealed class Gsm850LinearPaR0VbattLoComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6343)]
    [Attributes(9)]
   public sealed class Gsm850LinearPaR1TempComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6361)]
    [Attributes(9)]
   public sealed class Gsm850LinearPaR1VbattHiComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6360)]
    [Attributes(9)]
   public sealed class Gsm850LinearPaR1VbattLoComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6344)]
    [Attributes(9)]
   public sealed class Gsm850LinearPaR2TempComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6363)]
    [Attributes(9)]
   public sealed class Gsm850LinearPaR2VbattHiComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6362)]
    [Attributes(9)]
   public sealed class Gsm850LinearPaR2VbattLoComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6345)]
    [Attributes(9)]
   public sealed class Gsm850LinearPaR3TempComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6365)]
    [Attributes(9)]
   public sealed class Gsm850LinearPaR3VbattHiComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6364)]
    [Attributes(9)]
   public sealed class Gsm850LinearPaR3VbattLoComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5395)]
    [Attributes(9)]
   public sealed class Gsm850LinearPaTempComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6472)]
    [Attributes(9)]
   public sealed class Gsm850LinearTxGainParam : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2776)]
    [Attributes(9)]
   public sealed class Gsm850OpllBwVal : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5285)]
    [Attributes(9)]
   public sealed class Gsm850PadacDcOffset : ItemBase
    {
        [FieldCount(15)]
        public sbyte[] Value { get; set; }
    }

    [Serializable]
    [NvItemId(3067)]
    [Attributes(9)]
   public sealed class Gsm850PaEnStart : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3074)]
    [Attributes(9)]
   public sealed class Gsm850PaEnStop : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1136)]
    [Attributes(9)]
   public sealed class Gsm850PaGainSlope : ItemBase
    {
        [FieldCount(15)]
        public byte[] Value { get; set; }
    }

    [Serializable]
    [NvItemId(5365)]
    [Attributes(9)]
   public sealed class Gsm850PaPredistSwpt1 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5366)]
    [Attributes(9)]
   public sealed class Gsm850PaPredistSwpt2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5359)]
    [Attributes(9)]
   public sealed class Gsm850PaR1ToR2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5360)]
    [Attributes(9)]
   public sealed class Gsm850PaR2ToR3 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5361)]
    [Attributes(9)]
   public sealed class Gsm850PaR3ToR4 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1140)]
    [Attributes(9)]
   public sealed class Gsm850PaStartTimeOffset : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1141)]
    [Attributes(9)]
   public sealed class Gsm850PaStopTimeOffset : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1312)]
    [Attributes(9)]
   public sealed class Gsm850PaTempCompIndex00 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1313)]
    [Attributes(9)]
   public sealed class Gsm850PaTempCompIndex01 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1314)]
    [Attributes(9)]
   public sealed class Gsm850PaTempCompIndex02 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1315)]
    [Attributes(9)]
   public sealed class Gsm850PaTempCompIndex03 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1316)]
    [Attributes(9)]
   public sealed class Gsm850PaTempCompIndex04 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1317)]
    [Attributes(9)]
   public sealed class Gsm850PaTempCompIndex05 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1318)]
    [Attributes(9)]
   public sealed class Gsm850PaTempCompIndex06 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1319)]
    [Attributes(9)]
   public sealed class Gsm850PaTempCompIndex07 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1320)]
    [Attributes(9)]
   public sealed class Gsm850PaTempCompIndex08 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1321)]
    [Attributes(9)]
   public sealed class Gsm850PaTempCompIndex09 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1322)]
    [Attributes(9)]
   public sealed class Gsm850PaTempCompIndex10 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1323)]
    [Attributes(9)]
   public sealed class Gsm850PaTempCompIndex11 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1324)]
    [Attributes(9)]
   public sealed class Gsm850PaTempCompIndex12 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1325)]
    [Attributes(9)]
   public sealed class Gsm850PaTempCompIndex13 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4368)]
    [Attributes(9)]
   public sealed class Gsm850PaTempCompMaxPwr : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4218)]
    [Attributes(9)]
   public sealed class Gsm850PathDelayColdTempVsFreq : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4214)]
    [Attributes(9)]
   public sealed class Gsm850PathDelayCompFreqTbl : EightUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4220)]
    [Attributes(9)]
   public sealed class Gsm850PathDelayHotTempVsFreq : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4219)]
    [Attributes(9)]
   public sealed class Gsm850PathDelayRoomTempVsFreq : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5323)]
    [Attributes(9)]
   public sealed class Gsm850PmeasG0F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5327)]
    [Attributes(9)]
   public sealed class Gsm850PmeasG0F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5415)]
    [Attributes(9)]
   public sealed class Gsm850PmeasG0F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5324)]
    [Attributes(9)]
   public sealed class Gsm850PmeasG1F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5328)]
    [Attributes(9)]
   public sealed class Gsm850PmeasG1F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5416)]
    [Attributes(9)]
   public sealed class Gsm850PmeasG1F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5325)]
    [Attributes(9)]
   public sealed class Gsm850PmeasG2F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5329)]
    [Attributes(9)]
   public sealed class Gsm850PmeasG2F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5417)]
    [Attributes(9)]
   public sealed class Gsm850PmeasG2F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5326)]
    [Attributes(9)]
   public sealed class Gsm850PmeasG3F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5330)]
    [Attributes(9)]
   public sealed class Gsm850PmeasG3F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5418)]
    [Attributes(9)]
   public sealed class Gsm850PmeasG3F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2772)]
    [Attributes(9)]
   public sealed class Gsm850PolarPathDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3511)]
    [Attributes(9)]
   public sealed class Gsm850PolarRampProfile : SixtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3061)]
    [Attributes(9)]
   public sealed class Gsm850PowerLevels : ItemBase
    {
        [FieldCount(15)]
        public short[] Value { get; set; }
    }

    [Serializable]
    [NvItemId(3397)]
    [Attributes(9)]
   public sealed class Gsm850PrechargeDur : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3396)]
    [Attributes(9)]
   public sealed class Gsm850Precharge : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5291)]
    [Attributes(9)]
   public sealed class Gsm850RgiG0F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5295)]
    [Attributes(9)]
   public sealed class Gsm850RgiG0F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5399)]
    [Attributes(9)]
   public sealed class Gsm850RgiG0F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5292)]
    [Attributes(9)]
   public sealed class Gsm850RgiG1F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5296)]
    [Attributes(9)]
   public sealed class Gsm850RgiG1F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5400)]
    [Attributes(9)]
   public sealed class Gsm850RgiG1F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5293)]
    [Attributes(9)]
   public sealed class Gsm850RgiG2F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5297)]
    [Attributes(9)]
   public sealed class Gsm850RgiG2F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5401)]
    [Attributes(9)]
   public sealed class Gsm850RgiG2F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5294)]
    [Attributes(9)]
   public sealed class Gsm850RgiG3F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5298)]
    [Attributes(9)]
   public sealed class Gsm850RgiG3F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5402)]
    [Attributes(9)]
   public sealed class Gsm850RgiG3F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3153)]
    [Attributes(9)]
   public sealed class Gsm850Rtr6250Rsb : EightUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1102)]
    [Attributes(9)]
   public sealed class Gsm850RxGainRange1FreqComp : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4373)]
    [Attributes(9)]
   public sealed class Gsm850RxGainRange1TempComp : ThreeInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1103)]
    [Attributes(9)]
   public sealed class Gsm850RxGainRange2FreqComp : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4377)]
    [Attributes(9)]
   public sealed class Gsm850RxGainRange2TempComp : ThreeInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1104)]
    [Attributes(9)]
   public sealed class Gsm850RxGainRange3FreqComp : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4381)]
    [Attributes(9)]
   public sealed class Gsm850RxGainRange3TempComp : ThreeInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1105)]
    [Attributes(9)]
   public sealed class Gsm850RxGainRange4FreqComp : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4385)]
    [Attributes(9)]
   public sealed class Gsm850RxGainRange4TempComp : ThreeInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3504)]
    [Attributes(9)]
   public sealed class Gsm850RxGainRange5FreqComp : EightUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4389)]
    [Attributes(9)]
   public sealed class Gsm850RxGainRange5TempComp : ThreeInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5091)]
    [Attributes(9)]
   public sealed class Gsm850SmpsPdmTbl : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5697)]
    [Attributes(9)]
   public sealed class Gsm850TxAgcSettingForPred : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1121)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampDownIndex00 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1122)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampDownIndex01 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1123)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampDownIndex02 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1124)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampDownIndex03 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1125)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampDownIndex04 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1126)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampDownIndex05 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1127)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampDownIndex06 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1128)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampDownIndex07 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1129)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampDownIndex08 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1130)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampDownIndex09 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1131)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampDownIndex10 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1132)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampDownIndex11 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1133)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampDownIndex12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1134)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampDownIndex13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1135)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampDownIndex14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1106)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampUpIndex00 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1107)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampUpIndex01 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1108)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampUpIndex02 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1109)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampUpIndex03 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1110)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampUpIndex04 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1111)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampUpIndex05 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1112)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampUpIndex06 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1113)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampUpIndex07 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1114)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampUpIndex08 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1115)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampUpIndex09 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1116)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampUpIndex10 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1117)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampUpIndex11 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1118)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampUpIndex12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1119)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampUpIndex13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1120)]
    [Attributes(9)]
   public sealed class Gsm850TxBurstRampUpIndex14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1137)]
    [Attributes(9)]
   public sealed class Gsm850TxFreqComp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4181)]
    [Attributes(9)]
   public sealed class Gsm850TxRsbCorr : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1138)]
    [Attributes(9)]
   public sealed class Gsm850VbattHiPaComp : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1139)]
    [Attributes(9)]
   public sealed class Gsm850VbattLoPaComp : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4145)]
    [Attributes(9)]
   public sealed class Gsm8pskMultislot2TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4146)]
    [Attributes(9)]
   public sealed class Gsm8pskMultislot3TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4147)]
    [Attributes(9)]
   public sealed class Gsm8pskMultislot4TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4148)]
    [Attributes(9)]
   public sealed class Gsm8pskMultislot5TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5613)]
    [Attributes(9)]
   public sealed class Gsm900AmamLinearPaRangeaF1Seg1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5614)]
    [Attributes(9)]
   public sealed class Gsm900AmamLinearPaRangeaF1Seg2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5617)]
    [Attributes(9)]
   public sealed class Gsm900AmamLinearPaRangeaF2Seg1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5618)]
    [Attributes(9)]
   public sealed class Gsm900AmamLinearPaRangeaF2Seg2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5621)]
    [Attributes(9)]
   public sealed class Gsm900AmamLinearPaRangeaF3Seg1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5622)]
    [Attributes(9)]
   public sealed class Gsm900AmamLinearPaRangeaF3Seg2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5615)]
    [Attributes(9)]
   public sealed class Gsm900AmamLinearPaRangebF1Seg1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5616)]
    [Attributes(9)]
   public sealed class Gsm900AmamLinearPaRangebF1Seg2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5619)]
    [Attributes(9)]
   public sealed class Gsm900AmamLinearPaRangebF2Seg1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5620)]
    [Attributes(9)]
   public sealed class Gsm900AmamLinearPaRangebF2Seg2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5623)]
    [Attributes(9)]
   public sealed class Gsm900AmamLinearPaRangebF3Seg1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5624)]
    [Attributes(9)]
   public sealed class Gsm900AmamLinearPaRangebF3Seg2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5661)]
    [Attributes(9)]
   public sealed class Gsm900AmpmLinearPaRangeaF1Seg1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5662)]
    [Attributes(9)]
   public sealed class Gsm900AmpmLinearPaRangeaF1Seg2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5665)]
    [Attributes(9)]
   public sealed class Gsm900AmpmLinearPaRangeaF2Seg1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5666)]
    [Attributes(9)]
   public sealed class Gsm900AmpmLinearPaRangeaF2Seg2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5669)]
    [Attributes(9)]
   public sealed class Gsm900AmpmLinearPaRangeaF3Seg1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5670)]
    [Attributes(9)]
   public sealed class Gsm900AmpmLinearPaRangeaF3Seg2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5663)]
    [Attributes(9)]
   public sealed class Gsm900AmpmLinearPaRangebF1Seg1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5664)]
    [Attributes(9)]
   public sealed class Gsm900AmpmLinearPaRangebF1Seg2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5667)]
    [Attributes(9)]
   public sealed class Gsm900AmpmLinearPaRangebF2Seg1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5668)]
    [Attributes(9)]
   public sealed class Gsm900AmpmLinearPaRangebF2Seg2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5671)]
    [Attributes(9)]
   public sealed class Gsm900AmpmLinearPaRangebF3Seg1 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5672)]
    [Attributes(9)]
   public sealed class Gsm900AmpmLinearPaRangebF3Seg2 : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5385)]
    [Attributes(9)]
   public sealed class Gsm900EdgePaLoToMid : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5386)]
    [Attributes(9)]
   public sealed class Gsm900EdgePaMidToHi : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5384)]
    [Attributes(9)]
   public sealed class Gsm900EdgePaUltraLoToLo : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5271)]
    [Attributes(9)]
   public sealed class Gsm900KvCalChan : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5067)]
    [Attributes(9)]
   public sealed class Gsm900KvCal : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5381)]
    [Attributes(9)]
   public sealed class Gsm900KvVsTemp : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6295)]
    [Attributes(9)]
   public sealed class Gsm900LinearEnvdcCalVal : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6346)]
    [Attributes(9)]
   public sealed class Gsm900LinearPaR0TempComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6367)]
    [Attributes(9)]
   public sealed class Gsm900LinearPaR0VbattHiComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6366)]
    [Attributes(9)]
   public sealed class Gsm900LinearPaR0VbattLoComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6347)]
    [Attributes(9)]
   public sealed class Gsm900LinearPaR1TempComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6369)]
    [Attributes(9)]
   public sealed class Gsm900LinearPaR1VbattHiComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6368)]
    [Attributes(9)]
   public sealed class Gsm900LinearPaR1VbattLoComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6348)]
    [Attributes(9)]
   public sealed class Gsm900LinearPaR2TempComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6371)]
    [Attributes(9)]
   public sealed class Gsm900LinearPaR2VbattHiComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6370)]
    [Attributes(9)]
   public sealed class Gsm900LinearPaR2VbattLoComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6349)]
    [Attributes(9)]
   public sealed class Gsm900LinearPaR3TempComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6373)]
    [Attributes(9)]
   public sealed class Gsm900LinearPaR3VbattHiComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6372)]
    [Attributes(9)]
   public sealed class Gsm900LinearPaR3VbattLoComp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5396)]
    [Attributes(9)]
   public sealed class Gsm900LinearPaTempComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5286)]
    [Attributes(9)]
   public sealed class Gsm900PadacDcOffset : ItemBase
    {
        [FieldCount(15)]
        public sbyte[] Value { get; set; }
    }

    [Serializable]
    [NvItemId(5367)]
    [Attributes(9)]
   public sealed class Gsm900PaPredistSwpt1 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5368)]
    [Attributes(9)]
   public sealed class Gsm900PaPredistSwpt2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5362)]
    [Attributes(9)]
   public sealed class Gsm900PaR1ToR2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5363)]
    [Attributes(9)]
   public sealed class Gsm900PaR2ToR3 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5364)]
    [Attributes(9)]
   public sealed class Gsm900PaR3ToR4 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5331)]
    [Attributes(9)]
   public sealed class Gsm900PmeasG0F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5335)]
    [Attributes(9)]
   public sealed class Gsm900PmeasG0F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5419)]
    [Attributes(9)]
   public sealed class Gsm900PmeasG0F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5332)]
    [Attributes(9)]
   public sealed class Gsm900PmeasG1F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5336)]
    [Attributes(9)]
   public sealed class Gsm900PmeasG1F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5420)]
    [Attributes(9)]
   public sealed class Gsm900PmeasG1F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5333)]
    [Attributes(9)]
   public sealed class Gsm900PmeasG2F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5337)]
    [Attributes(9)]
   public sealed class Gsm900PmeasG2F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5421)]
    [Attributes(9)]
   public sealed class Gsm900PmeasG2F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5334)]
    [Attributes(9)]
   public sealed class Gsm900PmeasG3F1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5338)]
    [Attributes(9)]
   public sealed class Gsm900PmeasG3F2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5422)]
    [Attributes(9)]
   public sealed class Gsm900PmeasG3F3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5299)]
    [Attributes(9)]
   public sealed class Gsm900RgiG0F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5303)]
    [Attributes(9)]
   public sealed class Gsm900RgiG0F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5403)]
    [Attributes(9)]
   public sealed class Gsm900RgiG0F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5300)]
    [Attributes(9)]
   public sealed class Gsm900RgiG1F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5304)]
    [Attributes(9)]
   public sealed class Gsm900RgiG1F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5404)]
    [Attributes(9)]
   public sealed class Gsm900RgiG1F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5301)]
    [Attributes(9)]
   public sealed class Gsm900RgiG2F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5305)]
    [Attributes(9)]
   public sealed class Gsm900RgiG2F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5405)]
    [Attributes(9)]
   public sealed class Gsm900RgiG2F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5302)]
    [Attributes(9)]
   public sealed class Gsm900RgiG3F1 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5306)]
    [Attributes(9)]
   public sealed class Gsm900RgiG3F2 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5406)]
    [Attributes(9)]
   public sealed class Gsm900RgiG3F3 : ThirtyTwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5092)]
    [Attributes(9)]
   public sealed class Gsm900SmpsPdmTbl : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5698)]
    [Attributes(9)]
   public sealed class Gsm900TxAgcSettingForPred : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(553)]
    [Attributes(9)]
   public sealed class GsmA5AlgorithmsSupported : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2758)]
    [Attributes(9)]
   public sealed class GsmAmamArfcnF1 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2762)]
    [Attributes(9)]
   public sealed class GsmAmamArfcnF2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3142)]
    [Attributes(9)]
   public sealed class GsmAmamArfcnF3 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2743)]
    [Attributes(9)]
   public sealed class GsmAmamDynamicRange : TwoInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2521)]
    [Attributes(9)]
   public sealed class GsmAmamMasterTblSeg1F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2553)]
    [Attributes(9)]
   public sealed class GsmAmamMasterTblSeg1F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3078)]
    [Attributes(9)]
   public sealed class GsmAmamMasterTblSeg1F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2522)]
    [Attributes(9)]
   public sealed class GsmAmamMasterTblSeg2F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2554)]
    [Attributes(9)]
   public sealed class GsmAmamMasterTblSeg2F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3079)]
    [Attributes(9)]
   public sealed class GsmAmamMasterTblSeg2F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2523)]
    [Attributes(9)]
   public sealed class GsmAmamMasterTblSeg3F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2555)]
    [Attributes(9)]
   public sealed class GsmAmamMasterTblSeg3F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3080)]
    [Attributes(9)]
   public sealed class GsmAmamMasterTblSeg3F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2524)]
    [Attributes(9)]
   public sealed class GsmAmamMasterTblSeg4F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2556)]
    [Attributes(9)]
   public sealed class GsmAmamMasterTblSeg4F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3081)]
    [Attributes(9)]
   public sealed class GsmAmamMasterTblSeg4F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2525)]
    [Attributes(9)]
   public sealed class GsmAmamMasterTblSeg5F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2557)]
    [Attributes(9)]
   public sealed class GsmAmamMasterTblSeg5F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3082)]
    [Attributes(9)]
   public sealed class GsmAmamMasterTblSeg5F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2526)]
    [Attributes(9)]
   public sealed class GsmAmamMasterTblSeg6F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2558)]
    [Attributes(9)]
   public sealed class GsmAmamMasterTblSeg6F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3083)]
    [Attributes(9)]
   public sealed class GsmAmamMasterTblSeg6F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2527)]
    [Attributes(9)]
   public sealed class GsmAmamMasterTblSeg7F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2559)]
    [Attributes(9)]
   public sealed class GsmAmamMasterTblSeg7F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3084)]
    [Attributes(9)]
   public sealed class GsmAmamMasterTblSeg7F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2528)]
    [Attributes(9)]
   public sealed class GsmAmamMasterTblSeg8F1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2560)]
    [Attributes(9)]
   public sealed class GsmAmamMasterTblSeg8F2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3085)]
    [Attributes(9)]
   public sealed class GsmAmamMasterTblSeg8F3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2754)]
    [Attributes(9)]
   public sealed class GsmAmamSysGainDcCorr : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2585)]
    [Attributes(9)]
   public sealed class GsmAmpmMasterTblSeg1F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2617)]
    [Attributes(9)]
   public sealed class GsmAmpmMasterTblSeg1F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3110)]
    [Attributes(9)]
   public sealed class GsmAmpmMasterTblSeg1F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2586)]
    [Attributes(9)]
   public sealed class GsmAmpmMasterTblSeg2F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2618)]
    [Attributes(9)]
   public sealed class GsmAmpmMasterTblSeg2F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3111)]
    [Attributes(9)]
   public sealed class GsmAmpmMasterTblSeg2F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2587)]
    [Attributes(9)]
   public sealed class GsmAmpmMasterTblSeg3F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2619)]
    [Attributes(9)]
   public sealed class GsmAmpmMasterTblSeg3F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3112)]
    [Attributes(9)]
   public sealed class GsmAmpmMasterTblSeg3F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2588)]
    [Attributes(9)]
   public sealed class GsmAmpmMasterTblSeg4F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2620)]
    [Attributes(9)]
   public sealed class GsmAmpmMasterTblSeg4F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3113)]
    [Attributes(9)]
   public sealed class GsmAmpmMasterTblSeg4F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2589)]
    [Attributes(9)]
   public sealed class GsmAmpmMasterTblSeg5F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2621)]
    [Attributes(9)]
   public sealed class GsmAmpmMasterTblSeg5F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3114)]
    [Attributes(9)]
   public sealed class GsmAmpmMasterTblSeg5F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2590)]
    [Attributes(9)]
   public sealed class GsmAmpmMasterTblSeg6F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2622)]
    [Attributes(9)]
   public sealed class GsmAmpmMasterTblSeg6F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3115)]
    [Attributes(9)]
   public sealed class GsmAmpmMasterTblSeg6F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2591)]
    [Attributes(9)]
   public sealed class GsmAmpmMasterTblSeg7F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2623)]
    [Attributes(9)]
   public sealed class GsmAmpmMasterTblSeg7F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3116)]
    [Attributes(9)]
   public sealed class GsmAmpmMasterTblSeg7F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2592)]
    [Attributes(9)]
   public sealed class GsmAmpmMasterTblSeg8F1 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2624)]
    [Attributes(9)]
   public sealed class GsmAmpmMasterTblSeg8F2 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3117)]
    [Attributes(9)]
   public sealed class GsmAmpmMasterTblSeg8F3 : ThirtyTwoUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(1302)]
    [Attributes(9)]
   public sealed class GsmAmrCallConfiguration : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3064)]
    [Attributes(9)]
   public sealed class GsmAntTimingRelToPaEnStart : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3071)]
    [Attributes(9)]
   public sealed class GsmAntTimingRelToPaEnStop : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2742)]
    [Attributes(9)]
   public sealed class GsmAutocalPwrDacF1 : ItemBase
    {
        public short Value1 { get; set; }


        public ushort Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(2766)]
    [Attributes(9)]
   public sealed class GsmAutocalPwrDacF2 : ItemBase
    {
        public short Value1 { get; set; }


        public ushort Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(3146)]
    [Attributes(9)]
   public sealed class GsmAutocalPwrDacF3 : ItemBase
    {
        public short Value1 { get; set; }


        public ushort Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(2778)]
    [Attributes(9)]
   public sealed class GsmBasebandBwVal : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2319)]
    [Attributes(9)]
   public sealed class GsmC0TxFreqComp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2322)]
    [Attributes(9)]
   public sealed class GsmC1TxFreqComp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(724)]
    [Attributes(9)]
   public sealed class GsmCalArfcn : EightUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2750)]
    [Attributes(9)]
   public sealed class GsmCalpathRsb : FourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4869)]
    [Attributes(9)]
   public sealed class GsmCarrierSuppression : TwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4871)]
    [Attributes(9)]
   public sealed class GsmDcsCarrierSuppression : TwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2325)]
    [Attributes(9)]
   public sealed class GsmEnableTxFreqCompVsPcl : ItemBase
    {
        [FieldCount(15)]
        public sbyte[] Value { get; set; }
    }

    [Serializable]
    [NvItemId(3501)]
    [Attributes(9)]
   public sealed class GsmGainrange5Switchpoints : TwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(916)]
    [Attributes(9)]
   public sealed class GsmGainrangeSwitchpoints : SixSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4129)]
    [Attributes(9)]
   public sealed class GsmGmskMultislot2TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4130)]
    [Attributes(9)]
   public sealed class GsmGmskMultislot3TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4131)]
    [Attributes(9)]
   public sealed class GsmGmskMultislot4TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4132)]
    [Attributes(9)]
   public sealed class GsmGmskMultislot5TxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4176)]
    [Attributes(9)]
   public sealed class GsmIm21800 : ItemBase
    {
        [FieldCount(3)]
        public ushort[] Value1 { get; set; }

        [FieldCount(7)]
        public byte[] Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(4177)]
    [Attributes(9)]
   public sealed class GsmIm21900 : ItemBase
    {
        [FieldCount(3)]
        public ushort[] Value1 { get; set; }

        [FieldCount(7)]
        public byte[] Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(4174)]
    [Attributes(9)]
   public sealed class GsmIm2850 : ItemBase
    {
        [FieldCount(3)]
        public ushort[] Value1 { get; set; }

        [FieldCount(7)]
        public byte[] Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(4175)]
    [Attributes(9)]
   public sealed class GsmIm2900 : ItemBase
    {
        [FieldCount(3)]
        public ushort[] Value1 { get; set; }

        [FieldCount(7)]
        public byte[] Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(5477)]
    [Attributes(9)]
   public sealed class GsmLinearTxGainParam : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2774)]
    [Attributes(9)]
   public sealed class GsmOpllBwVal : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3063)]
    [Attributes(9)]
   public sealed class GsmPaEnStart : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3070)]
    [Attributes(9)]
   public sealed class GsmPaEnStop : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(802)]
    [Attributes(9)]
   public sealed class GsmPaGainSlope : ItemBase
    {
        [FieldCount(15)]
        public byte[] Value { get; set; }
    }

    [Serializable]
    [NvItemId(819)]
    [Attributes(9)]
   public sealed class GsmPaStartTimeOffset : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(820)]
    [Attributes(9)]
   public sealed class GsmPaStopTimeOffset : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1273)]
    [Attributes(9)]
   public sealed class GsmPaTempCompIndex0 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1283)]
    [Attributes(9)]
   public sealed class GsmPaTempCompIndex10 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1284)]
    [Attributes(9)]
   public sealed class GsmPaTempCompIndex11 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1285)]
    [Attributes(9)]
   public sealed class GsmPaTempCompIndex12 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1286)]
    [Attributes(9)]
   public sealed class GsmPaTempCompIndex13 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(934)]
    [Attributes(9)]
   public sealed class GsmPaTempCompIndex14 : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1274)]
    [Attributes(9)]
   public sealed class GsmPaTempCompIndex1 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1275)]
    [Attributes(9)]
   public sealed class GsmPaTempCompIndex2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1276)]
    [Attributes(9)]
   public sealed class GsmPaTempCompIndex3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1277)]
    [Attributes(9)]
   public sealed class GsmPaTempCompIndex4 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1278)]
    [Attributes(9)]
   public sealed class GsmPaTempCompIndex5 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1279)]
    [Attributes(9)]
   public sealed class GsmPaTempCompIndex6 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1280)]
    [Attributes(9)]
   public sealed class GsmPaTempCompIndex7 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1281)]
    [Attributes(9)]
   public sealed class GsmPaTempCompIndex8 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1282)]
    [Attributes(9)]
   public sealed class GsmPaTempCompIndex9 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1303)]
    [Attributes(9)]
   public sealed class GsmPaTempCompInt8Index14 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4369)]
    [Attributes(9)]
    public sealed class GsmPaTempCompMaxPwr : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4215)]
    [Attributes(9)]
   public sealed class GsmPathDelayColdTempVsFreq : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4213)]
    [Attributes(9)]
   public sealed class GsmPathDelayCompFreqTbl : EightUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4217)]
    [Attributes(9)]
   public sealed class GsmPathDelayHotTempVsFreq : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4216)]
    [Attributes(9)]
   public sealed class GsmPathDelayRoomTempVsFreq : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3431)]
    [Attributes(9)]
   public sealed class GsmPaTransitionTable : ItemBase
    {
        [FieldCount(48)]
        public ushort[] Value { get; set; }
    }

    [Serializable]
    [NvItemId(2770)]
    [Attributes(9)]
   public sealed class GsmPolarPathDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3353)]
    [Attributes(9)]
   public sealed class GsmPolarRampProfile : SixtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3059)]
    [Attributes(9)]
   public sealed class GsmPowerLevels : ItemBase
    {
        [FieldCount(15)]
        public short[] Value { get; set; }
    }

    [Serializable]
    [NvItemId(2097)]
    [Attributes(9)]
   public sealed class GsmPrdi00 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2098)]
    [Attributes(9)]
   public sealed class GsmPrdi01 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2099)]
    [Attributes(9)]
   public sealed class GsmPrdi02 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2100)]
    [Attributes(9)]
   public sealed class GsmPrdi03 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2101)]
    [Attributes(9)]
   public sealed class GsmPrdi04 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2102)]
    [Attributes(9)]
   public sealed class GsmPrdi05 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2103)]
    [Attributes(9)]
   public sealed class GsmPrdi06 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2104)]
    [Attributes(9)]
   public sealed class GsmPrdi07 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2105)]
    [Attributes(9)]
   public sealed class GsmPrdi08 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2106)]
    [Attributes(9)]
   public sealed class GsmPrdi09 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2107)]
    [Attributes(9)]
   public sealed class GsmPrdi10 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2108)]
    [Attributes(9)]
   public sealed class GsmPrdi11 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(815)]
    [Attributes(9)]
   public sealed class GsmPrechargeDur : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(813)]
    [Attributes(9)]
   public sealed class GsmPrecharge : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2086)]
    [Attributes(9)]
   public sealed class GsmPrui00 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2087)]
    [Attributes(9)]
   public sealed class GsmPrui01 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2088)]
    [Attributes(9)]
   public sealed class GsmPrui02 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2089)]
    [Attributes(9)]
   public sealed class GsmPrui03 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2090)]
    [Attributes(9)]
   public sealed class GsmPrui04 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2091)]
    [Attributes(9)]
   public sealed class GsmPrui05 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2092)]
    [Attributes(9)]
   public sealed class GsmPrui06 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2093)]
    [Attributes(9)]
   public sealed class GsmPrui07 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2094)]
    [Attributes(9)]
   public sealed class GsmPrui08 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2095)]
    [Attributes(9)]
   public sealed class GsmPrui09 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2096)]
    [Attributes(9)]
   public sealed class GsmPrui10 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2501)]
    [Attributes(9)]
   public sealed class GsmPrui11 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4372)]
    [Attributes(9)]
   public sealed class GsmRssiTempValues : FourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3151)]
    [Attributes(9)]
   public sealed class GsmRtr6250Rsb : EightUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(726)]
    [Attributes(9)]
   public sealed class GsmRxGainRange1FreqComp : EightUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4374)]
    [Attributes(9)]
   public sealed class GsmRxGainRange1TempComp : ThreeInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(727)]
    [Attributes(9)]
   public sealed class GsmRxGainRange2FreqComp : EightUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4378)]
    [Attributes(9)]
   public sealed class GsmRxGainRange2TempComp : ThreeInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(728)]
    [Attributes(9)]
   public sealed class GsmRxGainRange3FreqComp : EightUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4382)]
    [Attributes(9)]
   public sealed class GsmRxGainRange3TempComp : ThreeInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(729)]
    [Attributes(9)]
   public sealed class GsmRxGainRange4FreqComp : EightUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4386)]
    [Attributes(9)]
   public sealed class GsmRxGainRange4TempComp : ThreeInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3502)]
    [Attributes(9)]
   public sealed class GsmRxGainRange5FreqComp : EightUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4390)]
    [Attributes(9)]
   public sealed class GsmRxGainRange5TempComp : ThreeInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(735)]
    [Attributes(9)]
   public sealed class GsmTrkLoAdjPdmGainSlope : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(734)]
    [Attributes(9)]
   public sealed class GsmTrkLoAdjPdmInitVal : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1891)]
    [Attributes(9)]
   public sealed class GsmTxBurstOffsetAdj : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(755)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampDownIndex00 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(756)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampDownIndex01 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(757)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampDownIndex02 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(758)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampDownIndex03 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(759)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampDownIndex04 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(760)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampDownIndex05 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(761)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampDownIndex06 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(762)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampDownIndex07 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(763)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampDownIndex08 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(764)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampDownIndex09 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(765)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampDownIndex10 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(766)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampDownIndex11 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(767)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampDownIndex12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(768)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampDownIndex13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(769)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampDownIndex14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(740)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampUpIndex00 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(741)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampUpIndex01 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(742)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampUpIndex02 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(743)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampUpIndex03 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(744)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampUpIndex04 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(745)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampUpIndex05 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(746)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampUpIndex06 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(747)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampUpIndex07 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(748)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampUpIndex08 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(749)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampUpIndex09 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(750)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampUpIndex10 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(751)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampUpIndex11 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(752)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampUpIndex12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(753)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampUpIndex13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(754)]
    [Attributes(9)]
   public sealed class GsmTxBurstRampUpIndex14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(804)]
    [Attributes(9)]
   public sealed class GsmTxFreqComp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4179)]
    [Attributes(9)]
   public sealed class GsmTxRsbCorr : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1016)]
    [Attributes(9)]
   public sealed class GsmUmtsCellBroadcastSmsCarrierConfiguration : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1014)]
    [Attributes(41)]
   public sealed class GsmUmtsCellBroadcastSmsServiceTable : ItemBase
    {
        public byte Index { get; set; }


        public byte ActiveService { get; set; }


        public ushort ServiceFrom { get; set; }


        public ushort ServiceTo { get; set; }


        public byte Selected { get; set; }

        [JsonIgnore]
        [FieldCount(30)]
        public byte[] Label { get; set; }

        public string LabelString
        {
            get => StringUtils.GetString(Label);
            set => Label = StringUtils.GetBytes(value, 30);
        }


        public byte LabelEncoding { get; set; }


        public byte BcAlert { get; set; }


        public byte MaxMessages { get; set; }
    }

    [Serializable]
    [NvItemId(1015)]
    [Attributes(9)]
   public sealed class GsmUmtsCellBroadcastSmsServiceTableSize : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1017)]
    [Attributes(9)]
   public sealed class GsmUmtsCellBroadcastSmsUserPreference : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(909)]
    [Attributes(9)]
   public sealed class GsmUmtsSmsBearerPreference : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(806)]
    [Attributes(9)]
   public sealed class GsmVbattHiPaComp : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(807)]
    [Attributes(9)]
   public sealed class GsmVbattLoPaComp : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2306)]
    [Attributes(9)]
   public sealed class GsmVhThBrdi12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2305)]
    [Attributes(9)]
   public sealed class GsmVhThBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2304)]
    [Attributes(9)]
   public sealed class GsmVhThBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2303)]
    [Attributes(9)]
   public sealed class GsmVhThBrui12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2302)]
    [Attributes(9)]
   public sealed class GsmVhThBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2301)]
    [Attributes(9)]
   public sealed class GsmVhThBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2484)]
    [Attributes(9)]
   public sealed class GsmVhThPrdi12 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2483)]
    [Attributes(9)]
   public sealed class GsmVhThPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2482)]
    [Attributes(9)]
   public sealed class GsmVhThPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2481)]
    [Attributes(9)]
   public sealed class GsmVhThPrui12 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2480)]
    [Attributes(9)]
   public sealed class GsmVhThPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2479)]
    [Attributes(9)]
   public sealed class GsmVhThPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2198)]
    [Attributes(9)]
   public sealed class GsmVhTlBrdi12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2197)]
    [Attributes(9)]
   public sealed class GsmVhTlBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2196)]
    [Attributes(9)]
   public sealed class GsmVhTlBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2195)]
    [Attributes(9)]
   public sealed class GsmVhTlBrui12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2194)]
    [Attributes(9)]
   public sealed class GsmVhTlBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2193)]
    [Attributes(9)]
   public sealed class GsmVhTlBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2376)]
    [Attributes(9)]
   public sealed class GsmVhTlPrdi12 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2375)]
    [Attributes(9)]
   public sealed class GsmVhTlPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2374)]
    [Attributes(9)]
   public sealed class GsmVhTlPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2373)]
    [Attributes(9)]
   public sealed class GsmVhTlPrui12 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2372)]
    [Attributes(9)]
   public sealed class GsmVhTlPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2371)]
    [Attributes(9)]
   public sealed class GsmVhTlPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2252)]
    [Attributes(9)]
   public sealed class GsmVhTmBrdi12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2251)]
    [Attributes(9)]
   public sealed class GsmVhTmBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2250)]
    [Attributes(9)]
   public sealed class GsmVhTmBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2249)]
    [Attributes(9)]
   public sealed class GsmVhTmBrui12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2248)]
    [Attributes(9)]
   public sealed class GsmVhTmBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2247)]
    [Attributes(9)]
   public sealed class GsmVhTmBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2430)]
    [Attributes(9)]
   public sealed class GsmVhTmPrdi12 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2429)]
    [Attributes(9)]
   public sealed class GsmVhTmPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2428)]
    [Attributes(9)]
   public sealed class GsmVhTmPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2427)]
    [Attributes(9)]
   public sealed class GsmVhTmPrui12 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2426)]
    [Attributes(9)]
   public sealed class GsmVhTmPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2425)]
    [Attributes(9)]
   public sealed class GsmVhTmPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2270)]
    [Attributes(9)]
   public sealed class GsmVlThBrdi12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2269)]
    [Attributes(9)]
   public sealed class GsmVlThBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2268)]
    [Attributes(9)]
   public sealed class GsmVlThBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2267)]
    [Attributes(9)]
   public sealed class GsmVlThBrui12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2266)]
    [Attributes(9)]
   public sealed class GsmVlThBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2265)]
    [Attributes(9)]
   public sealed class GsmVlThBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2448)]
    [Attributes(9)]
   public sealed class GsmVlThPrdi12 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2447)]
    [Attributes(9)]
   public sealed class GsmVlThPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2446)]
    [Attributes(9)]
   public sealed class GsmVlThPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2445)]
    [Attributes(9)]
   public sealed class GsmVlThPrui12 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2444)]
    [Attributes(9)]
   public sealed class GsmVlThPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2443)]
    [Attributes(9)]
   public sealed class GsmVlThPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2162)]
    [Attributes(9)]
   public sealed class GsmVlTlBrdi12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2161)]
    [Attributes(9)]
   public sealed class GsmVlTlBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2160)]
    [Attributes(9)]
   public sealed class GsmVlTlBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2159)]
    [Attributes(9)]
   public sealed class GsmVlTlBrui12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2158)]
    [Attributes(9)]
   public sealed class GsmVlTlBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2157)]
    [Attributes(9)]
   public sealed class GsmVlTlBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2340)]
    [Attributes(9)]
   public sealed class GsmVlTlPrdi12 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2339)]
    [Attributes(9)]
   public sealed class GsmVlTlPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2338)]
    [Attributes(9)]
   public sealed class GsmVlTlPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2337)]
    [Attributes(9)]
   public sealed class GsmVlTlPrui12 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2336)]
    [Attributes(9)]
   public sealed class GsmVlTlPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2335)]
    [Attributes(9)]
   public sealed class GsmVlTlPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2216)]
    [Attributes(9)]
   public sealed class GsmVlTmBrdi12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2215)]
    [Attributes(9)]
   public sealed class GsmVlTmBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2214)]
    [Attributes(9)]
   public sealed class GsmVlTmBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2213)]
    [Attributes(9)]
   public sealed class GsmVlTmBrui12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2212)]
    [Attributes(9)]
   public sealed class GsmVlTmBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2211)]
    [Attributes(9)]
   public sealed class GsmVlTmBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2394)]
    [Attributes(9)]
   public sealed class GsmVlTmPrdi12 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2393)]
    [Attributes(9)]
   public sealed class GsmVlTmPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2392)]
    [Attributes(9)]
   public sealed class GsmVlTmPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2391)]
    [Attributes(9)]
   public sealed class GsmVlTmPrui12 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2390)]
    [Attributes(9)]
   public sealed class GsmVlTmPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2389)]
    [Attributes(9)]
   public sealed class GsmVlTmPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2288)]
    [Attributes(9)]
   public sealed class GsmVmThBrdi12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2287)]
    [Attributes(9)]
   public sealed class GsmVmThBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2286)]
    [Attributes(9)]
   public sealed class GsmVmThBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2285)]
    [Attributes(9)]
   public sealed class GsmVmThBrui12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2284)]
    [Attributes(9)]
   public sealed class GsmVmThBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2283)]
    [Attributes(9)]
   public sealed class GsmVmThBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2466)]
    [Attributes(9)]
   public sealed class GsmVmThPrdi12 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2465)]
    [Attributes(9)]
   public sealed class GsmVmThPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2464)]
    [Attributes(9)]
   public sealed class GsmVmThPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2463)]
    [Attributes(9)]
   public sealed class GsmVmThPrui12 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2462)]
    [Attributes(9)]
   public sealed class GsmVmThPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2461)]
    [Attributes(9)]
   public sealed class GsmVmThPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2180)]
    [Attributes(9)]
   public sealed class GsmVmTlBrdi12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2179)]
    [Attributes(9)]
   public sealed class GsmVmTlBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2178)]
    [Attributes(9)]
   public sealed class GsmVmTlBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2177)]
    [Attributes(9)]
   public sealed class GsmVmTlBrui12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2176)]
    [Attributes(9)]
   public sealed class GsmVmTlBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2175)]
    [Attributes(9)]
   public sealed class GsmVmTlBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2358)]
    [Attributes(9)]
   public sealed class GsmVmTlPrdi12 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2357)]
    [Attributes(9)]
   public sealed class GsmVmTlPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2356)]
    [Attributes(9)]
   public sealed class GsmVmTlPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2355)]
    [Attributes(9)]
   public sealed class GsmVmTlPrui12 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2354)]
    [Attributes(9)]
   public sealed class GsmVmTlPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2353)]
    [Attributes(9)]
   public sealed class GsmVmTlPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2234)]
    [Attributes(9)]
   public sealed class GsmVmTmBrdi12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2233)]
    [Attributes(9)]
   public sealed class GsmVmTmBrdi13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2232)]
    [Attributes(9)]
   public sealed class GsmVmTmBrdi14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2231)]
    [Attributes(9)]
   public sealed class GsmVmTmBrui12 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2230)]
    [Attributes(9)]
   public sealed class GsmVmTmBrui13 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2229)]
    [Attributes(9)]
   public sealed class GsmVmTmBrui14 : ThirtyUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2412)]
    [Attributes(9)]
   public sealed class GsmVmTmPrdi12 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2411)]
    [Attributes(9)]
   public sealed class GsmVmTmPrdi13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2410)]
    [Attributes(9)]
   public sealed class GsmVmTmPrdi14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2409)]
    [Attributes(9)]
   public sealed class GsmVmTmPrui12 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2408)]
    [Attributes(9)]
   public sealed class GsmVmTmPrui13 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2407)]
    [Attributes(9)]
   public sealed class GsmVmTmPrui14 : ThirtyByteItemBase
    {
    }

    [Serializable]
    [NvItemId(143)]
    [Attributes(9)]
   public sealed class HdetOff : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(144)]
    [Attributes(9)]
   public sealed class HdetSpn : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3514)]
    [Attributes(9)]
   public sealed class HdrbcmcsDisableSubnetReg : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4528)]
    [Attributes(9)]
   public sealed class HdrEmpaSupported : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6429)]
    [Attributes(41)]
   public sealed class HdrIs683AScanList : ItemBase
    {
        public byte Nam { get; set; }


        public byte Band { get; set; }


        public ushort Chan { get; set; }
    }

    [Serializable]
    [NvItemId(4231)]
    [Attributes(9)]
   public sealed class HdrL1DebugMask : ItemBase
    {
        public ulong Field1 { get; set; }


        public ulong Field2 { get; set; }
    }

    [Serializable]
    [NvItemId(818)]
    [Attributes(9)]
   public sealed class HdrReceiveDiversity : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2844)]
    [Attributes(9)]
   public sealed class HdrscpBcmcsEnable : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(4964)]
    [Attributes(9)]
   public sealed class HdrScpForceAtConfiguration : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4204)]
    [Attributes(9)]
   public sealed class HdrScpForceRelease0SessionConfiguration : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6832)]
    [Attributes(9)]
   public sealed class HdrScpForceRestrictedCf : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(475)]
    [Attributes(9)]
   public sealed class HdrScpSessionStatus : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3458)]
    [Attributes(9)]
   public sealed class HdrScpSubtypeCustomConfig : ItemBase
    {
        public byte CustomConfigIsActive { get; set; }


        public uint Subtype2PhysicalLayer { get; set; }


        public uint EnhancedCcmac { get; set; }


        public uint EnhancedAcmac { get; set; }


        public uint EnhancedFtcmac { get; set; }
    }

    [Serializable]
    [NvItemId(259)]
    [Attributes(45)]
   public sealed class HomeSidNidList : ItemBase
    {
        public byte Nam { get; set; }


        public ushort Sid1 { get; set; }


        public ushort Nid1 { get; set; }


        public ushort Sid2 { get; set; }


        public ushort Nid2 { get; set; }


        public ushort Sid3 { get; set; }


        public ushort Nid3 { get; set; }


        public ushort Sid4 { get; set; }


        public ushort Nid4 { get; set; }


        public ushort Sid5 { get; set; }


        public ushort Nid5 { get; set; }


        public ushort Sid6 { get; set; }


        public ushort Nid6 { get; set; }


        public ushort Sid7 { get; set; }


        public ushort Nid7 { get; set; }


        public ushort Sid8 { get; set; }


        public ushort Nid8 { get; set; }


        public ushort Sid9 { get; set; }


        public ushort Nid9 { get; set; }


        public ushort Sid10 { get; set; }


        public ushort Nid10 { get; set; }


        public ushort Sid11 { get; set; }


        public ushort Nid11 { get; set; }


        public ushort Sid12 { get; set; }


        public ushort Nid12 { get; set; }


        public ushort Sid13 { get; set; }


        public ushort Nid13 { get; set; }


        public ushort Sid14 { get; set; }


        public ushort Nid14 { get; set; }


        public ushort Sid15 { get; set; }


        public ushort Nid15 { get; set; }


        public ushort Sid16 { get; set; }


        public ushort Nid16 { get; set; }


        public ushort Sid17 { get; set; }


        public ushort Nid17 { get; set; }


        public ushort Sid18 { get; set; }


        public ushort Nid18 { get; set; }


        public ushort Sid19 { get; set; }


        public ushort Nid19 { get; set; }


        public ushort Sid20 { get; set; }


        public ushort Nid20 { get; set; }
    }

    [Serializable]
    [NvItemId(4960)]
    [Attributes(9)]
   public sealed class HSBasedPlusDialSetting : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4118)]
    [Attributes(9)]
   public sealed class HsdpaCategory : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(198)]
    [Attributes(9)]
   public sealed class HwConfig : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(364)]
    [Attributes(9)]
   public sealed class IbatPerLsb : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(365)]
    [Attributes(9)]
   public sealed class Iext : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(366)]
    [Attributes(9)]
   public sealed class IextThr : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(381)]
    [Attributes(9)]
   public sealed class ImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(382)]
    [Attributes(9)]
   public sealed class ImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(585)]
    [Attributes(9)]
   public sealed class ImLevel3 : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(586)]
    [Attributes(9)]
   public sealed class ImLevel4 : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(177)]
    [Attributes(45)]
   public sealed class Imsi11_12 : ItemBase
    {
        public byte Nam { get; set; }


        public byte Value { get; set; }
    }

    [Serializable]
    [NvItemId(176)]
    [Attributes(45)]
   public sealed class ImsiMcc : ItemBase
    {
        public byte Nam { get; set; }


        public ushort Value { get; set; }
    }

    [Serializable]
    [NvItemId(906)]
    [Attributes(9)]
   public sealed class IpPppPassword : ItemBase
    {
        public byte Length { get; set; }


        [JsonIgnore]
        [FieldCount(127)]
        public byte[] Value { get; set; }

        public string ValueString
        {
            get => StringUtils.GetString(Value);
            set => Value = StringUtils.GetBytes(value, 127);
        }
    }

    [Serializable]
    [NvItemId(1896)]
    [Attributes(9)]
   public sealed class Ipv6Enabled : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1897)]
    [Attributes(9)]
   public sealed class Ipv6StateMachineConfiguration : ItemBase
    {
        public ushort InitSolDelay { get; set; }


        public ushort SolInterval { get; set; }


        public ushort ResolInterval { get; set; }


        public ushort MaxSolAttempts { get; set; }


        public ushort MaxResolAttempts { get; set; }


        public ushort PreRaExpResolTime { get; set; }
    }

    [Serializable]
    [NvItemId(405)]
    [Attributes(9)]
   public sealed class Is2000CaiRadioConfigurationRcPreference : UInt16ItemBase
    {
    }

    public enum IWlanAuthModeValues : byte
    {
        Uac = 0,
        Uas = 1,
        None = 2
    }

    [Serializable]
    [NvItemId(5828)]
    [Attributes(9)]
   public sealed class IWlanAuthMode : ItemBase
    {
        [JsonIgnore]
        public byte Value { get; set; }

        public string ValueString
        {
            get => $"{(IWlanAuthModeValues) Value}";
            set =>
                Value =
                    EnumUtils.ParseEnumByte(typeof(IWlanAuthModeValues), value);
        }
    }

    [Serializable]
    [NvItemId(5847)]
    [Attributes(9)]
   public sealed class IWlanMultipleAuthenticationSupported : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(899)]
    [Attributes(9)]
   public sealed class JCdmaM512ModeSetting : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(72)]
    [Attributes(9)]
   public sealed class Lcd : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(843)]
    [Attributes(9)]
   public sealed class LnaBypassTimer0 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(844)]
    [Attributes(9)]
   public sealed class LnaBypassTimer1 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(845)]
    [Attributes(9)]
   public sealed class LnaBypassTimer2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(846)]
    [Attributes(9)]
   public sealed class LnaBypassTimer3 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(839)]
    [Attributes(9)]
   public sealed class LnaNonBypassTimer0 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(840)]
    [Attributes(9)]
   public sealed class LnaNonBypassTimer1 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(841)]
    [Attributes(9)]
   public sealed class LnaNonBypassTimer2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(842)]
    [Attributes(9)]
   public sealed class LnaNonBypassTimer3 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(378)]
    [Attributes(9)]
   public sealed class LnaRange12Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(377)]
    [Attributes(9)]
   public sealed class LnaRange2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(376)]
    [Attributes(9)]
   public sealed class LnaRange2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(158)]
    [Attributes(9)]
   public sealed class LnaRangeFall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(159)]
    [Attributes(9)]
   public sealed class LnaRangeOffset : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(156)]
    [Attributes(9)]
   public sealed class LnaRangePol : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(157)]
    [Attributes(9)]
   public sealed class LnaRangeRise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6503)]
    [Attributes(9)]
   public sealed class LteB13AgcPaOnRiseFallDelay : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6504)]
    [Attributes(9)]
   public sealed class LteB13AgcTxOnRiseFallDelay : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6530)]
    [Attributes(9)]
   public sealed class LteB13Antsel : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6585)]
    [Attributes(9)]
   public sealed class LteB13C0C1Delay : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6531)]
    [Attributes(9)]
   public sealed class LteB13C1Antsel : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6539)]
    [Attributes(9)]
   public sealed class LteB13C1Im2Values : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6534)]
    [Attributes(9)]
   public sealed class LteB13C1ImLevel : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6536)]
    [Attributes(9)]
   public sealed class LteB13C1LnaPhaseCtrl : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6533)]
    [Attributes(9)]
   public sealed class LteB13C1LnaRangeRiseFall : ThirtyTwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6532)]
    [Attributes(9)]
   public sealed class LteB13C1NonbypassBypassTimer : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6540)]
    [Attributes(9)]
   public sealed class LteB13C1RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6537)]
    [Attributes(9)]
   public sealed class LteB13C1RxGain : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6538)]
    [Attributes(9)]
   public sealed class LteB13C1RxGainVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6535)]
    [Attributes(9)]
   public sealed class LteB13C1RxGainVsTemp : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6750)]
    [Attributes(9)]
   public sealed class LteB13DrxModeSel : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6501)]
    [Attributes(9)]
   public sealed class LteB13EncBtf : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6527)]
    [Attributes(9)]
   public sealed class LteB13ExpHdetVsAgc : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7226)]
    [Attributes(9)]
   public sealed class LteB13ExpLpmHdetVsAgc : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7227)]
    [Attributes(9)]
   public sealed class LteB13HdetHpmLpmSwitchPoint : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6529)]
    [Attributes(9)]
   public sealed class LteB13HdetOffSpan : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6499)]
    [Attributes(9)]
   public sealed class LteB13Im2Values : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6494)]
    [Attributes(9)]
   public sealed class LteB13ImLevel : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6498)]
    [Attributes(9)]
   public sealed class LteB13LnaPhaseCtrl : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6492)]
    [Attributes(9)]
   public sealed class LteB13LnaRangeRiseFall : ThirtyTwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6502)]
    [Attributes(9)]
   public sealed class LteB13MaxTxPower : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6514)]
    [Attributes(9)]
   public sealed class LteB13MprBasedPaSwitchpointsShift : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6493)]
    [Attributes(9)]
   public sealed class LteB13NonbypassBypassTimer : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6507)]
    [Attributes(9)]
   public sealed class LteB13PaCompensateUpDown : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6505)]
    [Attributes(9)]
   public sealed class LteB13PaGainUpDownTime : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6509)]
    [Attributes(9)]
   public sealed class LteB13PaRangeMap : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6511)]
    [Attributes(9)]
   public sealed class LteB13PaRiseFallThreshold : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6490)]
    [Attributes(9)]
   public sealed class LteB13RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6491)]
    [Attributes(9)]
   public sealed class LteB13RxDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6500)]
    [Attributes(9)]
   public sealed class LteB13RxfMismatchComp : TwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6496)]
    [Attributes(9)]
   public sealed class LteB13RxGain : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6497)]
    [Attributes(9)]
   public sealed class LteB13RxGainVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6495)]
    [Attributes(9)]
   public sealed class LteB13RxGainVsTemp : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6510)]
    [Attributes(9)]
   public sealed class LteB13TimerHysterisis : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6517)]
    [Attributes(9)]
   public sealed class LteB13TxAgcOffset : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6512)]
    [Attributes(9)]
   public sealed class LteB13TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6823)]
    [Attributes(9)]
   public sealed class LteB13TxCarrierFeedthroughComp : TwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6526)]
    [Attributes(9)]
   public sealed class LteB13TxCompVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6516)]
    [Attributes(9)]
   public sealed class LteB13TxDigitalGainComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6522)]
    [Attributes(9)]
   public sealed class LteB13TxGainIndex0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6523)]
    [Attributes(9)]
   public sealed class LteB13TxGainIndex1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6524)]
    [Attributes(9)]
   public sealed class LteB13TxGainIndex2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6525)]
    [Attributes(9)]
   public sealed class LteB13TxGainIndex3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6528)]
    [Attributes(9)]
   public sealed class LteB13TxLimitVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6513)]
    [Attributes(9)]
   public sealed class LteB13TxLimitVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6518)]
    [Attributes(9)]
   public sealed class LteB13TxLinMaster0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6519)]
    [Attributes(9)]
   public sealed class LteB13TxLinMaster1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6520)]
    [Attributes(9)]
   public sealed class LteB13TxLinMaster2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6521)]
    [Attributes(9)]
   public sealed class LteB13TxLinMaster3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6508)]
    [Attributes(9)]
   public sealed class LteB13TxLinVsTemp : SixtyFourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6818)]
    [Attributes(9)]
   public sealed class LteB13TxMismatchComp : TwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6515)]
    [Attributes(9)]
   public sealed class LteB13TxMprBackoff : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6506)]
    [Attributes(9)]
   public sealed class LteB13TxRotAnglePaState : EightUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6607)]
    [Attributes(9)]
   public sealed class LteB17AgcPaOnRiseFallDelay : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6608)]
    [Attributes(9)]
   public sealed class LteB17AgcTxOnRiseFallDelay : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6634)]
    [Attributes(9)]
   public sealed class LteB17Antsel : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6636)]
    [Attributes(9)]
   public sealed class LteB17C0C1Delay : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6635)]
    [Attributes(9)]
   public sealed class LteB17C1Antsel : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6643)]
    [Attributes(9)]
   public sealed class LteB17C1Im2Values : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6638)]
    [Attributes(9)]
   public sealed class LteB17C1ImLevel : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6640)]
    [Attributes(9)]
   public sealed class LteB17C1LnaPhaseCtrl : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6637)]
    [Attributes(9)]
   public sealed class LteB17C1LnaRangeRiseFall : ThirtyTwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6645)]
    [Attributes(9)]
   public sealed class LteB17C1NonbypassBypassTimer : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6644)]
    [Attributes(9)]
   public sealed class LteB17C1RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6641)]
    [Attributes(9)]
   public sealed class LteB17C1RxGain : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6642)]
    [Attributes(9)]
   public sealed class LteB17C1RxGainVsFreq : ItemBase
    {
        [FieldCount(128)]
        public byte[] Value { get; set; }
    }

    [Serializable]
    [NvItemId(7225)]
    [Attributes(9)]
   public sealed class LteB17C1RxGainVsFreqI : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6639)]
    [Attributes(9)]
   public sealed class LteB17C1RxGainVsTemp : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6752)]
    [Attributes(9)]
   public sealed class LteB17DrxModeSel : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6605)]
    [Attributes(9)]
   public sealed class LteB17EncBtf : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6631)]
    [Attributes(9)]
   public sealed class LteB17ExpHdetVsAgc : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6633)]
    [Attributes(9)]
   public sealed class LteB17HdetOffSpan : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6603)]
    [Attributes(9)]
   public sealed class LteB17Im2Values : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6598)]
    [Attributes(9)]
   public sealed class LteB17ImLevel : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6602)]
    [Attributes(9)]
   public sealed class LteB17LnaPhaseCtrl : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6597)]
    [Attributes(9)]
   public sealed class LteB17LnaRangeRiseFall : ThirtyTwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6606)]
    [Attributes(9)]
   public sealed class LteB17MaxTxPower : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6619)]
    [Attributes(9)]
   public sealed class LteB17MprBasedPaSwitchpointsShift : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6594)]
    [Attributes(9)]
   public sealed class LteB17NonbypassBypassTimer : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6611)]
    [Attributes(9)]
   public sealed class LteB17PaCompensateUpDown : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6609)]
    [Attributes(9)]
   public sealed class LteB17PaGainUpDownTime : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6613)]
    [Attributes(9)]
   public sealed class LteB17PaRangeMap : FourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6615)]
    [Attributes(9)]
   public sealed class LteB17PaRiseFallThreshold : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6596)]
    [Attributes(9)]
   public sealed class LteB17RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6595)]
    [Attributes(9)]
   public sealed class LteB17RxDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6604)]
    [Attributes(9)]
   public sealed class LteB17RxfMismatchComp : TwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6600)]
    [Attributes(9)]
   public sealed class LteB17RxGain : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6601)]
    [Attributes(9)]
   public sealed class LteB17RxGainVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6599)]
    [Attributes(9)]
   public sealed class LteB17RxGainVsTemp : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6614)]
    [Attributes(9)]
   public sealed class LteB17TimerHysterisis : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6622)]
    [Attributes(9)]
   public sealed class LteB17TxAgcOffset : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6616)]
    [Attributes(9)]
   public sealed class LteB17TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6825)]
    [Attributes(9)]
   public sealed class LteB17TxCarrierFeedthroughComp : TwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6630)]
    [Attributes(9)]
   public sealed class LteB17TxCompVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6621)]
    [Attributes(9)]
   public sealed class LteB17TxDigitalGainComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6626)]
    [Attributes(9)]
   public sealed class LteB17TxGainIndex0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6627)]
    [Attributes(9)]
   public sealed class LteB17TxGainIndex1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6628)]
    [Attributes(9)]
   public sealed class LteB17TxGainIndex2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6629)]
    [Attributes(9)]
   public sealed class LteB17TxGainIndex3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6632)]
    [Attributes(9)]
   public sealed class LteB17TxLimitVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6617)]
    [Attributes(9)]
   public sealed class LteB17TxLimitVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6618)]
    [Attributes(9)]
   public sealed class LteB17TxLinMaster0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6623)]
    [Attributes(9)]
   public sealed class LteB17TxLinMaster1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6624)]
    [Attributes(9)]
   public sealed class LteB17TxLinMaster2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6625)]
    [Attributes(9)]
   public sealed class LteB17TxLinMaster3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6612)]
    [Attributes(9)]
   public sealed class LteB17TxLinVsTemp : SixtyFourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6820)]
    [Attributes(9)]
   public sealed class LteB17TxMismatchComp : TwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6620)]
    [Attributes(9)]
   public sealed class LteB17TxMprBackoff : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6610)]
    [Attributes(9)]
   public sealed class LteB17TxRotAnglePaState : EightUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6711)]
    [Attributes(9)]
   public sealed class LteB1AgcPaOnRiseFallDelay : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6712)]
    [Attributes(9)]
   public sealed class LteB1AgcTxOnRiseFallDelay : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6738)]
    [Attributes(9)]
   public sealed class LteB1Antsel : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6740)]
    [Attributes(9)]
   public sealed class LteB1C0C1Delay : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6739)]
    [Attributes(9)]
   public sealed class LteB1C1Antsel : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6748)]
    [Attributes(9)]
   public sealed class LteB1C1Im2Values : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6743)]
    [Attributes(9)]
   public sealed class LteB1C1ImLevel : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6745)]
    [Attributes(9)]
   public sealed class LteB1C1LnaPhaseCtrl : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6742)]
    [Attributes(9)]
   public sealed class LteB1C1LnaRangeRiseFall : ThirtyTwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6741)]
    [Attributes(9)]
   public sealed class LteB1C1NonbypassBypassTimer : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6749)]
    [Attributes(9)]
   public sealed class LteB1C1RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6746)]
    [Attributes(9)]
   public sealed class LteB1C1RxGain : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6747)]
    [Attributes(9)]
   public sealed class LteB1C1RxGainVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6744)]
    [Attributes(9)]
   public sealed class LteB1C1RxGainVsTemp : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6754)]
    [Attributes(9)]
   public sealed class LteB1DrxModeSel : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6709)]
    [Attributes(9)]
   public sealed class LteB1EncBtf : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6735)]
    [Attributes(9)]
   public sealed class LteB1ExpHdetVsAgc : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7229)]
    [Attributes(9)]
   public sealed class LteB1HdetHpmLpmSwitchPoint : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6737)]
    [Attributes(9)]
   public sealed class LteB1HdetOffSpan : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6707)]
    [Attributes(9)]
   public sealed class LteB1Im2Values : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6702)]
    [Attributes(9)]
   public sealed class LteB1ImLevel : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6706)]
    [Attributes(9)]
   public sealed class LteB1LnaPhaseCtrl : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6701)]
    [Attributes(9)]
   public sealed class LteB1LnaRangeRiseFall : ThirtyTwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6710)]
    [Attributes(9)]
   public sealed class LteB1MaxTxPower : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6722)]
    [Attributes(9)]
   public sealed class LteB1MprBasedPaSwitchpointsShift : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6698)]
    [Attributes(9)]
   public sealed class LteB1NonbypassBypassTimer : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6715)]
    [Attributes(9)]
   public sealed class LteB1PaCompensateUpDown : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6713)]
    [Attributes(9)]
   public sealed class LteB1PaGainUpDownTime : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6717)]
    [Attributes(9)]
   public sealed class LteB1PaRangeMap : FourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6719)]
    [Attributes(9)]
   public sealed class LteB1PaRiseFallThreshold : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6700)]
    [Attributes(9)]
   public sealed class LteB1RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6699)]
    [Attributes(9)]
   public sealed class LteB1RxDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6708)]
    [Attributes(9)]
   public sealed class LteB1RxfMismatchComp : TwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6704)]
    [Attributes(9)]
   public sealed class LteB1RxGain : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6705)]
    [Attributes(9)]
   public sealed class LteB1RxGainVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6703)]
    [Attributes(9)]
   public sealed class LteB1RxGainVsTemp : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6718)]
    [Attributes(9)]
   public sealed class LteB1TimerHysterisis : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6725)]
    [Attributes(9)]
   public sealed class LteB1TxAgcOffset : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6720)]
    [Attributes(9)]
   public sealed class LteB1TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6827)]
    [Attributes(9)]
   public sealed class LteB1TxCarrierFeedthroughComp : TwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6734)]
    [Attributes(9)]
   public sealed class LteB1TxCompVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6724)]
    [Attributes(9)]
   public sealed class LteB1TxDigitalGainComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6730)]
    [Attributes(9)]
   public sealed class LteB1TxGainIndex0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6731)]
    [Attributes(9)]
   public sealed class LteB1TxGainIndex1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6732)]
    [Attributes(9)]
   public sealed class LteB1TxGainIndex2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6733)]
    [Attributes(9)]
   public sealed class LteB1TxGainIndex3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6736)]
    [Attributes(9)]
   public sealed class LteB1TxLimitVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6721)]
    [Attributes(9)]
   public sealed class LteB1TxLimitVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6726)]
    [Attributes(9)]
   public sealed class LteB1TxLinMaster0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6727)]
    [Attributes(9)]
   public sealed class LteB1TxLinMaster1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6728)]
    [Attributes(9)]
   public sealed class LteB1TxLinMaster2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6729)]
    [Attributes(9)]
   public sealed class LteB1TxLinMaster3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6716)]
    [Attributes(9)]
   public sealed class LteB1TxLinVsTemp : SixtyFourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6822)]
    [Attributes(9)]
   public sealed class LteB1TxMismatchComp : TwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6723)]
    [Attributes(9)]
   public sealed class LteB1TxMprBackoff : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6714)]
    [Attributes(9)]
   public sealed class LteB1TxRotAnglePaState : EightUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6659)]
    [Attributes(9)]
   public sealed class LteB40AgcPaOnRiseFallDelay : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6660)]
    [Attributes(9)]
   public sealed class LteB40AgcTxOnRiseFallDelay : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6686)]
    [Attributes(9)]
   public sealed class LteB40Antsel : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6688)]
    [Attributes(9)]
   public sealed class LteB40C0C1Delay : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6687)]
    [Attributes(9)]
   public sealed class LteB40C1Antsel : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6696)]
    [Attributes(9)]
   public sealed class LteB40C1Im2Values : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6691)]
    [Attributes(9)]
   public sealed class LteB40C1ImLevel : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6693)]
    [Attributes(9)]
   public sealed class LteB40C1LnaPhaseCtrl : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6690)]
    [Attributes(9)]
   public sealed class LteB40C1LnaRangeRiseFall : ThirtyTwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6689)]
    [Attributes(9)]
   public sealed class LteB40C1NonbypassBypassTimer : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6697)]
    [Attributes(9)]
   public sealed class LteB40C1RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6694)]
    [Attributes(9)]
   public sealed class LteB40C1RxGain : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6695)]
    [Attributes(9)]
   public sealed class LteB40C1RxGainVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6692)]
    [Attributes(9)]
   public sealed class LteB40C1RxGainVsTemp : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6753)]
    [Attributes(9)]
   public sealed class LteB40DrxModeSel : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6657)]
    [Attributes(9)]
   public sealed class LteB40EncBtf : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6683)]
    [Attributes(9)]
   public sealed class LteB40ExpHdetVsAgc : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6685)]
    [Attributes(9)]
   public sealed class LteB40HdetOffSpan : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6655)]
    [Attributes(9)]
   public sealed class LteB40Im2Values : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6650)]
    [Attributes(9)]
   public sealed class LteB40ImLevel : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6654)]
    [Attributes(9)]
   public sealed class LteB40LnaPhaseCtrl : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6649)]
    [Attributes(9)]
   public sealed class LteB40LnaRangeRiseFall : ThirtyTwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6658)]
    [Attributes(9)]
   public sealed class LteB40MaxTxPower : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6670)]
    [Attributes(9)]
   public sealed class LteB40MprBasedPaSwitchpointsShift : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6646)]
    [Attributes(9)]
   public sealed class LteB40NonbypassBypassTimer : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6663)]
    [Attributes(9)]
   public sealed class LteB40PaCompensateUpDown : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6661)]
    [Attributes(9)]
   public sealed class LteB40PaGainUpDownTime : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6665)]
    [Attributes(9)]
   public sealed class LteB40PaRangeMap : FourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6667)]
    [Attributes(9)]
   public sealed class LteB40PaRiseFallThreshold : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6648)]
    [Attributes(9)]
   public sealed class LteB40RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6647)]
    [Attributes(9)]
   public sealed class LteB40RxDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6656)]
    [Attributes(9)]
   public sealed class LteB40RxfMismatchComp : TwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6652)]
    [Attributes(9)]
   public sealed class LteB40RxGain : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6653)]
    [Attributes(9)]
   public sealed class LteB40RxGainVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6651)]
    [Attributes(9)]
   public sealed class LteB40RxGainVsTemp : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6666)]
    [Attributes(9)]
   public sealed class LteB40TimerHysterisis : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6673)]
    [Attributes(9)]
   public sealed class LteB40TxAgcOffset : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6668)]
    [Attributes(9)]
   public sealed class LteB40TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6826)]
    [Attributes(9)]
   public sealed class LteB40TxCarrierFeedthroughComp : TwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6682)]
    [Attributes(9)]
   public sealed class LteB40TxCompVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6672)]
    [Attributes(9)]
   public sealed class LteB40TxDigitalGainComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6678)]
    [Attributes(9)]
   public sealed class LteB40TxGainIndex0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6679)]
    [Attributes(9)]
   public sealed class LteB40TxGainIndex1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6680)]
    [Attributes(9)]
   public sealed class LteB40TxGainIndex2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6681)]
    [Attributes(9)]
   public sealed class LteB40TxGainIndex3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6684)]
    [Attributes(9)]
   public sealed class LteB40TxLimitVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6669)]
    [Attributes(9)]
   public sealed class LteB40TxLimitVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6674)]
    [Attributes(9)]
   public sealed class LteB40TxLinMaster0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6675)]
    [Attributes(9)]
   public sealed class LteB40TxLinMaster1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6676)]
    [Attributes(9)]
   public sealed class LteB40TxLinMaster2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6677)]
    [Attributes(9)]
   public sealed class LteB40TxLinMaster3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6664)]
    [Attributes(9)]
   public sealed class LteB40TxLinVsTemp : SixtyFourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6821)]
    [Attributes(9)]
   public sealed class LteB40TxMismatchComp : TwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6671)]
    [Attributes(9)]
   public sealed class LteB40TxMprBackoff : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6662)]
    [Attributes(9)]
   public sealed class LteB40TxRotAnglePaState : EightUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6554)]
    [Attributes(9)]
   public sealed class LteB7AgcPaOnRiseFallDelay : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6555)]
    [Attributes(9)]
   public sealed class LteB7AgcTxOnRiseFallDelay : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6581)]
    [Attributes(9)]
   public sealed class LteB7Antsel : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6584)]
    [Attributes(9)]
   public sealed class LteB7C0C1Delay : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6582)]
    [Attributes(9)]
   public sealed class LteB7C1Antsel : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6592)]
    [Attributes(9)]
   public sealed class LteB7C1Im2Values : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6587)]
    [Attributes(9)]
   public sealed class LteB7C1ImLevel : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6589)]
    [Attributes(9)]
   public sealed class LteB7C1LnaPhaseCtrl : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6586)]
    [Attributes(9)]
   public sealed class LteB7C1LnaRangeRiseFall : ThirtyTwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6583)]
    [Attributes(9)]
   public sealed class LteB7C1NonbypassBypassTimer : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6593)]
    [Attributes(9)]
   public sealed class LteB7C1RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6590)]
    [Attributes(9)]
   public sealed class LteB7C1RxGain : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6591)]
    [Attributes(9)]
   public sealed class LteB7C1RxGainVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6588)]
    [Attributes(9)]
   public sealed class LteB7C1RxGainVsTemp : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6751)]
    [Attributes(9)]
   public sealed class LteB7DrxModeSel : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6552)]
    [Attributes(9)]
   public sealed class LteB7EncBtf : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6578)]
    [Attributes(9)]
   public sealed class LteB7ExpHdetVsAgc : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6580)]
    [Attributes(9)]
   public sealed class LteB7HdetOffSpan : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6550)]
    [Attributes(9)]
   public sealed class LteB7Im2Values : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6545)]
    [Attributes(9)]
   public sealed class LteB7ImLevel : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6549)]
    [Attributes(9)]
   public sealed class LteB7LnaPhaseCtrl : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6544)]
    [Attributes(9)]
   public sealed class LteB7LnaRangeRiseFall : ThirtyTwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6553)]
    [Attributes(9)]
   public sealed class LteB7MaxTxPower : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6565)]
    [Attributes(9)]
   public sealed class LteB7MprBasedPaSwitchpointsShift : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6541)]
    [Attributes(9)]
   public sealed class LteB7NonbypassBypassTimer : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6558)]
    [Attributes(9)]
   public sealed class LteB7PaCompensateUpDown : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6556)]
    [Attributes(9)]
   public sealed class LteB7PaGainUpDownTime : TwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6560)]
    [Attributes(9)]
   public sealed class LteB7PaRangeMap : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6562)]
    [Attributes(9)]
   public sealed class LteB7PaRiseFallThreshold : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6543)]
    [Attributes(9)]
   public sealed class LteB7RxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6542)]
    [Attributes(9)]
   public sealed class LteB7RxDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6551)]
    [Attributes(9)]
   public sealed class LteB7RxfMismatchComp : TwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6547)]
    [Attributes(9)]
   public sealed class LteB7RxGain : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6548)]
    [Attributes(9)]
   public sealed class LteB7RxGainVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6546)]
    [Attributes(9)]
   public sealed class LteB7RxGainVsTemp : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6561)]
    [Attributes(9)]
   public sealed class LteB7TimerHysterisis : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6568)]
    [Attributes(9)]
   public sealed class LteB7TxAgcOffset : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6563)]
    [Attributes(9)]
   public sealed class LteB7TxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6824)]
    [Attributes(9)]
   public sealed class LteB7TxCarrierFeedthroughComp : TwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6577)]
    [Attributes(9)]
   public sealed class LteB7TxCompVsFreq : OneHundredTwentyEightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6567)]
    [Attributes(9)]
   public sealed class LteB7TxDigitalGainComp : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6573)]
    [Attributes(9)]
   public sealed class LteB7TxGainIndex0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6574)]
    [Attributes(9)]
   public sealed class LteB7TxGainIndex1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6575)]
    [Attributes(9)]
   public sealed class LteB7TxGainIndex2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6576)]
    [Attributes(9)]
   public sealed class LteB7TxGainIndex3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6579)]
    [Attributes(9)]
   public sealed class LteB7TxLimitVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6564)]
    [Attributes(9)]
   public sealed class LteB7TxLimitVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6569)]
    [Attributes(9)]
   public sealed class LteB7TxLinMaster0 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6570)]
    [Attributes(9)]
   public sealed class LteB7TxLinMaster1 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6571)]
    [Attributes(9)]
   public sealed class LteB7TxLinMaster2 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6572)]
    [Attributes(9)]
   public sealed class LteB7TxLinMaster3 : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6559)]
    [Attributes(9)]
   public sealed class LteB7TxLinVsTemp : SixtyFourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6819)]
    [Attributes(9)]
   public sealed class LteB7TxMismatchComp : TwoInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6566)]
    [Attributes(9)]
   public sealed class LteB7TxMprBackoff : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6557)]
    [Attributes(9)]
   public sealed class LteB7TxRotAnglePaState : EightUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6829)]
    [Attributes(9)]
   public sealed class LteBcConfigDiv : TwoUInt64ItemBase
    {
    }

    [Serializable]
    [NvItemId(6828)]
    [Attributes(9)]
    public sealed class LteBcConfig : LteBandsConfigBase
    {
    }

    [Serializable]
    [NvItemId(3370)]
    [Attributes(9)]
   public sealed class Mf700AgcVsFreq : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3373)]
    [Attributes(9)]
   public sealed class MfBandConfig : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3645)]
    [Attributes(9)]
   public sealed class MfC1Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3646)]
    [Attributes(9)]
   public sealed class MfC1Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3647)]
    [Attributes(9)]
   public sealed class MfC1Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3642)]
    [Attributes(9)]
   public sealed class MfCoIm2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3643)]
    [Attributes(9)]
   public sealed class MfCoIm2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3644)]
    [Attributes(9)]
   public sealed class MfCoIm2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3372)]
    [Attributes(9)]
   public sealed class MfHwConfig : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3631)]
    [Attributes(9)]
   public sealed class MfMruChan : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5895)]
    [Attributes(9)]
   public sealed class MgrfSupported : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(495)]
    [Attributes(9)]
   public sealed class MipHandoffOptimizationEnabled : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6)]
    [Attributes(9)]
   public sealed class MobileCaiRevisionNumber : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4158)]
    [Attributes(9)]
   public sealed class Multislot8pskPowerProfile : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4157)]
    [Attributes(9)]
   public sealed class MultislotGmskPowerProfile : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4722)]
    [Attributes(9)]
   public sealed class NasReleaseCompliance : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(849)]
    [Attributes(41)]
   public sealed class NetworkSelectionModePreference : ItemBase
    {
        public byte Nam { get; set; }


        public ushort NetSelMode { get; set; }
    }

    [Serializable]
    [NvItemId(379)]
    [Attributes(9)]
   public sealed class NonbypassTimer : ByteItemBase
    {
    }

    
    [Serializable]
    [NvItemId(260)]
    [Attributes(41)]
   public sealed class OtaPaEnabled : ItemBase
    {
        public byte Nam { get; set; }


        public byte Enabled { get; set; }
    }

    [Serializable]
    [NvItemId(296)]
    [Attributes(9)]
   public sealed class OtaSpSpcChange : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(304)]
    [Attributes(13)]
   public sealed class OTKSLFlag : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(492)]
    [Attributes(9)]
   public sealed class PaBackoffVolts : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(930)]
    [Attributes(9)]
   public sealed class PacketCallDialStringLookupTable : ItemBase
    {
        [JsonIgnore]
        [FieldCount(5)]
        public byte[] DialString1 { get; set; }

        public string DialString1String
        {
            get => StringUtils.GetString(DialString1);
            set => DialString1 = StringUtils.GetBytes(value, 5);
        }


        public ushort CallType1 { get; set; }


        public ushort ModesPermitted1 { get; set; }


        [JsonIgnore]
        [FieldCount(5)]
        public byte[] DialString2 { get; set; }

        public string DialString2String
        {
            get => StringUtils.GetString(DialString2);
            set => DialString2 = StringUtils.GetBytes(value, 5);
        }


        public ushort CallType2 { get; set; }


        public ushort ModesPermitted2 { get; set; }

        [JsonIgnore]
        [FieldCount(5)]
        public byte[] DialString3 { get; set; }

        public string DialString3String
        {
            get => StringUtils.GetString(DialString3);
            set => DialString3 = StringUtils.GetBytes(value, 5);
        }


        public ushort CallType3 { get; set; }


        public ushort ModesPermitted3 { get; set; }

        [JsonIgnore]
        [FieldCount(5)]
        public byte[] DialString4 { get; set; }

        public string DialString4String
        {
            get => StringUtils.GetString(DialString4);
            set => DialString4 = StringUtils.GetBytes(value, 5);
        }


        public ushort CallType4 { get; set; }


        public ushort ModesPermitted4 { get; set; }
    }

    [Serializable]
    [NvItemId(298)]
    [Attributes(9)]
   public sealed class PacketDataCallsOriginateString : ItemBase
    {
        public PacketDataCallsOriginateString()
        {
            Digits = new byte[16];
        }

        [JsonIgnore]
        public byte NumDigits { get; set; }

        [JsonIgnore]
        [FieldCount(16)]
        public byte[] Digits { get; set; }

        public string DigitsString
        {
            get => StringUtils.GetString(Digits);
            set
            {
                if (value != null)
                {
                    Digits = StringUtils.GetBytes(value, 16);
                    NumDigits = (byte) Math.Min(value.Length, 16);
                }
            }
        }
    }

    [Serializable]
    [NvItemId(1802)]
    [Attributes(9)]
   public sealed class PaCompensateDown : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2022)]
    [Attributes(9)]
   public sealed class PaCompensateDownR2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2024)]
    [Attributes(9)]
   public sealed class PaCompensateDownR3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1801)]
    [Attributes(9)]
   public sealed class PaCompensateUp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2021)]
    [Attributes(9)]
   public sealed class PaCompensateUpR2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2023)]
    [Attributes(9)]
   public sealed class PaCompensateUpR3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(410)]
    [Attributes(9)]
   public sealed class PaRangeOffsets : FourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(155)]
    [Attributes(9)]
   public sealed class PaRangeStepCal : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(204)]
    [Attributes(9)]
   public sealed class PaRangeVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1875)]
    [Attributes(9)]
   public sealed class PaRMap : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(351)]
    [Attributes(9)]
   public sealed class PcsAdjFactor : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(396)]
    [Attributes(9)]
   public sealed class PcsAgcPhaseOffset : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(717)]
    [Attributes(9)]
   public sealed class PcsAgcValue3Min : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(718)]
    [Attributes(9)]
   public sealed class PcsAgcValue4Min : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(391)]
    [Attributes(9)]
   public sealed class PcsBypassTimer : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(395)]
    [Attributes(9)]
   public sealed class PcsCdmaLna12OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(394)]
    [Attributes(9)]
   public sealed class PcsCdmaLnaOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(636)]
    [Attributes(9)]
   public sealed class PcsDaccEstIoffset : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(640)]
    [Attributes(9)]
   public sealed class PcsDaccEstQoffset : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(684)]
    [Attributes(9)]
   public sealed class PcsDaccGainMult : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(644)]
    [Attributes(9)]
   public sealed class PcsDaccIaccum0 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(648)]
    [Attributes(9)]
   public sealed class PcsDaccIaccum1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(652)]
    [Attributes(9)]
   public sealed class PcsDaccIaccum2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(656)]
    [Attributes(9)]
   public sealed class PcsDaccIaccum3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(660)]
    [Attributes(9)]
   public sealed class PcsDaccIaccum4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(664)]
    [Attributes(9)]
   public sealed class PcsDaccQaccum0 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(668)]
    [Attributes(9)]
   public sealed class PcsDaccQaccum1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(672)]
    [Attributes(9)]
   public sealed class PcsDaccQaccum2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(676)]
    [Attributes(9)]
   public sealed class PcsDaccQaccum3 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(680)]
    [Attributes(9)]
   public sealed class PcsDaccQaccum4 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(445)]
    [Attributes(9)]
   public sealed class PcsEncBtf : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(334)]
    [Attributes(9)]
   public sealed class PcsExpHdetVsAgc : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(335)]
    [Attributes(9)]
   public sealed class PcsHdetOff : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(336)]
    [Attributes(9)]
   public sealed class PcsHdetSpn : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(688)]
    [Attributes(9)]
   public sealed class PcsIm2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(690)]
    [Attributes(9)]
   public sealed class PcsIm2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(838)]
    [Attributes(9)]
   public sealed class PcsIm2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(392)]
    [Attributes(9)]
   public sealed class PcsImLevel1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(393)]
    [Attributes(9)]
   public sealed class PcsImLevel2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(715)]
    [Attributes(9)]
   public sealed class PcsImLevel3 : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(716)]
    [Attributes(9)]
   public sealed class PcsImLevel4 : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(594)]
    [Attributes(9)]
   public sealed class PcsLna3Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(595)]
    [Attributes(9)]
   public sealed class PcsLna3Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(597)]
    [Attributes(9)]
   public sealed class PcsLna3OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(596)]
    [Attributes(9)]
   public sealed class PcsLna3Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(602)]
    [Attributes(9)]
   public sealed class PcsLna4Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(603)]
    [Attributes(9)]
   public sealed class PcsLna4Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(605)]
    [Attributes(9)]
   public sealed class PcsLna4OffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(604)]
    [Attributes(9)]
   public sealed class PcsLna4Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(389)]
    [Attributes(9)]
   public sealed class PcsLnaRange12Offset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(388)]
    [Attributes(9)]
   public sealed class PcsLnaRange2Fall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(387)]
    [Attributes(9)]
   public sealed class PcsLnaRange2Rise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(348)]
    [Attributes(9)]
   public sealed class PcsLnaRangeFall : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(349)]
    [Attributes(9)]
   public sealed class PcsLnaRangeOffset : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(346)]
    [Attributes(9)]
   public sealed class PcsLnaRangePol : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(347)]
    [Attributes(9)]
   public sealed class PcsLnaRangeRise : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(390)]
    [Attributes(9)]
   public sealed class PcsNonbypassTimer : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(902)]
    [Attributes(9)]
   public sealed class PcsP1RiseFallOff : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(435)]
    [Attributes(9)]
   public sealed class PcsPaRangeOffsets : FourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(343)]
    [Attributes(9)]
   public sealed class PcsPaRangeStepCal : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(352)]
    [Attributes(9)]
   public sealed class PcsPaRangeVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(344)]
    [Attributes(9)]
   public sealed class PcsPdm1VsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(353)]
    [Attributes(9)]
   public sealed class PcsPdm1VsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(345)]
    [Attributes(9)]
   public sealed class PcsPdm2VsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(354)]
    [Attributes(9)]
   public sealed class PcsPdm2VsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(338)]
    [Attributes(9)]
   public sealed class PcsR1Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(337)]
    [Attributes(9)]
   public sealed class PcsR1Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(340)]
    [Attributes(9)]
   public sealed class PcsR2Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(339)]
    [Attributes(9)]
   public sealed class PcsR2Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(342)]
    [Attributes(9)]
   public sealed class PcsR3Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(341)]
    [Attributes(9)]
   public sealed class PcsR3Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(397)]
    [Attributes(9)]
   public sealed class PcsRxAgcMin11 : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(357)]
    [Attributes(9)]
   public sealed class PcsRxAgcMinmax : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1309)]
    [Attributes(9)]
   public sealed class PcsRxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(327)]
    [Attributes(9)]
   public sealed class PcsRxCompVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(620)]
    [Attributes(9)]
   public sealed class PcsRxfCgIoffset : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(624)]
    [Attributes(9)]
   public sealed class PcsRxfCgQoffset : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(628)]
    [Attributes(9)]
   public sealed class PcsRxfFgIoffset : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(632)]
    [Attributes(9)]
   public sealed class PcsRxfFgQoffset : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(325)]
    [Attributes(9)]
   public sealed class PcsRxLinOff0 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(326)]
    [Attributes(9)]
   public sealed class PcsRxLinSlp : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(350)]
    [Attributes(9)]
   public sealed class PcsRxLinVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(355)]
    [Attributes(9)]
   public sealed class PcsRxSlpVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1310)]
    [Attributes(9)]
   public sealed class PcsTxCalChan : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(436)]
    [Attributes(9)]
   public sealed class PcsTxComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(437)]
    [Attributes(9)]
   public sealed class PcsTxComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(438)]
    [Attributes(9)]
   public sealed class PcsTxComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(439)]
    [Attributes(9)]
   public sealed class PcsTxComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(328)]
    [Attributes(9)]
   public sealed class PcsTxCompVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(333)]
    [Attributes(9)]
   public sealed class PcsTxLimVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(332)]
    [Attributes(9)]
   public sealed class PcsTxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(431)]
    [Attributes(9)]
   public sealed class PcsTxLinMaster0 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(432)]
    [Attributes(9)]
   public sealed class PcsTxLinMaster1 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(433)]
    [Attributes(9)]
   public sealed class PcsTxLinMaster2 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(434)]
    [Attributes(9)]
   public sealed class PcsTxLinMaster3 : ItemBase
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(329)]
    [Attributes(9)]
   public sealed class PcsTxLinMasterOff0 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(330)]
    [Attributes(9)]
   public sealed class PcsTxLinMasterSlp : ThirtySevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(331)]
    [Attributes(9)]
   public sealed class PcsTxLinVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(356)]
    [Attributes(9)]
   public sealed class PcsTxSlpVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(694)]
    [Attributes(9)]
   public sealed class PcsVgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(697)]
    [Attributes(9)]
   public sealed class PcsVgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(700)]
    [Attributes(9)]
   public sealed class PcsVgaGainOffsetVsTemp : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(251)]
    [Attributes(9)]
   public sealed class Pdm1 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(288)]
    [Attributes(9)]
   public sealed class Pdm1VsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(253)]
    [Attributes(9)]
   public sealed class Pdm1VsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(246)]
    [Attributes(9)]
   public sealed class Pdm2 : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(289)]
    [Attributes(9)]
   public sealed class Pdm2VsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(254)]
    [Attributes(9)]
   public sealed class Pdm2VsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(81)]
    [Attributes(9)]
   public sealed class PhoneLock : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3189)]
    [Attributes(9)]
   public sealed class PocAutoAnswer : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(910)]
    [Attributes(9)]
   public sealed class PppUserId : ItemBase
    {
        public byte Length { get; set; }


        [JsonIgnore]
        [FieldCount(127)]
        public byte[] Value { get; set; }

        public string ValueString
        {
            get => StringUtils.GetString(Value);
            set => Value = StringUtils.GetBytes(value, 127);
        }
    }

    [Serializable]
    [NvItemId(6247)]
    [Attributes(9)]
   public sealed class PppVsncpConfigData : ItemBase
    {
        public uint TermTimeout { get; set; }


        public uint AckTimeout { get; set; }


        public ushort RegTry { get; set; }


        public ushort TermTry { get; set; }
    }

    [Serializable]
    [NvItemId(562)]
    [Attributes(9)]
   public sealed class PreferredHybridMode : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(423)]
    [Attributes(9)]
   public sealed class PrimaryDnsServer : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5432)]
    [Attributes(9)]
   public sealed class ProcessCal : ItemBase
    {
        public ushort Value1 { get; set; }

        [FieldCount(3)]
        public byte[] Value2 { get; set; }
    }

    [Serializable]
    [NvItemId(932)]
    [Attributes(9)]
   public sealed class ProcessIncomingCsDataCallAsInternal : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(491)]
    [Attributes(9)]
   public sealed class PwrBackoffVsVoltLow : ItemBase
    {
        [FieldCount(20)]
        public byte[] Value { get; set; }
    }

    [Serializable]
    [NvItemId(490)]
    [Attributes(9)]
   public sealed class PwrBackoffVsVoltMed : ItemBase
    {
        [FieldCount(20)]
        public byte[] Value { get; set; }
    }

    [Serializable]
    [NvItemId(928)]
    [Attributes(9)]
   public sealed class PzidHysterisisActivationTimer : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(929)]
    [Attributes(9)]
   public sealed class PzidHysterisisTimer : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(240)]
    [Attributes(9)]
   public sealed class QncEnabledFlag : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(150)]
    [Attributes(9)]
   public sealed class R1Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(149)]
    [Attributes(9)]
   public sealed class R1Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(152)]
    [Attributes(9)]
   public sealed class R2Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(151)]
    [Attributes(9)]
   public sealed class R2Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(154)]
    [Attributes(9)]
   public sealed class R3Fall : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(153)]
    [Attributes(9)]
   public sealed class R3Rise : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6861)]
    [Attributes(9)]
   public sealed class RcProcessErrors : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5107)]
    [Attributes(9)]
   public sealed class RepeatedAcch : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1951)]
    [Attributes(9)]
   public sealed class RfAntselGsm1800Rx : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1950)]
    [Attributes(9)]
   public sealed class RfAntselGsm1800Tx : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1953)]
    [Attributes(9)]
   public sealed class RfAntselGsm1900Rx : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1952)]
    [Attributes(9)]
   public sealed class RfAntselGsm1900Tx : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1947)]
    [Attributes(9)]
   public sealed class RfAntselGsm850Rx : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1946)]
    [Attributes(9)]
   public sealed class RfAntselGsm850Tx : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1949)]
    [Attributes(9)]
   public sealed class RfAntselGsm900Rx : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1948)]
    [Attributes(9)]
   public sealed class RfAntselGsm900Tx : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1945)]
    [Attributes(9)]
   public sealed class RfAntselGsmDefault : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7096)]
    [Attributes(9)]
   public sealed class RfAntselUmts1500 : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3027)]
    [Attributes(9)]
   public sealed class RfAntselUmts1800 : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1955)]
    [Attributes(9)]
   public sealed class RfAntselUmts1900 : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1956)]
    [Attributes(9)]
   public sealed class RfAntselUmts2100 : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1954)]
    [Attributes(9)]
   public sealed class RfAntselUmts800 : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4098)]
    [Attributes(9)]
   public sealed class RfAntselUmts900 : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4099)]
    [Attributes(9)]
   public sealed class RfAntselUmtsBc4 : FourByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1877)]
    [Attributes(9)]
   public sealed class RfBandConfiguration : UInt64ItemBase
    {
    }

    [Serializable]
    [NvItemId(4548)]
    [Attributes(9)]
   public sealed class RfBcConfigDiv : UInt64ItemBase
    {
    }

    [Serializable]
    [NvItemId(571)]
    [Attributes(9)]
   public sealed class RfCalDate : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(573)]
    [Attributes(9)]
   public sealed class RfCalDatFile : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(569)]
    [Attributes(9)]
   public sealed class RfCalVer : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(148)]
    [Attributes(9)]
   public sealed class RfConfig : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(570)]
    [Attributes(9)]
   public sealed class RfConfigVer : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1878)]
    [Attributes(9)]
   public sealed class RfHwConfig : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(572)]
    [Attributes(9)]
   public sealed class RfNvLoadedDate : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(4257)]
    [Attributes(9)]
   public sealed class RfpMicConfiguration : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1791)]
    [Attributes(9)]
   public sealed class RfrBbFilter : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1792)]
    [Attributes(9)]
   public sealed class RfrIqLineResistor : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3849)]
    [Attributes(9)]
   public sealed class RfrVcoCoarseTune21900 : TwelveByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2912)]
    [Attributes(9)]
   public sealed class RfrVcoCoarseTuning1800 : TwelveByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1794)]
    [Attributes(9)]
   public sealed class RfrVcoCoarseTuning1900 : TwelveByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3283)]
    [Attributes(9)]
   public sealed class RfrVcoCoarseTuning800 : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3752)]
    [Attributes(9)]
   public sealed class RfrVcoCoarseTuning900 : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4097)]
    [Attributes(9)]
   public sealed class RfrVcoCoarseTuningBc4 : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3850)]
    [Attributes(9)]
   public sealed class RfrWcdmaC0C1Delay : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(256)]
    [Attributes(41)]
   public sealed class RoamingListEnabled : ItemBase
    {
        public byte Name { get; set; }


        public byte Enabled { get; set; }
    }

    [Serializable]
    [NvItemId(442)]
    [Attributes(45)]
   public sealed class RoamingPreference : ItemBase
    {
        public byte Nam { get; set; }


        public ushort Roam { get; set; }
    }

    [Serializable]
    [NvItemId(881)]
    [Attributes(9)]
   public sealed class RrcCipheringEnabled : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(882)]
    [Attributes(9)]
   public sealed class RrcFakeSecurityEnabled : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(880)]
    [Attributes(9)]
   public sealed class RrcIntegrityEnabled : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(691)]
    [Attributes(9)]
   public sealed class RtcTimeAdjust : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4103)]
    [Attributes(9)]
   public sealed class RtrBbFilter : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(855)]
    [Attributes(9)]
   public sealed class RtreConfiguration : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(386)]
    [Attributes(9)]
   public sealed class RxAgcMin11 : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(247)]
    [Attributes(9)]
   public sealed class RxAgcMinmax : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3635)]
    [Attributes(9)]
   public sealed class SdConfigurableItems : ItemBase
    {
        [FieldCount(25)] private readonly uint[] _items = new uint[25];

        [Required]
        public ushort Version { get; set; }

        [JsonIgnore]
        public ushort Count { get; set; }

        [JsonIgnore]
        public uint[] RawItems
        {
            get => _items;
            set
            {
                if (value != null)
                {
                    var len = Math.Min(value.Length, _items.Length);
                    Array.Copy(value, _items, len);
                }
            }
        }


        public uint[] Items
        {
            get
            {
                if (Count >= 25)
                {
                    return _items;
                }

                var data = new uint[Count];
                Array.Copy(_items, data, Count);
                return data;
            }
            set
            {
                if (value != null)
                {
                    var len = Math.Min(value.Length, _items.Length);
                    Array.Copy(value, _items, len);
                    Count = (ushort) len;
                }
            }
        }
    }

    [Serializable]
    [NvItemId(3632)]
    [Attributes(9)]
   public sealed class SearchDebugMask : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(424)]
    [Attributes(9)]
   public sealed class SecondaryDnsServer : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(69)]
    [Attributes(9)]
   public sealed class ServiceAreaAlert : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(850)]
    [Attributes(41)]
   public sealed class ServiceDomainPreference : ItemBase
    {
        public byte Nam { get; set; }


        //[Description("2=CS+PS,3=Any")]
        public ushort ServiceDomain { get; set; }
    }

    [Serializable]
    [NvItemId(291)]
    [Attributes(9)]
   public sealed class SilentRedialEnabled : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5)]
    [Attributes(9)]
   public sealed class SlotCycleIndex : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(830)]
    [Attributes(9)]
   public sealed class SmsConfigRouting : ItemBase
    {
        public byte PPRoutes1 { get; set; }


        public byte PPMemStores1 { get; set; }


        public byte BCRoutes1 { get; set; }


        public byte BCMemStores1 { get; set; }


        public byte PPRoutes2 { get; set; }


        public byte PPMemStores2 { get; set; }


        public byte BCRoutes2 { get; set; }


        public byte BCMemStores2 { get; set; }


        public byte PPRoutes3 { get; set; }


        public byte PPMemStores3 { get; set; }


        public byte BCRoutes3 { get; set; }


        public byte BCMemStores3 { get; set; }


        public byte PPRoutes4 { get; set; }


        public byte PPMemStores4 { get; set; }


        public byte BCRoutes4 { get; set; }


        public byte BCMemStores4 { get; set; }


        public byte PPRoutes5 { get; set; }


        public byte PPMemStores5 { get; set; }


        public byte BCRoutes5 { get; set; }


        public byte BCMemStores5 { get; set; }


        public byte PPRoutes6 { get; set; }


        public byte PPMemStores6 { get; set; }


        public byte BCRoutes6 { get; set; }


        public byte BCMemStores6 { get; set; }


        public byte TransferStatusReport { get; set; }
    }

    [Serializable]
    [NvItemId(4228)]
    [Attributes(9)]
   public sealed class SmsMoOnAccessChannel : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4229)]
    [Attributes(9)]
   public sealed class SmsMoOnTrafficChannel : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3533)]
    [Attributes(9)]
   public sealed class SmsMoRetryInterval : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3532)]
    [Attributes(9)]
   public sealed class SmsMoRetryPeriod : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4366)]
    [Attributes(9)]
   public sealed class SmsServiceOption : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(448)]
    [Attributes(9)]
   public sealed class SubpcgPaWarmupDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5576)]
    [Attributes(9)]
   public sealed class Supply : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(568)]
    [Attributes(9)]
   public sealed class SysSwVer : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(567)]
    [Attributes(9)]
   public sealed class TestCodeVer : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5029)]
    [Attributes(9)]
   public sealed class ThermBins : EightUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2328)]
    [Attributes(9)]
   public sealed class ThermCompThresholds : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(141)]
    [Attributes(9)]
   public sealed class Therm : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4226)]
    [Attributes(9)]
   public sealed class ThermTempMax : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4225)]
    [Attributes(9)]
   public sealed class ThermTempMin : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4221)]
    [Attributes(9)]
   public sealed class ThermValueT1 : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4222)]
    [Attributes(9)]
   public sealed class ThermValueT2 : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4223)]
    [Attributes(9)]
   public sealed class ThermValueT3 : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4224)]
    [Attributes(9)]
   public sealed class ThermValueT4 : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5770)]
    [Attributes(9)]
   public sealed class ToolkitCsPsParallel : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1962)]
    [Attributes(9)]
   public sealed class TraceFilesSavedEFS : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3446)]
    [Attributes(9)]
   public sealed class TrmConfiguration : ItemBase
    {
        public ushort Config { get; set; }


        public uint Mask { get; set; }
    }

    [Serializable]
    [NvItemId(409)]
    [Attributes(9)]
   public sealed class TtyMode : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(411)]
    [Attributes(9)]
   public sealed class TxComp0 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(420)]
    [Attributes(9)]
   public sealed class TxComp1 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(421)]
    [Attributes(9)]
   public sealed class TxComp2 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(422)]
    [Attributes(9)]
   public sealed class TxComp3 : ThirtyTwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(589)]
    [Attributes(9)]
   public sealed class TxGainAttenLimit : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(884)]
    [Attributes(9)]
   public sealed class TxWarmup : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(550)]
    [Attributes(9)]
   public sealed class UeImei : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6862)]
    [Attributes(9)]
   public sealed class UiccMode : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(896)]
    [Attributes(9)]
   public sealed class UimFirstInstructionClass : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6907)]
    [Attributes(9)]
   public sealed class UimHwSimConfig : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4398)]
    [Attributes(9)]
   public sealed class UimSelectDefaultSimApplication : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6850)]
    [Attributes(9)]
   public sealed class UmtsAmrCodecPreferenceConfig : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(810)]
    [Attributes(9)]
   public sealed class Vbatt3200MvAdc : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(811)]
    [Attributes(9)]
   public sealed class Vbatt3700MvAdc : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(812)]
    [Attributes(9)]
   public sealed class Vbatt4200MvAdc : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2329)]
    [Attributes(9)]
   public sealed class VbattCompThresholds : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(90)]
    [Attributes(9)]
   public sealed class Vbatt : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(493)]
    [Attributes(9)]
   public sealed class VbattMinMax : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(142)]
    [Attributes(9)]
   public sealed class VbattPa : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(931)]
    [Attributes(9)]
   public sealed class VcoCoarseTuneTable : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1882)]
    [Attributes(9)]
   public sealed class VcoDefault : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1884)]
    [Attributes(9)]
   public sealed class VcoSlopeRange : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1883)]
    [Attributes(9)]
   public sealed class VctcxoSlope : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(360)]
    [Attributes(9)]
   public sealed class Vext : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(361)]
    [Attributes(9)]
   public sealed class VlcdAdcCnt : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(362)]
    [Attributes(9)]
   public sealed class VlcdDrvrCnt : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(179)]
    [Attributes(9)]
   public sealed class VoicePrivacy : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6831)]
    [Attributes(9)]
   public sealed class VoipCancelRetryTimer : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4230)]
    [Attributes(9)]
   public sealed class VoipPreferredUrl : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4265)]
    [Attributes(9)]
   public sealed class VoipRegistrationMode : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(363)]
    [Attributes(9)]
   public sealed class VrefAdjPdmCnt : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6950)]
    [Attributes(9)]
   public sealed class Wcdma1500AdjFactor : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6958)]
    [Attributes(9)]
   public sealed class Wcdma1500AgcPaOnFallDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6957)]
    [Attributes(9)]
   public sealed class Wcdma1500AgcPaOnRiseDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6937)]
    [Attributes(9)]
   public sealed class Wcdma1500AgcPhaseOffset : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6996)]
    [Attributes(9)]
   public sealed class Wcdma1500AgcTxAdjPdmDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6960)]
    [Attributes(9)]
   public sealed class Wcdma1500AgcTxOnFallDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6959)]
    [Attributes(9)]
   public sealed class Wcdma1500AgcTxOnRiseDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6961)]
    [Attributes(9)]
   public sealed class Wcdma1500AgcUpdateTxAgcTime : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6932)]
    [Attributes(9)]
   public sealed class Wcdma1500BypassTimer : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7015)]
    [Attributes(9)]
   public sealed class Wcdma1500C0C1Delay : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6995)]
    [Attributes(9)]
   public sealed class Wcdma1500DchAgcUpdateTxAgcTime : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7066)]
    [Attributes(9)]
   public sealed class Wcdma1500DrxModeSel : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6954)]
    [Attributes(9)]
   public sealed class Wcdma1500EncBtf : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6951)]
    [Attributes(9)]
   public sealed class Wcdma1500ExpHdetVsAgc : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7123)]
    [Attributes(9)]
   public sealed class Wcdma1500ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6952)]
    [Attributes(9)]
   public sealed class Wcdma1500HdetOff : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7124)]
    [Attributes(9)]
   public sealed class Wcdma1500HdetOffV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6953)]
    [Attributes(9)]
   public sealed class Wcdma1500HdetSpn : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7125)]
    [Attributes(9)]
   public sealed class Wcdma1500HdetSpnV2 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7061)]
    [Attributes(9)]
   public sealed class Wcdma1500HsImLevel2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7063)]
    [Attributes(9)]
   public sealed class Wcdma1500HsImLevel3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7064)]
    [Attributes(9)]
   public sealed class Wcdma1500HsImLevel4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7062)]
    [Attributes(9)]
   public sealed class Wcdma1500HsImLevel : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7055)]
    [Attributes(9)]
   public sealed class Wcdma1500HsLnaRangeFall2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7054)]
    [Attributes(9)]
   public sealed class Wcdma1500HsLnaRangeFall3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7053)]
    [Attributes(9)]
   public sealed class Wcdma1500HsLnaRangeFall4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7056)]
    [Attributes(9)]
   public sealed class Wcdma1500HsLnaRangeFall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7059)]
    [Attributes(9)]
   public sealed class Wcdma1500HsLnaRangeRise2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7058)]
    [Attributes(9)]
   public sealed class Wcdma1500HsLnaRangeRise3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7057)]
    [Attributes(9)]
   public sealed class Wcdma1500HsLnaRangeRise4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7060)]
    [Attributes(9)]
   public sealed class Wcdma1500HsLnaRangeRise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7048)]
    [Attributes(9)]
   public sealed class Wcdma1500HsR1Fall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7047)]
    [Attributes(9)]
   public sealed class Wcdma1500HsR1Rise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7050)]
    [Attributes(9)]
   public sealed class Wcdma1500HsR2Fall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7049)]
    [Attributes(9)]
   public sealed class Wcdma1500HsR2Rise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7052)]
    [Attributes(9)]
   public sealed class Wcdma1500HsR3Fall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7051)]
    [Attributes(9)]
   public sealed class Wcdma1500HsR3Rise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7065)]
    [Attributes(9)]
   public sealed class Wcdma1500HsSwitchpointsShift : TwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7008)]
    [Attributes(9)]
   public sealed class Wcdma1500Iaccum : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6921)]
    [Attributes(9)]
   public sealed class Wcdma1500Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6922)]
    [Attributes(9)]
   public sealed class Wcdma1500Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6923)]
    [Attributes(9)]
   public sealed class Wcdma1500Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6915)]
    [Attributes(9)]
   public sealed class Wcdma1500ImLevel2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6916)]
    [Attributes(9)]
   public sealed class Wcdma1500ImLevel3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7010)]
    [Attributes(9)]
   public sealed class Wcdma1500ImLevel4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6930)]
    [Attributes(9)]
   public sealed class Wcdma1500ImLevel : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6919)]
    [Attributes(9)]
   public sealed class Wcdma1500LnaOffsetVsFreq2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6920)]
    [Attributes(9)]
   public sealed class Wcdma1500LnaOffsetVsFreq3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7011)]
    [Attributes(9)]
   public sealed class Wcdma1500LnaOffsetVsFreq4 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6934)]
    [Attributes(9)]
   public sealed class Wcdma1500LnaOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7026)]
    [Attributes(9)]
   public sealed class Wcdma1500LnaPhaseCtl : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6913)]
    [Attributes(9)]
   public sealed class Wcdma1500LnaRangeFall2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6914)]
    [Attributes(9)]
   public sealed class Wcdma1500LnaRangeFall3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7012)]
    [Attributes(9)]
   public sealed class Wcdma1500LnaRangeFall4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6929)]
    [Attributes(9)]
   public sealed class Wcdma1500LnaRangeFall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6917)]
    [Attributes(9)]
   public sealed class Wcdma1500LnaRangeOffset2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6918)]
    [Attributes(9)]
   public sealed class Wcdma1500LnaRangeOffset3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7013)]
    [Attributes(9)]
   public sealed class Wcdma1500LnaRangeOffset4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6933)]
    [Attributes(9)]
   public sealed class Wcdma1500LnaRangeOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6911)]
    [Attributes(9)]
   public sealed class Wcdma1500LnaRangeRise2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6912)]
    [Attributes(9)]
   public sealed class Wcdma1500LnaRangeRise3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7014)]
    [Attributes(9)]
   public sealed class Wcdma1500LnaRangeRise4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6928)]
    [Attributes(9)]
   public sealed class Wcdma1500LnaRangeRise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6999)]
    [Attributes(9)]
   public sealed class Wcdma1500MaxPwrBackoffVolt1 : FourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7000)]
    [Attributes(9)]
   public sealed class Wcdma1500MaxPwrBackoffVolt2 : FourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7001)]
    [Attributes(9)]
   public sealed class Wcdma1500MaxPwrBackoffVolt3 : FourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6998)]
    [Attributes(9)]
   public sealed class Wcdma1500MaxPwrBackoffVoltages : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6926)]
    [Attributes(9)]
   public sealed class Wcdma1500MaxTxPower : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6931)]
    [Attributes(9)]
   public sealed class Wcdma1500NonbypassTimer : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6927)]
    [Attributes(9)]
   public sealed class Wcdma1500OutOfServiceThresh : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6994)]
    [Attributes(9)]
   public sealed class Wcdma1500PaCompensateDnWithDvs : TenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6956)]
    [Attributes(9)]
   public sealed class Wcdma1500PaCompensateDown : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6978)]
    [Attributes(9)]
   public sealed class Wcdma1500PaCompensateDownR2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6980)]
    [Attributes(9)]
   public sealed class Wcdma1500PaCompensateDownR3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6955)]
    [Attributes(9)]
   public sealed class Wcdma1500PaCompensateUp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6977)]
    [Attributes(9)]
   public sealed class Wcdma1500PaCompensateUpR2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6979)]
    [Attributes(9)]
   public sealed class Wcdma1500PaCompensateUpR3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6993)]
    [Attributes(9)]
   public sealed class Wcdma1500PaCompensateUpWithDvs : TenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7003)]
    [Attributes(9)]
   public sealed class Wcdma1500PaGainDownTime : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7002)]
    [Attributes(9)]
   public sealed class Wcdma1500PaGainUpTime : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6992)]
    [Attributes(9)]
   public sealed class Wcdma1500PaRangeForDvs : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6989)]
    [Attributes(9)]
   public sealed class Wcdma1500PaRangeMap : FourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6963)]
    [Attributes(9)]
   public sealed class Wcdma1500PrachR1FallOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6962)]
    [Attributes(9)]
   public sealed class Wcdma1500PrachR1RiseOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6986)]
    [Attributes(9)]
   public sealed class Wcdma1500PrachR2FallOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6985)]
    [Attributes(9)]
   public sealed class Wcdma1500PrachR2RiseOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6988)]
    [Attributes(9)]
   public sealed class Wcdma1500PrachR3FallOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6987)]
    [Attributes(9)]
   public sealed class Wcdma1500PrachR3RiseOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7009)]
    [Attributes(9)]
   public sealed class Wcdma1500Qaccum : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6947)]
    [Attributes(9)]
   public sealed class Wcdma1500R1Fall : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6946)]
    [Attributes(9)]
   public sealed class Wcdma1500R1Rise : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6974)]
    [Attributes(9)]
   public sealed class Wcdma1500R2Fall : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6973)]
    [Attributes(9)]
   public sealed class Wcdma1500R2Rise : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6976)]
    [Attributes(9)]
   public sealed class Wcdma1500R3Fall : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6975)]
    [Attributes(9)]
   public sealed class Wcdma1500R3Rise : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7017)]
    [Attributes(9)]
   public sealed class Wcdma1500Rel6TxAgcOffset : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7016)]
    [Attributes(9)]
   public sealed class Wcdma1500Rel6TxBetaScalingComp : SevenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7018)]
    [Attributes(9)]
   public sealed class Wcdma1500Rel6TxMprBackoff : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6936)]
    [Attributes(9)]
   public sealed class Wcdma1500RxAgcMax : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6924)]
    [Attributes(9)]
   public sealed class Wcdma1500RxAgcMin2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6925)]
    [Attributes(9)]
   public sealed class Wcdma1500RxAgcMin3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6935)]
    [Attributes(9)]
   public sealed class Wcdma1500RxAgcMin : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6991)]
    [Attributes(9)]
   public sealed class Wcdma1500RxCalChan : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6964)]
    [Attributes(9)]
   public sealed class Wcdma1500RxDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7030)]
    [Attributes(9)]
   public sealed class Wcdma1500RxfIciICoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7035)]
    [Attributes(9)]
   public sealed class Wcdma1500RxfIciICoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7036)]
    [Attributes(9)]
   public sealed class Wcdma1500RxfIciICoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7037)]
    [Attributes(9)]
   public sealed class Wcdma1500RxfIciICoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7031)]
    [Attributes(9)]
   public sealed class Wcdma1500RxfIciICoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7032)]
    [Attributes(9)]
   public sealed class Wcdma1500RxfIciICoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7033)]
    [Attributes(9)]
   public sealed class Wcdma1500RxfIciICoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7034)]
    [Attributes(9)]
   public sealed class Wcdma1500RxfIciICoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7046)]
    [Attributes(9)]
   public sealed class Wcdma1500RxfIciIqTrunc : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7038)]
    [Attributes(9)]
   public sealed class Wcdma1500RxfIciQCoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7043)]
    [Attributes(9)]
   public sealed class Wcdma1500RxfIciQCoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7044)]
    [Attributes(9)]
   public sealed class Wcdma1500RxfIciQCoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7045)]
    [Attributes(9)]
   public sealed class Wcdma1500RxfIciQCoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7039)]
    [Attributes(9)]
   public sealed class Wcdma1500RxfIciQCoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7040)]
    [Attributes(9)]
   public sealed class Wcdma1500RxfIciQCoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7041)]
    [Attributes(9)]
   public sealed class Wcdma1500RxfIciQCoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7042)]
    [Attributes(9)]
   public sealed class Wcdma1500RxfIciQCoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7028)]
    [Attributes(9)]
   public sealed class Wcdma1500RxfMisCompACoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7029)]
    [Attributes(9)]
   public sealed class Wcdma1500RxfMisCompBCoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7027)]
    [Attributes(9)]
   public sealed class Wcdma1500TimerHysterisis : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6990)]
    [Attributes(9)]
   public sealed class Wcdma1500TxCalChan : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6940)]
    [Attributes(9)]
   public sealed class Wcdma1500TxCompVsFreq0 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7019)]
    [Attributes(9)]
   public sealed class Wcdma1500TxCompVsFreq0Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6941)]
    [Attributes(9)]
   public sealed class Wcdma1500TxCompVsFreq1 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7020)]
    [Attributes(9)]
   public sealed class Wcdma1500TxCompVsFreq1Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6967)]
    [Attributes(9)]
   public sealed class Wcdma1500TxCompVsFreq2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7021)]
    [Attributes(9)]
   public sealed class Wcdma1500TxCompVsFreq2Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6968)]
    [Attributes(9)]
   public sealed class Wcdma1500TxCompVsFreq3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7022)]
    [Attributes(9)]
   public sealed class Wcdma1500TxCompVsFreq3Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7023)]
    [Attributes(9)]
   public sealed class Wcdma1500TxCompVsFreqSecPdmList : FourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6949)]
    [Attributes(9)]
   public sealed class Wcdma1500TxLimVsFreq : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6948)]
    [Attributes(9)]
   public sealed class Wcdma1500TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7024)]
    [Attributes(9)]
   public sealed class Wcdma1500TxLinMaster0Enh : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6938)]
    [Attributes(9)]
   public sealed class Wcdma1500TxLinMaster0 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6939)]
    [Attributes(9)]
   public sealed class Wcdma1500TxLinMaster1 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6965)]
    [Attributes(9)]
   public sealed class Wcdma1500TxLinMaster2 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6966)]
    [Attributes(9)]
   public sealed class Wcdma1500TxLinMaster3 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6942)]
    [Attributes(9)]
   public sealed class Wcdma1500TxLinVsTemp0 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6943)]
    [Attributes(9)]
   public sealed class Wcdma1500TxLinVsTemp1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6969)]
    [Attributes(9)]
   public sealed class Wcdma1500TxLinVsTemp2 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6970)]
    [Attributes(9)]
   public sealed class Wcdma1500TxLinVsTemp3 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7025)]
    [Attributes(9)]
   public sealed class Wcdma1500TxPdmLin0Enh : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7004)]
    [Attributes(9)]
   public sealed class Wcdma1500TxPdmLin0 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7005)]
    [Attributes(9)]
   public sealed class Wcdma1500TxPdmLin1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7006)]
    [Attributes(9)]
   public sealed class Wcdma1500TxPdmLin2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7007)]
    [Attributes(9)]
   public sealed class Wcdma1500TxPdmLin3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6981)]
    [Attributes(9)]
   public sealed class Wcdma1500TxRotAnglePaState00 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6982)]
    [Attributes(9)]
   public sealed class Wcdma1500TxRotAnglePaState01 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6983)]
    [Attributes(9)]
   public sealed class Wcdma1500TxRotAnglePaState10 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6984)]
    [Attributes(9)]
   public sealed class Wcdma1500TxRotAnglePaState11 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6944)]
    [Attributes(9)]
   public sealed class Wcdma1500TxSlpVsTemp0 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6945)]
    [Attributes(9)]
   public sealed class Wcdma1500TxSlpVsTemp1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6971)]
    [Attributes(9)]
   public sealed class Wcdma1500TxSlpVsTemp2 : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6972)]
    [Attributes(9)]
   public sealed class Wcdma1500TxSlpVsTemp3 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6997)]
    [Attributes(9)]
   public sealed class Wcdma1500UtranTxLimVsTempOffset : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6908)]
    [Attributes(9)]
   public sealed class Wcdma1500VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6909)]
    [Attributes(9)]
   public sealed class Wcdma1500VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6910)]
    [Attributes(9)]
   public sealed class Wcdma1500VgaGainOffsetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2893)]
    [Attributes(9)]
   public sealed class Wcdma1800AdjFactor : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2902)]
    [Attributes(9)]
   public sealed class Wcdma1800AgcPaOnFallDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2901)]
    [Attributes(9)]
   public sealed class Wcdma1800AgcPaOnRiseDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2872)]
    [Attributes(9)]
   public sealed class Wcdma1800AgcPhaseOffset : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2946)]
    [Attributes(9)]
   public sealed class Wcdma1800AgcTxAdjPdmDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2904)]
    [Attributes(9)]
   public sealed class Wcdma1800AgcTxOnFallDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2903)]
    [Attributes(9)]
   public sealed class Wcdma1800AgcTxOnRiseDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2905)]
    [Attributes(9)]
   public sealed class Wcdma1800AgcUpdateTxAgcTime : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2867)]
    [Attributes(9)]
   public sealed class Wcdma1800BypassTimer : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4936)]
    [Attributes(9)]
   public sealed class Wcdma1800C0C1Delay : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2945)]
    [Attributes(9)]
   public sealed class Wcdma1800DchAgcUpdateTxAgcTime : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4194)]
    [Attributes(9)]
   public sealed class Wcdma1800DrxModeSel : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2899)]
    [Attributes(9)]
   public sealed class Wcdma1800EncBtf : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(2894)]
    [Attributes(9)]
   public sealed class Wcdma1800ExpHdetVsAgc : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5463)]
    [Attributes(9)]
   public sealed class Wcdma1800ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2895)]
    [Attributes(9)]
   public sealed class Wcdma1800HdetOff : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2896)]
    [Attributes(9)]
   public sealed class Wcdma1800HdetSpn : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4758)]
    [Attributes(9)]
   public sealed class Wcdma1800HsImLevel1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4757)]
    [Attributes(9)]
   public sealed class Wcdma1800HsImLevel2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4756)]
    [Attributes(9)]
   public sealed class Wcdma1800HsImLevel3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4755)]
    [Attributes(9)]
   public sealed class Wcdma1800HsImLevel4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4752)]
    [Attributes(9)]
   public sealed class Wcdma1800HsLnaRangeFall2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4751)]
    [Attributes(9)]
   public sealed class Wcdma1800HsLnaRangeFall3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4753)]
    [Attributes(9)]
   public sealed class Wcdma1800HsLnaRangeFall4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4754)]
    [Attributes(9)]
   public sealed class Wcdma1800HsLnaRangeFall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4749)]
    [Attributes(9)]
   public sealed class Wcdma1800HsLnaRangeRise2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4747)]
    [Attributes(9)]
   public sealed class Wcdma1800HsLnaRangeRise3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4748)]
    [Attributes(9)]
   public sealed class Wcdma1800HsLnaRangeRise4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4750)]
    [Attributes(9)]
   public sealed class Wcdma1800HsLnaRangeRise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2940)]
    [Attributes(9)]
   public sealed class Wcdma1800HsR1Fall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2939)]
    [Attributes(9)]
   public sealed class Wcdma1800HsR1Rise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2942)]
    [Attributes(9)]
   public sealed class Wcdma1800HsR2Fall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2941)]
    [Attributes(9)]
   public sealed class Wcdma1800HsR2Rise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2944)]
    [Attributes(9)]
   public sealed class Wcdma1800HsR3Fall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2943)]
    [Attributes(9)]
   public sealed class Wcdma1800HsR3Rise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6050)]
    [Attributes(9)]
   public sealed class Wcdma1800HsSwitchpointsShift : TwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4165)]
    [Attributes(9)]
   public sealed class Wcdma1800Iaccum : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2858)]
    [Attributes(9)]
   public sealed class Wcdma1800Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2859)]
    [Attributes(9)]
   public sealed class Wcdma1800Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2860)]
    [Attributes(9)]
   public sealed class Wcdma1800Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2852)]
    [Attributes(9)]
   public sealed class Wcdma1800ImLevel2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2853)]
    [Attributes(9)]
   public sealed class Wcdma1800ImLevel3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4415)]
    [Attributes(9)]
   public sealed class Wcdma1800ImLevel4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2865)]
    [Attributes(9)]
   public sealed class Wcdma1800ImLevel : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2856)]
    [Attributes(9)]
   public sealed class Wcdma1800LnaOffsetVsFreq2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2857)]
    [Attributes(9)]
   public sealed class Wcdma1800LnaOffsetVsFreq3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4416)]
    [Attributes(9)]
   public sealed class Wcdma1800LnaOffsetVsFreq4 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2869)]
    [Attributes(9)]
   public sealed class Wcdma1800LnaOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5103)]
    [Attributes(9)]
   public sealed class Wcdma1800LnaPhaseCtl : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2850)]
    [Attributes(9)]
   public sealed class Wcdma1800LnaRangeFall2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2851)]
    [Attributes(9)]
   public sealed class Wcdma1800LnaRangeFall3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4417)]
    [Attributes(9)]
   public sealed class Wcdma1800LnaRangeFall4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2864)]
    [Attributes(9)]
   public sealed class Wcdma1800LnaRangeFall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2854)]
    [Attributes(9)]
   public sealed class Wcdma1800LnaRangeOffset2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2855)]
    [Attributes(9)]
   public sealed class Wcdma1800LnaRangeOffset3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4418)]
    [Attributes(9)]
   public sealed class Wcdma1800LnaRangeOffset4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2868)]
    [Attributes(9)]
   public sealed class Wcdma1800LnaRangeOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2848)]
    [Attributes(9)]
   public sealed class Wcdma1800LnaRangeRise2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2849)]
    [Attributes(9)]
   public sealed class Wcdma1800LnaRangeRise3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4419)]
    [Attributes(9)]
   public sealed class Wcdma1800LnaRangeRise4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2863)]
    [Attributes(9)]
   public sealed class Wcdma1800LnaRangeRise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2936)]
    [Attributes(9)]
   public sealed class Wcdma1800MaxPwrBackoffVolt1 : FourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2937)]
    [Attributes(9)]
   public sealed class Wcdma1800MaxPwrBackoffVolt2 : FourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2938)]
    [Attributes(9)]
   public sealed class Wcdma1800MaxPwrBackoffVolt3 : FourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2935)]
    [Attributes(9)]
   public sealed class Wcdma1800MaxPwrBackoffVoltages : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2897)]
    [Attributes(9)]
   public sealed class Wcdma1800MaxTxPower : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2866)]
    [Attributes(9)]
   public sealed class Wcdma1800NonbypassTimer : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2934)]
    [Attributes(9)]
   public sealed class Wcdma1800PaCompensateDnWithDvs : TenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2914)]
    [Attributes(9)]
   public sealed class Wcdma1800PaCompensateDown : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2924)]
    [Attributes(9)]
   public sealed class Wcdma1800PaCompensateDownR2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2926)]
    [Attributes(9)]
   public sealed class Wcdma1800PaCompensateDownR3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2913)]
    [Attributes(9)]
   public sealed class Wcdma1800PaCompensateUp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2923)]
    [Attributes(9)]
   public sealed class Wcdma1800PaCompensateUpR2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2925)]
    [Attributes(9)]
   public sealed class Wcdma1800PaCompensateUpR3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2933)]
    [Attributes(9)]
   public sealed class Wcdma1800PaCompensateUpWithDvs : TenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2907)]
    [Attributes(9)]
   public sealed class Wcdma1800PaGainDownTime : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2906)]
    [Attributes(9)]
   public sealed class Wcdma1800PaGainUpTime : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2932)]
    [Attributes(9)]
   public sealed class Wcdma1800PaRangeForDvs : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2931)]
    [Attributes(9)]
   public sealed class Wcdma1800PaRangeMap : FourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2916)]
    [Attributes(9)]
   public sealed class Wcdma1800PrachR1FallOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2915)]
    [Attributes(9)]
   public sealed class Wcdma1800PrachR1RiseOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2928)]
    [Attributes(9)]
   public sealed class Wcdma1800PrachR2FallOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2927)]
    [Attributes(9)]
   public sealed class Wcdma1800PrachR2RiseOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2930)]
    [Attributes(9)]
   public sealed class Wcdma1800PrachR3FallOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2929)]
    [Attributes(9)]
   public sealed class Wcdma1800PrachR3RiseOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4166)]
    [Attributes(9)]
   public sealed class Wcdma1800Qaccum : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2890)]
    [Attributes(9)]
   public sealed class Wcdma1800R1Fall : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2889)]
    [Attributes(9)]
   public sealed class Wcdma1800R1Rise : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2920)]
    [Attributes(9)]
   public sealed class Wcdma1800R2Fall : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2919)]
    [Attributes(9)]
   public sealed class Wcdma1800R2Rise : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2922)]
    [Attributes(9)]
   public sealed class Wcdma1800R3Fall : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2921)]
    [Attributes(9)]
   public sealed class Wcdma1800R3Rise : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5278)]
    [Attributes(9)]
   public sealed class Wcdma1800Rel6TxAgcOffset : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5277)]
    [Attributes(9)]
   public sealed class Wcdma1800Rel6TxBetaScalingComp : SevenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5279)]
    [Attributes(9)]
   public sealed class Wcdma1800Rel6TxMprBackoff : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2871)]
    [Attributes(9)]
   public sealed class Wcdma1800RxAgcMax : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2861)]
    [Attributes(9)]
   public sealed class Wcdma1800RxAgcMin2 : Int16ItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    [NvItemId(2826)]
    [Attributes(9)]
   public sealed class Wcdma1800RxAgcMin3 : ItemBase
    {
        public byte Field1 { get; set; }


        public byte Field2 { get; set; }
    }

    [Serializable]
    [NvItemId(2862)]
    [Attributes(9)]
   public sealed class Wcdma1800RxAgcMin3I : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2870)]
    [Attributes(9)]
   public sealed class Wcdma1800RxAgcMin : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2918)]
    [Attributes(9)]
   public sealed class Wcdma1800RxCalChan : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2900)]
    [Attributes(9)]
   public sealed class Wcdma1800RxDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6394)]
    [Attributes(9)]
   public sealed class Wcdma1800RxfIciICoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6399)]
    [Attributes(9)]
   public sealed class Wcdma1800RxfIciICoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6400)]
    [Attributes(9)]
   public sealed class Wcdma1800RxfIciICoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6401)]
    [Attributes(9)]
   public sealed class Wcdma1800RxfIciICoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6395)]
    [Attributes(9)]
   public sealed class Wcdma1800RxfIciICoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6396)]
    [Attributes(9)]
   public sealed class Wcdma1800RxfIciICoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6397)]
    [Attributes(9)]
   public sealed class Wcdma1800RxfIciICoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6398)]
    [Attributes(9)]
   public sealed class Wcdma1800RxfIciICoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6410)]
    [Attributes(9)]
   public sealed class Wcdma1800RxfIciIqTrunc : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6402)]
    [Attributes(9)]
   public sealed class Wcdma1800RxfIciQCoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6407)]
    [Attributes(9)]
   public sealed class Wcdma1800RxfIciQCoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6408)]
    [Attributes(9)]
   public sealed class Wcdma1800RxfIciQCoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6409)]
    [Attributes(9)]
   public sealed class Wcdma1800RxfIciQCoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6403)]
    [Attributes(9)]
   public sealed class Wcdma1800RxfIciQCoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6404)]
    [Attributes(9)]
   public sealed class Wcdma1800RxfIciQCoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6405)]
    [Attributes(9)]
   public sealed class Wcdma1800RxfIciQCoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6406)]
    [Attributes(9)]
   public sealed class Wcdma1800RxfIciQCoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6390)]
    [Attributes(9)]
   public sealed class Wcdma1800RxfMisCompACoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6391)]
    [Attributes(9)]
   public sealed class Wcdma1800RxfMisCompBCoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5051)]
    [Attributes(9)]
   public sealed class Wcdma1800TimerHysterisis : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2917)]
    [Attributes(9)]
   public sealed class Wcdma1800TxCalChan : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2877)]
    [Attributes(9)]
   public sealed class Wcdma1800TxCompVsFreq0 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4980)]
    [Attributes(9)]
   public sealed class Wcdma1800TxCompVsFreq0Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2878)]
    [Attributes(9)]
   public sealed class Wcdma1800TxCompVsFreq1 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4981)]
    [Attributes(9)]
   public sealed class Wcdma1800TxCompVsFreq1Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2879)]
    [Attributes(9)]
   public sealed class Wcdma1800TxCompVsFreq2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4982)]
    [Attributes(9)]
   public sealed class Wcdma1800TxCompVsFreq2Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2880)]
    [Attributes(9)]
   public sealed class Wcdma1800TxCompVsFreq3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4983)]
    [Attributes(9)]
   public sealed class Wcdma1800TxCompVsFreq3Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4984)]
    [Attributes(9)]
   public sealed class Wcdma1800TxCompVsFreqSecPdmList : FourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2892)]
    [Attributes(9)]
   public sealed class Wcdma1800TxLimVsFreq : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2891)]
    [Attributes(9)]
   public sealed class Wcdma1800TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5057)]
    [Attributes(9)]
   public sealed class Wcdma1800TxLinMaster0Enh : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2873)]
    [Attributes(9)]
   public sealed class Wcdma1800TxLinMaster0 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2874)]
    [Attributes(9)]
   public sealed class Wcdma1800TxLinMaster1 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2875)]
    [Attributes(9)]
   public sealed class Wcdma1800TxLinMaster2 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2876)]
    [Attributes(9)]
   public sealed class Wcdma1800TxLinMaster3 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2881)]
    [Attributes(9)]
   public sealed class Wcdma1800TxLinVsTemp0 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2882)]
    [Attributes(9)]
   public sealed class Wcdma1800TxLinVsTemp1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2883)]
    [Attributes(9)]
   public sealed class Wcdma1800TxLinVsTemp2 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2884)]
    [Attributes(9)]
   public sealed class Wcdma1800TxLinVsTemp3 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5063)]
    [Attributes(9)]
   public sealed class Wcdma1800TxPdmLin0Enh : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3991)]
    [Attributes(9)]
   public sealed class Wcdma1800TxPdmLin0 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3992)]
    [Attributes(9)]
   public sealed class Wcdma1800TxPdmLin1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3993)]
    [Attributes(9)]
   public sealed class Wcdma1800TxPdmLin2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3994)]
    [Attributes(9)]
   public sealed class Wcdma1800TxPdmLin3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2908)]
    [Attributes(9)]
   public sealed class Wcdma1800TxRotAnglePaState00 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2909)]
    [Attributes(9)]
   public sealed class Wcdma1800TxRotAnglePaState01 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2910)]
    [Attributes(9)]
   public sealed class Wcdma1800TxRotAnglePaState10 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2911)]
    [Attributes(9)]
   public sealed class Wcdma1800TxRotAnglePaState11 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2885)]
    [Attributes(9)]
   public sealed class Wcdma1800TxSlpVsTemp0 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2886)]
    [Attributes(9)]
   public sealed class Wcdma1800TxSlpVsTemp1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2887)]
    [Attributes(9)]
   public sealed class Wcdma1800TxSlpVsTemp2 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2888)]
    [Attributes(9)]
   public sealed class Wcdma1800TxSlpVsTemp3 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2981)]
    [Attributes(9)]
   public sealed class Wcdma1800UtranTxLimVsTempOffset : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2845)]
    [Attributes(9)]
   public sealed class Wcdma1800VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2846)]
    [Attributes(9)]
   public sealed class Wcdma1800VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2847)]
    [Attributes(9)]
   public sealed class Wcdma1800VgaGainOffsetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1185)]
    [Attributes(9)]
   public sealed class Wcdma1900AdjFactor : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1202)]
    [Attributes(9)]
   public sealed class Wcdma1900AgcPaOnFallDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1201)]
    [Attributes(9)]
   public sealed class Wcdma1900AgcPaOnRiseDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1172)]
    [Attributes(9)]
   public sealed class Wcdma1900AgcPhaseOffset : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2948)]
    [Attributes(9)]
   public sealed class Wcdma1900AgcTxAdjPdmDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1204)]
    [Attributes(9)]
   public sealed class Wcdma1900AgcTxOnFallDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1203)]
    [Attributes(9)]
   public sealed class Wcdma1900AgcTxOnRiseDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1205)]
    [Attributes(9)]
   public sealed class Wcdma1900AgcUpdateTxAgcTime : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1167)]
    [Attributes(9)]
   public sealed class Wcdma1900BypassTimer : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4935)]
    [Attributes(9)]
   public sealed class Wcdma1900C0C1Delay : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2947)]
    [Attributes(9)]
   public sealed class Wcdma1900DchAgcUpdateTxAgcTime : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4195)]
    [Attributes(9)]
   public sealed class Wcdma1900DrxModeSel : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1189)]
    [Attributes(9)]
   public sealed class Wcdma1900EncBtf : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(1186)]
    [Attributes(9)]
   public sealed class Wcdma1900ExpHdetVsAgc : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5460)]
    [Attributes(9)]
   public sealed class Wcdma1900ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1187)]
    [Attributes(9)]
   public sealed class Wcdma1900HdetOff : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1188)]
    [Attributes(9)]
   public sealed class Wcdma1900HdetSpn : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4768)]
    [Attributes(9)]
   public sealed class Wcdma1900HsImLevel1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4767)]
    [Attributes(9)]
   public sealed class Wcdma1900HsImLevel2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4769)]
    [Attributes(9)]
   public sealed class Wcdma1900HsImLevel3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4770)]
    [Attributes(9)]
   public sealed class Wcdma1900HsImLevel4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4761)]
    [Attributes(9)]
   public sealed class Wcdma1900HsLnaRangeFall2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4760)]
    [Attributes(9)]
   public sealed class Wcdma1900HsLnaRangeFall3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4759)]
    [Attributes(9)]
   public sealed class Wcdma1900HsLnaRangeFall4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4762)]
    [Attributes(9)]
   public sealed class Wcdma1900HsLnaRangeFall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4765)]
    [Attributes(9)]
   public sealed class Wcdma1900HsLnaRangeRise2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4764)]
    [Attributes(9)]
   public sealed class Wcdma1900HsLnaRangeRise3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4763)]
    [Attributes(9)]
   public sealed class Wcdma1900HsLnaRangeRise4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4766)]
    [Attributes(9)]
   public sealed class Wcdma1900HsLnaRangeRise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2731)]
    [Attributes(9)]
   public sealed class Wcdma1900HsR1Fall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2730)]
    [Attributes(9)]
   public sealed class Wcdma1900HsR1Rise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2733)]
    [Attributes(9)]
   public sealed class Wcdma1900HsR2Fall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2732)]
    [Attributes(9)]
   public sealed class Wcdma1900HsR2Rise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2735)]
    [Attributes(9)]
   public sealed class Wcdma1900HsR3Fall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2734)]
    [Attributes(9)]
   public sealed class Wcdma1900HsR3Rise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6049)]
    [Attributes(9)]
   public sealed class Wcdma1900HsSwitchpointsShift : TwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4163)]
    [Attributes(9)]
   public sealed class Wcdma1900Iaccum : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1156)]
    [Attributes(9)]
   public sealed class Wcdma1900Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1157)]
    [Attributes(9)]
   public sealed class Wcdma1900Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1158)]
    [Attributes(9)]
   public sealed class Wcdma1900Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1150)]
    [Attributes(9)]
   public sealed class Wcdma1900ImLevel2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1151)]
    [Attributes(9)]
   public sealed class Wcdma1900ImLevel3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4405)]
    [Attributes(9)]
   public sealed class Wcdma1900ImLevel4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1165)]
    [Attributes(9)]
   public sealed class Wcdma1900ImLevel : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1154)]
    [Attributes(9)]
   public sealed class Wcdma1900LnaOffsetVsFreq2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1155)]
    [Attributes(9)]
   public sealed class Wcdma1900LnaOffsetVsFreq3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4406)]
    [Attributes(9)]
   public sealed class Wcdma1900LnaOffsetVsFreq4 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1169)]
    [Attributes(9)]
   public sealed class Wcdma1900LnaOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5095)]
    [Attributes(9)]
   public sealed class Wcdma1900LnaPhaseCtl : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1148)]
    [Attributes(9)]
   public sealed class Wcdma1900LnaRangeFall2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1149)]
    [Attributes(9)]
   public sealed class Wcdma1900LnaRangeFall3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4407)]
    [Attributes(9)]
   public sealed class Wcdma1900LnaRangeFall4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1164)]
    [Attributes(9)]
   public sealed class Wcdma1900LnaRangeFall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1152)]
    [Attributes(9)]
   public sealed class Wcdma1900LnaRangeOffset2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1153)]
    [Attributes(9)]
   public sealed class Wcdma1900LnaRangeOffset3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4408)]
    [Attributes(9)]
   public sealed class Wcdma1900LnaRangeOffset4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1168)]
    [Attributes(9)]
   public sealed class Wcdma1900LnaRangeOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1146)]
    [Attributes(9)]
   public sealed class Wcdma1900LnaRangeRise2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1147)]
    [Attributes(9)]
   public sealed class Wcdma1900LnaRangeRise3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4409)]
    [Attributes(9)]
   public sealed class Wcdma1900LnaRangeRise4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1163)]
    [Attributes(9)]
   public sealed class Wcdma1900LnaRangeRise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2717)]
    [Attributes(9)]
   public sealed class Wcdma1900MaxPwrBackoffVolt1 : FourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2718)]
    [Attributes(9)]
   public sealed class Wcdma1900MaxPwrBackoffVolt2 : FourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2719)]
    [Attributes(9)]
   public sealed class Wcdma1900MaxPwrBackoffVolt3 : FourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2716)]
    [Attributes(9)]
   public sealed class Wcdma1900MaxPwrBackoffVoltages : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1161)]
    [Attributes(9)]
   public sealed class Wcdma1900MaxTxPower : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1166)]
    [Attributes(9)]
   public sealed class Wcdma1900NonbypassTimer : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1162)]
    [Attributes(9)]
   public sealed class Wcdma1900OutOfServiceThresh : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2708)]
    [Attributes(9)]
   public sealed class Wcdma1900PaCompensateDnWithDvs : TenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1966)]
    [Attributes(9)]
   public sealed class Wcdma1900PaCompensateDown : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2043)]
    [Attributes(9)]
   public sealed class Wcdma1900PaCompensateDownR2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2045)]
    [Attributes(9)]
   public sealed class Wcdma1900PaCompensateDownR3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1965)]
    [Attributes(9)]
   public sealed class Wcdma1900PaCompensateUp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2042)]
    [Attributes(9)]
   public sealed class Wcdma1900PaCompensateUpR2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2044)]
    [Attributes(9)]
   public sealed class Wcdma1900PaCompensateUpR3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2707)]
    [Attributes(9)]
   public sealed class Wcdma1900PaCompensateUpWithDvs : TenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1970)]
    [Attributes(9)]
   public sealed class Wcdma1900PaGainDownTime : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1969)]
    [Attributes(9)]
   public sealed class Wcdma1900PaGainUpTime : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2706)]
    [Attributes(9)]
   public sealed class Wcdma1900PaRangeForDvs : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2054)]
    [Attributes(9)]
   public sealed class Wcdma1900PaRangeMap : FourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1911)]
    [Attributes(9)]
   public sealed class Wcdma1900PrachR1FallOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1909)]
    [Attributes(9)]
   public sealed class Wcdma1900PrachR1RiseOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2051)]
    [Attributes(9)]
   public sealed class Wcdma1900PrachR2FallOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2050)]
    [Attributes(9)]
   public sealed class Wcdma1900PrachR2RiseOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2053)]
    [Attributes(9)]
   public sealed class Wcdma1900PrachR3FallOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2052)]
    [Attributes(9)]
   public sealed class Wcdma1900PrachR3RiseOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4164)]
    [Attributes(9)]
   public sealed class Wcdma1900Qaccum : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1182)]
    [Attributes(9)]
   public sealed class Wcdma1900R1Fall : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1181)]
    [Attributes(9)]
   public sealed class Wcdma1900R1Rise : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2039)]
    [Attributes(9)]
   public sealed class Wcdma1900R2Fall : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2038)]
    [Attributes(9)]
   public sealed class Wcdma1900R2Rise : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2041)]
    [Attributes(9)]
   public sealed class Wcdma1900R3Fall : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2040)]
    [Attributes(9)]
   public sealed class Wcdma1900R3Rise : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4945)]
    [Attributes(9)]
   public sealed class Wcdma1900Rel6TxAgcOffset : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4944)]
    [Attributes(9)]
   public sealed class Wcdma1900Rel6TxBetaScalingComp : SevenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4946)]
    [Attributes(9)]
   public sealed class Wcdma1900Rel6TxMprBackoff : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1171)]
    [Attributes(9)]
   public sealed class Wcdma1900RxAgcMax : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1159)]
    [Attributes(9)]
   public sealed class Wcdma1900RxAgcMin2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1160)]
    [Attributes(9)]
   public sealed class Wcdma1900RxAgcMin3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1170)]
    [Attributes(9)]
   public sealed class Wcdma1900RxAgcMin : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1974)]
    [Attributes(9)]
   public sealed class Wcdma1900RxCalChan : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1987)]
    [Attributes(9)]
   public sealed class Wcdma1900RxDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5946)]
    [Attributes(9)]
   public sealed class Wcdma1900RxfIciICoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5951)]
    [Attributes(9)]
   public sealed class Wcdma1900RxfIciICoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5952)]
    [Attributes(9)]
   public sealed class Wcdma1900RxfIciICoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5953)]
    [Attributes(9)]
   public sealed class Wcdma1900RxfIciICoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5947)]
    [Attributes(9)]
   public sealed class Wcdma1900RxfIciICoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5948)]
    [Attributes(9)]
   public sealed class Wcdma1900RxfIciICoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5949)]
    [Attributes(9)]
   public sealed class Wcdma1900RxfIciICoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5950)]
    [Attributes(9)]
   public sealed class Wcdma1900RxfIciICoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5978)]
    [Attributes(9)]
   public sealed class Wcdma1900RxfIciIqTrunc : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5954)]
    [Attributes(9)]
   public sealed class Wcdma1900RxfIciQCoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5959)]
    [Attributes(9)]
   public sealed class Wcdma1900RxfIciQCoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5960)]
    [Attributes(9)]
   public sealed class Wcdma1900RxfIciQCoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5961)]
    [Attributes(9)]
   public sealed class Wcdma1900RxfIciQCoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5955)]
    [Attributes(9)]
   public sealed class Wcdma1900RxfIciQCoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5956)]
    [Attributes(9)]
   public sealed class Wcdma1900RxfIciQCoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5957)]
    [Attributes(9)]
   public sealed class Wcdma1900RxfIciQCoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5958)]
    [Attributes(9)]
   public sealed class Wcdma1900RxfIciQCoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5900)]
    [Attributes(9)]
   public sealed class Wcdma1900RxfMisCompACoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5901)]
    [Attributes(9)]
   public sealed class Wcdma1900RxfMisCompBCoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5052)]
    [Attributes(9)]
   public sealed class Wcdma1900TimerHysterisis : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1973)]
    [Attributes(9)]
   public sealed class Wcdma1900TxCalChan : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1175)]
    [Attributes(9)]
   public sealed class Wcdma1900TxCompVsFreq0 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4970)]
    [Attributes(9)]
   public sealed class Wcdma1900TxCompVsFreq0Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1176)]
    [Attributes(9)]
   public sealed class Wcdma1900TxCompVsFreq1 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4971)]
    [Attributes(9)]
   public sealed class Wcdma1900TxCompVsFreq1Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2032)]
    [Attributes(9)]
   public sealed class Wcdma1900TxCompVsFreq2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4972)]
    [Attributes(9)]
   public sealed class Wcdma1900TxCompVsFreq2Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2033)]
    [Attributes(9)]
   public sealed class Wcdma1900TxCompVsFreq3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4973)]
    [Attributes(9)]
   public sealed class Wcdma1900TxCompVsFreq3Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4974)]
    [Attributes(9)]
   public sealed class Wcdma1900TxCompVsFreqSecPdmList : FourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1184)]
    [Attributes(9)]
   public sealed class Wcdma1900TxLimVsFreq : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1183)]
    [Attributes(9)]
   public sealed class Wcdma1900TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5058)]
    [Attributes(9)]
   public sealed class Wcdma1900TxLinMaster0Enh : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1173)]
    [Attributes(9)]
   public sealed class Wcdma1900TxLinMaster0 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1174)]
    [Attributes(9)]
   public sealed class Wcdma1900TxLinMaster1 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2030)]
    [Attributes(9)]
   public sealed class Wcdma1900TxLinMaster2 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2031)]
    [Attributes(9)]
   public sealed class Wcdma1900TxLinMaster3 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1177)]
    [Attributes(9)]
   public sealed class Wcdma1900TxLinVsTemp0 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1178)]
    [Attributes(9)]
   public sealed class Wcdma1900TxLinVsTemp1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2034)]
    [Attributes(9)]
   public sealed class Wcdma1900TxLinVsTemp2 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2035)]
    [Attributes(9)]
   public sealed class Wcdma1900TxLinVsTemp3 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5064)]
    [Attributes(9)]
   public sealed class Wcdma1900TxPdmLin0Enh : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3977)]
    [Attributes(9)]
   public sealed class Wcdma1900TxPdmLin0 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3978)]
    [Attributes(9)]
   public sealed class Wcdma1900TxPdmLin1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3979)]
    [Attributes(9)]
   public sealed class Wcdma1900TxPdmLin2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3980)]
    [Attributes(9)]
   public sealed class Wcdma1900TxPdmLin3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2046)]
    [Attributes(9)]
   public sealed class Wcdma1900TxRotAnglePaState00 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2047)]
    [Attributes(9)]
   public sealed class Wcdma1900TxRotAnglePaState01 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2048)]
    [Attributes(9)]
   public sealed class Wcdma1900TxRotAnglePaState10 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2049)]
    [Attributes(9)]
   public sealed class Wcdma1900TxRotAnglePaState11 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1179)]
    [Attributes(9)]
   public sealed class Wcdma1900TxSlpVsTemp0 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1180)]
    [Attributes(9)]
   public sealed class Wcdma1900TxSlpVsTemp1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2036)]
    [Attributes(9)]
   public sealed class Wcdma1900TxSlpVsTemp2 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2037)]
    [Attributes(9)]
   public sealed class Wcdma1900TxSlpVsTemp3 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2983)]
    [Attributes(9)]
   public sealed class Wcdma1900UtranTxLimVsTempOffset : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1143)]
    [Attributes(9)]
   public sealed class Wcdma1900VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1144)]
    [Attributes(9)]
   public sealed class Wcdma1900VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1145)]
    [Attributes(9)]
   public sealed class Wcdma1900VgaGainOffsetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4196)]
    [Attributes(9)]
   public sealed class Wcdma2100DrxModeSel : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5459)]
    [Attributes(9)]
   public sealed class Wcdma2100ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6048)]
    [Attributes(9)]
   public sealed class Wcdma2100HsSwitchpointsShift : TwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6904)]
    [Attributes(9)]
   public sealed class Wcdma2100LnaRangeFall2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6905)]
    [Attributes(9)]
   public sealed class Wcdma2100LnaRangeFall3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6906)]
    [Attributes(9)]
   public sealed class Wcdma2100LnaRangeFall4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6903)]
    [Attributes(9)]
   public sealed class Wcdma2100LnaRangeFallCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6885)]
    [Attributes(9)]
   public sealed class Wcdma2100LnaRangeOffset2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6886)]
    [Attributes(9)]
   public sealed class Wcdma2100LnaRangeOffset3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6887)]
    [Attributes(9)]
   public sealed class Wcdma2100LnaRangeOffset4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6888)]
    [Attributes(9)]
   public sealed class Wcdma2100LnaRangeOffset5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6884)]
    [Attributes(9)]
   public sealed class Wcdma2100LnaRangeOffsetCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6896)]
    [Attributes(9)]
   public sealed class Wcdma2100LnaRangeRise2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6897)]
    [Attributes(9)]
   public sealed class Wcdma2100LnaRangeRise3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6898)]
    [Attributes(9)]
   public sealed class Wcdma2100LnaRangeRise4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6895)]
    [Attributes(9)]
   public sealed class Wcdma2100LnaRangeRiseCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5053)]
    [Attributes(9)]
   public sealed class Wcdma2100TimerHysterisis : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5059)]
    [Attributes(9)]
   public sealed class Wcdma2100TxLinMaster0Enh : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5065)]
    [Attributes(9)]
   public sealed class Wcdma2100TxPdmLin0Enh : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6890)]
    [Attributes(9)]
   public sealed class Wcdma2100VgaGainOffsetCar1I : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1865)]
    [Attributes(9)]
   public sealed class Wcdma800AdjFactor : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1871)]
    [Attributes(9)]
   public sealed class Wcdma800AgcPaOnFallDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1870)]
    [Attributes(9)]
   public sealed class Wcdma800AgcPaOnRiseDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1843)]
    [Attributes(9)]
   public sealed class Wcdma800AgcPhaseOffset : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2950)]
    [Attributes(9)]
   public sealed class Wcdma800AgcTxAdjPdmDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1873)]
    [Attributes(9)]
   public sealed class Wcdma800AgcTxOnFallDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1872)]
    [Attributes(9)]
   public sealed class Wcdma800AgcTxOnRiseDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1874)]
    [Attributes(9)]
   public sealed class Wcdma800AgcUpdateTxAgcTime : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1838)]
    [Attributes(9)]
   public sealed class Wcdma800BypassTimer : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4939)]
    [Attributes(9)]
   public sealed class Wcdma800C0C1Delay : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2949)]
    [Attributes(9)]
   public sealed class Wcdma800DchAgcUpdateTxAgcTime : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4197)]
    [Attributes(9)]
   public sealed class Wcdma800DrxModeSel : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1869)]
    [Attributes(9)]
   public sealed class Wcdma800EncBtf : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(1866)]
    [Attributes(9)]
   public sealed class Wcdma800ExpHdetVsAgc : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5461)]
    [Attributes(9)]
   public sealed class Wcdma800ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1867)]
    [Attributes(9)]
   public sealed class Wcdma800HdetOff : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1868)]
    [Attributes(9)]
   public sealed class Wcdma800HdetSpn : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4781)]
    [Attributes(9)]
   public sealed class Wcdma800HsImLevel1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4780)]
    [Attributes(9)]
   public sealed class Wcdma800HsImLevel2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4779)]
    [Attributes(9)]
   public sealed class Wcdma800HsImLevel3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4782)]
    [Attributes(9)]
   public sealed class Wcdma800HsImLevel4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4776)]
    [Attributes(9)]
   public sealed class Wcdma800HsLnaRangeFall1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4775)]
    [Attributes(9)]
   public sealed class Wcdma800HsLnaRangeFall2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4777)]
    [Attributes(9)]
   public sealed class Wcdma800HsLnaRangeFall3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4778)]
    [Attributes(9)]
   public sealed class Wcdma800HsLnaRangeFall4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4773)]
    [Attributes(9)]
   public sealed class Wcdma800HsLnaRangeRise2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4772)]
    [Attributes(9)]
   public sealed class Wcdma800HsLnaRangeRise3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4771)]
    [Attributes(9)]
   public sealed class Wcdma800HsLnaRangeRise4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4774)]
    [Attributes(9)]
   public sealed class Wcdma800HsLnaRangeRise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2737)]
    [Attributes(9)]
   public sealed class Wcdma800HsR1Fall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2736)]
    [Attributes(9)]
   public sealed class Wcdma800HsR1Rise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2739)]
    [Attributes(9)]
   public sealed class Wcdma800HsR2Fall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2738)]
    [Attributes(9)]
   public sealed class Wcdma800HsR2Rise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2741)]
    [Attributes(9)]
   public sealed class Wcdma800HsR3Fall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2740)]
    [Attributes(9)]
   public sealed class Wcdma800HsR3Rise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6052)]
    [Attributes(9)]
   public sealed class Wcdma800HsSwitchpointsShift : TwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4169)]
    [Attributes(9)]
   public sealed class Wcdma800Iaccum : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1827)]
    [Attributes(9)]
   public sealed class Wcdma800Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1828)]
    [Attributes(9)]
   public sealed class Wcdma800Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1829)]
    [Attributes(9)]
   public sealed class Wcdma800Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1821)]
    [Attributes(9)]
   public sealed class Wcdma800ImLevel2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1822)]
    [Attributes(9)]
   public sealed class Wcdma800ImLevel3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4410)]
    [Attributes(9)]
   public sealed class Wcdma800ImLevel4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1836)]
    [Attributes(9)]
   public sealed class Wcdma800ImLevel : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1825)]
    [Attributes(9)]
   public sealed class Wcdma800LnaOffsetVsFreq2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1826)]
    [Attributes(9)]
   public sealed class Wcdma800LnaOffsetVsFreq3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4411)]
    [Attributes(9)]
   public sealed class Wcdma800LnaOffsetVsFreq4 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1840)]
    [Attributes(9)]
   public sealed class Wcdma800LnaOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5097)]
    [Attributes(9)]
   public sealed class Wcdma800LnaPhaseCtl : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1819)]
    [Attributes(9)]
   public sealed class Wcdma800LnaRangeFall2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1820)]
    [Attributes(9)]
   public sealed class Wcdma800LnaRangeFall3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4412)]
    [Attributes(9)]
   public sealed class Wcdma800LnaRangeFall4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1835)]
    [Attributes(9)]
   public sealed class Wcdma800LnaRangeFall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1823)]
    [Attributes(9)]
   public sealed class Wcdma800LnaRangeOffset2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1824)]
    [Attributes(9)]
   public sealed class Wcdma800LnaRangeOffset3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4413)]
    [Attributes(9)]
   public sealed class Wcdma800LnaRangeOffset4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1839)]
    [Attributes(9)]
   public sealed class Wcdma800LnaRangeOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1817)]
    [Attributes(9)]
   public sealed class Wcdma800LnaRangeRise2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1818)]
    [Attributes(9)]
   public sealed class Wcdma800LnaRangeRise3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4414)]
    [Attributes(9)]
   public sealed class Wcdma800LnaRangeRise4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1834)]
    [Attributes(9)]
   public sealed class Wcdma800LnaRangeRise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2721)]
    [Attributes(9)]
   public sealed class Wcdma800MaxPwrBackoffVolt1 : FourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2722)]
    [Attributes(9)]
   public sealed class Wcdma800MaxPwrBackoffVolt2 : FourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2723)]
    [Attributes(9)]
   public sealed class Wcdma800MaxPwrBackoffVolt3 : FourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2720)]
    [Attributes(9)]
   public sealed class Wcdma800MaxPwrBackoffVoltages : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1832)]
    [Attributes(9)]
   public sealed class Wcdma800MaxTxPower : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1837)]
    [Attributes(9)]
   public sealed class Wcdma800NonbypassTimer : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1833)]
    [Attributes(9)]
   public sealed class Wcdma800OutOfServiceThresh : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2711)]
    [Attributes(9)]
   public sealed class Wcdma800PaCompensateDnWithDvs : TenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1964)]
    [Attributes(9)]
   public sealed class Wcdma800PaCompensateDown : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2068)]
    [Attributes(9)]
   public sealed class Wcdma800PaCompensateDownR2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2070)]
    [Attributes(9)]
   public sealed class Wcdma800PaCompensateDownR3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1963)]
    [Attributes(9)]
   public sealed class Wcdma800PaCompensateUp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2067)]
    [Attributes(9)]
   public sealed class Wcdma800PaCompensateUpR2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2069)]
    [Attributes(9)]
   public sealed class Wcdma800PaCompensateUpR3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2710)]
    [Attributes(9)]
   public sealed class Wcdma800PaCompensateUpWithDvs : TenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1968)]
    [Attributes(9)]
   public sealed class Wcdma800PaGainDownTime : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1967)]
    [Attributes(9)]
   public sealed class Wcdma800PaGainUpTime : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2709)]
    [Attributes(9)]
   public sealed class Wcdma800PaRangeForDvs : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2079)]
    [Attributes(9)]
   public sealed class Wcdma800PaRangeMap : FourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1912)]
    [Attributes(9)]
   public sealed class Wcdma800PrachR1FallOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1931)]
    [Attributes(9)]
   public sealed class Wcdma800PrachR1RiseOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2076)]
    [Attributes(9)]
   public sealed class Wcdma800PrachR2FallOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2075)]
    [Attributes(9)]
   public sealed class Wcdma800PrachR2RiseOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2078)]
    [Attributes(9)]
   public sealed class Wcdma800PrachR3FallOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2077)]
    [Attributes(9)]
   public sealed class Wcdma800PrachR3RiseOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4170)]
    [Attributes(9)]
   public sealed class Wcdma800Qaccum : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1862)]
    [Attributes(9)]
   public sealed class Wcdma800R1Fall : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1861)]
    [Attributes(9)]
   public sealed class Wcdma800R1Rise : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2064)]
    [Attributes(9)]
   public sealed class Wcdma800R2Fall : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2063)]
    [Attributes(9)]
   public sealed class Wcdma800R2Rise : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2066)]
    [Attributes(9)]
   public sealed class Wcdma800R3Fall : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2065)]
    [Attributes(9)]
   public sealed class Wcdma800R3Rise : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4948)]
    [Attributes(9)]
   public sealed class Wcdma800Rel6TxAgcOffset : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4947)]
    [Attributes(9)]
   public sealed class Wcdma800Rel6TxBetaScalingComp : SevenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4949)]
    [Attributes(9)]
   public sealed class Wcdma800Rel6TxMprBackoff : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1842)]
    [Attributes(9)]
   public sealed class Wcdma800RxAgcMax : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1830)]
    [Attributes(9)]
   public sealed class Wcdma800RxAgcMin2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1831)]
    [Attributes(9)]
   public sealed class Wcdma800RxAgcMin3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1841)]
    [Attributes(9)]
   public sealed class Wcdma800RxAgcMin : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1976)]
    [Attributes(9)]
   public sealed class Wcdma800RxCalChan : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1986)]
    [Attributes(9)]
   public sealed class Wcdma800RxDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7158)]
    [Attributes(9)]
   public sealed class Wcdma800RxfIciCalDataCar0 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7159)]
    [Attributes(9)]
   public sealed class Wcdma800RxfIciCalDataCar1 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6014)]
    [Attributes(9)]
   public sealed class Wcdma800RxfIciICoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6019)]
    [Attributes(9)]
   public sealed class Wcdma800RxfIciICoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6020)]
    [Attributes(9)]
   public sealed class Wcdma800RxfIciICoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6021)]
    [Attributes(9)]
   public sealed class Wcdma800RxfIciICoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6015)]
    [Attributes(9)]
   public sealed class Wcdma800RxfIciICoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6016)]
    [Attributes(9)]
   public sealed class Wcdma800RxfIciICoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6017)]
    [Attributes(9)]
   public sealed class Wcdma800RxfIciICoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6018)]
    [Attributes(9)]
   public sealed class Wcdma800RxfIciICoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6046)]
    [Attributes(9)]
   public sealed class Wcdma800RxfIciIqTrunc : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6022)]
    [Attributes(9)]
   public sealed class Wcdma800RxfIciQCoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6027)]
    [Attributes(9)]
   public sealed class Wcdma800RxfIciQCoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6028)]
    [Attributes(9)]
   public sealed class Wcdma800RxfIciQCoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6029)]
    [Attributes(9)]
   public sealed class Wcdma800RxfIciQCoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6023)]
    [Attributes(9)]
   public sealed class Wcdma800RxfIciQCoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6024)]
    [Attributes(9)]
   public sealed class Wcdma800RxfIciQCoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6025)]
    [Attributes(9)]
   public sealed class Wcdma800RxfIciQCoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6026)]
    [Attributes(9)]
   public sealed class Wcdma800RxfIciQCoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5908)]
    [Attributes(9)]
   public sealed class Wcdma800RxfMisCompACoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5909)]
    [Attributes(9)]
   public sealed class Wcdma800RxfMisCompBCoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5048)]
    [Attributes(9)]
   public sealed class Wcdma800TimerHysterisis : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1975)]
    [Attributes(9)]
   public sealed class Wcdma800TxCalChan : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1846)]
    [Attributes(9)]
   public sealed class Wcdma800TxCompVsFreq0 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4975)]
    [Attributes(9)]
   public sealed class Wcdma800TxCompVsFreq0Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1847)]
    [Attributes(9)]
   public sealed class Wcdma800TxCompVsFreq1 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4976)]
    [Attributes(9)]
   public sealed class Wcdma800TxCompVsFreq1Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2057)]
    [Attributes(9)]
   public sealed class Wcdma800TxCompVsFreq2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4977)]
    [Attributes(9)]
   public sealed class Wcdma800TxCompVsFreq2Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2058)]
    [Attributes(9)]
   public sealed class Wcdma800TxCompVsFreq3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4978)]
    [Attributes(9)]
   public sealed class Wcdma800TxCompVsFreq3Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4979)]
    [Attributes(9)]
   public sealed class Wcdma800TxCompVsFreqSecPdmList : FourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1864)]
    [Attributes(9)]
   public sealed class Wcdma800TxLimVsFreq : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1863)]
    [Attributes(9)]
   public sealed class Wcdma800TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5054)]
    [Attributes(9)]
   public sealed class Wcdma800TxLinMaster0Enh : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1844)]
    [Attributes(9)]
   public sealed class Wcdma800TxLinMaster0 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1845)]
    [Attributes(9)]
   public sealed class Wcdma800TxLinMaster1 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2055)]
    [Attributes(9)]
   public sealed class Wcdma800TxLinMaster2 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2056)]
    [Attributes(9)]
   public sealed class Wcdma800TxLinMaster3 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1848)]
    [Attributes(9)]
   public sealed class Wcdma800TxLinVsTemp0 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1849)]
    [Attributes(9)]
   public sealed class Wcdma800TxLinVsTemp1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2059)]
    [Attributes(9)]
   public sealed class Wcdma800TxLinVsTemp2 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2060)]
    [Attributes(9)]
   public sealed class Wcdma800TxLinVsTemp3 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5060)]
    [Attributes(9)]
   public sealed class Wcdma800TxPdmLin0Enh : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3973)]
    [Attributes(9)]
   public sealed class Wcdma800TxPdmLin0 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3974)]
    [Attributes(9)]
   public sealed class Wcdma800TxPdmLin1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3975)]
    [Attributes(9)]
   public sealed class Wcdma800TxPdmLin2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3976)]
    [Attributes(9)]
   public sealed class Wcdma800TxPdmLin3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2071)]
    [Attributes(9)]
   public sealed class Wcdma800TxRotAnglePaState00 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2072)]
    [Attributes(9)]
   public sealed class Wcdma800TxRotAnglePaState01 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2073)]
    [Attributes(9)]
   public sealed class Wcdma800TxRotAnglePaState10 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2074)]
    [Attributes(9)]
   public sealed class Wcdma800TxRotAnglePaState11 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1850)]
    [Attributes(9)]
   public sealed class Wcdma800TxSlpVsTemp0 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1860)]
    [Attributes(9)]
   public sealed class Wcdma800TxSlpVsTemp1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2061)]
    [Attributes(9)]
   public sealed class Wcdma800TxSlpVsTemp2 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2062)]
    [Attributes(9)]
   public sealed class Wcdma800TxSlpVsTemp3 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2982)]
    [Attributes(9)]
   public sealed class Wcdma800UtranTxLimVsTempOffset : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1814)]
    [Attributes(9)]
   public sealed class Wcdma800VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1815)]
    [Attributes(9)]
   public sealed class Wcdma800VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1816)]
    [Attributes(9)]
   public sealed class Wcdma800VgaGainOffsetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3692)]
    [Attributes(9)]
   public sealed class Wcdma900AdjFactor : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3698)]
    [Attributes(9)]
   public sealed class Wcdma900AgcPaOnFallDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3697)]
    [Attributes(9)]
   public sealed class Wcdma900AgcPaOnRiseDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3679)]
    [Attributes(9)]
   public sealed class Wcdma900AgcPhaseOffset : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3732)]
    [Attributes(9)]
   public sealed class Wcdma900AgcTxAdjPdmDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3700)]
    [Attributes(9)]
   public sealed class Wcdma900AgcTxOnFallDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3699)]
    [Attributes(9)]
   public sealed class Wcdma900AgcTxOnRiseDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3701)]
    [Attributes(9)]
   public sealed class Wcdma900AgcUpdateTxAgcTime : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3674)]
    [Attributes(9)]
   public sealed class Wcdma900BypassTimer : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4938)]
    [Attributes(9)]
   public sealed class Wcdma900C0C1Delay : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3731)]
    [Attributes(9)]
   public sealed class Wcdma900DchAgcUpdateTxAgcTime : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4198)]
    [Attributes(9)]
   public sealed class Wcdma900DrxModeSel : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3696)]
    [Attributes(9)]
   public sealed class Wcdma900EncBtf : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3693)]
    [Attributes(9)]
   public sealed class Wcdma900ExpHdetVsAgc : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5464)]
    [Attributes(9)]
   public sealed class Wcdma900ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3694)]
    [Attributes(9)]
   public sealed class Wcdma900HdetOff : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3695)]
    [Attributes(9)]
   public sealed class Wcdma900HdetSpn : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4745)]
    [Attributes(9)]
   public sealed class Wcdma900HsImLevel1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4743)]
    [Attributes(9)]
   public sealed class Wcdma900HsImLevel2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4744)]
    [Attributes(9)]
   public sealed class Wcdma900HsImLevel3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4746)]
    [Attributes(9)]
   public sealed class Wcdma900HsImLevel4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4741)]
    [Attributes(9)]
   public sealed class Wcdma900HsLnaRangeFall2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4740)]
    [Attributes(9)]
   public sealed class Wcdma900HsLnaRangeFall3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4739)]
    [Attributes(9)]
   public sealed class Wcdma900HsLnaRangeFall4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4742)]
    [Attributes(9)]
   public sealed class Wcdma900HsLnaRangeFall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4735)]
    [Attributes(9)]
   public sealed class Wcdma900HsLnaRangeRise2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4737)]
    [Attributes(9)]
   public sealed class Wcdma900HsLnaRangeRise3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4738)]
    [Attributes(9)]
   public sealed class Wcdma900HsLnaRangeRise4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4736)]
    [Attributes(9)]
   public sealed class Wcdma900HsLnaRangeRise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3747)]
    [Attributes(9)]
   public sealed class Wcdma900HsR1Fall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3746)]
    [Attributes(9)]
   public sealed class Wcdma900HsR1Rise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3749)]
    [Attributes(9)]
   public sealed class Wcdma900HsR2Fall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3748)]
    [Attributes(9)]
   public sealed class Wcdma900HsR2Rise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3751)]
    [Attributes(9)]
   public sealed class Wcdma900HsR3Fall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3750)]
    [Attributes(9)]
   public sealed class Wcdma900HsR3Rise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6051)]
    [Attributes(9)]
   public sealed class Wcdma900HsSwitchpointsShift : TwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4171)]
    [Attributes(9)]
   public sealed class Wcdma900Iaccum : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3663)]
    [Attributes(9)]
   public sealed class Wcdma900Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3664)]
    [Attributes(9)]
   public sealed class Wcdma900Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3665)]
    [Attributes(9)]
   public sealed class Wcdma900Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3657)]
    [Attributes(9)]
   public sealed class Wcdma900ImLevel2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3658)]
    [Attributes(9)]
   public sealed class Wcdma900ImLevel3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4420)]
    [Attributes(9)]
   public sealed class Wcdma900ImLevel4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3672)]
    [Attributes(9)]
   public sealed class Wcdma900ImLevel : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3661)]
    [Attributes(9)]
   public sealed class Wcdma900LnaOffsetVsFreq2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3662)]
    [Attributes(9)]
   public sealed class Wcdma900LnaOffsetVsFreq3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4421)]
    [Attributes(9)]
   public sealed class Wcdma900LnaOffsetVsFreq4 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3676)]
    [Attributes(9)]
   public sealed class Wcdma900LnaOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5101)]
    [Attributes(9)]
   public sealed class Wcdma900LnaPhaseCtl : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3655)]
    [Attributes(9)]
   public sealed class Wcdma900LnaRangeFall2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3656)]
    [Attributes(9)]
   public sealed class Wcdma900LnaRangeFall3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4422)]
    [Attributes(9)]
   public sealed class Wcdma900LnaRangeFall4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3671)]
    [Attributes(9)]
   public sealed class Wcdma900LnaRangeFall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3659)]
    [Attributes(9)]
   public sealed class Wcdma900LnaRangeOffset2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3660)]
    [Attributes(9)]
   public sealed class Wcdma900LnaRangeOffset3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4423)]
    [Attributes(9)]
   public sealed class Wcdma900LnaRangeOffset4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3675)]
    [Attributes(9)]
   public sealed class Wcdma900LnaRangeOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3653)]
    [Attributes(9)]
   public sealed class Wcdma900LnaRangeRise2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3654)]
    [Attributes(9)]
   public sealed class Wcdma900LnaRangeRise3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4424)]
    [Attributes(9)]
   public sealed class Wcdma900LnaRangeRise4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3670)]
    [Attributes(9)]
   public sealed class Wcdma900LnaRangeRise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3743)]
    [Attributes(9)]
   public sealed class Wcdma900MaxPwrBackoffVolt1 : FourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3744)]
    [Attributes(9)]
   public sealed class Wcdma900MaxPwrBackoffVolt2 : FourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3745)]
    [Attributes(9)]
   public sealed class Wcdma900MaxPwrBackoffVolt3 : FourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3742)]
    [Attributes(9)]
   public sealed class Wcdma900MaxPwrBackoffVoltages : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3668)]
    [Attributes(9)]
   public sealed class Wcdma900MaxTxPower : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3673)]
    [Attributes(9)]
   public sealed class Wcdma900NonbypassTimer : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3669)]
    [Attributes(9)]
   public sealed class Wcdma900OutOfServiceThresh : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3741)]
    [Attributes(9)]
   public sealed class Wcdma900PaCompensateDnWithDvs : ItemBase
    {
        [FieldCount(10)]
        public short[] Value
        {
            get;
        }
    }

    [Serializable]
    [NvItemId(3737)]
    [Attributes(9)]
   public sealed class Wcdma900PaCompensateDown : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3719)]
    [Attributes(9)]
   public sealed class Wcdma900PaCompensateDownR2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3721)]
    [Attributes(9)]
   public sealed class Wcdma900PaCompensateDownR3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3736)]
    [Attributes(9)]
   public sealed class Wcdma900PaCompensateUp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3718)]
    [Attributes(9)]
   public sealed class Wcdma900PaCompensateUpR2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3720)]
    [Attributes(9)]
   public sealed class Wcdma900PaCompensateUpR3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3740)]
    [Attributes(9)]
   public sealed class Wcdma900PaCompensateUpWithDvs : TenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3735)]
    [Attributes(9)]
   public sealed class Wcdma900PaGainDownTime : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3734)]
    [Attributes(9)]
   public sealed class Wcdma900PaGainUpTime : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3739)]
    [Attributes(9)]
   public sealed class Wcdma900PaRangeForDvs : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3730)]
    [Attributes(9)]
   public sealed class Wcdma900PaRangeMap : FourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3703)]
    [Attributes(9)]
   public sealed class Wcdma900PrachR1FallOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3702)]
    [Attributes(9)]
   public sealed class Wcdma900PrachR1RiseOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3727)]
    [Attributes(9)]
   public sealed class Wcdma900PrachR2FallOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3726)]
    [Attributes(9)]
   public sealed class Wcdma900PrachR2RiseOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3729)]
    [Attributes(9)]
   public sealed class Wcdma900PrachR3FallOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3728)]
    [Attributes(9)]
   public sealed class Wcdma900PrachR3RiseOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4172)]
    [Attributes(9)]
   public sealed class Wcdma900Qaccum : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3689)]
    [Attributes(9)]
   public sealed class Wcdma900R1Fall : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3688)]
    [Attributes(9)]
   public sealed class Wcdma900R1Rise : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3715)]
    [Attributes(9)]
   public sealed class Wcdma900R2Fall : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3714)]
    [Attributes(9)]
   public sealed class Wcdma900R2Rise : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3717)]
    [Attributes(9)]
   public sealed class Wcdma900R3Fall : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3716)]
    [Attributes(9)]
   public sealed class Wcdma900R3Rise : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5275)]
    [Attributes(9)]
   public sealed class Wcdma900Rel6TxAgcOffset : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5274)]
    [Attributes(9)]
   public sealed class Wcdma900Rel6TxBetaScalingComp : SevenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5276)]
    [Attributes(9)]
   public sealed class Wcdma900Rel6TxMprBackoff : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3678)]
    [Attributes(9)]
   public sealed class Wcdma900RxAgcMax : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3666)]
    [Attributes(9)]
   public sealed class Wcdma900RxAgcMin2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3667)]
    [Attributes(9)]
   public sealed class Wcdma900RxAgcMin3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3677)]
    [Attributes(9)]
   public sealed class Wcdma900RxAgcMin : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3705)]
    [Attributes(9)]
   public sealed class Wcdma900RxCalChan : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3738)]
    [Attributes(9)]
   public sealed class Wcdma900RxDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6435)]
    [Attributes(9)]
   public sealed class Wcdma900RxfIciICoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6440)]
    [Attributes(9)]
   public sealed class Wcdma900RxfIciICoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6441)]
    [Attributes(9)]
   public sealed class Wcdma900RxfIciICoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6442)]
    [Attributes(9)]
   public sealed class Wcdma900RxfIciICoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6436)]
    [Attributes(9)]
   public sealed class Wcdma900RxfIciICoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6437)]
    [Attributes(9)]
   public sealed class Wcdma900RxfIciICoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6438)]
    [Attributes(9)]
   public sealed class Wcdma900RxfIciICoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6439)]
    [Attributes(9)]
   public sealed class Wcdma900RxfIciICoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6451)]
    [Attributes(9)]
   public sealed class Wcdma900RxfIciIqTrunc : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6443)]
    [Attributes(9)]
   public sealed class Wcdma900RxfIciQCoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6448)]
    [Attributes(9)]
   public sealed class Wcdma900RxfIciQCoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6449)]
    [Attributes(9)]
   public sealed class Wcdma900RxfIciQCoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6450)]
    [Attributes(9)]
   public sealed class Wcdma900RxfIciQCoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6444)]
    [Attributes(9)]
   public sealed class Wcdma900RxfIciQCoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6445)]
    [Attributes(9)]
   public sealed class Wcdma900RxfIciQCoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6446)]
    [Attributes(9)]
   public sealed class Wcdma900RxfIciQCoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6447)]
    [Attributes(9)]
   public sealed class Wcdma900RxfIciQCoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6431)]
    [Attributes(9)]
   public sealed class Wcdma900RxfMisCompACoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6432)]
    [Attributes(9)]
   public sealed class Wcdma900RxfMisCompBCoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5049)]
    [Attributes(9)]
   public sealed class Wcdma900TimerHysterisis : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3704)]
    [Attributes(9)]
   public sealed class Wcdma900TxCalChan : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3682)]
    [Attributes(9)]
   public sealed class Wcdma900TxCompVsFreq0 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4990)]
    [Attributes(9)]
   public sealed class Wcdma900TxCompVsFreq0Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3683)]
    [Attributes(9)]
   public sealed class Wcdma900TxCompVsFreq1 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4991)]
    [Attributes(9)]
   public sealed class Wcdma900TxCompVsFreq1Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3708)]
    [Attributes(9)]
   public sealed class Wcdma900TxCompVsFreq2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4992)]
    [Attributes(9)]
   public sealed class Wcdma900TxCompVsFreq2Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3709)]
    [Attributes(9)]
   public sealed class Wcdma900TxCompVsFreq3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4993)]
    [Attributes(9)]
   public sealed class Wcdma900TxCompVsFreq3Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4994)]
    [Attributes(9)]
   public sealed class Wcdma900TxCompVsFreqSecPdmList : FourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3691)]
    [Attributes(9)]
   public sealed class Wcdma900TxLimVsFreq : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3690)]
    [Attributes(9)]
   public sealed class Wcdma900TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5055)]
    [Attributes(9)]
   public sealed class Wcdma900TxLinMaster0Enh : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3680)]
    [Attributes(9)]
   public sealed class Wcdma900TxLinMaster0 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3681)]
    [Attributes(9)]
   public sealed class Wcdma900TxLinMaster1 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3706)]
    [Attributes(9)]
   public sealed class Wcdma900TxLinMaster2 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3707)]
    [Attributes(9)]
   public sealed class Wcdma900TxLinMaster3 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3684)]
    [Attributes(9)]
   public sealed class Wcdma900TxLinVsTemp0 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3685)]
    [Attributes(9)]
   public sealed class Wcdma900TxLinVsTemp1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3710)]
    [Attributes(9)]
   public sealed class Wcdma900TxLinVsTemp2 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3711)]
    [Attributes(9)]
   public sealed class Wcdma900TxLinVsTemp3 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5061)]
    [Attributes(9)]
   public sealed class Wcdma900TxPdmLin0Enh : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3981)]
    [Attributes(9)]
   public sealed class Wcdma900TxPdmLin0 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3982)]
    [Attributes(9)]
   public sealed class Wcdma900TxPdmLin1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3983)]
    [Attributes(9)]
   public sealed class Wcdma900TxPdmLin2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3984)]
    [Attributes(9)]
   public sealed class Wcdma900TxPdmLin3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3722)]
    [Attributes(9)]
   public sealed class Wcdma900TxRotAnglePaState00 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3723)]
    [Attributes(9)]
   public sealed class Wcdma900TxRotAnglePaState01 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3724)]
    [Attributes(9)]
   public sealed class Wcdma900TxRotAnglePaState10 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3725)]
    [Attributes(9)]
   public sealed class Wcdma900TxRotAnglePaState11 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3686)]
    [Attributes(9)]
   public sealed class Wcdma900TxSlpVsTemp0 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3687)]
    [Attributes(9)]
   public sealed class Wcdma900TxSlpVsTemp1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3712)]
    [Attributes(9)]
   public sealed class Wcdma900TxSlpVsTemp2 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3713)]
    [Attributes(9)]
   public sealed class Wcdma900TxSlpVsTemp3 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3733)]
    [Attributes(9)]
   public sealed class Wcdma900UtranTxLimVsTempOffset : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3650)]
    [Attributes(9)]
   public sealed class Wcdma900VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3651)]
    [Attributes(9)]
   public sealed class Wcdma900VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3652)]
    [Attributes(9)]
   public sealed class Wcdma900VgaGainOffsetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(541)]
    [Attributes(9)]
   public sealed class WcdmaAdjFactor : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1197)]
    [Attributes(9)]
   public sealed class WcdmaAgcPaOnFallDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1196)]
    [Attributes(9)]
   public sealed class WcdmaAgcPaOnRiseDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(528)]
    [Attributes(9)]
   public sealed class WcdmaAgcPhaseOffset : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2952)]
    [Attributes(9)]
   public sealed class WcdmaAgcTxAdjPdmDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1199)]
    [Attributes(9)]
   public sealed class WcdmaAgcTxOnFallDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1198)]
    [Attributes(9)]
   public sealed class WcdmaAgcTxOnRiseDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1200)]
    [Attributes(9)]
   public sealed class WcdmaAgcUpdateTxAgcTime : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4037)]
    [Attributes(9)]
   public sealed class WcdmaBc4AdjFactor : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4043)]
    [Attributes(9)]
   public sealed class WcdmaBc4AgcPaOnFallDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4042)]
    [Attributes(9)]
   public sealed class WcdmaBc4AgcPaOnRiseDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4024)]
    [Attributes(9)]
   public sealed class WcdmaBc4AgcPhaseOffset : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4077)]
    [Attributes(9)]
   public sealed class WcdmaBc4AgcTxAdjPdmDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4045)]
    [Attributes(9)]
   public sealed class WcdmaBc4AgcTxOnFallDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4044)]
    [Attributes(9)]
   public sealed class WcdmaBc4AgcTxOnRiseDelay : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4046)]
    [Attributes(9)]
   public sealed class WcdmaBc4AgcUpdateTxAgcTime : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4019)]
    [Attributes(9)]
   public sealed class WcdmaBc4BypassTimer : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4937)]
    [Attributes(9)]
   public sealed class WcdmaBc4C0C1Delay : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4076)]
    [Attributes(9)]
   public sealed class WcdmaBc4DchAgcUpdateTxAgcTime : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4199)]
    [Attributes(9)]
   public sealed class WcdmaBc4DrxModeSel : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4041)]
    [Attributes(9)]
   public sealed class WcdmaBc4EncBtf : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(4038)]
    [Attributes(9)]
   public sealed class WcdmaBc4ExpHdetVsAgc : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5462)]
    [Attributes(9)]
   public sealed class WcdmaBc4ExpHdetVsAgcV2 : SixteenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4039)]
    [Attributes(9)]
   public sealed class WcdmaBc4HdetOff : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4040)]
    [Attributes(9)]
   public sealed class WcdmaBc4HdetSpn : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4725)]
    [Attributes(9)]
   public sealed class WcdmaBc4HsImLevel2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4724)]
    [Attributes(9)]
   public sealed class WcdmaBc4HsImLevel3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4723)]
    [Attributes(9)]
   public sealed class WcdmaBc4HsImLevel4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4726)]
    [Attributes(9)]
   public sealed class WcdmaBc4HsImLevel : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4731)]
    [Attributes(9)]
   public sealed class WcdmaBc4HsLnaRangeFall2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4732)]
    [Attributes(9)]
   public sealed class WcdmaBc4HsLnaRangeFall3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4733)]
    [Attributes(9)]
   public sealed class WcdmaBc4HsLnaRangeFall4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4734)]
    [Attributes(9)]
   public sealed class WcdmaBc4HsLnaRangeFall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4729)]
    [Attributes(9)]
   public sealed class WcdmaBc4HsLnaRangeRise2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4728)]
    [Attributes(9)]
   public sealed class WcdmaBc4HsLnaRangeRise3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4727)]
    [Attributes(9)]
   public sealed class WcdmaBc4HsLnaRangeRise4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4730)]
    [Attributes(9)]
   public sealed class WcdmaBc4HsLnaRangeRise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4092)]
    [Attributes(9)]
   public sealed class WcdmaBc4HsR1Fall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4091)]
    [Attributes(9)]
   public sealed class WcdmaBc4HsR1Rise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4094)]
    [Attributes(9)]
   public sealed class WcdmaBc4HsR2Fall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4093)]
    [Attributes(9)]
   public sealed class WcdmaBc4HsR2Rise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4096)]
    [Attributes(9)]
   public sealed class WcdmaBc4HsR3Fall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4095)]
    [Attributes(9)]
   public sealed class WcdmaBc4HsR3Rise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(6053)]
    [Attributes(9)]
   public sealed class WcdmaBc4HsSwitchpointsShift : TwoSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4167)]
    [Attributes(9)]
   public sealed class WcdmaBc4Iaccum : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4008)]
    [Attributes(9)]
   public sealed class WcdmaBc4Im2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4009)]
    [Attributes(9)]
   public sealed class WcdmaBc4Im2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4010)]
    [Attributes(9)]
   public sealed class WcdmaBc4Im2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4002)]
    [Attributes(9)]
   public sealed class WcdmaBc4ImLevel2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4003)]
    [Attributes(9)]
   public sealed class WcdmaBc4ImLevel3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4425)]
    [Attributes(9)]
   public sealed class WcdmaBc4ImLevel4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4017)]
    [Attributes(9)]
   public sealed class WcdmaBc4ImLevel : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4006)]
    [Attributes(9)]
   public sealed class WcdmaBc4LnaOffsetVsFreq2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4007)]
    [Attributes(9)]
   public sealed class WcdmaBc4LnaOffsetVsFreq3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4426)]
    [Attributes(9)]
   public sealed class WcdmaBc4LnaOffsetVsFreq4 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4021)]
    [Attributes(9)]
   public sealed class WcdmaBc4LnaOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5099)]
    [Attributes(9)]
   public sealed class WcdmaBc4LnaPhaseCtl : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4000)]
    [Attributes(9)]
   public sealed class WcdmaBc4LnaRangeFall2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4001)]
    [Attributes(9)]
   public sealed class WcdmaBc4LnaRangeFall3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4427)]
    [Attributes(9)]
   public sealed class WcdmaBc4LnaRangeFall4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4016)]
    [Attributes(9)]
   public sealed class WcdmaBc4LnaRangeFall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4004)]
    [Attributes(9)]
   public sealed class WcdmaBc4LnaRangeOffset2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4005)]
    [Attributes(9)]
   public sealed class WcdmaBc4LnaRangeOffset3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4428)]
    [Attributes(9)]
   public sealed class WcdmaBc4LnaRangeOffset4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4020)]
    [Attributes(9)]
   public sealed class WcdmaBc4LnaRangeOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3998)]
    [Attributes(9)]
   public sealed class WcdmaBc4LnaRangeRise2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3999)]
    [Attributes(9)]
   public sealed class WcdmaBc4LnaRangeRise3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4429)]
    [Attributes(9)]
   public sealed class WcdmaBc4LnaRangeRise4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4015)]
    [Attributes(9)]
   public sealed class WcdmaBc4LnaRangeRise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4088)]
    [Attributes(9)]
   public sealed class WcdmaBc4MaxPwrBackoffVolt1 : FourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4089)]
    [Attributes(9)]
   public sealed class WcdmaBc4MaxPwrBackoffVolt2 : FourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4090)]
    [Attributes(9)]
   public sealed class WcdmaBc4MaxPwrBackoffVolt3 : FourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4087)]
    [Attributes(9)]
   public sealed class WcdmaBc4MaxPwrBackoffVoltages : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4013)]
    [Attributes(9)]
   public sealed class WcdmaBc4MaxTxPower : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4018)]
    [Attributes(9)]
   public sealed class WcdmaBc4NonbypassTimer : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4014)]
    [Attributes(9)]
   public sealed class WcdmaBc4OutOfServiceThresh : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4086)]
    [Attributes(9)]
   public sealed class WcdmaBc4PaCompensateDnWithDvs : TenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4082)]
    [Attributes(9)]
   public sealed class WcdmaBc4PaCompensateDown : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4064)]
    [Attributes(9)]
   public sealed class WcdmaBc4PaCompensateDownR2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4066)]
    [Attributes(9)]
   public sealed class WcdmaBc4PaCompensateDownR3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4081)]
    [Attributes(9)]
   public sealed class WcdmaBc4PaCompensateUp : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4063)]
    [Attributes(9)]
   public sealed class WcdmaBc4PaCompensateUpR2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4065)]
    [Attributes(9)]
   public sealed class WcdmaBc4PaCompensateUpR3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4085)]
    [Attributes(9)]
   public sealed class WcdmaBc4PaCompensateUpWithDvs : TenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4080)]
    [Attributes(9)]
   public sealed class WcdmaBc4PaGainDownTime : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4079)]
    [Attributes(9)]
   public sealed class WcdmaBc4PaGainUpTime : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4084)]
    [Attributes(9)]
   public sealed class WcdmaBc4PaRangeForDvs : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4075)]
    [Attributes(9)]
   public sealed class WcdmaBc4PaRangeMap : FourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4048)]
    [Attributes(9)]
   public sealed class WcdmaBc4PrachR1FallOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4047)]
    [Attributes(9)]
   public sealed class WcdmaBc4PrachR1RiseOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4072)]
    [Attributes(9)]
   public sealed class WcdmaBc4PrachR2FallOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4071)]
    [Attributes(9)]
   public sealed class WcdmaBc4PrachR2RiseOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4074)]
    [Attributes(9)]
   public sealed class WcdmaBc4PrachR3FallOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4073)]
    [Attributes(9)]
   public sealed class WcdmaBc4PrachR3RiseOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4168)]
    [Attributes(9)]
   public sealed class WcdmaBc4Qaccum : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4034)]
    [Attributes(9)]
   public sealed class WcdmaBc4R1Fall : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4033)]
    [Attributes(9)]
   public sealed class WcdmaBc4R1Rise : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4060)]
    [Attributes(9)]
   public sealed class WcdmaBc4R2Fall : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4059)]
    [Attributes(9)]
   public sealed class WcdmaBc4R2Rise : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4062)]
    [Attributes(9)]
   public sealed class WcdmaBc4R3Fall : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4061)]
    [Attributes(9)]
   public sealed class WcdmaBc4R3Rise : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4951)]
    [Attributes(9)]
   public sealed class WcdmaBc4Rel6TxAgcOffset : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4950)]
    [Attributes(9)]
   public sealed class WcdmaBc4Rel6TxBetaScalingComp : SevenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4952)]
    [Attributes(9)]
   public sealed class WcdmaBc4Rel6TxMprBackoff : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4023)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxAgcMax : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4011)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxAgcMin2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4012)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxAgcMin3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4022)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxAgcMin : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4050)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxCalChan : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4083)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5980)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxfIciICoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5985)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxfIciICoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5986)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxfIciICoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5987)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxfIciICoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5981)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxfIciICoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5982)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxfIciICoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5983)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxfIciICoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5984)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxfIciICoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(6012)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxfIciIqTrunc : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5988)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxfIciQCoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5993)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxfIciQCoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5994)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxfIciQCoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5995)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxfIciQCoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5989)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxfIciQCoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5990)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxfIciQCoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5991)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxfIciQCoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5992)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxfIciQCoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5904)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxfMisCompACoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5905)]
    [Attributes(9)]
   public sealed class WcdmaBc4RxfMisCompBCoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5050)]
    [Attributes(9)]
   public sealed class WcdmaBc4TimerHysterisis : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4049)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxCalChan : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4027)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxCompVsFreq0 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4985)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxCompVsFreq0Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4028)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxCompVsFreq1 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4986)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxCompVsFreq1Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4053)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxCompVsFreq2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4987)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxCompVsFreq2Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4054)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxCompVsFreq3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4988)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxCompVsFreq3Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4989)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxCompVsFreqSecPdmList : FourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4036)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxLimVsFreq : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4035)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5056)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxLinMaster0Enh : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4025)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxLinMaster0 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4026)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxLinMaster1 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4051)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxLinMaster2 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4052)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxLinMaster3 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4029)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxLinVsTemp0 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4030)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxLinVsTemp1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4055)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxLinVsTemp2 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4056)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxLinVsTemp3 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5062)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxPdmLin0Enh : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4112)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxPdmLin0 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4113)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxPdmLin1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4114)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxPdmLin2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4115)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxPdmLin3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4067)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxRotAnglePaState00 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4068)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxRotAnglePaState01 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4069)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxRotAnglePaState10 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4070)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxRotAnglePaState11 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4031)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxSlpVsTemp0 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4032)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxSlpVsTemp1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4057)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxSlpVsTemp2 : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4058)]
    [Attributes(9)]
   public sealed class WcdmaBc4TxSlpVsTemp3 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4078)]
    [Attributes(9)]
   public sealed class WcdmaBc4UtranTxLimVsTempOffset : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3995)]
    [Attributes(9)]
   public sealed class WcdmaBc4VgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3996)]
    [Attributes(9)]
   public sealed class WcdmaBc4VgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3997)]
    [Attributes(9)]
   public sealed class WcdmaBc4VgaGainOffsetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(523)]
    [Attributes(9)]
   public sealed class WcdmaBypassTimer : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2330)]
    [Attributes(9)]
   public sealed class WcdmaC0TxCompVsFreq0 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2331)]
    [Attributes(9)]
   public sealed class WcdmaC0TxCompVsFreq1 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3341)]
    [Attributes(9)]
   public sealed class WcdmaC0TxLimVsFreq : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2332)]
    [Attributes(9)]
   public sealed class WcdmaC1TxCompVsFreq0 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2333)]
    [Attributes(9)]
   public sealed class WcdmaC1TxCompVsFreq1 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(7191)]
    [Attributes(9)]
   public sealed class WcdmaDc1LnaRangeFall2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7193)]
    [Attributes(9)]
   public sealed class WcdmaDc1LnaRangeFall3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7195)]
    [Attributes(9)]
   public sealed class WcdmaDc1LnaRangeFall4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7197)]
    [Attributes(9)]
   public sealed class WcdmaDc1LnaRangeFall5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7189)]
    [Attributes(9)]
   public sealed class WcdmaDc1LnaRangeFallCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7169)]
    [Attributes(9)]
   public sealed class WcdmaDc1LnaRangeOffset2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7171)]
    [Attributes(9)]
   public sealed class WcdmaDc1LnaRangeOffset3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7173)]
    [Attributes(9)]
   public sealed class WcdmaDc1LnaRangeOffset4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7175)]
    [Attributes(9)]
   public sealed class WcdmaDc1LnaRangeOffset5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7167)]
    [Attributes(9)]
   public sealed class WcdmaDc1LnaRangeOffsetCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7181)]
    [Attributes(9)]
   public sealed class WcdmaDc1LnaRangeRise2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7183)]
    [Attributes(9)]
   public sealed class WcdmaDc1LnaRangeRise3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7185)]
    [Attributes(9)]
   public sealed class WcdmaDc1LnaRangeRise4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7187)]
    [Attributes(9)]
   public sealed class WcdmaDc1LnaRangeRise5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7179)]
    [Attributes(9)]
   public sealed class WcdmaDc1LnaRangeRiseCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7199)]
    [Attributes(9)]
   public sealed class WcdmaDc1RxfIciCalDataCar0 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7201)]
    [Attributes(9)]
   public sealed class WcdmaDc1RxfIciCalDataCar1 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7177)]
    [Attributes(9)]
   public sealed class WcdmaDc1VgaGainOffsetCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7192)]
    [Attributes(9)]
   public sealed class WcdmaDc2LnaRangeFall2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7194)]
    [Attributes(9)]
   public sealed class WcdmaDc2LnaRangeFall3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7196)]
    [Attributes(9)]
   public sealed class WcdmaDc2LnaRangeFall4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7198)]
    [Attributes(9)]
   public sealed class WcdmaDc2LnaRangeFall5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7190)]
    [Attributes(9)]
   public sealed class WcdmaDc2LnaRangeFallCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7170)]
    [Attributes(9)]
   public sealed class WcdmaDc2LnaRangeOffset2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7172)]
    [Attributes(9)]
   public sealed class WcdmaDc2LnaRangeOffset3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7174)]
    [Attributes(9)]
   public sealed class WcdmaDc2LnaRangeOffset4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7176)]
    [Attributes(9)]
   public sealed class WcdmaDc2LnaRangeOffset5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7168)]
    [Attributes(9)]
   public sealed class WcdmaDc2LnaRangeOffsetCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7182)]
    [Attributes(9)]
   public sealed class WcdmaDc2LnaRangeRise2Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7184)]
    [Attributes(9)]
   public sealed class WcdmaDc2LnaRangeRise3Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7186)]
    [Attributes(9)]
   public sealed class WcdmaDc2LnaRangeRise4Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7188)]
    [Attributes(9)]
   public sealed class WcdmaDc2LnaRangeRise5Car1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7180)]
    [Attributes(9)]
   public sealed class WcdmaDc2LnaRangeRiseCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(7200)]
    [Attributes(9)]
   public sealed class WcdmaDc2RxfIciCalDataCar0 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7202)]
    [Attributes(9)]
   public sealed class WcdmaDc2RxfIciCalDataCar1 : SeventeenUInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(7178)]
    [Attributes(9)]
   public sealed class WcdmaDc2VgaGainOffsetCar1 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2951)]
    [Attributes(9)]
   public sealed class WcdmaDchAgcUpdateTxAgcTime : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(545)]
    [Attributes(9)]
   public sealed class WcdmaEncBtf : Int32ItemBase
    {
    }

    [Serializable]
    [NvItemId(3852)]
    [Attributes(9)]
   public sealed class WcdmaEqualizerControl : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(542)]
    [Attributes(9)]
   public sealed class WcdmaExpHdetVsAgc : SixteenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(543)]
    [Attributes(9)]
   public sealed class WcdmaHdetOff : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(544)]
    [Attributes(9)]
   public sealed class WcdmaHdetSpn : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4783)]
    [Attributes(9)]
   public sealed class WcdmaHsImLevel2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4784)]
    [Attributes(9)]
   public sealed class WcdmaHsImLevel3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4785)]
    [Attributes(9)]
   public sealed class WcdmaHsImLevel4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4786)]
    [Attributes(9)]
   public sealed class WcdmaHsImLevel : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4789)]
    [Attributes(9)]
   public sealed class WcdmaHsLnaRangeFall2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4788)]
    [Attributes(9)]
   public sealed class WcdmaHsLnaRangeFall3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4787)]
    [Attributes(9)]
   public sealed class WcdmaHsLnaRangeFall4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4790)]
    [Attributes(9)]
   public sealed class WcdmaHsLnaRangeFall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4793)]
    [Attributes(9)]
   public sealed class WcdmaHsLnaRangeRise2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4792)]
    [Attributes(9)]
   public sealed class WcdmaHsLnaRangeRise3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4791)]
    [Attributes(9)]
   public sealed class WcdmaHsLnaRangeRise4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4794)]
    [Attributes(9)]
   public sealed class WcdmaHsLnaRangeRise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2725)]
    [Attributes(9)]
   public sealed class WcdmaHsR1Fall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2724)]
    [Attributes(9)]
   public sealed class WcdmaHsR1Rise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2727)]
    [Attributes(9)]
   public sealed class WcdmaHsR2Fall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2726)]
    [Attributes(9)]
   public sealed class WcdmaHsR2Rise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2729)]
    [Attributes(9)]
   public sealed class WcdmaHsR3Fall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2728)]
    [Attributes(9)]
   public sealed class WcdmaHsR3Rise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4210)]
    [Attributes(9)]
   public sealed class WcdmaHsupaCategory : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5090)]
    [Attributes(9)]
   public sealed class WcdmaHsupaCmController : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4161)]
    [Attributes(9)]
   public sealed class WcdmaIaccum : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(869)]
    [Attributes(9)]
   public sealed class WcdmaIm2IValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(870)]
    [Attributes(9)]
   public sealed class WcdmaIm2QValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(871)]
    [Attributes(9)]
   public sealed class WcdmaIm2TransconductorValue : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(863)]
    [Attributes(9)]
   public sealed class WcdmaImLevel2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(864)]
    [Attributes(9)]
   public sealed class WcdmaImLevel3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4400)]
    [Attributes(9)]
   public sealed class WcdmaImLevel4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(521)]
    [Attributes(9)]
   public sealed class WcdmaImLevel : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(867)]
    [Attributes(9)]
   public sealed class WcdmaLnaOffsetVsFreq2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(868)]
    [Attributes(9)]
   public sealed class WcdmaLnaOffsetVsFreq3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4401)]
    [Attributes(9)]
   public sealed class WcdmaLnaOffsetVsFreq4 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(525)]
    [Attributes(9)]
   public sealed class WcdmaLnaOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4956)]
    [Attributes(9)]
   public sealed class WcdmaLnaPhaseCtl : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(861)]
    [Attributes(9)]
   public sealed class WcdmaLnaRangeFall2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(862)]
    [Attributes(9)]
   public sealed class WcdmaLnaRangeFall3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4402)]
    [Attributes(9)]
   public sealed class WcdmaLnaRangeFall4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(520)]
    [Attributes(9)]
   public sealed class WcdmaLnaRangeFall : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(865)]
    [Attributes(9)]
   public sealed class WcdmaLnaRangeOffset2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(866)]
    [Attributes(9)]
   public sealed class WcdmaLnaRangeOffset3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4403)]
    [Attributes(9)]
   public sealed class WcdmaLnaRangeOffset4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(524)]
    [Attributes(9)]
   public sealed class WcdmaLnaRangeOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(518)]
    [Attributes(9)]
   public sealed class WcdmaLnaRangePol : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(859)]
    [Attributes(9)]
   public sealed class WcdmaLnaRangeRise2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(860)]
    [Attributes(9)]
   public sealed class WcdmaLnaRangeRise3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4404)]
    [Attributes(9)]
   public sealed class WcdmaLnaRangeRise4 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(519)]
    [Attributes(9)]
   public sealed class WcdmaLnaRangeRise : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2713)]
    [Attributes(9)]
   public sealed class WcdmaMaxPwrBackoffVolt1 : FourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2714)]
    [Attributes(9)]
   public sealed class WcdmaMaxPwrBackoffVolt2 : FourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2715)]
    [Attributes(9)]
   public sealed class WcdmaMaxPwrBackoffVolt3 : FourInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2712)]
    [Attributes(9)]
   public sealed class WcdmaMaxPwrBackoffVoltages : ThreeByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3014)]
    [Attributes(9)]
   public sealed class WcdmaMaxTxPowerDchPc4 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(876)]
    [Attributes(9)]
   public sealed class WcdmaMaxTxPower : SByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3440)]
    [Attributes(9)]
   public sealed class WcdmaMinTxPower : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(522)]
    [Attributes(9)]
   public sealed class WcdmaNonbypassTimer : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2705)]
    [Attributes(9)]
   public sealed class WcdmaPaCompensateDnWithDvs : TenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2704)]
    [Attributes(9)]
   public sealed class WcdmaPaCompensateUpWithDvs : TenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1348)]
    [Attributes(9)]
   public sealed class WcdmaPaGainDownTime : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1347)]
    [Attributes(9)]
   public sealed class WcdmaPaGainUpTime : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2703)]
    [Attributes(9)]
   public sealed class WcdmaPaRangeForDvs : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2029)]
    [Attributes(9)]
   public sealed class WcdmaPaRangeMap : FourSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1910)]
    [Attributes(9)]
   public sealed class WcdmaPrachR1FallOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1908)]
    [Attributes(9)]
   public sealed class WcdmaPrachR1RiseOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2026)]
    [Attributes(9)]
   public sealed class WcdmaPrachR2FallOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2025)]
    [Attributes(9)]
   public sealed class WcdmaPrachR2RiseOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2028)]
    [Attributes(9)]
   public sealed class WcdmaPrachR3FallOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2027)]
    [Attributes(9)]
   public sealed class WcdmaPrachR3RiseOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4162)]
    [Attributes(9)]
   public sealed class WcdmaQaccum : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(538)]
    [Attributes(9)]
   public sealed class WcdmaR1Fall : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(537)]
    [Attributes(9)]
   public sealed class WcdmaR1Rise : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2018)]
    [Attributes(9)]
   public sealed class WcdmaR2Fall : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2017)]
    [Attributes(9)]
   public sealed class WcdmaR2Rise : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2020)]
    [Attributes(9)]
   public sealed class WcdmaR3Fall : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2019)]
    [Attributes(9)]
   public sealed class WcdmaR3Rise : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4942)]
    [Attributes(9)]
   public sealed class WcdmaRel6TxAgcOffset : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4941)]
    [Attributes(9)]
   public sealed class WcdmaRel6TxBetaScalingComp : SevenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4943)]
    [Attributes(9)]
   public sealed class WcdmaRel6TxMprBackoff : SevenByteItemBase
    {
    }

    [Serializable]
    [NvItemId(6756)]
    [Attributes(9)]
   public sealed class WcdmaRel7PaMprBackoff : SixUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(4173)]
    [Attributes(9)]
   public sealed class WcdmaRrcPdcpDisabled : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3649)]
    [Attributes(9)]
   public sealed class WcdmaRrcVersion : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(527)]
    [Attributes(9)]
   public sealed class WcdmaRxAgcMax : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(872)]
    [Attributes(9)]
   public sealed class WcdmaRxAgcMin2 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(873)]
    [Attributes(9)]
   public sealed class WcdmaRxAgcMin3 : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(526)]
    [Attributes(9)]
   public sealed class WcdmaRxAgcMin : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1972)]
    [Attributes(9)]
   public sealed class WcdmaRxCalChan : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(515)]
    [Attributes(9)]
   public sealed class WcdmaRxCompVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1985)]
    [Attributes(9)]
   public sealed class WcdmaRxDelay : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3851)]
    [Attributes(9)]
   public sealed class WcdmaRxDiversityControl : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5912)]
    [Attributes(9)]
   public sealed class WcdmaRxfIciICoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5917)]
    [Attributes(9)]
   public sealed class WcdmaRxfIciICoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5918)]
    [Attributes(9)]
   public sealed class WcdmaRxfIciICoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5919)]
    [Attributes(9)]
   public sealed class WcdmaRxfIciICoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5913)]
    [Attributes(9)]
   public sealed class WcdmaRxfIciICoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5914)]
    [Attributes(9)]
   public sealed class WcdmaRxfIciICoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5915)]
    [Attributes(9)]
   public sealed class WcdmaRxfIciICoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5916)]
    [Attributes(9)]
   public sealed class WcdmaRxfIciICoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5944)]
    [Attributes(9)]
   public sealed class WcdmaRxfIciIqTrunc : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5920)]
    [Attributes(9)]
   public sealed class WcdmaRxfIciQCoef01 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5925)]
    [Attributes(9)]
   public sealed class WcdmaRxfIciQCoef1011 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5926)]
    [Attributes(9)]
   public sealed class WcdmaRxfIciQCoef1213 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5927)]
    [Attributes(9)]
   public sealed class WcdmaRxfIciQCoef1415 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5921)]
    [Attributes(9)]
   public sealed class WcdmaRxfIciQCoef23 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5922)]
    [Attributes(9)]
   public sealed class WcdmaRxfIciQCoef45 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5923)]
    [Attributes(9)]
   public sealed class WcdmaRxfIciQCoef67 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5924)]
    [Attributes(9)]
   public sealed class WcdmaRxfIciQCoef89 : UInt32ItemBase
    {
    }

    [Serializable]
    [NvItemId(5896)]
    [Attributes(9)]
   public sealed class WcdmaRxfMisCompACoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(5897)]
    [Attributes(9)]
   public sealed class WcdmaRxfMisCompBCoeff : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(514)]
    [Attributes(9)]
   public sealed class WcdmaRxLin : SeventeenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(516)]
    [Attributes(9)]
   public sealed class WcdmaRxLinVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(517)]
    [Attributes(9)]
   public sealed class WcdmaRxSlpVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(875)]
    [Attributes(9)]
   public sealed class WcdmaTherm : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(1971)]
    [Attributes(9)]
   public sealed class WcdmaTxCalChan : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(531)]
    [Attributes(9)]
   public sealed class WcdmaTxCompVsFreq0 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4965)]
    [Attributes(9)]
   public sealed class WcdmaTxCompVsFreq0Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(532)]
    [Attributes(9)]
   public sealed class WcdmaTxCompVsFreq1 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4966)]
    [Attributes(9)]
   public sealed class WcdmaTxCompVsFreq1Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2011)]
    [Attributes(9)]
   public sealed class WcdmaTxCompVsFreq2 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4967)]
    [Attributes(9)]
   public sealed class WcdmaTxCompVsFreq2Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2012)]
    [Attributes(9)]
   public sealed class WcdmaTxCompVsFreq3 : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4968)]
    [Attributes(9)]
   public sealed class WcdmaTxCompVsFreq3Secondary : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4969)]
    [Attributes(9)]
   public sealed class WcdmaTxCompVsFreqSecPdmList : FourUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(540)]
    [Attributes(9)]
   public sealed class WcdmaTxLimVsFreq : SixteenInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(539)]
    [Attributes(9)]
   public sealed class WcdmaTxLimVsTemp : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3512)]
    [Attributes(9)]
   public sealed class WcdmaTxLimVsTempVoiceCallActive : EightByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2334)]
    [Attributes(9)]
   public sealed class WcdmaTxLimVsVoltOffset : ItemBase
    {
        [FieldCount(3)]
        public sbyte[] Value { get; set; }
    }

    [Serializable]
    [NvItemId(529)]
    [Attributes(9)]
   public sealed class WcdmaTxLinMaster0 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(530)]
    [Attributes(9)]
   public sealed class WcdmaTxLinMaster1 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2009)]
    [Attributes(9)]
   public sealed class WcdmaTxLinMaster2 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(2010)]
    [Attributes(9)]
   public sealed class WcdmaTxLinMaster3 : ThirtySevenUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(533)]
    [Attributes(9)]
   public sealed class WcdmaTxLinVsTemp0 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(534)]
    [Attributes(9)]
   public sealed class WcdmaTxLinVsTemp1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2013)]
    [Attributes(9)]
   public sealed class WcdmaTxLinVsTemp2 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2014)]
    [Attributes(9)]
   public sealed class WcdmaTxLinVsTemp3 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3969)]
    [Attributes(9)]
   public sealed class WcdmaTxPdmLin0 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3970)]
    [Attributes(9)]
   public sealed class WcdmaTxPdmLin1 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3971)]
    [Attributes(9)]
   public sealed class WcdmaTxPdmLin2 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(3972)]
    [Attributes(9)]
   public sealed class WcdmaTxPdmLin3 : ThirtyTwoUInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1795)]
    [Attributes(9)]
   public sealed class WcdmaTxRotAnglePaState00 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1796)]
    [Attributes(9)]
   public sealed class WcdmaTxRotAnglePaState01 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1797)]
    [Attributes(9)]
   public sealed class WcdmaTxRotAnglePaState10 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(1798)]
    [Attributes(9)]
   public sealed class WcdmaTxRotAnglePaState11 : UInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(535)]
    [Attributes(9)]
   public sealed class WcdmaTxSlpVsTemp0 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(536)]
    [Attributes(9)]
   public sealed class WcdmaTxSlpVsTemp1 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2015)]
    [Attributes(9)]
   public sealed class WcdmaTxSlpVsTemp2 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2016)]
    [Attributes(9)]
   public sealed class WcdmaTxSlpVsTemp3 : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(2980)]
    [Attributes(9)]
   public sealed class WcdmaUtranTxLimVsTempOffset : EightInt16ItemBase
    {
    }

    [Serializable]
    [NvItemId(874)]
    [Attributes(9)]
   public sealed class WcdmaVbatt : TwoByteItemBase
    {
    }

    [Serializable]
    [NvItemId(856)]
    [Attributes(9)]
   public sealed class WcdmaVgaGainOffset : Int16ItemBase
    {
    }

    [Serializable]
    [NvItemId(857)]
    [Attributes(9)]
   public sealed class WcdmaVgaGainOffsetVsFreq : SixteenSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(858)]
    [Attributes(9)]
   public sealed class WcdmaVgaGainOffsetVsTemp : EightSByteItemBase
    {
    }

    [Serializable]
    [NvItemId(3363)]
    [Attributes(9)]
   public sealed class WlanEnablePowerSaveMode : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4122)]
    [Attributes(9)]
   public sealed class WlanQosMode : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(5824)]
    [Attributes(9)]
   public sealed class WwanAccessOverWifiPreferred : ByteItemBase
    {
    }

    [Serializable]
    [NvItemId(4954)]
    [Attributes(9)]
   public sealed class XoFactoryCalibration : ItemBase
    {
        public int C3 { get; set; }


        public int C2 { get; set; }


        public int C1 { get; set; }


        public int C0 { get; set; }


        public int T0 { get; set; }


        public int T0p { get; set; }


        public int P { get; set; }


        public ushort FtQualInd { get; set; }


        public byte XoTrim { get; set; }
    }

    [Serializable]
    [NvItemId(4953)]
    [Attributes(9)]
   public sealed class XoFieldCalibration : ItemBase
    {
        public int C3 { get; set; }


        public int C2 { get; set; }


        public int C1 { get; set; }


        public int C0 { get; set; }


        public int T0 { get; set; }


        public int T0p { get; set; }


        public int P { get; set; }


        public long Timestamp { get; set; }


        public ushort FtQualInd { get; set; }


        public byte XoTrim { get; set; }


        public ushort FtSampleCount { get; set; }


        public ushort State { get; set; }
    }

    [Serializable]
    [NvItemId(4212)]
    [Attributes(9)]
   public sealed class XoTrimValues : ItemBase
    {
        public byte Current { get; set; }


        public byte Table { get; set; }
    }
}