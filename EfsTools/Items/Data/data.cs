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
        [FieldCount(4)]
        [FieldOrder(0)]
        public int[] Am
        {
            get; set;
        }

        [FieldCount(3)]
        [FieldOrder(1)]
        public int[] Pm
        {
            get; set;
        }

        [FieldCount(3)]
        [FieldOrder(2)]
        public byte[] PmShift
        {
            get; set;
        }


        [FieldOrder(3)]
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
        [FieldOrder(0)]
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
        [FieldOrder(0)]
        public sbyte MaxGainrange1 { get; set; }


        [FieldOrder(1)]
        public sbyte MinGainrange2 { get; set; }


        [FieldOrder(2)]
        public sbyte MaxGainrange2 { get; set; }


        [FieldOrder(3)]
        public sbyte MinGainrange3 { get; set; }


        [FieldOrder(4)]
        public sbyte MaxGainrange3 { get; set; }


        [FieldOrder(5)]
        public sbyte MinGainrange4 { get; set; }


        [FieldOrder(6)]
        public sbyte MaxGainrange4 { get; set; }


        [FieldOrder(7)]
        public sbyte MinGainrange5 { get; set; }
    }

    [Serializable]
    public sealed class GsmTxEnhAptDataType : ItemBase
    {
        [FieldOrder(0)]
        public byte PclThresholdVal { get; set; }


        [FieldOrder(1)]
        public ushort VbattThresholdLowPwr { get; set; }


        [FieldOrder(2)]
        public ushort VbattThresholdHighPwr { get; set; }
    }

    [Serializable]
    public sealed class GsmTxGtrThreshDataType : ItemBase
    {
        [FieldOrder(0)]
        public sbyte Enable { get; set; }


        [FieldOrder(1)]
        public short RiseThresh { get; set; }


        [FieldOrder(2)]
        public short FallThresh { get; set; }


        [FieldOrder(3)]
        public short AdvTime { get; set; }
    }

    [Serializable]
    public sealed class GsmTxLinearTxGainParamDataType : ItemBase
    {
        [FieldOrder(0)]
        public ushort GsmLinearTxGainVal { get; set; }


        [FieldOrder(1)]
        public ushort EdgeLinearTxGainVal { get; set; }

        [FieldCount(16)]
        [FieldOrder(2)]
        public byte[] CharpredistEnvGain
        {
            get; set;
        }
    }

    [Serializable]
    public sealed class GsmTxPaSwptDataType : ItemBase
    {
        [FieldOrder(0)]
        public ushort PaR1ToR2 { get; set; }


        [FieldOrder(1)]
        public ushort PaR2ToR3 { get; set; }


        [FieldOrder(2)]
        public ushort PaR3ToR4 { get; set; }


        [FieldOrder(3)]
        public ushort PaR2ToR4 { get; set; }


        [FieldOrder(4)]
        public ushort EdgePaLoToMid { get; set; }


        [FieldOrder(5)]
        public ushort EdgePaMidToHi { get; set; }


        [FieldOrder(6)]
        public ushort PaPredistSwpt1 { get; set; }


        [FieldOrder(7)]
        public ushort PaPredistSwpt2 { get; set; }
    }

    [Serializable]
    public sealed class GsmTxPolarRampProfileDataType : ItemBase
    {
        [FieldCount(30)]
        [FieldOrder(0)]
        public ushort[] RampUp
        {
            get; set;
        }

        [FieldCount(30)]
        [FieldOrder(1)]
        public ushort[] RampDown
        {
            get; set;
        }
    }

    [Serializable]
    public sealed class GsmTxSarBackoffDataType : ItemBase
    {
        [FieldOrder(0)]
        public short SarGmsk { get; set; }


        [FieldOrder(1)]
        public short Sar8psk { get; set; }
    }

    [Serializable]
    public sealed class GsmTxSmpsPdmDataType : ItemBase
    {
        [FieldCount(6)]
        [FieldOrder(0)]
        public ushort[] CalSmpsPdmTbl
        {
            get; set;
        }

        [FieldCount(16)]
        [FieldOrder(1)]
        public ushort[] GsmSmpsPdmTbl
        {
            get; set;
        }

        [FieldCount(16)]
        [FieldOrder(2)]
        public ushort[] EdgeSmpsPdmTbl
        {
            get; set;
        }
    }

    [Serializable]
    public sealed class GsmTxTempCompDataType : ItemBase
    {
        [FieldCount(16)]
        [FieldOrder(0)]
        public short[] TempCompPclPwrScaling
        {
            get; set;
        }

        [FieldCount(16)]
        [FieldOrder(1)]
        public ushort[] HotTempCompPclPwrOffsetGsmk
        {
            get; set;
        }

        [FieldCount(16)]
        [FieldOrder(2)]
        public ushort[] ColdTempCompPclPwrOffsetGsmk
        {
            get; set;
        }

        [FieldCount(16)]
        [FieldOrder(3)]
        public ushort[] HotTempCompPclPwrOffset8psk
        {
            get; set;
        }

        [FieldCount(16)]
        [FieldOrder(4)]
        public ushort[] ColdTempCompPclPwrOffset8psk
        {
            get; set;
        }
    }

    [Serializable]
    public sealed class GsmTxTimingDataType : ItemBase
    {
        [FieldOrder(0)]
        public short TxBurstOffsetAdj { get; set; }


        [FieldOrder(1)]
        public short PaEnStartOffsetAdj { get; set; }


        [FieldOrder(2)]
        public short PaEnStopOffsetAdj { get; set; }


        [FieldOrder(3)]
        public short PaStartOffsetAdj { get; set; }


        [FieldOrder(4)]
        public short PaStopOffsetAdj { get; set; }


        [FieldOrder(5)]
        public short AntTimingStartOffsetAdj { get; set; }


        [FieldOrder(6)]
        public short AntTimingStopOffsetAdj { get; set; }
    }


    [Serializable]
    public sealed class GsmTxVbattCompDataType : ItemBase
    {
        [FieldOrder(0)]
        public short VbattCompDbx100 { get; set; }

        [FieldCount(4)]
        [FieldOrder(1)]
        public short[] VbattCompParangeDbx100
        {
            get; set;
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
        [FieldCount(8)]
        [FieldOrder(0)]
        public sbyte[] Reserved
        {
            get; set;
        }

        [FieldCount(16)]
        [FieldOrder(1)]
        public ushort[] TxCalChan
        {
            get; set;
        }

        [FieldCount(4)]
        [FieldOrder(2)]
        public QmslTxPaStateCalDataNvType[] TxPaStateCalData
        {
            get; set;
        }
    }


    [Serializable]
    public sealed class QmslTxBandCalRev2NvType : ItemBase
    {
        [FieldCount(8)]
        [FieldOrder(0)]
        public sbyte[] Reserved
        {
            get; set;
        }

        [FieldCount(16)]
        [FieldOrder(1)]
        public ushort[] TxCalChan
        {
            get; set;
        }

        [FieldCount(4)]
        [FieldOrder(2)]
        public QmslTxPaStateCalDataRev2NvType[] TxPaStateCalData
        {
            get; set;
        }
    }

    [Serializable]
    public sealed class QmslTxCalCompleteNvType : ItemBase
    {
        [FieldOrder(0)]
        public QmslTxBandCalNvType BandCalData { get; set; }

        [FieldCount(192)]
        [FieldOrder(1)]
        public QmslTxCalLinearizerTableNvType[] TxLinData
        {
            get; set;
        }
    }

    [Serializable]
    public sealed class QmslTxCalCompleteRev2NvType : ItemBase
    {
        [FieldOrder(0)]
        public QmslTxBandCalRev2NvType BandCalData { get; set; }

        [FieldCount(192)]
        [FieldOrder(1)]
        public QmslTxCalLinearizerTableNvType[] TxLinData
        {
            get; set;
        }

        [FieldCount(32)]
        [FieldOrder(2)]
        public QmslTxCalLinearizerEptDpdTableNvType[] TxDpdData
        {
            get; set;
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
        [FieldOrder(0)]
        public sbyte[] FreqComp
        {
            get; set;
        }


        [FieldOrder(1)]
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
        [FieldOrder(0)]
        public EptDpdStruct[] Dpd
        {
            get;
        }
    }

    [Serializable]
    public sealed class QmslTxCalLinearizerTableNvType : ItemBase
    {
        [FieldOrder(0)]
        public ushort TxChain { get; set; }

        [FieldCount(64)]
        [FieldOrder(1)]
        public ushort[] Rgi
        {
            get; set;
        }

        [FieldCount(64)]
        [FieldOrder(2)]
        public short[] Power
        {
            get; set;
        }

        [FieldCount(64)]
        [FieldOrder(3)]
        public uint[] Apt
        {
            get; set;
        }
    }

    [Serializable]
    public sealed class QmslTxCalMultiLinearizerIndexNodeNvType : ItemBase
    {
        [FieldOrder(0)]
        public ushort UpperBoundChan { get; set; }


        [FieldOrder(1)]
        public byte TableOffset { get; set; }
    }

    [Serializable]
    public sealed class QmslTxCalMultiLinearizerIndexNodeRev2NvType : ItemBase
    {
        [FieldOrder(0)]
        public ushort UpperBoundChan { get; set; }


        [FieldOrder(1)]
        public byte TableOffset { get; set; }


        [FieldOrder(2)]
        public byte DpdTableOffset { get; set; }
    }

    [Serializable]
    public sealed class QmslTxEptDpdV2AmamsType : ItemBase
    {
        [FieldCount(16)]
        [FieldOrder(0)]
        public uint[] Amam
        {
            get; set;
        }
    }

    [Serializable]
    public sealed class QmslTxEptDpdV2AmpmsType : ItemBase
    {
        [FieldCount(16)]
        [FieldOrder(0)]
        public int[] Ampm
        {
            get; set;
        }
    }

    [Serializable]
    public sealed class QmslTxEtDpdAmamsType : ItemBase
    {
        [FieldCount(16)]
        [FieldOrder(0)]
        public uint[] Amam
        {
            get; set;
        }
    }

    [Serializable]
    public sealed class QmslTxEtDpdAmpmsType : ItemBase
    {
        [FieldCount(16)]
        [FieldOrder(0)]
        public int[] Ampm
        {
            get; set;
        }
    }

    [Serializable]
    public sealed class QmslTxEtDpdEpdtsType : ItemBase
    {
        [FieldCount(16)]
        [FieldOrder(0)]
        public uint[] Epdt
        {
            get; set;
        }
    }

    [Serializable]
    public sealed class QmslTxLinV3AptsType : SixtyFourUInt32ItemBase
    {
    }

    [Serializable]
    public sealed class QmslTxLinV3DpdInfoType : ItemBase
    {
        [FieldOrder(0)]
        public byte DpdTypeUsed { get; set; }


        [FieldOrder(1)]
        public ushort NumDpdUsed { get; set; }

        [FieldCount(64)]
        [FieldOrder(2)]
        public ushort[] DpdIdx
        {
            get; set;
        }
    }

    [Serializable]
    public sealed class QmslTxLinV3FcompIndexType : ItemBase
    {
        [FieldOrder(0)]
        public byte FcompType { get; set; }


        [FieldOrder(1)]
        public ushort NumFcompUsed { get; set; }

        [FieldCount(64)]
        [FieldOrder(2)]
        public ushort[] FcompIdx
        {
            get; set;
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
        [FieldOrder(0)]
        public QmslTxCalFreqNumType[] Temp
        {
            get; set;
        }
    }

    [Serializable]
    public sealed class QmslTxPaStateCalDataNvType : ItemBase
    {
        [FieldOrder(0)]
        public TxFreqOffsetTableType TxFreqOffsets { get; set; }

        [FieldCount(3)]
        [FieldOrder(1)]
        public TxLinearizerIndexType[] TxLinearizerIndex
        {
            get;
            set;
        }
    }

    [Serializable]
    public sealed class QmslTxPaStateCalDataRev2NvType : ItemBase
    {
        [FieldCount(2)]
        [FieldOrder(0)]
        public TxFreqOffsetTableType[] TxFreqOffsets
        {
            get;
            set;
        }

        [FieldCount(4)]
        [FieldOrder(1)]
        public TxLinearizerIndexRev2Type[] TxLinearizerIndex
        {
            get;
            set;
        }
    }

    [Serializable]
    public sealed class QmslTxPwrImbalanceDbm10CoordinateType : ItemBase
    {
        [FieldOrder(0)]
        public short XAxisVal { get; set; }

        [FieldOrder(1)]
        public short YAxisVal { get; set; }
    }

    [Serializable]
    public sealed class QmslTxPwrLimitDataType : ItemBase
    {
        [FieldOrder(0)]
        public byte Bw { get; set; }


        [FieldOrder(1)]
        public ushort CarrierConfigPattern { get; set; }


        [FieldOrder(2)]
        public ushort LowestFreqChan { get; set; }


        [FieldOrder(3)]
        public ushort HighestFreqChan { get; set; }

        [FieldCount(8)]
        [FieldOrder(4)]
        public short[] TxPwrLimitDbm10
        {
            get;
            set;
        }

        [FieldCount(7)]
        [FieldOrder(5)]
        public QmslTxPwrImbalanceDbm10CoordinateType[] HiBackoffLut
        {
            get;
            set;
        }

        [FieldCount(7)]
        [FieldOrder(6)]
        public QmslTxPwrImbalanceDbm10CoordinateType[] LoBackoffLut
        {
            get;
            set;
        }


        [FieldOrder(7)]
        public byte LutIndicator { get; set; }


        [FieldOrder(8)]
        public byte FunnelBias { get; set; }


        [FieldOrder(9)]
        public ushort MdspReadingAtReferenceTemperature { get; set; }


        [FieldOrder(10)]
        public byte TableVersion { get; set; }

        [FieldCount(3)]
        [FieldOrder(11)]
        public byte[] Reserved
        {
            get;
            set;
        }
    }

    [Serializable]
    public sealed class RfcommonAntTunerDataType : ItemBase
    {
        [FieldCount(4)]
        [FieldOrder(0)]
        public byte[] DeviceEnable
        {
            get;
            set;
        }

        [FieldCount(4)]
        [FieldOrder(1)]
        public byte[] DeviceCs
        {
            get;
            set;
        }

        [FieldCount(16)]
        [FieldOrder(2)]
        public ushort[] ChannelList
        {
            get;
            set;
        }

        [FieldCount(64)]
        [FieldOrder(3)]
        public uint[] CodeWords
        {
            get;
            set;
        }
    }

    [Serializable]
    public sealed class RfnvDataAmamListType : ItemBase
    {
        [FieldOrder(0)]
        public byte AmamAmpmIdentifier { get; set; }


        [FieldOrder(1)]
        public byte ChannelIndex { get; set; }

        [FieldCount(128)]
        [FieldOrder(2)]
        public ushort[] DataList
        {
            get; set;
        }
    }

    [Serializable]
    public sealed class RfnvDataAmpmListType : ItemBase
    {
        [FieldOrder(0)]
        public byte AmamAmpmIdentifier { get; set; }


        [FieldOrder(1)]
        public byte ChannelIndex { get; set; }

        [FieldCount(128)]
        [FieldOrder(2)]
        public short[] DataList
        {
            get; set;
        }
    }

    [Serializable]
    public sealed class RfnvDataPmeasListType : ItemBase
    {
        [FieldOrder(0)]
        public byte Mod { get; set; }


        [FieldOrder(1)]
        public byte ChannelIndex { get; set; }


        [FieldOrder(2)]
        public byte PaState { get; set; }

        [FieldCount(32)]
        [FieldOrder(3)]
        public short[] PmeasList
        {
            get; set;
        }
    }

    [Serializable]
    public sealed class RfnvDataRgiListType : ItemBase
    {
        [FieldOrder(0)]
        public byte Mod { get; set; }


        [FieldOrder(1)]
        public byte PaState { get; set; }


        [FieldOrder(2)]
        public byte ValidRgiNum { get; set; }

        [FieldCount(32)]
        [FieldOrder(3)]
        public byte[] RgiList
        {
            get; set;
        }
    }

    [Serializable]
    public sealed class RfnvDataTxCalChansU32Type : ItemBase
    {
        [FieldCount(16)]
        [FieldOrder(0)]
        public uint[] TxCalChans
        {
            get;
            set;
        }
    }

    [Serializable]
    public sealed class RfnvDataTxEptDpdV2Type : ItemBase
    {
        [FieldOrder(0)]
        public ushort EptDpdIndex { get; set; }

        [FieldOrder(1)]
        public QmslTxEptDpdV2AmamsType Amams { get; set; }

        [FieldOrder(2)]
        public QmslTxEptDpdV2AmpmsType Ampms { get; set; }
    }

    [Serializable]
    public sealed class RfnvDataTxEtDpdType : ItemBase
    {
        [FieldOrder(0)]
        public ushort EtDpdIndex { get; set; }

        [FieldOrder(1)]
        public QmslTxEtDpdAmamsType Amams { get; set; }

        [FieldOrder(2)]
        public QmslTxEtDpdAmpmsType Ampms { get; set; }

        [FieldOrder(3)]
        public QmslTxEtDpdEpdtsType Epdts { get; set; }
    }

    [Serializable]
    public sealed class RfnvDataTxFreqOffsetsType : ItemBase
    {
        [FieldOrder(0)]
        public byte PaState { get; set; }


        [FieldOrder(1)]
        public byte FcompSweepType { get; set; }


        [FieldOrder(2)]
        public ushort FcompIndex { get; set; }

        [FieldOrder(3)]
        public QmslTxCalFreqOffsetsType FreqOffsets { get; set; }
    }

    [Serializable]
    public sealed class RfnvDataTxLinV3Type : ItemBase
    {
        [FieldOrder(0)]
        public byte PaState { get; set; }


        [FieldOrder(1)]
        public byte WaveType { get; set; }


        [FieldOrder(2)]
        public uint TxChan { get; set; }


        [FieldOrder(3)]
        public uint UpperBoundTxChan { get; set; }

        [FieldOrder(4)]
        public QmslTxLinV3RgisType Rgis { get; set; }

        [FieldOrder(5)]
        public QmslTxLinV3PwrsType PwrsDb10 { get; set; }

        [FieldOrder(6)]
        public QmslTxLinV3AptsType Apts { get; set; }

        [FieldOrder(7)]
        public QmslTxLinV3PaCurrentsType Currents { get; set; }

        [FieldOrder(8)]
        public QmslTxLinV3IqOffsetsType IqOffsets { get; set; }

        [FieldOrder(9)]
        public QmslTxLinV3DpdInfoType DpdInfo { get; set; }

        [FieldOrder(10)]
        public QmslTxLinV3FcompIndexType FcompInfo { get; set; }
    }

    [Serializable]
    public sealed class RfnvDataTxPwrErrListType : ItemBase
    {
        [FieldOrder(0)]
        public byte Mod { get; set; }


        [FieldOrder(1)]
        public byte ChannelIndex { get; set; }

        [FieldCount(16)]
        [FieldOrder(2)]
        public short[] PwrErrList
        {
            get;
            set;
        }
    }

    [Serializable]
    public sealed class TxFreqOffsetTableType : ItemBase
    {
        [FieldCount(8)]
        [FieldOrder(0)]
        public QmslTxCalFreqOffsetRowNvType[] Row
        {
            get;
            set;
        }
    }

    [Serializable]
    public sealed class TxIntDevCalNvType : ItemBase
    {
        [FieldCount(8)]
        [FieldOrder(0)]
        public ulong[] CdmaBcTxIntCal
        {
            get;
            set;
        }

        [FieldCount(8)]
        [FieldOrder(1)]
        public byte[] GsmBcTxIntCal
        {
            get;
            set;
        }

        [FieldCount(8)]
        [FieldOrder(2)]
        public ulong[] WcdmaBcTxIntCal
        {
            get;
            set;
        }

        [FieldCount(8)]
        [FieldOrder(3)]
        public ulong[] LteBcTxIntCal
        {
            get;
            set;
        }

        [FieldCount(8)]
        [FieldOrder(4)]
        public ulong[] TdscdmaBcTxIntCal
        {
            get;
            set;
        }
    }

    [Serializable]
    public sealed class TxLinearizerIndexRev2Type : ItemBase
    {
        [FieldCount(16)]
        [FieldOrder(0)]
        public QmslTxCalMultiLinearizerIndexNodeRev2NvType[] NodeType
        {
            get;
            set;
        }
    }

    [Serializable]
    public sealed class TxLinearizerIndexType : ItemBase
    {
        [FieldCount(16)]
        [FieldOrder(0)]
        public QmslTxCalMultiLinearizerIndexNodeNvType[] NodeType
        {
            get;
            set;
        }
    }

    [Serializable]
    public sealed class TxXptDpdConfigParamsDataType : ItemBase
    {
        [FieldOrder(0)]
        public uint XptConfig { get; set; }


        [FieldOrder(1)]
        public uint ExpScale { get; set; }


        [FieldOrder(2)]
        public uint SearchCenter { get; set; }


        [FieldOrder(3)]
        public uint SearchWidth { get; set; }


        [FieldOrder(4)]
        public uint QFactor { get; set; }


        [FieldOrder(5)]
        public uint TxLinMag { get; set; }


        [FieldOrder(6)]
        public uint PmOrder { get; set; }


        [FieldOrder(7)]
        public uint EptEnvScaleUnity { get; set; }


        [FieldOrder(8)]
        public uint IqGainUnity { get; set; }


        [FieldOrder(9)]
        public uint RgiSelMaxPower { get; set; }


        [FieldOrder(10)]
        public uint RgiSelOffsetLow0 { get; set; }


        [FieldOrder(11)]
        public uint RgiSelOffsetLow1 { get; set; }


        [FieldOrder(12)]
        public uint RgiSelOffsetLow2 { get; set; }


        [FieldOrder(13)]
        public uint RgiSelOffsetHigh0 { get; set; }


        [FieldOrder(14)]
        public uint RgiSelOffsetHigh1 { get; set; }


        [FieldOrder(15)]
        public uint RgiSelOffsetHigh2 { get; set; }

        [FieldCount(7)]
        [FieldOrder(16)]
        public uint[] Reserved2
        {
            get;
            set;
        }


        [FieldOrder(17)]
        public uint EtEnvScaleUnity { get; set; }


        [FieldOrder(18)]
        public uint Reserved3 { get; set; }


        [FieldOrder(19)]
        public uint Reserved4 { get; set; }


        [FieldOrder(20)]
        public uint Reserved5 { get; set; }


        [FieldOrder(21)]
        public uint Reserved6 { get; set; }


        [FieldOrder(22)]
        public uint Reserved7 { get; set; }


        [FieldOrder(23)]
        public uint Reserved8 { get; set; }


        [FieldOrder(24)]
        public uint Reserved9 { get; set; }


        [FieldOrder(25)]
        public uint Reserved10 { get; set; }
    }

    [Serializable]
    public sealed class VariantMarker : ItemBase
    {
        [FieldOrder(0)]
        public ushort Version { get; set; }


        [FieldOrder(1)]
        public ushort NumOfElement { get; set; }
    }
}
