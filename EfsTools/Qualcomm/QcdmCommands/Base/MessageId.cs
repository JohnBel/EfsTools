using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfsTools.Qualcomm.QcdmCommands.Base
{
    internal enum MessageId
    {
        LEGACY = 0,
        AUDFMT = 1,
        AVS = 2,
        BOOT = 3,
        BT = 4,
        CM = 5,
        CMX = 6,
        DIAG = 7,
        DSM = 8,
        FS = 9,
        HS = 10,
        MDSP = 11,
        QDSP = 12,
        REX = 13,
        RF = 14,
        SD = 15,
        SIO = 16,
        VS = 17,
        WMS = 18,
        GPS = 19,
        MMOC = 20,
        RUIM = 21,
        TMC = 22,
        FTM = 23,
        MMGPS = 24,
        SLEEP = 25,
        SAM = 26,
        SRM = 27,
        SFAT = 28,
        JOYST = 29,
        MFLO = 30,
        DTV = 31,
        TCXOMGR = 32,
        EFS = 33,
        IRDA = 34,
        FM_RADIO = 35,
        AAM = 36,
        BM = 37,
        PE = 38,
        QIPCALL = 39,
        FLUTE = 40,
        CAMERA = 41,
        HSUSB = 42,
        FC = 43,
        USBHOST = 44,
        PROFILER = 45,
        MGP = 46,
        MGPME = 47,
        GPSOS = 48,
        MGPPE = 49,
        GPSSM = 50,
        IMS = 51,
        MBP_RF = 52,
        SNS = 53,
        WM = 54,
        LK = 55,
        PWRDB = 56,
        DCVS = 57,
        ANDROID_ADB = 58,
        VIDEO_ENCODER = 59,
        VENC_OMX = 60,
        GAN = 61, /* Generic Access Network */
        KINETO_GAN = 62,
        ANDROID_QCRIL = 63,
        A2 = 64,
        LINUX_DATA = 65,
        ECALL = 66,
        CHORD = 67,
        QCNE = 68,
        CAD_GENERAL = 69,
        OMADM = 70, /* OMA device management */
        SIWA = 71, /* Secure Instant Wireless Access */
        APR_MODEM = 72, /* Audio Packet Router Modem */
        APR_APPS = 73, /* Audio Packet Router Apps*/
        APR_ADSP = 74, /* Audio Packet Router Adsp*/
        SRD_GENERAL = 75,
        ACDB_GENERAL = 76,
        DALTF = 77, /* DAL Test Frame Work */
        CFM = 78, /* Centralized Flow Control Manager */
        PMIC = 79, /* PMIC SSID */
        GPS_SDP = 80,
        TLE = 81,
        TLE_XTM = 82,
        TLE_TLM = 83,
        TLE_TLM_MM = 84,
        WWAN_LOC = 85,
        GNSS_LOCMW = 86,
        QSET = 87,
        QBI = 88,
        ADC = 89,
        MMODE_QMI = 90,
        MCFG = 91,
        SSM = 92,
        MPOWER = 93,
        RMTS = 94,
        ADIE = 95,
        VT_VCEL = 96,
        FLASH_SCRUB = 97,
        STRIDE = 98,
        POLICYMAN = 99,
        TMS = 100,
        LWIP = 101,
        RFS = 102,
        RFS_ACCESS = 103,
        RLC = 104,
        MEMHEAP = 105,
        WCI2 = 106,
        LOWI_TEST = 107,
        AOSTLM = 108,
        LOWI_AP = 109,
        LOWI_MP = 110,
        LOWI_LP = 111,

        GEN_LAST = 111,


/* Messages arising from ONCRPC AMSS modules */
        ONCRPC = 500,
        ONCRPC_MISC_MODEM = 501,
        ONCRPC_MISC_APPS = 502,
        ONCRPC_CM_MODEM = 503,
        ONCRPC_CM_APPS = 504,
        ONCRPC_DB = 505,
        ONCRPC_SND = 506,

/* Default master category for = 1,X. */
        F1X = 1000,
        F1X_ACP = 1001,
        F1X_DCP = 1002,
        F1X_DEC = 1003,
        F1X_ENC = 1004,
        F1X_GPSSRCH = 1005,
        F1X_MUX = 1006,
        F1X_SRCH = 1007,


/* Default master category for HDR. */
        HDR_PROT = 2000,
        HDR_DATA = 2001,
        HDR_SRCH = 2002,
        HDR_DRIVERS = 2003,
        HDR_IS890 = 2004,
        HDR_DEBUG = 2005,
        HDR_HIT = 2006,
        HDR_PCP = 2007,
        HDR_HEAPMEM = 2008,


/* Default master category for UMTS. */
        UMTS = 3000,
        WCDMA_L1 = 3001,
        WCDMA_L2 = 3002,
        WCDMA_MAC = 3003,
        WCDMA_RLC = 3004,
        WCDMA_RRC = 3005,
        NAS_CNM = 3006,
        NAS_MM = 3007,
        NAS_MN = 3008,
        NAS_RABM = 3009,
        NAS_REG = 3010,
        NAS_SM = 3011,
        NAS_TC = 3012,
        NAS_CB = 3013,
        WCDMA_LEVEL = 3014,


/* Default master category for GSM. */
        GSM = 4000,
        GSM_L1 = 4001,
        GSM_L2 = 4002,
        GSM_RR = 4003,
        GSM_GPRS_GCOMMON = 4004,
        GSM_GPRS_GLLC = 4005,
        GSM_GPRS_GMAC = 4006,
        GSM_GPRS_GPL1 = 4007,
        GSM_GPRS_GRLC = 4008,
        GSM_GPRS_GRR = 4009,
        GSM_GPRS_GSNDCP = 4010,


        WLAN = 4500,
        WLAN_ADP = 4501,
        WLAN_CP = 4502,
        WLAN_FTM = 4503,
        WLAN_OEM = 4504,
        WLAN_SEC = 4505,
        WLAN_TRP = 4506,
        WLAN_RESERVED_1 = 4507,
        WLAN_RESERVED_2 = 4508,
        WLAN_RESERVED_3 = 4509,
        WLAN_RESERVED_4 = 4510,
        WLAN_RESERVED_5 = 4511,
        WLAN_RESERVED_6 = 4512,
        WLAN_RESERVED_7 = 4513,
        WLAN_RESERVED_8 = 4514,
        WLAN_RESERVED_9 = 4515,
        WLAN_RESERVED_10 = 4516,
        WLAN_TL = 4517,
        WLAN_BAL = 4518,
        WLAN_SAL = 4519,
        WLAN_SSC = 4520,
        WLAN_HDD = 4521,
        WLAN_SME = 4522,
        WLAN_PE = 4523,
        WLAN_HAL = 4524,
        WLAN_SYS = 4525,
        WLAN_VOSS = 4526,


        ATS = 4600,
        MSGR = 4601,
        APPMGR = 4602,
        QTF = 4603,
        FWS = 4604,
        SRCH4 = 4605,
        CMAPI = 4606,
        MMAL = 4607,
        MCS_RESERVED_5 = 4608,
        MCS_RESERVED_6 = 4609,
        MCS_RESERVED_7 = 4610,
        MCS_RESERVED_8 = 4611,
        IRATMAN = 4612,
        CXM = 4613,
        VSTMR = 4614,
        CFCM = 4615,


/* Default master category for data services. */
        DS = 5000,
        DS_RLP = 5001,
        DS_PPP = 5002,
        DS_TCPIP = 5003,
        DS_IS707 = 5004,
        DS_3GMGR = 5005,
        DS_PS = 5006,
        DS_MIP = 5007,
        DS_UMTS = 5008,
        DS_GPRS = 5009,
        DS_GSM = 5010,
        DS_SOCKETS = 5011,
        DS_ATCOP = 5012,
        DS_SIO = 5013,
        DS_BCMCS = 5014,
        DS_MLRLP = 5015,
        DS_RTP = 5016,
        DS_SIPSTACK = 5017,
        DS_ROHC = 5018,
        DS_DOQOS = 5019,
        DS_IPC = 5020,
        DS_SHIM = 5021,
        DS_ACLPOLICY = 5022,
        DS_APPS = 5023,
        DS_MUX = 5024,
        DS_3GPP = 5025,
        DS_LTE = 5026,
        DS_WCDMA = 5027,
        DS_ACLPOLICY_APPS = 5028, /* ACL POLICY */
        DS_HDR = 5029,
        DS_IPA = 5030,
        DS_EPC = 5031,


/* Default master category for Security. */
        SEC = 5500,
        SEC_CRYPTO = 5501, /* Cryptography */
        SEC_SSL = 5502, /* Secure Sockets Layer */
        SEC_IPSEC = 5503, /* Internet Protocol Security */
        SEC_SFS = 5504, /* Secure File System */
        SEC_TEST = 5505, /* Security Test Subsystem */
        SEC_CNTAGENT = 5506, /* Content Agent Interface */
        SEC_RIGHTSMGR = 5507, /* Rights Manager Interface */
        SEC_ROAP = 5508, /* Rights Object Aquisition Protocol */
        SEC_MEDIAMGR = 5509, /* Media Manager Interface */
        SEC_IDSTORE = 5510, /* ID Store Interface */
        SEC_IXFILE = 5511, /* File interface */
        SEC_IXSQL = 5512, /* SQL interface */
        SEC_IXCOMMON = 5513, /* Common Interface */
        SEC_BCASTCNTAGENT = 5514, /* Broadcast Content Agent Interface */
        SEC_PLAYREADY = 5515, /* Broadcast Content Agent Interface */
        SEC_WIDEVINE = 5516, /* Broadcast Content Agent Interface */


/* Default master category for applications. */
        APPS = 6000,
        APP_APPMGR = 6001,
        UI = 6002,
        QTV = 6003,
        QVP = 6004,
        QVP_STATISTICS = 6005,
        QVP_VENCODER = 6006,
        QVP_MODEM = 6007,
        QVP_UI = 6008,
        QVP_STACK = 6009,
        QVP_VDECODER = 6010,
        ACM = 6011,
        HEAP_PROFILE = 6012,
        QTV_GENERAL = 6013,
        QTV_DEBUG = 6014,
        QTV_STATISTICS = 6015,
        QTV_UI_TASK = 6016,
        QTV_MP4_PLAYER = 6017,
        QTV_AUDIO_TASK = 6018,
        QTV_VIDEO_TASK = 6019,
        QTV_STREAMING = 6020,
        QTV_MPEG4_TASK = 6021,
        QTV_FILE_OPS = 6022,
        QTV_RTP = 6023,
        QTV_RTCP = 6024,
        QTV_RTSP = 6025,
        QTV_SDP_PARSE = 6026,
        QTV_ATOM_PARSE = 6027,
        QTV_TEXT_TASK = 6028,
        QTV_DEC_DSP_IF = 6029,
        QTV_STREAM_RECORDING = 6030,
        QTV_CONFIGURATION = 6031,
        QCAMERA = 6032,
        QCAMCORDER = 6033,
        BREW = 6034,
        QDJ = 6035,
        QDTX = 6036,
        QTV_BCAST_FLO = 6037,
        MDP_GENERAL = 6038,
        PBM = 6039,
        GRAPHICS_GENERAL = 6040,
        GRAPHICS_EGL = 6041,
        GRAPHICS_OPENGL = 6042,
        GRAPHICS_DIRECT3D = 6043,
        GRAPHICS_SVG = 6044,
        GRAPHICS_OPENVG = 6045,
        GRAPHICS_2D = 6046,
        GRAPHICS_QXPROFILER = 6047,
        GRAPHICS_DSP = 6048,
        GRAPHICS_GRP = 6049,
        GRAPHICS_MDP = 6050,
        CAD = 6051,
        IMS_DPL = 6052,
        IMS_FW = 6053,
        IMS_SIP = 6054,
        IMS_REGMGR = 6055,
        IMS_RTP = 6056,
        IMS_SDP = 6057,
        IMS_VS = 6058,
        IMS_XDM = 6059,
        IMS_HOM = 6060,
        IMS_IM_ENABLER = 6061,
        IMS_IMS_CORE = 6062,
        IMS_FWAPI = 6063,
        IMS_SERVICES = 6064,
        IMS_POLICYMGR = 6065,
        IMS_PRESENCE = 6066,
        IMS_QIPCALL = 6067,
        IMS_SIGCOMP = 6068,
        IMS_PSVT = 6069,
        IMS_UNKNOWN = 6070,
        IMS_SETTINGS = 6071,
        OMX_COMMON = 6072,
        IMS_RCS_CD = 6073,
        IMS_RCS_IM = 6074,
        IMS_RCS_FT = 6075,
        IMS_RCS_IS = 6076,
        IMS_RCS_AUTO_CONFIG = 6077,
        IMS_RCS_COMMON = 6078,
        IMS_UT = 6079,
        IMS_XML = 6080,


/* Default master category for aDSP Tasks. */
        ADSPTASKS = 6500,
        ADSPTASKS_KERNEL = 6501,
        ADSPTASKS_AFETASK = 6502,
        ADSPTASKS_VOICEPROCTASK = 6503,
        ADSPTASKS_VOCDECTASK = 6504,
        ADSPTASKS_VOCENCTASK = 6505,
        ADSPTASKS_VIDEOTASK = 6506,
        ADSPTASKS_VFETASK = 6507,
        ADSPTASKS_VIDEOENCTASK = 6508,
        ADSPTASKS_JPEGTASK = 6509,
        ADSPTASKS_AUDPPTASK = 6510,
        ADSPTASKS_AUDPLAY0TASK = 6511,
        ADSPTASKS_AUDPLAY1TASK = 6512,
        ADSPTASKS_AUDPLAY2TASK = 6513,
        ADSPTASKS_AUDPLAY3TASK = 6514,
        ADSPTASKS_AUDPLAY4TASK = 6515,
        ADSPTASKS_LPMTASK = 6516,
        ADSPTASKS_DIAGTASK = 6517,
        ADSPTASKS_AUDRECTASK = 6518,
        ADSPTASKS_AUDPREPROCTASK = 6519,
        ADSPTASKS_MODMATHTASK = 6520,
        ADSPTASKS_GRAPHICSTASK = 6521,


/* Messages arising from Linux on L4, or its drivers or applications. */
        L4LINUX_KERNEL = 7000,
        L4LINUX_KEYPAD = 7001,
        L4LINUX_APPS = 7002,
        L4LINUX_QDDAEMON = 7003,

/* Messages arising from Iguana on L4, or its servers and drivers. */
        L4IGUANA_IGUANASERVER = 7100, /* Iguana Server itself */
        L4IGUANA_EFS2 = 7101, /* platform/apps stuff */
        L4IGUANA_QDMS = 7102,
        L4IGUANA_REX = 7103,
        L4IGUANA_SMMS = 7104,
        L4IGUANA_FRAMEBUFFER = 7105, /* platform/iguana stuff */
        L4IGUANA_KEYPAD = 7106,
        L4IGUANA_NAMING = 7107,
        L4IGUANA_SDIO = 7108,
        L4IGUANA_SERIAL = 7109,
        L4IGUANA_TIMER = 7110,
        L4IGUANA_TRAMP = 7111,

/* Messages arising from L4-specific AMSS modules */
        L4AMSS_QDIAG = 7200,
        L4AMSS_APS = 7201,


/* Default master category for HIT. */
        HIT = 8000,
        HIT_LAST = 8000,


/* Default master category for Q6 */
        QDSP6 = 8500,
        ADSP_AUD_SVC = 8501, /* Audio Service */
        ADSP_AUD_ENCDEC = 8502, /* audio encoders/decoders */
        ADSP_AUD_VOC = 8503, /* voice encoders/decoders */
        ADSP_AUD_VS = 8504, /* voice services */
        ADSP_AUD_MIDI = 8505, /* MIDI-based file formats */
        ADSP_AUD_POSTPROC = 8506, /* e.g. Graph EQ, Spec Analyzer */
        ADSP_AUD_PREPROC = 8507, /* e.g. AGC-R */
        ADSP_AUD_AFE = 8508, /* audio front end */
        ADSP_AUD_MSESSION = 8509, /* media session */
        ADSP_AUD_DSESSION = 8510, /* device session */
        ADSP_AUD_DCM = 8511, /* device configuration */
        ADSP_VID_ENC = 8512, /* Video Encoder */
        ADSP_VID_ENCRPC = 8513, /* Video Encoder DAL driver */
        ADSP_VID_DEC = 8514, /* Video Decoder */
        ADSP_VID_DECRPC = 8515, /* Video Decoder DAL driver */
        ADSP_VID_COMMONSW = 8516, /* Video Common Software Units */
        ADSP_VID_HWDRIVER = 8517, /* Video Hardware */
        ADSP_JPG_ENC = 8518, /* JPEG Encoder */
        ADSP_JPG_DEC = 8519, /* JPEG Decoder */
        ADSP_OMM = 8520, /* openmm */
        ADSP_PWRDEM = 8521, /* Power or DEM messages */
        ADSP_RESMGR = 8522, /* Resource Manager */
        ADSP_CORE = 8523, /* General core (startup, heap stats, etc.) */
        ADSP_RDA = 8524,


/* Default master category for UMB. */
        UMB = 9000,
        UMB_APP = 9001, /* UMB Application component */
        UMB_DS = 9002, /* UMB Data Services component */
        UMB_CP = 9003, /* UMB Call Processing component */
        UMB_RLL = 9004, /* UMB Radio Link Layer component */
        UMB_MAC = 9005, /* UMB MAC component */
        UMB_SRCH = 9006, /* UMB SRCH component */
        UMB_FW = 9007, /* UMB Firmware component */
        UMB_PLT = 9008, /* UMB PLT component */

/* Default master category for LTE. */
        LTE = 9500,
        LTE_RRC = 9501,
        LTE_MACUL = 9502,
        LTE_MACDL = 9503,
        LTE_MACCTRL = 9504,
        LTE_RLCUL = 9505,
        LTE_RLCDL = 9506,
        LTE_PDCPUL = 9507,
        LTE_PDCPDL = 9508,
        LTE_ML1 = 9509,
        LTE_DISCOVERY = 9510,

/*======================================================================================
 * SSIDs for Octopus Base Station Simulator. Although it needs only QXDM side changes
 * diag needs to be updated to keep it consistent with the QXDM database. OCTOPUS team
 * wanted the code changes reverted. They wanted to reserve the codes instead.
 * RESERVED = 9700, TILL = 10199,
 *====================================================================================*/


/* Default master category for QCHAT */

        QCHAT = 10200,
        QCHAT_CAPP = 10201,
        QCHAT_CENG = 10202,
        QCHAT_CREG = 10203,
        QCHAT_CMED = 10204,
        QCHAT_CAUTH = 10205,
        QCHAT_QBAL = 10206,
        QCHAT_OSAL = 10207,
        QCHAT_OEMCUST = 10208,
        QCHAT_MULTI_PROC = 10209,
        QCHAT_UPK = 10210,

/* Default master category for TDSCDMA */
        TDSCDMA_L1 = 10251,
        TDSCDMA_L2 = 10252,
        TDSCDMA_MAC = 10253,
        TDSCDMA_RLC = 10254,
        TDSCDMA_RRC = 10255,

/* Messages from the CTA framework */
        CTA = 10300,

/* QCNEA related SSIDs */
        QCNEA = 10350,
        QCNEA_CAC = 10351,
        QCNEA_CORE = 10352,
        QCNEA_CORE_CAS = 10353,
        QCNEA_CORE_CDE = 10354,
        QCNEA_CORE_COM = 10355,
        QCNEA_CORE_LEE = 10356,
        QCNEA_CORE_QMI = 10357,
        QCNEA_CORE_SRM = 10358,
        QCNEA_GENERIC = 10359,
        QCNEA_NETLINK = 10360,
        QCNEA_NIMS = 10361,
        QCNEA_NSRM = 10362,
        QCNEA_NSRM_CORE = 10363,
        QCNEA_NSRM_GATESM = 10364,
        QCNEA_NSRM_TRG = 10365,
        QCNEA_PLCY = 10366,
        QCNEA_PLCY_ANDSF = 10367,
        QCNEA_TEST = 10368,
        QCNEA_WQE = 10369,
        QCNEA_WQE_BQE = 10370,
        QCNEA_WQE_CQE = 10371,
        QCNEA_WQE_ICD = 10372,
        QCNEA_WQE_IFSEL = 10373,
        QCNEA_WQE_IFSELRSM = 10374,
        QCNEA_ATP = 10375,
        QCNEA_ATP_PLCY = 10376,
        QCNEA_ATP_RPRT = 10377,


/* DPM related SSIDs */
        DPM = 10400,
        DPM_COMMON = 10401,
        DPM_COM = 10402,
        DPM_QMI = 10403,
        DPM_DSM = 10404,
        DPM_CONFIG = 10405,
        DPM_GENERIC = 10406,
        DPM_NETLINK = 10407,
        DPM_FD_MGR = 10408,
        DPM_CT_MGR = 10409,
        DPM_NSRM = 10410,
        DPM_NSRM_CORE = 10411,
        DPM_NSRM_GATESM = 10412,
        DPM_NSRM_TRG = 10413,
        DPM_TEST = 10414,
        DPM_TCM = 10415
    }
}