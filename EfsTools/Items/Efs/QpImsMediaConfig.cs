using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    public enum VideoResolutionValues : byte
    {
        Invalid = 0,
        Sqcif = 1,
        Qcif = 2,
        Cif = 3,
        Qqvga = 4,
        Qvga = 5,
        Vga = 6
    }

    public enum VideoCodecValues : byte
    {
        Invalid = 0,
        Mpeg4Xvid = 1,
        Mpeg4 = 2,
        H263 = 3,
        H264 = 4
    }

    public enum H264ProfileValues : byte
    {
        Invalid = 0,
        Baseline = 1,
        Main = 2,
        Extended = 3,
        High = 4
    }

    public enum H264ProfileLevelValues : byte
    {
        Invalid = 0,
        Level1 = 1,
        Level1B = 2,
        Level11 = 3,
        Level12 = 4,
        Level13 = 5,
        Level2 = 6,
        Level21 = 7,
        Level22 = 8,
        Level3 = 9,
        Level31 = 10,
        Level32 = 11,
        Level4 = 12,
        Level41 = 13,
        Level42 = 14,
        Level5 = 15,
        Level51 = 16
    }

    [Serializable]
    [NvItemId(67332)]
    [Subscription]
    [EfsFile("/nv/item_files/ims/qp_ims_media_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QpImsMediaConfig
    {
        public QpImsMediaConfig()
        {
            Reserved = new byte[498];
        }

        [Required]
        public byte Version { get; set; }


        [JsonIgnore]
        public byte VideoResolution { get; set; }

        public string VideoResolutionString
        {
            get => $"{(VideoResolutionValues) VideoResolution}";
            set => VideoResolution = EnumUtils.ParseEnumByte(typeof(VideoResolutionValues), value);
        }


        public ushort VideoEncodingBitRate { get; set; }


        public byte FramesPerSecond { get; set; }

        [JsonIgnore]
        public byte VideoCodec { get; set; }

        public string VideoCodecString
        {
            get => $"{(VideoCodecValues) VideoCodec}";
            set => VideoCodec = EnumUtils.ParseEnumByte(typeof(VideoCodecValues), value);
        }


        public byte Sar { get; set; }


        public byte Par { get; set; }


        [JsonIgnore]
        public byte H264Profile { get; set; }

        public string H264ProfileString
        {
            get => $"{(H264ProfileValues) H264Profile}";
            set => H264Profile = EnumUtils.ParseEnumByte(typeof(H264ProfileValues), value);
        }

        [JsonIgnore]
        public byte H264ProfileLevel { get; set; }

        public string H264ProfileLevelString
        {
            get => $"{(H264ProfileLevelValues) H264ProfileLevel}";
            set => H264ProfileLevel = EnumUtils.ParseEnumByte(typeof(H264ProfileLevelValues), value);
        }


        public ushort IpSyncDropUpperLimit { get; set; }


        public ushort IpSyncDropLowerLimit { get; set; }


        public byte IpSyncEnabled { get; set; }


        public byte QdjTimeWrapping { get; set; }


        public byte QdjIbaMax { get; set; }


        public byte QdjMaxFramesAtStart { get; set; }


        public byte QdjMaxDelay { get; set; }


        public byte QdjMinDelay { get; set; }


        public byte QdjDelayByFrameCount { get; set; }


        public byte QdjMaxFramesAtRun { get; set; }


        public byte QdjMaxBumpedUpDelay { get; set; }


        public byte QdjJitterIncrement { get; set; }


        public ushort QdjTargetUnderflow { get; set; }


        public ushort QdjDefaultJitter { get; set; }


        public ushort QdjGoThroughThreshold { get; set; }


        public ushort QdjDropThreshold { get; set; }


        public byte Qmin { get; set; }


        public byte TxSystemDelay { get; set; }


        public byte RxSystemDelay { get; set; }


        [FieldCount(500)]
        public byte[] Reserved { get; set; }
    }
}

//typedef enum {
//  IMS_SETTINGS_H264_LEVEL_ENUM_MIN_ENUM_VAL_V01 = -2147483647, /**< To force a 32 bit signed enum.  Do not change or use*/
//  IMS_SETTINGS_H264_LEVEL1_V01 = 0x00, /**<  Level 1 */
//  IMS_SETTINGS_H264_LEVEL1B_V01 = 0x01, /**<  Level 1b */
//  IMS_SETTINGS_H264_LEVEL11_V01 = 0x02, /**<  Level 1.1 */
//  IMS_SETTINGS_H264_LEVEL12_V01 = 0x03, /**<  Level 1.2 */
//  IMS_SETTINGS_H264_LEVEL13_V01 = 0x04, /**<  Level 1.3 */
//  IMS_SETTINGS_H264_LEVEL2_V01 = 0x05, /**<  Level 2 */
//  IMS_SETTINGS_H264_LEVEL21_V01 = 0x06, /**<  Level 2.1 */
//  IMS_SETTINGS_H264_LEVEL22_V01 = 0x07, /**<  Level 2.2 */
//  IMS_SETTINGS_H264_LEVEL3_V01 = 0x08, /**<  Level 3 */
//  IMS_SETTINGS_H264_LEVEL31_V01 = 0x09, /**<  Level 3.1 */
//  IMS_SETTINGS_H264_LEVEL32_V01 = 0x0A, /**<  Level 3.2 */
//  IMS_SETTINGS_H264_LEVEL4_V01 = 0x0B, /**<  Level 4 */
//  IMS_SETTINGS_H264_LEVEL41_V01 = 0x0C, /**<  Level 4.1 */
//  IMS_SETTINGS_H264_LEVEL42_V01 = 0x0D, /**<  Level 4.2 */
//  IMS_SETTINGS_H264_LEVEL5_V01 = 0x0E, /**<  Level 5 */
//  IMS_SETTINGS_H264_LEVEL51_V01 = 0x0F, /**<  Level 5.1 */
//  IMS_SETTINGS_H264_LEVEL_ENUM_MAX_ENUM_VAL_V01 = 2147483647 /**< To force a 32 bit signed enum.  Do not change or use*/
//}ims_settings_h264_level_enum_v01;
///**
//    @}
//  */

///** @addtogroup imss_qmi_enums
//    @{
//  */
//typedef enum {
//  IMS_VIDEO_RESOLUTION_ENUM_MIN_ENUM_VAL_V01 = -2147483647, /**< To force a 32 bit signed enum.  Do not change or use*/
//  IMS_SETTINGS_SQCIF_RESOLUTION_V01 = 0x00, /**<  SQCIF */
//  IMS_SETTINGS_QCIF_RESOLUTION_V01 = 0x01, /**<  QCIF */
//  IMS_SETTINGS_CIF_RESOLUTION_V01 = 0x02, /**<  CIF */
//  IMS_SETTINGS_QQVGA_RESOLUTION_V01 = 0x03, /**<  QQVGA */
//  IMS_SETTINGS_QVGA_RESOLUTION_V01 = 0x04, /**<  QVGA */
//  IMS_SETTINGS_VGA_RESOLUTION_V01 = 0x05, /**<  VGA  */
//  IMS_VIDEO_RESOLUTION_ENUM_MAX_ENUM_VAL_V01 = 2147483647 /**< To force a 32 bit signed enum.  Do not change or use*/
//}ims_video_resolution_enum_v01;
///**
//    @}
//  */

///** @addtogroup imss_qmi_enums
//    @{
//  */
//typedef enum {
//  IMS_SETTINGS_VIDEO_CODEC_ENUM_MIN_ENUM_VAL_V01 = -2147483647, /**< To force a 32 bit signed enum.  Do not change or use*/
//  IMS_SETTINGS_CODEC_MPEG4_XVID_V01 = 0x00, /**<  XVID MPEG4 codec */
//  IMS_SETTINGS_CODEC_MPEG4_ISO_V01 = 0x01, /**<  ISO MPEG4 codec */
//  IMS_SETTINGS_CODEC_H263_V01 = 0x02, /**<  H.263 codec */
//  IMS_SETTINGS_CODEC_H264_V01 = 0x03, /**<  H.264 codec */
//  IMS_SETTINGS_VIDEO_CODEC_ENUM_MAX_ENUM_VAL_V01 = 2147483647 /**< To force a 32 bit signed enum.  Do not change or use*/
//}ims_settings_video_codec_enum_v01;
///**
//    @}
//  */

///** @addtogroup imss_qmi_enums
//    @{
//  */
//typedef enum {
//  IMS_SETTINGS_CONFIG_AUTH_SCHEME_ENUM_MIN_ENUM_VAL_V01 = -2147483647, /**< To force a 32 bit signed enum.  Do not change or use*/
//  IMS_SETTINGS_CONFIG_AUTH_SCHEME_NONE_V01 = 0x00, /**<  No scheme used  */
//  IMS_SETTINGS_CONFIG_AUTH_SCHEME_DIGEST_V01 = 0x01, /**<  Digest  */
//  IMS_SETTINGS_CONFIG_AUTH_SCHEME_SAG_V01 = 0x02, /**<  Token  */
//  IMS_SETTINGS_CONFIG_AUTH_SCHEME_AKA_V01 = 0x03, /**<  AKA  */
//  IMS_SETTINGS_CONFIG_AUTH_SCHEME_CAVE_V01 = 0x04, /**<  CAVE  */
//  IMS_SETTINGS_CONFIG_AUTH_SCHEME_AKAV2_V01 = 0x05, /**<  AKAv2  */
//  IMS_SETTINGS_CONFIG_AUTH_SCHEME_ENUM_MAX_ENUM_VAL_V01 = 2147483647 /**< To force a 32 bit signed enum.  Do not change or use*/
//}ims_settings_config_auth_scheme_enum_v01;
///**
//    @}
//  */

///** @addtogroup imss_qmi_enums
//    @{
//  */
//typedef enum {
//  IMS_SETTINGS_CONFIG_INITIAL_AUTH_TYPE_ENUM_MIN_ENUM_VAL_V01 = -2147483647, /**< To force a 32 bit signed enum.  Do not change or use*/
//  IMS_SETTINGS_CONFIG_INITIAL_AUTH_NONE_V01 = 0x00, /**<  None  */
//  IMS_SETTINGS_CONFIG_INITIAL_AUTH_AUTHORIZATION_V01 = 0x01, /**<  Authorization  */
//  IMS_SETTINGS_CONFIG_INITIAL_AUTH_PROXY_AUTHORIZATION_V01 = 0x02, /**<  Proxy authorization  */
//  IMS_SETTINGS_CONFIG_INITIAL_AUTH_TYPE_ENUM_MAX_ENUM_VAL_V01 = 2147483647 /**< To force a 32 bit signed enum.  Do not change or use*/
//}ims_settings_config_initial_auth_type_enum_v01;
///**
//    @}
//  */

///** @addtogroup imss_qmi_enums
//    @{
//  */
//typedef enum {
//  IMS_SETTINGS_REGMGR_CONFIG_MODE_ENUM_MIN_ENUM_VAL_V01 = -2147483647, /**< To force a 32 bit signed enum.  Do not change or use*/
//  IMS_SETTINGS_REGMGR_CONFIG_IETF_V01 = 0x00, /**<  IETF Configuration mode */
//  IMS_SETTINGS_REGMGR_CONFIG_EARLY_IMS_V01 = 0x01, /**<  Early IMS Configuration mode */
//  IMS_SETTINGS_REGMGR_CONFIG_IMS_V01 = 0x02, /**<  IMS Configuration mode */
//  IMS_SETTINGS_REGMGR_CONFIG_IMS_NO_IPSEC_V01 = 0x03, /**<  IMS No IPSec Configuration mode */
//  IMS_SETTINGS_REGMGR_CONFIG_IMS_NONE_V01 = 0x04, /**<  No configuration mode */
//  IMS_SETTINGS_REGMGR_CONFIG_MODE_ENUM_MAX_ENUM_VAL_V01 = 2147483647 /**< To force a 32 bit signed enum.  Do not change or use*/
//}ims_settings_regmgr_config_mode_enum_v01;
///**
//    @}
//  */

///** @addtogroup imss_qmi_enums
//    @{
//  */
//typedef enum {
//  IMS_SETTINGS_QIPCALL_VT_QUALITY_ENUM_MIN_ENUM_VAL_V01 = -2147483647, /**< To force a 32 bit signed enum.  Do not change or use*/
//  IMS_SETTINGS_VT_QUALITY_LEVEL_0_V01 = 0x00, /**<  VT Quality Selector Level 0  */
//  IMS_SETTINGS_VT_QUALITY_LEVEL_1_V01 = 0x01, /**<  VT Quality Selector Level 1  */
//  IMS_SETTINGS_QIPCALL_VT_QUALITY_ENUM_MAX_ENUM_VAL_V01 = 2147483647 /**< To force a 32 bit signed enum.  Do not change or use*/
//}ims_settings_qipcall_vt_quality_enum_v01;
///**
//    @}
//  */

///** @addtogroup imss_qmi_enums
//    @{
//  */
//typedef enum {
//  IMS_SETTINGS_IP_ADDR_TYPE_ENUM_MIN_ENUM_VAL_V01 = -2147483647, /**< To force a 32 bit signed enum.  Do not change or use*/
//  IMS_SETTINGS_IP_TYPE_UNKNOWN_V01 = 0x00, /**<  Unknown IP address type   */
//  IMS_SETTINGS_IP_TYPE_IPV4_V01 = 0x01, /**<  IPv4 address  */
//  IMS_SETTINGS_IP_TYPE_IPV6_V01 = 0x02, /**<  IPv6 address  */
//  IMS_SETTINGS_IP_ADDR_TYPE_ENUM_MAX_ENUM_VAL_V01 = 2147483647 /**< To force a 32 bit signed enum.  Do not change or use*/
//}ims_settings_ip_addr_type_enum_v01;
///**
//    @}
//  */

//typedef uint64_t ims_settings_integ_algo_mask_v01;
//#define IMS_SETTINGS_INTEG_ALGO_HMAC_SHA_1_96_V01 ((ims_settings_integ_algo_mask_v01)0x01ull) /**<  HMAC-SHA-1-96 algorithm is used for IPSec integrity  */
//#define IMS_SETTINGS_INTEG_ALGO_HMAC_MD5_96_V01 ((ims_settings_integ_algo_mask_v01)0x02ull) /**<  HMAC-MD5-96 algorithm is used for IPSec integrity  */
//typedef uint64_t ims_settings_encrypt_algo_mask_v01;
//#define IMS_SETTINGS_ENCRYPT_ALGO_NULL_V01 ((ims_settings_encrypt_algo_mask_v01)0x01ull) /**<  NULL algorithm is used for IPSec encryption  */
//#define IMS_SETTINGS_ENCRYPT_ALGO_AES_CBC_V01 ((ims_settings_encrypt_algo_mask_v01)0x02ull) /**<  AES-CBC algorithm is used for IPSec encryption  */
//#define IMS_SETTINGS_ENCRYPT_ALGO_DES_EDE3_CBC_V01 ((ims_settings_encrypt_algo_mask_v01)0x04ull) /**<  DES-EDE3-CBC algorithm is used for IPSec encryption  */
//typedef uint64_t ims_settings_service_type_mask_v01;
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