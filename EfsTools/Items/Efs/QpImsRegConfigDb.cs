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

//   ImsServiceInfo
//#define IMS_SETTINGS_SERVICE_TYPE_VOLTE_V01 ((ims_settings_service_type_mask_v01)0x01ull) /**<  Bitmask to indicate the VoLTE service.  */
//#define IMS_SETTINGS_SERVICE_TYPE_VT_V01 ((ims_settings_service_type_mask_v01)0x02ull) /**<  Bitmask to indicate the Video Telephony service.  */
//#define IMS_SETTINGS_SERVICE_TYPE_SMS_V01 ((ims_settings_service_type_mask_v01)0x04ull) /**<  Bitmask to indicate the SMS service.  */
//#define IMS_SETTINGS_SERVICE_TYPE_IM_V01 ((ims_settings_service_type_mask_v01)0x08ull) /**<  Bitmask to indicate the Instant Messaging service.  */
//#define IMS_SETTINGS_SERVICE_TYPE_VS_V01 ((ims_settings_service_type_mask_v01)0x10ull) /**<  Bitmask to indicate the Video Share service.  */
//#define IMS_SETTINGS_SERVICE_TYPE_IS_V01 ((ims_settings_service_type_mask_v01)0x20ull) /**<  Bitmask to indicate the Image Share service.  */
//#define IMS_SETTINGS_SERVICE_TYPE_MSRP_V01 ((ims_settings_service_type_mask_v01)0x40ull) /**<  Bitmask to indicate the MSRP service.  */
//#define IMS_SETTINGS_SERVICE_TYPE_GL_V01 ((ims_settings_service_type_mask_v01)0x80ull) /**<  Bitmask to indicate the Geo-Location service.  */
//#define IMS_SETTINGS_SERVICE_TYPE_PRESENCE_V01 ((ims_settings_service_type_mask_v01)0x100ull) /**<  Bitmask to indicate the Presence service.  */
//#define IMS_SETTINGS_SERVICE_TYPE_FT_V01 ((ims_settings_service_type_mask_v01)0x200ull) /**<  Bitmask to indicate the File Transfer service.  */
//#define IMS_SETTINGS_SERVICE_TYPE_RCS_ALL_V01 ((ims_settings_service_type_mask_v01)0x400ull) /**<  Bitmask to indicate all the RCS services.  */
//#define IMS_SETTINGS_SERVICE_TYPE_DEFAULT_V01 ((ims_settings_service_type_mask_v01)0x8000ull) /**<  Bitmask to indicate the default services.\n

    public enum ImsServiceInfoValues : ushort
    {
        None = 0x0,
        VoLte = 0x1,
        Vt = 0x2,
        VoLte_Vt = 0x3,
        Sms = 0x4,
        VoLte_Sms = 0x5,
        Vt_Sms = 0x6,
        VoLte_Vt_Sms = 0x7,
        Im = 0x8,
        Vs = 0x10,
        Is = 0x20,
        Msrp = 0x40,
        Gl = 0x80,
        Presence = 0x100,
        Ft = 0x200,
        RcsAll = 0x400,
        Default = 0x8000
    }

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

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ImsServiceInfo { get; set; }

        public string ImsServiceInfoString
        {
            get => $"{(ImsServiceInfoValues) ImsServiceInfo}";
            set => ImsServiceInfo = (ushort) Enum.Parse(typeof(ImsServiceInfoValues), value);
        }
        
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
    public class QpImsRegConfigDbItem2
    {
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RatApnFallback { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ServicePriorityWwan { get; set; }
    }

    [Serializable]
    [NvItemId(71527)]
    [EfsFile("/nv/item_files/ims/qp_ims_reg_config_db", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsRegConfigDb
    {
        [Required]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Rat1 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ApnIndex1 { get; set; }


        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ImsServiceInfo1 { get; set; }


        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte AuthSecType1 { get; set; }
        
        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpTypeInfo1 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Rat2 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ApnIndex2 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ImsServiceInfo2 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte AuthSecType2 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpTypeInfo2 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Rat3 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ApnIndex3 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ImsServiceInfo3 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte AuthSecType3 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpTypeInfo3 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Rat4 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ApnIndex4 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ImsServiceInfo4 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte AuthSecType4 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpTypeInfo4 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Rat5 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ApnIndex5 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ImsServiceInfo5 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte AuthSecType5 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpTypeInfo5 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Rat6 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ApnIndex6 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ImsServiceInfo6 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte AuthSecType6 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpTypeInfo6 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Rat7 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ApnIndex7 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ImsServiceInfo7 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte AuthSecType7 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpTypeInfo7 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Rat8 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ApnIndex8 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ImsServiceInfo8 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte AuthSecType8 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpTypeInfo8 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Rat9 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ApnIndex9 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ImsServiceInfo9 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte AuthSecType9 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpTypeInfo9 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Rat10 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ApnIndex10 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ImsServiceInfo10 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte AuthSecType10 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpTypeInfo10 { get; set; }


        public QpImsRegConfigDbItem[] Items
        {
            get => new QpImsRegConfigDbItem[]
            {
                new QpImsRegConfigDbItem() {ApnIndex = ApnIndex1, AuthSecType = AuthSecType1, ImsServiceInfo = ImsServiceInfo1, IpTypeInfo = IpTypeInfo1, Rat = Rat1},
                new QpImsRegConfigDbItem() {ApnIndex = ApnIndex2, AuthSecType = AuthSecType2, ImsServiceInfo = ImsServiceInfo2, IpTypeInfo = IpTypeInfo2, Rat = Rat2},
                new QpImsRegConfigDbItem() {ApnIndex = ApnIndex3, AuthSecType = AuthSecType3, ImsServiceInfo = ImsServiceInfo3, IpTypeInfo = IpTypeInfo3, Rat = Rat3},
                new QpImsRegConfigDbItem() {ApnIndex = ApnIndex4, AuthSecType = AuthSecType4, ImsServiceInfo = ImsServiceInfo4, IpTypeInfo = IpTypeInfo4, Rat = Rat4},
                new QpImsRegConfigDbItem() {ApnIndex = ApnIndex5, AuthSecType = AuthSecType5, ImsServiceInfo = ImsServiceInfo5, IpTypeInfo = IpTypeInfo5, Rat = Rat5},
                new QpImsRegConfigDbItem() {ApnIndex = ApnIndex6, AuthSecType = AuthSecType6, ImsServiceInfo = ImsServiceInfo6, IpTypeInfo = IpTypeInfo6, Rat = Rat6},
                new QpImsRegConfigDbItem() {ApnIndex = ApnIndex7, AuthSecType = AuthSecType7, ImsServiceInfo = ImsServiceInfo7, IpTypeInfo = IpTypeInfo7, Rat = Rat7},
                new QpImsRegConfigDbItem() {ApnIndex = ApnIndex8, AuthSecType = AuthSecType8, ImsServiceInfo = ImsServiceInfo8, IpTypeInfo = IpTypeInfo8, Rat = Rat8},
                new QpImsRegConfigDbItem() {ApnIndex = ApnIndex9, AuthSecType = AuthSecType9, ImsServiceInfo = ImsServiceInfo9, IpTypeInfo = IpTypeInfo9, Rat = Rat9},
                new QpImsRegConfigDbItem() {ApnIndex = ApnIndex10, AuthSecType = AuthSecType10, ImsServiceInfo = ImsServiceInfo10, IpTypeInfo = IpTypeInfo10, Rat = Rat10}
            };
            set
            {
                if (value != null)
                {
                    if (value.Length > 0)
                    {
                        var val = value[0];
                        ApnIndex1 = val.ApnIndex;
                        AuthSecType1 = val.AuthSecType;
                        ImsServiceInfo1 = val.ImsServiceInfo;
                        IpTypeInfo1 = val.IpTypeInfo;
                        Rat1 = val.Rat;
                    }
                    if (value.Length > 1)
                    {
                        var val = value[1];
                        ApnIndex2 = val.ApnIndex;
                        AuthSecType2 = val.AuthSecType;
                        ImsServiceInfo2 = val.ImsServiceInfo;
                        IpTypeInfo2 = val.IpTypeInfo;
                        Rat2 = val.Rat;
                    }
                    if (value.Length > 2)
                    {
                        var val = value[2];
                        ApnIndex3 = val.ApnIndex;
                        AuthSecType3 = val.AuthSecType;
                        ImsServiceInfo3 = val.ImsServiceInfo;
                        IpTypeInfo3 = val.IpTypeInfo;
                        Rat3 = val.Rat;
                    }
                    if (value.Length > 3)
                    {
                        var val = value[3];
                        ApnIndex4 = val.ApnIndex;
                        AuthSecType4 = val.AuthSecType;
                        ImsServiceInfo4 = val.ImsServiceInfo;
                        IpTypeInfo4 = val.IpTypeInfo;
                        Rat4 = val.Rat;
                    }
                    if (value.Length > 4)
                    {
                        var val = value[4];
                        ApnIndex5 = val.ApnIndex;
                        AuthSecType5 = val.AuthSecType;
                        ImsServiceInfo5 = val.ImsServiceInfo;
                        IpTypeInfo5 = val.IpTypeInfo;
                        Rat5 = val.Rat;
                    }
                    if (value.Length > 5)
                    {
                        var val = value[5];
                        ApnIndex6 = val.ApnIndex;
                        AuthSecType6 = val.AuthSecType;
                        ImsServiceInfo6 = val.ImsServiceInfo;
                        IpTypeInfo6 = val.IpTypeInfo;
                        Rat6 = val.Rat;
                    }
                    if (value.Length > 6)
                    {
                        var val = value[6];
                        ApnIndex7 = val.ApnIndex;
                        AuthSecType7 = val.AuthSecType;
                        ImsServiceInfo7 = val.ImsServiceInfo;
                        IpTypeInfo7 = val.IpTypeInfo;
                        Rat7 = val.Rat;
                    }
                    if (value.Length > 7)
                    {
                        var val = value[7];
                        ApnIndex8 = val.ApnIndex;
                        AuthSecType8 = val.AuthSecType;
                        ImsServiceInfo8 = val.ImsServiceInfo;
                        IpTypeInfo8 = val.IpTypeInfo;
                        Rat8 = val.Rat;
                    }
                    if (value.Length > 8)
                    {
                        var val = value[8];
                        ApnIndex9 = val.ApnIndex;
                        AuthSecType9 = val.AuthSecType;
                        ImsServiceInfo9 = val.ImsServiceInfo;
                        IpTypeInfo9 = val.IpTypeInfo;
                        Rat9 = val.Rat;
                    }
                    if (value.Length > 9)
                    {
                        var val = value[9];
                        ApnIndex10 = val.ApnIndex;
                        AuthSecType10 = val.AuthSecType;
                        ImsServiceInfo10 = val.ImsServiceInfo;
                        IpTypeInfo10 = val.IpTypeInfo;
                        Rat10 = val.Rat;
                    }
                }
            }
        }
        
        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RatApnFallback1 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ServicePriorityWwan1 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RatApnFallback2 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ServicePriorityWwan2 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RatApnFallback3 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ServicePriorityWwan3 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RatApnFallback4 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ServicePriorityWwan4 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RatApnFallback5 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ServicePriorityWwan5 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RatApnFallback6 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ServicePriorityWwan6 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RatApnFallback7 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ServicePriorityWwan7 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RatApnFallback8 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ServicePriorityWwan8 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RatApnFallback9 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ServicePriorityWwan9 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RatApnFallback10 { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ServicePriorityWwan10 { get; set; }

        public QpImsRegConfigDbItem2[] Items2
        {
            get => new QpImsRegConfigDbItem2[]
            {
                new QpImsRegConfigDbItem2()
                {
                    RatApnFallback = RatApnFallback1, ServicePriorityWwan = ServicePriorityWwan1
                },
                new QpImsRegConfigDbItem2()
                {
                    RatApnFallback = RatApnFallback2, ServicePriorityWwan = ServicePriorityWwan2
                },
                new QpImsRegConfigDbItem2()
                {
                    RatApnFallback = RatApnFallback3, ServicePriorityWwan = ServicePriorityWwan3
                },
                new QpImsRegConfigDbItem2()
                {
                    RatApnFallback = RatApnFallback4, ServicePriorityWwan = ServicePriorityWwan4
                },
                new QpImsRegConfigDbItem2()
                {
                    RatApnFallback = RatApnFallback5, ServicePriorityWwan = ServicePriorityWwan5
                },
                new QpImsRegConfigDbItem2()
                {
                    RatApnFallback = RatApnFallback6, ServicePriorityWwan = ServicePriorityWwan6
                },
                new QpImsRegConfigDbItem2()
                {
                    RatApnFallback = RatApnFallback7, ServicePriorityWwan = ServicePriorityWwan7
                },
                new QpImsRegConfigDbItem2()
                {
                    RatApnFallback = RatApnFallback8, ServicePriorityWwan = ServicePriorityWwan8
                },
                new QpImsRegConfigDbItem2()
                {
                    RatApnFallback = RatApnFallback9, ServicePriorityWwan = ServicePriorityWwan9
                },
                new QpImsRegConfigDbItem2()
                {
                    RatApnFallback = RatApnFallback10, ServicePriorityWwan = ServicePriorityWwan10
                }
            };
            set
            {
                if (value != null)
                {
                    if (value.Length > 0)
                    {
                        var val = value[0];
                        RatApnFallback1 = val.RatApnFallback;
                        ServicePriorityWwan1 = val.ServicePriorityWwan;
                    }
                    if (value.Length > 1)
                    {
                        var val = value[1];
                        RatApnFallback2 = val.RatApnFallback;
                        ServicePriorityWwan2 = val.ServicePriorityWwan;
                    }
                    if (value.Length > 2)
                    {
                        var val = value[2];
                        RatApnFallback3 = val.RatApnFallback;
                        ServicePriorityWwan3 = val.ServicePriorityWwan;
                    }
                    if (value.Length > 3)
                    {
                        var val = value[3];
                        RatApnFallback4 = val.RatApnFallback;
                        ServicePriorityWwan4 = val.ServicePriorityWwan;
                    }
                    if (value.Length > 4)
                    {
                        var val = value[4];
                        RatApnFallback5 = val.RatApnFallback;
                        ServicePriorityWwan5 = val.ServicePriorityWwan;
                    }
                    if (value.Length > 5)
                    {
                        var val = value[5];
                        RatApnFallback6 = val.RatApnFallback;
                        ServicePriorityWwan6 = val.ServicePriorityWwan;
                    }
                    if (value.Length > 6)
                    {
                        var val = value[6];
                        RatApnFallback7 = val.RatApnFallback;
                        ServicePriorityWwan7 = val.ServicePriorityWwan;
                    }
                    if (value.Length > 7)
                    {
                        var val = value[7];
                        RatApnFallback8 = val.RatApnFallback;
                        ServicePriorityWwan8 = val.ServicePriorityWwan;
                    }
                    if (value.Length > 8)
                    {
                        var val = value[8];
                        RatApnFallback9 = val.RatApnFallback;
                        ServicePriorityWwan9 = val.ServicePriorityWwan;
                    }
                    if (value.Length > 9)
                    {
                        var val = value[9];
                        RatApnFallback10 = val.RatApnFallback;
                        ServicePriorityWwan10 = val.ServicePriorityWwan;
                    }
                }
            }
        }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort AllowedImsSrvOnWlan { get; set; }

        public string AllowedImsSrvOnWlanString
        {
            get => $"{(ImsServiceInfoValues) AllowedImsSrvOnWlan}";
            set => AllowedImsSrvOnWlan = (ushort) Enum.Parse(typeof(ImsServiceInfoValues), value);
        }


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

        [JsonIgnore]
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

        [JsonIgnore]
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

        [JsonIgnore]
        public string ApnName3String
        {
            get => StringUtils.GetString(ApnName3);
            set => ApnName3 = StringUtils.GetBytes(value, 50);
        }

        public string[] ApnNames
        {
            get => new[] {ApnName1String, ApnName2String, ApnName3String};
            set
            {
                if (value != null)
                {
                    if (value.Length > 0)
                    {
                        ApnName1String = value[0];
                    }
                    if (value.Length > 1)
                    {
                        ApnName2String = value[1];
                    }
                    if (value.Length > 2)
                    {
                        ApnName3String = value[2];
                    }
                }
            }
        }

        [ElementsCount(754)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] ReservedBytes { get; set; }
    }
}