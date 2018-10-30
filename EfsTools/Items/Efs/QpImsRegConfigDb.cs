using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
//	typedef enum {
//  IMSRTP_DCM_RAT_TYPE_MIN_ENUM_VAL_V01 = -2147483647, /**< To force a 32 bit signed enum.  Do not change or use*/
//    IMSRTP_DCM_RAT_NONE_V01 = 0, /**<  None.   */
//    IMSRTP_DCM_RAT_GPRS_V01 = 1, /**<  General packet radio services.     */
//    IMSRTP_DCM_RAT_EDGE_V01 = 2, /**<  Enhanced data GSM environment.    */
//    IMSRTP_DCM_RAT_WCDMA_V01 = 3, /**<  WCDMA.    */
//    IMSRTP_DCM_RAT_WLAN_V01 = 4, /**<  WLAN.    */
//    IMSRTP_DCM_RAT_CDMA_V01 = 5, /**<  CDMA 1.x.    */
//    IMSRTP_DCM_RAT_IWLAN_V01 = 6, /**<  IWLAN.    */
//    IMSRTP_DCM_RAT_DOR0_V01 = 7, /**<  CDMA DO Rev0.    */
//    IMSRTP_DCM_RAT_DORA_V01 = 8, /**<  CDMA DO RevA.    */
//    IMSRTP_DCM_RAT_EHRPD_V01 = 9, /**<  CDMA evolved high-rate packet data.    */
//    IMSRTP_DCM_RAT_LTE_V01 = 10, /**<  Long-term evolution.    */
//    IMSRTP_DCM_RAT_DORB_V01 = 11, /**<  CDMA DO RevB.    */
//    IMSRTP_DCM_RAT_EPC_V01 = 12, /**<  EPC.    */
//    IMSRTP_DCM_RAT_TYPE_MAX_ENUM_VAL_V01 = 2147483647 /**< To force a 32 bit signed enum.  Do not change or use*/
//}imsrtp_dcm_rat_type_v01;

    [Serializable]
    public class QpImsRegConfigDbItem
    {
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Rat { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ApnIndex { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ImsServiceInfo { get; set; }


        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte AuthSecType { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpTypeInfo { get; set; }
    }

    [Serializable]
    [EfsFile("/nv/item_files/ims/qp_ims_reg_config_db", false, 0x81FF)]
    [Attributes(9)]
    public class QpImsRegConfigDb
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }

        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Rat1 { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ApnIndex1 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ImsServiceInfo1 { get; set; }


        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte AuthSecType1 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpTypeInfo1 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Rat2 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ApnIndex2 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ImsServiceInfo2 { get; set; }


        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte AuthSecType2 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpTypeInfo2 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Rat3 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ApnIndex3 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ImsServiceInfo3 { get; set; }


        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte AuthSecType3 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpTypeInfo3 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Rat4 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ApnIndex4 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ImsServiceInfo4 { get; set; }


        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte AuthSecType4 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpTypeInfo4 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Rat5 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ApnIndex5 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ImsServiceInfo5 { get; set; }


        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte AuthSecType5 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpTypeInfo5 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Rat6 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ApnIndex6 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ImsServiceInfo6 { get; set; }


        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte AuthSecType6 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpTypeInfo6 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Rat7 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ApnIndex7 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ImsServiceInfo7 { get; set; }


        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte AuthSecType7 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpTypeInfo7 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Rat8 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ApnIndex8 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ImsServiceInfo8 { get; set; }


        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte AuthSecType8 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpTypeInfo8 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Rat9 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ApnIndex9 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ImsServiceInfo9 { get; set; }


        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte AuthSecType9 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpTypeInfo9 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Rat10 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ApnIndex10 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ImsServiceInfo10 { get; set; }


        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte AuthSecType10 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpTypeInfo10 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RatApnFallback1 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ServicePriorityWwan1 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RatApnFallback2 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ServicePriorityWwan2 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RatApnFallback3 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ServicePriorityWwan3 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RatApnFallback4 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ServicePriorityWwan4 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RatApnFallback5 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ServicePriorityWwan5 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RatApnFallback6 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ServicePriorityWwan6 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RatApnFallback7 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ServicePriorityWwan7 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RatApnFallback8 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ServicePriorityWwan8 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RatApnFallback9 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ServicePriorityWwan9 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RatApnFallback10 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ServicePriorityWwan10 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort AllowedImsSrvOnWlan { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte AddAllFTs { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte AcsPriority { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ISimPriority { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte NvPriority { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte PcoPriority { get; set; }


        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short ImsServiceStatus { get; set; }

        [JsonIgnore]
        [ElementsCount(50)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] ApnName1 { get; set; }

        public string ApnName1String
        {
            get => StringUtils.GetString(ApnName1);
            set => ApnName1 = StringUtils.GetBytes(value, 50);
        }

        [JsonIgnore]
        [ElementsCount(50)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] ApnName2 { get; set; }

        public string ApnName2String
        {
            get => StringUtils.GetString(ApnName2);
            set => ApnName2 = StringUtils.GetBytes(value, 50);
        }

        [JsonIgnore]
        [ElementsCount(50)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] ApnName3 { get; set; }

        public string ApnName3String
        {
            get => StringUtils.GetString(ApnName3);
            set => ApnName3 = StringUtils.GetBytes(value, 50);
        }

        [ElementsCount(754)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] ReservedBytes { get; set; }
    }
}