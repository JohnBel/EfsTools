using System;
using BinarySerialization;
using Newtonsoft.Json;
using EfsTools.Items.Base;
using EfsTools.Attributes;

namespace EfsTools.Items.Data
{
    [Serializable]
    public sealed class EptDpdStruct : ItemBase
    {
        [FieldOffset(0)]
        [FieldCount(4)]
        public int[] Am
        {
            get; set;
        }

        [FieldOffset(1)]
        [FieldCount(3)]
        public int[] Pm
        {
            get; set;
        }

        [FieldOffset(2)]
        [FieldCount(3)]
        public byte[] PmShift
        {
            get; set;
        }

        [FieldOffset(3)]
        public sbyte Status { get; set; }
    }



    [Serializable]
    public sealed class GsmEnhtempcompPclType : SixteenInt16ItemBase
    {
    }

    [IgnoreItem]
    [Serializable]
    public sealed class GsmEnhtempcompTempType : ItemBase
    {
        /*
        public GsmEnhtempcompPclType[] TempBin { get; set; }
        */
    }

    [Serializable]
    public sealed class GsmRxFreqCompDataType : SixteenInt16ItemBase
    {
    }

    [Serializable]
    public sealed class GsmRxLnaSwptType : ItemBase
    {
        public sbyte MaxGainrange1 { get; set; }


        public sbyte MinGainrange2 { get; set; }


        public sbyte MaxGainrange2 { get; set; }


        public sbyte MinGainrange3 { get; set; }


        public sbyte MaxGainrange3 { get; set; }


        public sbyte MinGainrange4 { get; set; }


        public sbyte MaxGainrange4 { get; set; }


        public sbyte MinGainrange5 { get; set; }
    }

    [Serializable]
    public sealed class GsmTxEnhAptDataType : ItemBase
    {
        public byte PclThresholdVal { get; set; }


        public ushort VbattThresholdLowPwr { get; set; }


        public ushort VbattThresholdHighPwr { get; set; }
    }

    [Serializable]
    public sealed class GsmTxGtrThreshDataType : ItemBase
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short AdvTime { get; set; }
    }

    [Serializable]
    public sealed class GsmTxLinearTxGainParamDataType : ItemBase
    {
        public ushort GsmLinearTxGainVal { get; set; }


        public ushort EdgeLinearTxGainVal { get; set; }

        [FieldCount(16)]
        public byte[] CharpredistEnvGain
        {
            get;
        }
    }

    [Serializable]
    public sealed class GsmTxPaSwptDataType : ItemBase
    {
        public ushort PaR1ToR2 { get; set; }


        public ushort PaR2ToR3 { get; set; }


        public ushort PaR3ToR4 { get; set; }


        public ushort PaR2ToR4 { get; set; }


        public ushort EdgePaLoToMid { get; set; }


        public ushort EdgePaMidToHi { get; set; }


        public ushort PaPredistSwpt1 { get; set; }


        public ushort PaPredistSwpt2 { get; set; }
    }

    [Serializable]
    public sealed class GsmTxPolarRampProfileDataType : ItemBase
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

    [Serializable]
    public sealed class GsmTxSarBackoffDataType : ItemBase
    {
        public short SarGmsk { get; set; }


        public short Sar8psk { get; set; }
    }

    [Serializable]
    public sealed class GsmTxSmpsPdmDataType : ItemBase
    {
        [FieldCount(6)]
        public ushort[] CalSmpsPdmTbl
        {
            get;
        }

        [FieldCount(16)]
        public ushort[] GsmSmpsPdmTbl
        {
            get;
        }

        [FieldCount(16)]
        public ushort[] EdgeSmpsPdmTbl
        {
            get;
        }
    }

    [Serializable]
    public sealed class GsmTxTempCompDataType : ItemBase
    {
        [FieldCount(16)]
        public short[] TempCompPclPwrScaling
        {
            get;
        }

        [FieldCount(16)]
        public ushort[] HotTempCompPclPwrOffsetGsmk
        {
            get;
        }

        [FieldCount(16)]
        public ushort[] ColdTempCompPclPwrOffsetGsmk
        {
            get;
        }

        [FieldCount(16)]
        public ushort[] HotTempCompPclPwrOffset8psk
        {
            get;
        }

        [FieldCount(16)]
        public ushort[] ColdTempCompPclPwrOffset8psk
        {
            get;
        }
    }

    [Serializable]
    public sealed class GsmTxTimingDataType : ItemBase
    {
        public short TxBurstOffsetAdj { get; set; }


        public short PaEnStartOffsetAdj { get; set; }


        public short PaEnStopOffsetAdj { get; set; }


        public short PaStartOffsetAdj { get; set; }


        public short PaStopOffsetAdj { get; set; }


        public short AntTimingStartOffsetAdj { get; set; }


        public short AntTimingStopOffsetAdj { get; set; }
    }


    [Serializable]
    public sealed class GsmTxVbattCompDataType : ItemBase
    {
        public short VbattCompDbx100 { get; set; }

        [FieldCount(4)]
        public short[] VbattCompParangeDbx100
        {
            get;
        }
    }

    [Serializable]
    public sealed class QmslRxSpurTableNvType : ItemBase
    {
        [FieldOrder(0)]
        public uint AbsFreqHz { get; set; }

        [FieldOrder(1)]
        public byte NotchSetting { get; set; }
    }

    [Serializable]
    public sealed class QmslTxBandCalNvType : ItemBase
    {
        [FieldOrder(0)]
        [FieldCount(8)]
        public sbyte[] Reserved
        {
            get; set;
        }

        [FieldOrder(1)]
        [FieldCount(16)]
        public ushort[] TxCalChan
        {
            get; set;
        }

        [FieldOrder(2)]
        [FieldCount(4)]
        public QmslTxPaStateCalDataNvType[] TxPaStateCalData
        {
            get; set;
        }
    }


    [Serializable]
    public sealed class QmslTxBandCalRev2NvType : ItemBase
    {
        [FieldCount(8)]
        public sbyte[] Reserved
        {
            get;
        }

        [FieldCount(16)]
        public ushort[] TxCalChan
        {
            get;
        }

        [FieldCount(4)]
        public QmslTxPaStateCalDataRev2NvType[] TxPaStateCalData
        {
            get;
        }
    }

    [Serializable]
   public sealed class QmslTxCalCompleteNvType : ItemBase
    {
        public QmslTxBandCalNvType BandCalData { get; set; }

        [FieldCount(192)]
        public QmslTxCalLinearizerTableNvType[] TxLinData
        {
            get;
        }
    }

    [Serializable]
   public sealed class QmslTxCalCompleteRev2NvType : ItemBase
    {
        public QmslTxBandCalRev2NvType BandCalData { get; set; }

        [FieldCount(192)]
        public QmslTxCalLinearizerTableNvType[] TxLinData
        {
            get;
        }

        [FieldCount(32)]
        public QmslTxCalLinearizerEptDpdTableNvType[] TxDpdData
        {
            get;
        }
    }

    [Serializable]
    public sealed class QmslTxCalFreqNumType : SixteenInt16ItemBase
    {
    }

    [Serializable]
    public sealed class QmslTxCalFreqOffsetRowNvType : ItemBase
    {
        [FieldCount(16)]
        public sbyte[] FreqComp
        {
            get;
        }


        public short RgiThreshold { get; set; }
    }

    [Serializable]
    public sealed class QmslTxCalFreqOffsetsType : SixteenSByteItemBase
    {
    }

    [Serializable]
    public sealed class QmslTxCalLinearizerEptDpdTableNvType : ItemBase
    {
        [FieldCount(64)]
        public EptDpdStruct[] Dpd
        {
            get;
        }
    }

    [Serializable]
   public sealed class QmslTxCalLinearizerTableNvType : ItemBase
    {
        public ushort TxChain { get; set; }

        [FieldCount(64)]
        public ushort[] Rgi
        {
            get;
        }

        [FieldCount(64)]
        public short[] Power
        {
            get;
        }

        [FieldCount(64)]
        public uint[] Apt
        {
            get;
        }
    }

    [Serializable]
   public sealed class QmslTxCalMultiLinearizerIndexNodeNvType : ItemBase
    {
        public ushort UpperBoundChan { get; set; }


        public byte TableOffset { get; set; }
    }

    [Serializable]
   public sealed class QmslTxCalMultiLinearizerIndexNodeRev2NvType : ItemBase
    {
        public ushort UpperBoundChan { get; set; }


        public byte TableOffset { get; set; }


        public byte DpdTableOffset { get; set; }
    }

    [Serializable]
   public sealed class QmslTxEptDpdV2AmamsType : ItemBase
    {
        [FieldCount(16)]
        public uint[] Amam
        {
            get;
        }
    }

    [Serializable]
   public sealed class QmslTxEptDpdV2AmpmsType : ItemBase
    {
        [FieldCount(16)]
        public int[] Ampm
        {
            get;
        }
    }

    [Serializable]
   public sealed class QmslTxEtDpdAmamsType : ItemBase
    {
        [FieldCount(16)]
        public uint[] Amam
        {
            get;
        }
    }

    [Serializable]
   public sealed class QmslTxEtDpdAmpmsType : ItemBase
    {
        [FieldCount(16)]
        public int[] Ampm
        {
            get;
        }
    }

    [Serializable]
   public sealed class QmslTxEtDpdEpdtsType : ItemBase
    {
        [FieldCount(16)]
        public uint[] Epdt
        {
            get;
        }
    }

    [Serializable]
    public sealed class QmslTxLinV3AptsType : SixtyFourUInt32ItemBase
    {
    }

    [Serializable]
   public sealed class QmslTxLinV3DpdInfoType : ItemBase
    {
        public byte DpdTypeUsed { get; set; }


        public ushort NumDpdUsed { get; set; }

        [FieldCount(64)]
        public ushort[] DpdIdx
        {
            get;
        }
    }

    [Serializable]
   public sealed class QmslTxLinV3FcompIndexType : ItemBase
    {
        public byte FcompType { get; set; }


        public ushort NumFcompUsed { get; set; }

        [FieldCount(64)]
        public ushort[] FcompIdx
        {
            get;
        }
    }

    [Serializable]
    public sealed class QmslTxLinV3IqOffsetsType : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    public sealed class QmslTxLinV3PaCurrentsType : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
    public sealed class QmslTxLinV3PwrsType : SixtyFourInt16ItemBase
    {
    }

    [Serializable]
    public sealed class QmslTxLinV3RgisType : SixtyFourUInt16ItemBase
    {
    }

    [Serializable]
   public sealed class QmslTxLinVsTempVsFreqNumType : ItemBase
    {
        [FieldCount(8)]
        public QmslTxCalFreqNumType[] Temp
        {
            get;
        }
    }

    [Serializable]
   public sealed class QmslTxPaStateCalDataNvType : ItemBase
    {
        public TxFreqOffsetTableType TxFreqOffsets { get; set; }

        [FieldCount(3)]
        public TxLinearizerIndexType[] TxLinearizerIndex
        {
            get;
        }
    }

    [Serializable]
   public sealed class QmslTxPaStateCalDataRev2NvType : ItemBase
    {
        [FieldCount(2)]
        public TxFreqOffsetTableType[] TxFreqOffsets
        {
            get;
        }

        [FieldCount(4)]
        public TxLinearizerIndexRev2Type[] TxLinearizerIndex
        {
            get;
        }
    }

    [Serializable]
   public sealed class QmslTxPwrImbalanceDbm10CoordinateType : ItemBase
    {
        public short XAxisVal { get; set; }


        public short YAxisVal { get; set; }
    }

    [Serializable]
   public sealed class QmslTxPwrLimitDataType : ItemBase
    {
        public byte Bw { get; set; }


        public ushort CarrierConfigPattern { get; set; }


        public ushort LowestFreqChan { get; set; }


        public ushort HighestFreqChan { get; set; }

        [FieldCount(8)]
        public short[] TxPwrLimitDbm10
        {
            get;
        }

        [FieldCount(7)]
        public QmslTxPwrImbalanceDbm10CoordinateType[] HiBackoffLut
        {
            get;
        }

        [FieldCount(7)]
        public QmslTxPwrImbalanceDbm10CoordinateType[] LoBackoffLut
        {
            get;
        }


        public byte LutIndicator { get; set; }


        public byte FunnelBias { get; set; }


        public ushort MdspReadingAtReferenceTemperature { get; set; }


        public byte TableVersion { get; set; }

        [FieldCount(3)]
        public byte[] Reserved
        {
            get;
        }
    }

    [Serializable]
   public sealed class RfcommonAntTunerDataType : ItemBase
    {
        [FieldCount(4)]
        public byte[] DeviceEnable
        {
            get;
        }

        [FieldCount(4)]
        public byte[] DeviceCs
        {
            get;
        }

        [FieldCount(16)]
        public ushort[] ChannelList
        {
            get;
        }

        [FieldCount(64)]
        public uint[] CodeWords
        {
            get;
        }
    }

    [Serializable]
   public sealed class RfnvDataAmamListType : ItemBase
    {
        public byte AmamAmpmIdentifier { get; set; }


        public byte ChannelIndex { get; set; }

        [FieldCount(128)]
        public ushort[] DataList
        {
            get;
        }
    }

    [Serializable]
   public sealed class RfnvDataAmpmListType : ItemBase
    {
        public byte AmamAmpmIdentifier { get; set; }


        public byte ChannelIndex { get; set; }

        [FieldCount(128)]
        public short[] DataList
        {
            get;
        }
    }

    [Serializable]
   public sealed class RfnvDataPmeasListType : ItemBase
    {
        public byte Mod { get; set; }


        public byte ChannelIndex { get; set; }


        public byte PaState { get; set; }

        [FieldCount(32)]
        public short[] PmeasList
        {
            get;
        }
    }

    [Serializable]
   public sealed class RfnvDataRgiListType : ItemBase
    {
        public byte Mod { get; set; }


        public byte PaState { get; set; }


        public byte ValidRgiNum { get; set; }

        [FieldCount(32)]
        public byte[] RgiList
        {
            get;
        }
    }

    [Serializable]
   public sealed class RfnvDataTxCalChansU32Type : ItemBase
    {
        [FieldCount(16)]
        public uint[] TxCalChans
        {
            get;
        }
    }

    [Serializable]
   public sealed class RfnvDataTxEptDpdV2Type : ItemBase
    {
        public ushort EptDpdIndex { get; set; }


        public QmslTxEptDpdV2AmamsType Amams { get; set; }


        public QmslTxEptDpdV2AmpmsType Ampms { get; set; }
    }

    [Serializable]
   public sealed class RfnvDataTxEtDpdType : ItemBase
    {
        public ushort EtDpdIndex { get; set; }


        public QmslTxEtDpdAmamsType Amams { get; set; }


        public QmslTxEtDpdAmpmsType Ampms { get; set; }


        public QmslTxEtDpdEpdtsType Epdts { get; set; }
    }

    [Serializable]
   public sealed class RfnvDataTxFreqOffsetsType : ItemBase
    {
        public byte PaState { get; set; }


        public byte FcompSweepType { get; set; }


        public ushort FcompIndex { get; set; }


        public QmslTxCalFreqOffsetsType FreqOffsets { get; set; }
    }

    [Serializable]
   public sealed class RfnvDataTxLinV3Type : ItemBase
    {
        public byte PaState { get; set; }


        public byte WaveType { get; set; }


        public uint TxChan { get; set; }


        public uint UpperBoundTxChan { get; set; }


        public QmslTxLinV3RgisType Rgis { get; set; }


        public QmslTxLinV3PwrsType PwrsDb10 { get; set; }


        public QmslTxLinV3AptsType Apts { get; set; }


        public QmslTxLinV3PaCurrentsType Currents { get; set; }


        public QmslTxLinV3IqOffsetsType IqOffsets { get; set; }


        public QmslTxLinV3DpdInfoType DpdInfo { get; set; }


        public QmslTxLinV3FcompIndexType FcompInfo { get; set; }
    }

    [Serializable]
   public sealed class RfnvDataTxPwrErrListType : ItemBase
    {
        public byte Mod { get; set; }


        public byte ChannelIndex { get; set; }

        [FieldCount(16)]
        public short[] PwrErrList
        {
            get;
        }
    }

    [Serializable]
   public sealed class TxFreqOffsetTableType : ItemBase
    {
        [FieldCount(8)]
        public QmslTxCalFreqOffsetRowNvType[] Row
        {
            get;
        }
    }

    [Serializable]
   public sealed class TxIntDevCalNvType : ItemBase
    {
        [FieldCount(8)]
        public ulong[] CdmaBcTxIntCal
        {
            get;
        }

        [FieldCount(8)]
        public byte[] GsmBcTxIntCal
        {
            get;
        }

        [FieldCount(8)]
        public ulong[] WcdmaBcTxIntCal
        {
            get;
        }

        [FieldCount(8)]
        public ulong[] LteBcTxIntCal
        {
            get;
        }

        [FieldCount(8)]
        public ulong[] TdscdmaBcTxIntCal
        {
            get;
        }
    }

    [Serializable]
   public sealed class TxLinearizerIndexRev2Type : ItemBase
    {
        [FieldCount(16)]
        public QmslTxCalMultiLinearizerIndexNodeRev2NvType[] NodeType
        {
            get;
        }
    }

    [Serializable]
   public sealed class TxLinearizerIndexType : ItemBase
    {
        [FieldCount(16)]
        public QmslTxCalMultiLinearizerIndexNodeNvType[] NodeType
        {
            get;
        }
    }

    [Serializable]
   public sealed class TxXptDpdConfigParamsDataType : ItemBase
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

    [Serializable]
   public sealed class VariantMarker : ItemBase
    {
        public ushort Version { get; set; }


        public ushort NumOfElement { get; set; }
    }
}