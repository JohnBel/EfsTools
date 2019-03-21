using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class QmslTxPwrLimitDataType
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Bw { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort CarrierConfigPattern { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort LowestFreqChan { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort HighestFreqChan { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int16")]
        [Description("")]
        public short[] TxPwrLimitDbm10 { get; set; }
        
        [ElementsCount(7)]
        [ElementType("QMSL_Tx_Pwr_Imbalance_dbm10_coordinate_type")]
        [Description("")]
        public QmslTxPwrImbalanceDbm10CoordinateType[] HiBackoffLut { get; set; }
        
        [ElementsCount(7)]
        [ElementType("QMSL_Tx_Pwr_Imbalance_dbm10_coordinate_type")]
        [Description("")]
        public QmslTxPwrImbalanceDbm10CoordinateType[] LoBackoffLut { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte LutIndicator { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte FunnelBias { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort MdspReadingAtReferenceTemperature { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte TableVersion { get; set; }
        
        [ElementsCount(3)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Reserved { get; set; }
        
    }
}
