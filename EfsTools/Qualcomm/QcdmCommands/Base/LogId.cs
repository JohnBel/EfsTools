using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfsTools.Qualcomm.QcdmCommands.Base
{
    internal enum LogId
    {
       LOG_1X_BASE = 0x1000,
       WCDMA_BASE = 0x4000,
       GSM_BASE = 0x5000,
       LBS_BASE = 0x6000,
       UMTS_BASE = 0x7000,
       TDMA_BASE = 0x8000,
       DTV_BASE = 0xA000,
       APPS_BASE = 0xB000,
       LTE_BASE = (0xB000 + 0x0010),
       LTE_LAST = 0xB1FF,
       WIMAX_BASE = 0xB400,
       DSP_BASE = 0xC000,
       TDSCDMA_BASE = 0xD000,
       TDSCDMA_LAST = 0xD1FF,


       TOOLS_BASE_C = 0xF000,

/* -------------------------------------------------------------------------
 * Log Codes
 *   These codes identify the kind of information contained in a log entry.
 *   They are used in conjunction with the 'code' field of the log entry
 *   header.  The data types associated with each code are defined below.
 * ------------------------------------------------------------------------- */

/* The upper 4 bits of the 16 bit log entry code specify which type
 * of equipment created the log entry. */

/* 0 Mobile Station temporal analyzer entry */
       TA = (0x0 + 0x1000),

/* 1 AGC values and closed loop power control entry */
       AGC_PCTL = (0x1 + 0x1000),

/* 2 Forward link frame rates and types entry */
       F_MUX1 = (0x2 + 0x1000),

/* 3 Reverse link frame rates and types entry */
       R_MUX1 = (0x3 + 0x1000),

/* 4 Access channel message entry */
       AC_MSG = (0x4 + 0x1000),

/* 5 Reverse link traffic channel message entry */
       R_TC_MSG = (0x5 + 0x1000),

/* 6 Sync channel message entry */
       SC_MSG = (0x6 + 0x1000),

/* 7 Paging channel message entry */
       PC_MSG = (0x7 + 0x1000),

/* 8 Forward link traffic channel message entry */
       F_TC_MSG = (0x8 + 0x1000),

/* 9 Forward link vocoder packet entry */
       VOC_FOR = (0x9 + 0x1000),

/* 10 Reverse link vocoder packet entry */
       VOC_REV = (0xA + 0x1000),

/* 11 Temporal analyzer finger info only */
       FING = (0xB + 0x1000),

/* 12 Searcher pathlog info (Reused old SRCH logtype) */
       SRCH = (0xC + 0x1000),

/* 13 Position and speed information read from ETAK */
       ETAK = (0xD + 0x1000),

/* 14 Markov frame statistics */
       MAR = (0xE + 0x1000),

/* 15 New and improved temporal analyzer searcher info */
       SRCH2 = (0xF + 0x1000),

/* 16 The Fujitsu handset information */
       HANDSET = (0x10 + 0x1000),

/* 17 Vocoder bit error rate mask */
       ERRMASK = (0x11 + 0x1000),

/* 18 Analog voice channel information */
       ANALOG_INFO = (0x12 + 0x1000),

/* 19 Access probe information */
       ACC_INFO = (0x13 + 0x1000),

/* 20 Position & speed info read from GPS receiver */
       GPS = (0x14 + 0x1000),

/* 21 Test Command information */
       TEST_CMD = (0x15 + 0x1000),

/* 22 Sparse (20ms) AGC / closed loop power control entry */
       S_AGC_PCTL = (0x16 + 0x1000),

/* 23 Notification of a band class change */
       BAND_CHANGE = (0x17 + 0x1000),

/* 24 DM debug messages, if being logged via log services */
       DBG_MSG = (0x18 + 0x1000),

/* 25 General temporal analyzer entry */
       GENRL_TA = (0x19 + 0x1000),

/* 26 General temporal analyzer w/supplemental channels */
       GENRL_TA_SUP_CH = (0x1A + 0x1000),

/* Featurization Removal requested by CMI
#ifdef FEATURE_PLT
*/

/* 27 Decoder raw bits logging */
       PLT = (0x1B + 0x1000),

/* Featurization Removal requested by CMI
#else
27 EFS Usage Info - No implementation as yet
LOG_EFS_INFO =                                (0x1B + 0x1000),
#endif
*/

/* 28 Analog Forward Channel */
       ANALOG_FORW = (0x1C + 0x1000),

/* 29 Analog Reverse Channel */
       ANALOG_REVS = (0x1D + 0x1000),

/* 30 Analog Handoff Entry */
       ANALOG_HANDOFF = (0x1E + 0x1000),

/* 31 FM Slot Statistis entry */
       ANALOG_FMSLOT = (0x1F + 0x1000),

/* 32 FOCC Word Sync Count entry */
       ANALOG_WS_COUNT = (0x20 + 0x1000),

/* 33 */
       RLP_PACKET = (0x21 + 0x1000),

/* 34 */
       ASYNC_TCP_SEG = (0x22 + 0x1000),

/* 35 */
       PACKET_DATA_IP_PACKETS = (0x23 + 0x1000),

/* 36 */
       FNBDT_MESSAGE_LOG = (0x24 + 0x1000),

/* Begin IS-2000 LOG features */

/* 37 RLP RX Frames logging */
       RLP_RX_FRAMES = (0x25 + 0x1000),

/* 38 RLP TX Frames logging */
       RLP_TX_FRAMES = (0x26 + 0x1000),

/* 39 Reserved for additions to RLP frames */
       RLP_RSVD1 = (0x27 + 0x1000),

/* 40 Reserved for additions to RLP frames */
       RLP_RSVD2 = (0x28 + 0x1000),

/* 41 Forward Link Frame Types logging */
       FWD_FRAME_TYPES = (0x29 + 0x1000),

/* 42 Reverse Link Frame Types logging */
       REV_FRAME_TYPES = (0x2A + 0x1000),

/* 43 Fast Forward Power Control Parameters logging */
       FFWD_PCTRL = (0x2B + 0x1000),

/* 44 Reverse Power Control Parameters logging */
       REV_PCTRL = (0x2C + 0x1000),

/* 45 Searcher and Finger Information logging */
       SRCH_FING_INFO = (0x2D + 0x1000),

/* 46 Service Configuration logging */
       SVC_CONFIG = (0x2E + 0x1000),

/* 47 Active Set Configuration logging */
       ASET_CONFIG = (0x2F + 0x1000),

/* 48 Quick Paging Channel logging */
       QPCH = (0x30 + 0x1000),

/* 49 RLP Statistics logging */
       RLP_STAT = (0x31 + 0x1000),

/* 50 Simple Test Data Service Option logging */
       STDSO = (0x32 + 0x1000),

/* 51 Pilot Phase Measurement results logging */
       SRCH_PPM_RES = (0x33 + 0x1000),

/* 52 Pilot Phase Measurement Data Base logging */
       SRCH_PPM_DB = (0x34 + 0x1000),

/* 53 Pilot Phase Measurement search results logging */
       SRCH_PPM = (0x35 + 0x1000),

/* 54 IS-801 forward link message */
       GPS_FWD_MSG = (0x36 + 0x1000),

/* 55 IS-801 reverse link message */
       GPS_REV_MSG = (0x37 + 0x1000),

/* 56 GPS search session statistics */
       GPS_STATS_MSG = (0x38 + 0x1000),

/* 57 GPS search results */
       GPS_SRCH_PEAKS_MSG = (0x39 + 0x1000),

/* 58 Factory Testmode logging */
       FTM = (0x3A + 0x1000),

/* 59 Multiple Peak Logging */
       SRCH_GPS_MULTI_PEAKS_INFO = (0x3B + 0x1000),

/* 60 Post processed search results logs */
       SRCH_GPS_POST_PROC = (0x3C + 0x1000),

/* 61 FULL Test Data Service Option logging */
       FTDSO = (0x3D + 0x1000),

/* 62 Bluetooth logging */
       BT_RESERVED_CODES_BASE = (0x3E + 0x1000),
/* Keep confusing name for backwards compatibility.  */

/* 92 Bluetooth's last log code */
       BT_LAST = (30 +BT_RESERVED_CODES_BASE),

/* 93 HDR log codes */
       HDR_RESERVED_CODES_BASE = (0x5D + 0x1000),
/* Keep confusing name for backwards compatibility.  */

/* 143 is HDR's last log code */
       HDR_LAST = (50 +HDR_RESERVED_CODES_BASE),

/* 144 IS2000 DCCH Forward link channel */
       FOR_DCCH_MSG = (0x90 + 0x1000),

/* 145 IS2000 DCCH Forward link channel */
       REV_DCCH_MSG = (0x91 + 0x1000),

/* 146 IS2000 DCCH Forward link channel */
       ZREX = (0x92 + 0x1000),

/* 147 Active set info logging, similar to ASET_CONFIG, but simpler.  */
       ASET_INFO = (0x93 + 0x1000),

/* 148 Pilot Phase Measurement four-shoulder-search resutlts logging */
       SRCH_PPM_4SHOULDER_RES = (0x94 + 0x1000),

/* 149 Extended Pilot Phase Measurement Data Base logging */
       SRCH_EXT_PPM_DB = (0x95 + 0x1000),

/* 150 GPS Visit Parameters */
       GPS_VISIT_PARAMETERS = (0x96 + 0x1000),

/* 151 GPS Measurement */
       GPS_MEASUREMENT = (0x97 + 0x1000),

/* 152 UIM Data */
       UIM_DATA = (0x98 + 0x1000),

/* 153 STDSO plus P2 */
       STDSO_P2 = (0x99 + 0x1000),

/* 154 FTDSO plus P2 */
       FTDSO_P2 = (0x9A + 0x1000),

/* 155 Search PPM Statistics */
       SRCH_PPM_STATS = (0x9B + 0x1000),

/* 156 PPP Tx Frames */
       PPP_TX_FRAMES = (0x9C + 0x1000),

/* 157 PPP Rx Frames */
       PPP_RX_FRAMES = (0x9D + 0x1000),

/* 158-187 SSL reserved log codes */
       SSL_RESERVED_CODES_BASE = (0x9E + 0x1000),
       SSL_LAST = (29 +SSL_RESERVED_CODES_BASE),

/* 188-199 Puma reserved log codes */
/* 188 QPCH, version 2 */
       QPCH_VER_2 = (0xBC + 0x1000),

/* 189 Enhanced Access Probe */
       EA_PROBE = (0xBD + 0x1000),

/* 190 BCCH Frame Information */
       BCCH_FRAME_INFO = (0xBE + 0x1000),

/* 191 FCCCH Frame Information */
       FCCCH_FRAME_INFO = (0xBF + 0x1000),

/* 192 FDCH Frame Information */
       FDCH_FRAME_INFO = (0xC0 + 0x1000),

/* 193 RDCH Frame Information */
       RDCH_FRAME_INFO = (0xC1 + 0x1000),

/* 194 FFPC Information */
       FFPC_INFO = (0xC2 + 0x1000),

/* 195 RPC Information */
       RPC_INFO = (0xC3 + 0x1000),

/* 196 Searcher and Finger Information */
       SRCH_FING_INFO_VER_2 = (0xC4 + 0x1000),

/* 197 Service Configuration, version 2 */
       SRV_CONFIG_VER_2 = (0xC5 + 0x1000),

/* 198 Active Set Information, version 2 */
       ASET_INFO_VER_2 = (0xC6 + 0x1000),

/* 199 Reduced Active Set */
       REDUCED_ASET_INFO = (0xC7 + 0x1000),

/* 200 Search Triage Info */
       SRCH_TRIAGE_INFO = (0xC8 + 0x1000),

/* 201 RDA Frame Information */
       RDA_FRAME_INFO = (0xC9 + 0x1000),

/* 202 gpsOne fatpath information */
       GPS_FATPATH_INFO = (0xCA + 0x1000),

/* 203 Extended AGC */
       EXTENDED_AGC = (0xCB + 0x1000),

/* 204 Transmit AGC */
       TRANSMIT_AGC = (0xCC + 0x1000),

/* 205 I/Q Offset registers */
       IQ_OFFSET_REGISTERS = (0xCD + 0x1000),

/* 206 DACC I/Q Accumulator registers */
       DACC_IQ_ACCUMULATOR = (0xCE + 0x1000),

/* 207 Register polling results */
       REGISTER_POLLING_RESULTS = (0xCF + 0x1000),

/* 208 System arbitration module */
       AT_SAM = (0xD0 + 0x1000),

/* 209 Diablo searcher finger log */
       DIABLO_SRCH_FING_INFO = (0xD1 + 0x1000),

/* 210 log reserved for dandrus */
       SD20_LAST_ACTION = (0xD2 + 0x1000),

/* 211 log reserved for dandrus */
       SD20_LAST_ACTION_HYBRID = (0xD3 + 0x1000),

/* 212 log reserved for dandrus */
       SD20_SS_OBJECT = (0xD4 + 0x1000),

/* 213 log reserved for dandrus */
       SD20_SS_OBJECT_HYBRID = (0xD5 + 0x1000),

/* 214 log reserved for jpinos */
       BCCH_SIGNALING = (0xD6 + 0x1000),

/* 215 log reserved for jpinos */
       REACH_SIGNALING = (0xD7 + 0x1000),

/* 216 log reserved for jpinos */
       FCCCH_SIGNALING = (0xD8 + 0x1000),

/* 217 RDA Frame Information 2 */
       RDA_FRAME_INFO_2 = (0xD9 + 0x1000),

/* 218 */
       GPS_BIT_EDGE_RESULTS = (0xDA + 0x1000),

/* 219 */
       PE_DATA = (0xDB + 0x1000),

/* 220 */
       PE_PARTIAL_DATA = (0xDC + 0x1000),

/* 221 */
       GPS_SINGLE_PEAK_SRCH_RESULTS = (0xDD + 0x1000),

/* 222 */
       SRCH4_SAMPRAM = (0xDE + 0x1000),

/* 223 */
        HDR_AN_PPP_TX_FRAMES = (0xDF + 0x1000),

/* 224 */
        HDR_AN_PPP_RX_FRAMES = (0xE0 + 0x1000),

/* 225 */
       GPS_SCHEDULER_TRACE = (0xE1 + 0x1000),

/* 226 */
       MPEG4_YUV_FRAME = (0xE2 + 0x1000),

/* 227 */
       MPEG4_CLIP_STATS = (0xE3 + 0x1000),

/* 228 */
       MPEG4_CLIP_STATS_VER2 = (0xE4 + 0x1000),

/* 226-241 MMEG reserved. */
       MPEG_RESERVED_CODES_BASE = (0xF1 + 0x1000),

/* 242-274 BREW reserved log range */
       BREW_RESERVED_CODES_BASE = (0xF2 + 0x1000),
       BREW_LAST = (32 +BREW_RESERVED_CODES_BASE),

/* 275-339 PPP Extended Frames */
       PPP_FRAMES_RESERVED_CODES_BASE = (0x113 + 0x1000),
       PPP_FRAMES_LAST = (64 +PPP_FRAMES_RESERVED_CODES_BASE),

       PPP_EXT_FRAMED_RX_UM = (0x113 + 0x1000),
       PPP_EXT_FRAMED_RX_RM = (0x114 + 0x1000),
       PPP_EXT_FRAMED_RX_AN = (0x115 + 0x1000),

       PPP_EXT_FRAMED_TX_UM = (0x123 + 0x1000),
       PPP_EXT_FRAMED_TX_RM = (0x124 + 0x1000),
       PPP_EXT_FRAMED_TX_AN = (0x125 + 0x1000),

       PPP_EXT_UNFRAMED_RX_UM = (0x133 + 0x1000),
       PPP_EXT_UNFRAMED_RX_RM = (0x134 + 0x1000),
       PPP_EXT_UNFRAMED_RX_AN = (0x135 + 0x1000),

       PPP_EXT_UNFRAMED_TX_UM = (0x143 + 0x1000),
       PPP_EXT_UNFRAMED_TX_RM = (0x144 + 0x1000),
       PPP_EXT_UNFRAMED_TX_AN = (0x145 + 0x1000),

/* 340PE_DATA_EXT_C */
       PE_DATA_EXT = (0x154 + 0x1000),

/* REX Subsystem logs */
       MEMDEBUG = (0x155 + 0x1000),
       SYSPROFILE = (0x156 + 0x1000),
       TASKPROFILE = (0x157 + 0x1000),
       COREDUMP = (0x158 + 0x1000),

/* 341-349 REX subsystem logs */
       REX_RESERVED_CODES_BASE = (0x155 + 0x1000),
       REX_LAST = (8 +REX_RESERVED_CODES_BASE),

/* 350PE_PARTIAL_DATA_EXT_C */
       PE_PARTIAL_DATA_EXT = (0x15E + 0x1000),

/* 351DIAG_STRESS_TEST_C */
       DIAG_STRESS_TEST = (0x15F + 0x1000),

/* 352 WMS_READ_C */
       WMS_READ = (0x160 + 0x1000),

/* 353 Search Triage Info Version 2 */
       SRCH_TRIAGE_INFO2 = (0x161 + 0x1000),

/* 354 RLP Rx FDCH Frames */
       RLP_RX_FDCH_FRAMES = (0x162 + 0x1000),


/* 355 RLP Tx FDCH Frames */
       RLP_TX_FDCH_FRAMES = (0x163 + 0x1000),

/* 356-371 QTV subsystem logs */
       QTV_RESERVED_CODES_BASE = (0x164 + 0x1000),
       QTV_LAST = (15 +QTV_RESERVED_CODES_BASE),

/* 372 Searcher 4 1X */
       SRCH4_1X = (0x174 + 0x1000),

/* 373 Searcher sleep statistics */
       SRCH_SLEEP_STATS = (0x175 + 0x1000),

/* 374 Service Configuration, version 3 */
       SRV_CONFIG_VER_3 = (0x176 + 0x1000),

/* 375 Searcher 4 HDR */
       SRCH4_HDR = (0x177 + 0x1000),

/* 376 Searcher 4 AFLT */
       SRCH4_AFLT = (0x178 + 0x1000),

/* 377 Enhanced Finger Information */
       ENH_FING_INFO = (0x179 + 0x1000),

/* 378 DV Information */
       DV_INFO = (0x17A + 0x1000),

/* 379 WMS set routes information */
       WMS_SET_ROUTES = (0x17B + 0x1000),

/* 380 FTM Version 2 Logs */
       FTM_VER_2 = (0x17C + 0x1000),

/* 381 GPS Multipeak logging */
       SRCH_GPS_MULTI_PEAKS_SIMPLIFIED_INFO = (0x17D + 0x1000),

/* 382 GPS Multipeak logging */
       SRCH_GPS_MULTI_PEAKS_VERBOSE_INFO = (0x17E + 0x1000),

/* 383-403 HDR reserved logs */
       HDR_RESERVED_CODES_BASE_2 = (0x17F + 0x1000),
       HDR_LAST_2 = (20 +HDR_RESERVED_CODES_BASE_2),

/* RLP Rx - PDCH partial MuxPDU5 frames */
       RLP_RX_PDCH_PARTIAL_MUXPDU5_FRAMES = (0x194 + 0x1000),

/* RLP Tx - PDCH partial MuxPDU5 frames */
       RLP_TX_PDCH_PARTIAL_MUXPDU5_FRAMES = (0x195 + 0x1000),

/* RLP Rx internal details */
       RLP_RX_INTERNAL_DETAILS = (0x196 + 0x1000),

/* RLP Tx internal details */
       RLP_TX_INTERNAL_DETAILS = (0x197 + 0x1000),

/* MPEG4 Clip Statistics version 3 */
       MPEG4_CLIP_STATS_VER3 = (0x198 + 0x1000),

/* Mobile IP Performance */
       MOBILE_IP_PERFORMANCE = (0x199 + 0x1000),

/* 410-430 Searcher reserved logs */
       SEARCHER_RESERVED_CODES_BASE = (0x19A + 0x1000),
       SEARCHER_LAST_2 = (21 +SEARCHER_RESERVED_CODES_BASE),

/* 432-480 QTV reserved logs */
       QTV2_RESERVED_CODES_BASE = (0x1B0 + 0x1000),
       QTV2_LAST = (48 +QTV2_RESERVED_CODES_BASE),

       QTV_PDS2_STATS = (0x1B6 + 0x1000),
       QTV_PDS2_GET_REQUEST = (0x1B7 + 0x1000),
       QTV_PDS2_GET_RESP_HEADER = (0x1B8 + 0x1000),
       QTV_PDS2_GET_RESP_PCKT = (0x1B9 + 0x1000),
       QTV_CMX_AUDIO_INPUT_DATA = (0x1BA + 0x1000),
       QTV_RTSP_OPTIONS = (0x1BB + 0x1000),
       QTV_RTSP_GET_PARAMETER = (0x1BC + 0x1000),
       QTV_RTSP_SET_PARAMETER = (0x1BD + 0x1000),
       QTV_VIDEO_BITSTREAM = (0x1BE + 0x1000),
       ARM_VIDEO_DECODE_STATS = (0x1BF + 0x1000),
       QTV_DSP_SLICE_BUFFER = (0x1C0 + 0x1000),
       QTV_CMD_LOGGING = (0x1C1 + 0x1000),
       QTV_AUDIO_FRAME_PTS_INFO = (0x1C2 + 0x1000),
       QTV_VIDEO_FRAME_DECODE_INFO = (0x1C3 + 0x1000),
       QTV_RTCP_COMPOUND_RR = (0x1C4 + 0x1000),
       QTV_FRAME_BUFFER_RELEASE_REASON = (0x1C5 + 0x1000),
       QTV_AUDIO_CHANNEL_SWITCH_FRAME = (0x1C6 + 0x1000),
       QTV_RTP_DECRYPTED_PKT = (0x1C7 + 0x1000),
       QTV_PCR_DRIFT_RATE = (0x1C8 + 0x1000),

/* GPS PDSM logs */
       PDSM_POSITION_REPORT_CALLBACK = (0x1E1 + 0x1000),
       PDSM_PD_EVENT_CALLBACK = (0x1E2 + 0x1000),
       PDSM_PA_EVENT_CALLBACK = (0x1E3 + 0x1000),
       PDSM_NOTIFY_VERIFY_REQUEST = (0x1E4 + 0x1000),
       PDSM_RESERVED1 = (0x1E5 + 0x1000),
       PDSM_RESERVED2 = (0x1E6 + 0x1000),

/* Searcher Demodulation Status log */
       SRCH_DEMOD_STATUS = (0x1E7 + 0x1000),

/* Searcher Call Statistics log */
       SRCH_CALL_STATISTICS = (0x1E8 + 0x1000),

/* GPS MS-MPC Forward link */
       MS_MPC_FWD_LINK = (0x1E9 + 0x1000),

/* GPS MS-MPC Reverse link */
       MS_MPC_REV_LINK = (0x1EA + 0x1000),

/* Protocol Services Data */
       DATA_PROTOCOL_LOGGING = (0x1EB + 0x1000),

/* MediaFLO reserved log codes */
       MFLO_RESERVED_CODES_BASE = (0x1EC + 0x1000),
       MFLO_LAST = (99 +MFLO_RESERVED_CODES_BASE),

/* GPS demodulation tracking header info */
       GPS_DEMOD_TRACKING_HEADER = (0x250 + 0x1000),

/* GPS demodulation tracking results */
       GPS_DEMOD_TRACKING = (0x251 + 0x1000),

/* GPS bit edge logs from demod tracking */
       GPS_DEMOD_BIT_EDGE = (0x252 + 0x1000),

/* GPS demodulation soft decisions */
       GPS_DEMOD_SOFT_DECISIONS = (0x253 + 0x1000),

/* GPS post-processed demod tracking results */
       GPS_DEMOD_TRACKING_POST_PROC = (0x254 + 0x1000),

/* GPS subframe log */
       GPS_DEMOD_SUBFRAME = (0x255 + 0x1000),

/* F-CPCCH Quality Information */
       F_CPCCH_QUALITY_INFO = (0x256 + 0x1000),

/* Reverse PDCCH/PDCH Frame Information */
       R_PDCCH_R_PDCH_FRAME_INFO = (0x257 + 0x1000),

/* Forward G Channel Information */
       F_GCH_INFO = (0x258 + 0x1000),

/* Forward G Channel Frame Information */
       F_GCH_FRAME_INFO = (0x259 + 0x1000),

/* Forward RC Channel Information */
       F_RCCH_INFO = (0x25A + 0x1000),

/* Forward ACK Channel Information */
       F_ACKCH_INFO = (0x25B + 0x1000),

/* Forward ACK Channel ACKDA Information */
       F_ACKCH_ACKDA = (0x25C + 0x1000),

/* Reverse REQ Channel Information */
       R_REQCH_INFO = (0x25D + 0x1000),

/* Sleep Task Statistics */
       SLEEP_STATS = (0x25E + 0x1000),

/* Sleep controller statistics 1X */
      LOG_1X_SLEEP_CONTROLLER_STATS = (0x25F + 0x1000),

/* Sleep controller statistics HDR */
       HDR_SLEEP_CONTROLLER_STATS = (0x260 + 0x1000),

/* Sleep controller statistics GSM */
       GSM_SLEEP_CONTROLLER_STATS = (0x261 + 0x1000),

/* Sleep controller statistics WCDMA */
       WCDMA_SLEEP_CONTROLLER_STATS = (0x262 + 0x1000),

/* Sleep task and controller reserved logs */
       SLEEP_APPS_STATS = (0x263 + 0x1000),
       SLEEP_STATS_RESERVED2 = (0x264 + 0x1000),
       SLEEP_STATS_RESERVED3 = (0x265 + 0x1000),

/* DV Information placeholder channel logs */
       PDCCH_LO_SELECTED = (0x266 + 0x1000),
       PDCCH_HI_SELECTED = (0x267 + 0x1000),
       WALSH_SELECTED = (0x268 + 0x1000),
       PDCH_BE_SELECTED = (0x269 + 0x1000),
       PDCCH_LLR_SELECTED = (0x26A + 0x1000),
       CQI_ACK_LO_SELECTED = (0x26B + 0x1000),
       CQI_ACK_HI_SELECTED = (0x26C + 0x1000),
       RL_GAIN_SELECTED = (0x26D + 0x1000),
       PDCCH0_SNDA_SELECTED = (0x26E + 0x1000),
       PDCCH1_SNDA_SELECTED = (0x26F + 0x1000),

/* 624 WMS Message List */
       WMS_MESSAGE_LIST = (0x270 + 0x1000),

/* 625 Multimode Generic SIM Driver Interface */
       MM_GENERIC_SIM_DRIVER = (0x271 + 0x1000),

/* 626 Generic SIM Toolkit Task */
       GENERIC_SIM_TOOLKIT_TASK = (0x272 + 0x1000),

/* 627 Call Manager Phone events log */
       CM_PH_EVENT = (0x273 + 0x1000),

/* 628 WMS Set Message List */
       WMS_SET_MESSAGE_LIST = (0x274 + 0x1000),

/* 629-704 HDR reserved logs */
       HDR_RESERVED_CODES_BASE_3 = (0x275 + 0x1000),
       HDR_LAST_3 = (75 +HDR_RESERVED_CODES_BASE_3),

/* 705 Call Manager call event log */
       CM_CALL_EVENT = (0x2C1 + 0x1000),

/* 706-738 QVP reserved logs */
       QVP_RESERVED_CODES_BASE = (0x2C2 + 0x1000),
       QVP_LAST = (32 +QVP_RESERVED_CODES_BASE),

/* 739 GPS PE Position Report log */
       GPS_PE_POSITION_REPORT = (0x2E3 + 0x1000),

/* 740 GPS PE Position Report Extended log */
       GPS_PE_POSITION_REPORT_EXT = (0x2E4 + 0x1000),

/* 741 log */
       MDDI_HOST_STATS = (0x2E5 + 0x1000),

/* GPS Decoded Ephemeris */
       GPS_DECODED_EPHEMERIS = (0x2E6 + 0x1000),

/* GPS Decoded Almanac */
       GPS_DECODED_ALMANAC = (0x2E7 + 0x1000),

/* Transceiver Resource Manager */
       TRANSCEIVER_RESOURCE_MGR = (0x2E8 + 0x1000),

/* GPS Position Engine Info */
       GPS_POSITION_ENGINE_INFO = (0x2E9 + 0x1000),

/* 746-810 RAPTOR reserved log range */
       RAPTOR_RESERVED_CODES_BASE = (0x2EA + 0x1000),
       RAPTOR_LAST = (64 +RAPTOR_RESERVED_CODES_BASE),

/* QOS Specification Logging */

/* QOS Requested Log */
       QOS_REQUESTED = (0x32B + 0x1000),

/* QOS Granted Log */
       QOS_GRANTED = (0x32C + 0x1000),

/* QOS State Log */
       QOS_STATE = (0x32D + 0x1000),

       QOS_MODIFIED = (0x32E + 0x1000),

       QDJ_ENQUEUE = (0x32F + 0x1000),
       QDJ_DEQUEUE = (0x330 + 0x1000),
       QDJ_UPDATE = (0x331 + 0x1000),
       QDTX_ENCODER = (0x332 + 0x1000),
       QDTX_DECODER = (0x333 + 0x1000),

       PORT_ASSIGNMENT_STATUS = (0x334 + 0x1000),

/* Protocol Services reserved log codes */
       PS_STAT_GLOBAL_IPV4 = (0x335 + 0x1000),
       PS_STAT_GLOBAL_IPV6 = (0x336 + 0x1000),
       PS_STAT_GLOBAL_ICMPV4 = (0x337 + 0x1000),
       PS_STAT_GLOBAL_ICMPV6 = (0x338 + 0x1000),
       PS_STAT_GLOBAL_TCP = (0x339 + 0x1000),
       PS_STAT_GLOBAL_UDP = (0x33A + 0x1000),

/* Protocol Services describe all TCP instances */
       PS_STAT_DESC_ALL_TCP_INST = (0x33B + 0x1000),

/* Protocol Services describe all memory pool instances */
       PS_STAT_DESC_ALL_MEM_POOL_INST = (0x33C + 0x1000),

/* Protocol Services describe all IFACE instances */
       PS_STAT_DESC_ALL_IFACE_INST = (0x33D + 0x1000),

/* Protocol Services describe all PPP instances */
       PS_STAT_DESC_ALL_PPP_INST = (0x33E + 0x1000),

/* Protocol Services describe all ARP instances */
       PS_STAT_DESC_ALL_ARP_INST = (0x33F + 0x1000),

/* Protocol Services describe delta instance */
       PS_STAT_DESC_DELTA_INST = (0x340 + 0x1000),

/* Protocol Services instance TCP statistics */
       PS_STAT_TCP_INST = (0x341 + 0x1000),

/* Protocol Services instance UDP statistics */
       PS_STAT_UDP_INST = (0x342 + 0x1000),

/* Protocol Services instance PPP statistics */
       PS_STAT_PPP_INST = (0x343 + 0x1000),

/* Protocol Services instance IFACE statistics */
       PS_STAT_IFACE_INST = (0x344 + 0x1000),

/* Protocol Services instance memory statistics */
       PS_STAT_MEM_INST = (0x345 + 0x1000),

/* Protocol Services instance flow statistics */
       PS_STAT_FLOW_INST = (0x346 + 0x1000),

/* Protocol Services instance physical link statistics */
       PS_STAT_PHYS_LINK_INST = (0x347 + 0x1000),

/* Protocol Services instance ARP statistics */
       PS_STAT_ARP_INST = (0x348 + 0x1000),

/* Protocol Services instance LLC statistics */
       PS_STAT_LLC_INST = (0x349 + 0x1000),

/* Protocol Services instance IPHC statistics */
       PS_STAT_IPHC_INST = (0x34A + 0x1000),

/* Protocol Services instance ROHC statistics */
       PS_STAT_ROHC_INST = (0x34B + 0x1000),

/* Protocol Services instance RSVP statistics */
       PS_STAT_RSVP_INST = (0x34C + 0x1000),

/* Protocol Services describe all LLC instances */
       PS_STAT_DESC_ALL_LLC_INST = (0x34D + 0x1000),

/* Protocol Services describe all RSVP instances */
       PS_STAT_DESC_ALL_RSVP_INST = (0x34E + 0x1000),

/* Call Manager Serving System event log */
       CM_SS_EVENT = (0x34F + 0x1000),

/* VcTcxo manager�s automatic frequency control log */
       TCXOMGR_AFC_DATA = (0x350 + 0x1000),

/* Clock transactions and general clocks status log */
       CLOCK = (0x351 + 0x1000),

/* GPS search processed peak results and their associated search parameters */
       GPS_PROCESSED_PEAK = (0x352 + 0x1000),

       MDSP_LOG_CHUNKS = (0x353 + 0x1000),

/* Periodic RSSI update log */
       WLAN_RSSI_UPDATE = (0x354 + 0x1000),

/* Periodic Link Layer statistics log */
       WLAN_LL_STAT = (0x355 + 0x1000),

/* QOS Extended State Log */
       QOS_STATE_EX = (0x356 + 0x1000),

/* Bluetooth host HCI transmitted data */
       BT_HOST_HCI_TX = (0x357 + 0x1000),

/* Bluetooth host HCI received data */
       BT_HOST_HCI_RX = (0x358 + 0x1000),

/* Internal - GPS PE Position Report Part 3 */
       GPS_PE_POSITION_REPORT_PART3 = (0x359 + 0x1000),

/* Extended log code which logs requested QoS */
       QOS_REQUESTED_EX = (0x35A + 0x1000),

/* Extended log code which logs granted QoS */
       QOS_GRANTED_EX = (0x35B + 0x1000),

/* Extended log code which logs modified QoS */
       QOS_MODIFIED_EX = (0x35C + 0x1000),

/* Bus Monitor Profiling Info */
       BUS_MON_PROF_INFO = (0x35D + 0x1000),

/* Pilot Phase Measurement Search results */
       SRCH_PPM_RES_VER_2 = (0x35E + 0x1000),

/* Pilot Phase Measurement Data Base */
       SRCH_PPM_DB_VER_2 = (0x35F + 0x1000),

/* Pilot Phase Measurement state machine */
       PPM_SM = (0x360 + 0x1000),

/* Robust Header Compression - Compressor */
       ROHC_COMPRESSOR = (0x361 + 0x1000),

/* Robust Header Compression - Decompressor */
       ROHC_DECOMPRESSOR = (0x362 + 0x1000),

/* Robust Header Compression - Feedback Compressor */
       ROHC_FEEDBACK_COMPRESSOR = (0x363 + 0x1000),

/* Robust Header Compression - Feedback Decompressor */
       ROHC_FEEDBACK_DECOMPRESSOR = (0x364 + 0x1000),

/* Bluetooth HCI commands */
       BT_HCI_CMD = (0x365 + 0x1000),

/* Bluetooth HCI events */
       BT_HCI_EV = (0x366 + 0x1000),

/* Bluetooth HCI Transmitted ACL data */
       BT_HCI_TX_ACL = (0x367 + 0x1000),

/* Bluetooth HCI Received ACL data */
       BT_HCI_RX_ACL = (0x368 + 0x1000),

/* Bluetooth SOC H4 Deep Sleep */
       BT_SOC_H4DS = (0x369 + 0x1000),

/* UMTS to CDMA Handover Message */
       UMTS_TO_CDMA_HANDOVER_MSG = (0x36A + 0x1000),

/* Graphic Event Data */
       PROFILER_GRAPHIC_DATA = (0x36B + 0x1000),

/* Audio Event Data */
       PROFILER_AUDIO_DATA = (0x36C + 0x1000),

/* GPS Spectral Information */
       GPS_SPECTRAL_INFO = (0x36D + 0x1000),

/* AHB Performance Monitor LOG data */
       APM = (0x36E + 0x1000),

/* GPS Clock Report */
       CONVERGED_GPS_CLOCK_REPORT = (0x36F + 0x1000),

/* GPS Position Report */
       CONVERGED_GPS_POSITION_REPORT = (0x370 + 0x1000),

/* GPS Measurement Report */
       CONVERGED_GPS_MEASUREMENT_REPORT = (0x371 + 0x1000),

/* GPS RF Status Report */
       CONVERGED_GPS_RF_STATUS_REPORT = (0x372 + 0x1000),

/* VOIP To CDMA Handover Message - Obsoleted by 0x138B - 0x138D */
       VOIP_TO_CDMA_HANDOVER_MSG = (0x373 + 0x1000),

/* GPS Prescribed Dwell Result */
       GPS_PRESCRIBED_DWELL_RESULT = (0x374 + 0x1000),

/* CGPS IPC Data */
       CGPS_IPC_DATA = (0x375 + 0x1000),

/* CGPS Non IPC Data */
       CGPS_NON_IPC_DATA = (0x376 + 0x1000),

/* CGPS Session Report */
       CGPS_REP_EVT_LOG_PACKET = (0x377 + 0x1000),

/* CGPS PDSM Get Position */
       CGPS_PDSM_GET_POSITION = (0x378 + 0x1000),

/* CGPS PDSM Set Parameters */
       CGPS_PDSM_SET_PARAMETERS = (0x379 + 0x1000),

/* CGPS PDSM End Session */
       CGPS_PDSM_END_SESSION = (0x37A + 0x1000),

/* CGPS PDSM Notify Verify Response */
       CGPS_PDSM_NOTIFY_VERIFY_RESP = (0x37B + 0x1000),

/* CGPS PDSM Position Report Callback */
       CGPS_PDSM_POSITION_REPORT_CALLBACK = (0x37C + 0x1000),

/* CGPS PDSM PD Event Callback */
       CGPS_PDSM_PD_EVENT_CALLBACK = (0x37D + 0x1000),

/* CGPS PDSM PA Event Callback */
       CGPS_PDSM_PA_EVENT_CALLBACK = (0x37E + 0x1000),

/* CGPS PDSM Notify Verify Request Callback */
       CGPS_PDSM_NOTIFY_VERIFY_REQUEST = (0x37F + 0x1000),

/* CGPS PDSM PD Command Error Callback */
       CGPS_PDSM_PD_CMD_ERR_CALLBACK = (0x380 + 0x1000),

/* CGPS PDSM PA Command Error Callback */
       CGPS_PDSM_PA_CMD_ERR_CALLBACK = (0x381 + 0x1000),

/* CGPS PDSM Position Error */
       CGPS_PDSM_POS_ERROR = (0x382 + 0x1000),

/* CGPS PDSM Extended Status Position Report */
       CGPS_PDSM_EXT_STATUS_POS_REPORT = (0x383 + 0x1000),

/* CGPS PDSM Extended Status NMEA Report */
       CGPS_PDSM_EXT_STATUS_NMEA_REPORT = (0x384 + 0x1000),

/* CGPS PDSM Extended Status Measurement Report */
       CGPS_PDSM_EXT_STATUS_MEAS_REPORT = (0x385 + 0x1000),

/* CGPS Report Server TX Packet */
       CGPS_REP_SVR_TX_LOG_PACKET = (0x386 + 0x1000),

/* CGPS Report Server RX Packet */
       CGPS_REP_SVR_RX_LOG_PACKET = (0x387 + 0x1000),

/* UMTS To CDMA Handover Paging Channel Message */
       UMTS_TO_CDMA_HANDOVER_PCH_MSG = (0x388 + 0x1000),

/* UMTS To CDMA Handover Traffic Channel Message */
       UMTS_TO_CDMA_HANDOVER_TCH_MSG = (0x389 + 0x1000),

/* Converged GPS IQ Report */
       CONVERGED_GPS_IQ_REPORT = (0x38A + 0x1000),

/* VOIP To CDMA Paging Channel Handover Message */
       VOIP_TO_CDMA_PCH_HANDOVER_MSG = (0x38B + 0x1000),

/* VOIP To CDMA Access Channel Handover Message */
       VOIP_TO_CDMA_ACH_HANDOVER_MSG = (0x38C + 0x1000),

/* VOIP To CDMA Forward Traffic Channel Handover Message */
       VOIP_TO_CDMA_FTC_HANDOVER_MSG = (0x38D + 0x1000),

/* QMI reserved logs */
       QMI_RESERVED_CODES_BASE = (0x38E + 0x1000),
       QMI_RESERVED_CODE_1 = (1 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_2 = (2 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_3 = (3 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_4 = (4 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_5 = (5 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_6 = (6 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_7 = (7 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_8 = (8 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_9 = (9 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_10 = (10 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_11 = (11 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_12 = (12 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_13 = (13 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_14 = (14 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_15 = (15 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_16 = (16 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_17 = (17 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_18 = (18 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_19 = (19 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_20 = (20 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_21 = (21 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_22 = (22 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_23 = (23 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_24 = (24 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_25 = (25 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_26 = (26 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_27 = (27 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_28 = (28 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_29 = (29 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_30 = (30 + QMI_RESERVED_CODES_BASE),
       QMI_RESERVED_CODE_31 = (31 + QMI_RESERVED_CODES_BASE),
       
       QMI_LAST = (32 + QMI_RESERVED_CODES_BASE),

/* QOS Info Code Update Log */
       QOS_INFO_CODE_UPDATE = (0x3AF + 0x1000),

/* Transmit(Uplink) Vocoder PCM Packet Log */
       TX_PCM_PACKET = (0x3B0 + 0x1000),

/* Audio Vocoder Data Paths */
       AUDVOC_DATA_PATHS_PACKET = (0x3B0 + 0x1000),

/* Receive(Downlink) Vocoder PCM Packet Log */
       RX_PCM_PACKET = (0x3B1 + 0x1000),

/* CRC of YUV frame log */
       DEC_CRC_FRAME = (0x3B2 + 0x1000),

/* FLUTE Session Information */
       FLUTE_SESSION_INFO = (0x3B3 + 0x1000),

/* FLUTE ADP File Information */
       FLUTE_ADP_FILE_INFO = (0x3B4 + 0x1000),

/* FLUTE File Request Information */
       FLUTE_FILE_REQ_INFO = (0x3B5 + 0x1000),

/* FLUTE FDT Instance Information */
       FLUTE_FDT_INST = (0x3B6 + 0x1000),

/* FLUTE FDT Information */
       FLUTE_FDT_INFO = (0x3B7 + 0x1000),

/* FLUTE File Log Packet Information */
       FLUTE_FILE_INFO = (0x3B8 + 0x1000),

/* 3G 1X Parameter Overhead Information */
       VOIP_TO_CDMA_3G1X_PARAMETERS = (0x3B9 + 0x1000),

/* CGPS ME Job Info */
       CGPS_ME_JOB_INFO = (0x3BA + 0x1000),

/* CGPS ME SV Lists */
       CPGS_ME_SV_LISTS = (0x3BB + 0x1000),

/* Flexible Profiling Status */
       PROFDIAG_GEN_STATUS = (0x3BC + 0x1000),

/* Flexible Profiling Results */
       PROFDIAG_GEN_PROF = (0x3BD + 0x1000),

/* FLUTE ADP File Content Log Packet Information */
       FLUTE_ADP_FILE = (0x3BE + 0x1000),

/* FLUTE FDT Instance File Content Log Packet Information */
       FLUTE_FDT_INST_FILE = (0x3BF + 0x1000),

/* FLUTE FDT Entries Information */
       FLUTE_FDT_ENTRIES_INFO = (0x3C0 + 0x1000),

/* FLUTE File Contents Log Packet Information */
       FLUTE_FILE = (0x3C1 + 0x1000),

/* CGPS ME Time-Transfer Info */
       CGPS_ME_TIME_TRANSFER_INFO = (0x3C2 + 0x1000),

/* CGPS ME UMTS Time-Tagging Info */
       CGPS_ME_UMTS_TIME_TAGGING_INFO = (0x3C3 + 0x1000),

/* CGPS ME Generic Time Estimate Put lnfo */
       CGPS_ME_TIME_EST_PUT_INFO = (0x3C4 + 0x1000),

/* CGPS ME Generic Freq Estimate Put lnfo */
       CGPS_ME_FREQ_EST_PUT_INFO = (0x3C5 + 0x1000),

/* CGPS Slow Clock Report */
       CGPS_SLOW_CLOCK_REPORT = (0x3C6 + 0x1000),

/* Converged GPS Medium Grid */
       CONVERGED_GPS_MEDIUM_GRID = (0x3C7 + 0x1000),

/* Static information about the driver or device */
       SNSD_INFO = (0x3C8 + 0x1000),

/* Dynamic state information about the device or driver */
       SNSD_STATE = (0x3C9 + 0x1000),

/* Data from a driver */
       SNSD_DATA = (0x3CA + 0x1000),

/* CGPS Cell DB Cell Change Info */
       CGPS_CELLDB_CELL_CHANGE_INFO = (0x3CB + 0x1000),

/* xScalar YUV frame log */
       DEC_XSCALE_YUV_FRAME = (0x3CC + 0x1000),

/* CRC of xScaled YUV frame log */
       DEC_XSCALE_CRC_FRAME = (0x3CD + 0x1000),

/* CGPS Frequency Estimate Report */
       CGPS_FREQ_EST_REPORT = (0x3CE + 0x1000),

/* GPS DCME Srch Job Completed */
       GPS_DCME_SRCH_JOB_COMPLETED = (0x3CF + 0x1000),

/* CGPS ME Fastscan results  */
       CGPS_ME_FASTSCAN_RESULTS = (0x3D0 + 0x1000),

/* XO frequency Estimation log */
       XO_FREQ_EST = (0x3D1 + 0x1000),

/* Tcxomgr field calibration data  */
       TCXOMGR_FIELD_CAL = (0x3D2 + 0x1000),

/* UMB Call Processing Connection Attempt */
       UMBCP_CONNECTION_ATTEMPT = (0x3D3 + 0x1000),

/* UMB Call Processing Connection Release */
       UMBCP_CONNECTION_RELEASE = (0x3D4 + 0x1000),

/* UMB Call Processing Page Message */
       UMBCP_PAGE_MESSAGE = (0x3D5 + 0x1000),

/* UMB Call Processing OVHD Information */
       UMBCP_OVHD_INFO = (0x3D6 + 0x1000),

/* UMB Call Processing Session Attempt */
       UMBCP_SESSION_ATTEMPT = (0x3D7 + 0x1000),

/* UMB Call Processing Route Information */
       UMBCP_ROUTE_INFO = (0x3D8 + 0x1000),

/* UMB Call Processing State Information */
       UMBCP_STATE_INFO = (0x3D9 + 0x1000),

/* UMB Call Processing SNP */
       UMBCP_SNP = (0x3DA + 0x1000),

/* CGPS Session Early Exit Decision */
       CGPS_SESSION_EARLY_EXIT_DECISION = (0x3DB + 0x1000),

/* GPS RF Linearity Status */
       CGPS_ME_RF_LINEARITY_INFO = (0x3DC + 0x1000),

/* CGPS ME 5ms IQ Sums */
       CGPS_ME_5MS_IQ_SUMS = (0x3DD + 0x1000),

/* CGPS ME 20ms IQ Sums */
       CPGS_ME_20MS_IQ_SUMS = (0x3DE + 0x1000),

/* ROHC Compressor Statistics */
       ROHC_COMPRESSOR_STATS = (0x3DF + 0x1000),

/* ROHC Decompressor Statistics */
       ROHC_DECOMPRESSOR_STATS = (0x3E0 + 0x1000),

/* Sensors - Kalman filter information */
       SENSOR_KF_INFO = (0x3E1 + 0x1000),

/* Sensors - Integrated measurements */
       SENSOR_INT_MEAS = (0x3E2 + 0x1000),

/* Sensors - Bias calibration values */
       SENSOR_BIAS_CALIBRATION = (0x3E3 + 0x1000),

/* Log codes 0x13E4-0x13E7 are not following standard log naming convention */

/* DTV ISDB-T Transport Stream Packets */
       DTV_ISDB_TS_PACKETS = (0x3E4 + 0x1000),

/* DTV ISDB-T PES Packets */
       DTV_ISDB_PES_PACKETS = (0x3E5 + 0x1000),

/* DTV ISDB-T Sections */
       DTV_ISDB_SECTIONS = (0x3E6 + 0x1000),

/* DTV ISDB-T Buffering */
       DTV_ISDB_BUFFERING = (0x3E7 + 0x1000),

/* WLAN System Acquisition and Handoff */
       WLAN_SYS_ACQ_HO = (0x3E8 + 0x1000),

/* WLAN General Configurable Parameters */
       WLAN_GEN_CONFIG_PARAMS = (0x3E9 + 0x1000),

/* UMB Physical Layer Channel and Interference Estimation */
       UMB_PHY_RX_DPICH_CIE = (0x3EA + 0x1000),

/* UMB Physical Layer MMSE/MRC Demodulated Data Symbols (Low) */
       UMB_PHY_RX_DATA_DEMOD_LOW = (0x3EB + 0x1000),

/* UMB Physical Layer MMSE/MRC Demodulated Data Symbols (High) */
       UMB_PHY_RX_DATA_DEMOD_HIGH = (0x3EC + 0x1000),

/* UMB Physical Layer DCH Decoder */
       UMB_PHY_RX_DCH_DECODER = (0x3ED + 0x1000),

/* UMB Physical Layer DCH Statistics */
       UMB_PHY_DCH_STATISTICS = (0x3EE + 0x1000),

/* UMB Physical Layer CqiPich Processing */
       UMB_PHY_RX_CQIPICH = (0x3EF + 0x1000),

/* UMB Physical Layer MIMO/SIMO in CqiPich (High) */
       UMB_PHY_RX_CQIPICH_CHANTAPS_HIGH = (0x3F0 + 0x1000),

/* UMB Physical Layer MIMO/SIMO in CquiPich (Low) */
       UMB_PHY_RX_CQIPICH_CHANTAPS_LOW = (0x3F1 + 0x1000),

/* UMB Physical Layer Time-Domain Channel Taps (High) */
       UMB_PHY_RX_PPICH_CHAN_EST_HIGH = (0x3F2 + 0x1000),

/* UMB Physical Layer Time-Domain Channel Taps (Low) */
       UMB_PHY_RX_PPICH_CHAN_EST_LOW = (0x3F3 + 0x1000),

/* UMB Physical Layer AT Modulator */
       UMB_PHY_TX_PICH_CONFIG = (0x3F4 + 0x1000),

/* UMB Physical Layer AT Modulator for R-ACK (High) */
       UMB_PHY_TX_ACK_HIGH = (0x3F5 + 0x1000),

/* UMB Physical Layer AT Modulator for R-ACK (Low) */
       UMB_PHY_TX_ACK_LOW = (0x3F6 + 0x1000),

/* UMB Physical Layer AT Modulator for R-PICH */
       UMB_PHY_TX_PICH = (0x3F7 + 0x1000),

/* UMB Physical Layer AT Modulator for R-ACH (Access) */
       UMB_PHY_TX_ACH = (0x3F8 + 0x1000),

/* UMB Physical Layer AT Modulator for R-ODDCCH (High) */
       UMB_PHY_TX_ODCCH_HIGH = (0x3F9 + 0x1000),

/* UMB Physical Layer AT Modulator for R-ODDCCH (Low) */
       UMB_PHY_TX_ODCCH_LOW = (0x3FA + 0x1000),

/* UMB Physical Layer AT Modulator for R-CDCCH */
       UMB_PHY_TX_RCDCCH_CONFIG = (0x3FB + 0x1000),

/* UMB Physical Layer AT Modulator for CQI sent on RCDCCH */
       UMB_PHY_TX_NONFLSS_CQICH = (0x3FC + 0x1000),

/* UMB Physical Layer AT Modulator for CQI sent on RCDCCH */
       UMB_PHY_TX_FLSS_CQICH = (0x3FD + 0x1000),

/* UMB Physical Layer AT Modulator for PACH sent on RCDCCH */
       UMB_PHY_TX_PAHCH = (0x3FE + 0x1000),

/* UMB Physical Layer AT Modulator for REQ sent on RCDCCH */
       UMB_PHY_TX_REQCH = (0x3FF + 0x1000),

/* UMB Physical Layer AT Modulator for PSD sent on RCDCCH */
       UMB_PHY_TX_PSDCH = (0x400 + 0x1000),

/* UMB Physical Layer AT Modulator for R-DCH */
       UMB_PHY_TX_DCH = (0x401 + 0x1000),

/* UMB Physical Layer Time/Frequency/RxPower Estimate */
       UMB_PHY_RX_TIME_FREQ_POWER_ESTIMATE = (0x402 + 0x1000),

/* UMB Physical Layer FLCS Processing */
       UMB_PHY_RX_FLCS_PROCESSING = (0x403 + 0x1000),

/* UMB Physical Layer PBCCH Processing */
       UMB_PHY_RX_PBCCH_PROCESSING = (0x404 + 0x1000),

/* UMB Physical Layer SBCCH Processing */
       UMB_PHY_RX_SBCCH_PROCESSING = (0x405 + 0x1000),

/* UMB Physical Layer QPCH Processing */
       UMB_PHY_RX_QPCH_PROCESSING = (0x406 + 0x1000),

/* UMB Physical Layer MRC Demodulated Data Symbols (Preamble SBCCH/QPCH) */
       UMB_PHY_RX_SBCCH_DEMOD = (0x407 + 0x1000),

/* UMB Physical Layer MRC Demodulated Data Symbols (Preamble PBCCH) */
       UMB_PHY_RX_PBCCH_DEMOD = (0x408 + 0x1000),

/* UMB Physical Layer VCQI */
       UMB_PHY_RX_VCQI = (0x409 + 0x1000),

/* UMB Physical Layer Acquisition Algorithm */
       UMB_PHY_RX_INITIAL_ACQUISITION = (0x40A + 0x1000),

/* UMB Physical Layer Handoff Search Algorithm */
       UMB_PHY_RX_HANDOFF_SEARCH = (0x40B + 0x1000),

/* UMB RF RFFE Configuration Info */
       UMB_AT_RFFE_CONFG = (0x40C + 0x1000),

/* UMB RF Calibrated Values After Powerup */
       UMB_AT_RFFE_RX_CALIB = (0x40D + 0x1000),

/* UMB RF AGC Block in Acquisition Mode */
       UMB_AT_RFFE_RX_ACQ = (0x40E + 0x1000),

/* UMB RF AGC Block in Idle Mode */
       UMB_AT_RFFE_RX_IDLE = (0x40F + 0x1000),

/* UMB RF AGC Block in Connected Mode */
       UMB_AT_RFFE_RX_CONNECTED = (0x410 + 0x1000),

/* UMB RF AGC Block in Connected Mode (FTM) */
       UMB_AT_RFFE_RX_CONNECTED_FTM = (0x411 + 0x1000),

/* UMB RF Jammer Detector Functionality */
       UMB_AT_RFFE_RX_JAMMER_DETECTOR_FUNCTIONALITY = (0x412 + 0x1000),

/* UMB RF Jammer Detector Response */
       UMB_AT_RFFE_RX_JAMMER_DETECTOR_RESPONSE = (0x413 + 0x1000),

/* UMB RF RFFE TX Power Control */
       UMB_AT_RFFE_TX_BETA_SCALING = (0x414 + 0x1000),

/* UMB Searcher Dump */
       UMB_SEARCHER_DUMP = (0x415 + 0x1000),

/* UMB System Acquire */
       UMB_SYSTEM_ACQUIRE = (0x416 + 0x1000),

/* UMB Set Maintenance */
       UMB_SET_MAINTENANCE = (0x417 + 0x1000),

/* UMB QPCH */
       UMB_QPCH = (0x418 + 0x1000),

/* UMB RLL Forward Partial RP Packet */
       UMB_RLL_FORWARD_PARTIAL_RP = (0x419 + 0x1000),

/* UMB RLL Reverse Partial RP Packet */
       UMB_RLL_REVERSE_PARTIAL_RP = (0x41A + 0x1000),

/* UMB RLL Forward Signal Packet */
       UMB_RLL_FORWARD_SIGNAL = (0x41B + 0x1000),

/* UMB RLL Reverse Signal Packet */
       UMB_RLL_REVERSE_SIGNAL = (0x41C + 0x1000),

/* UMB RLL Forward Statistics */
       UMB_RLL_FORWARD_STATS = (0x41D + 0x1000),

/* UMB RLL Reverse Statistics */
       UMB_RLL_REVERSE_STATS = (0x41E + 0x1000),

/* UMB RLL IRTP */
       UMB_RLL_IRTP = (0x41F + 0x1000),

/* UMB AP Forward Link MAC Packets */
       UMB_AP_FL_MAC_PACKET = (0x420 + 0x1000),

/* UMB AP Reverse Link MAC Packets */
       UMB_AP_RL_MAC_PACKET = (0x421 + 0x1000),

/* GPS Performance Statistics log */
       CGPS_PERFORMANCE_STATS = (0x422 + 0x1000),

/* UMB Searcher General Status */
       UMB_SRCH_GENERAL_STATUS = (0x423 + 0x1000),

/* UMB Superframe Scheduler */
       UMB_SUPERFRAME_SCHEDULER = (0x424 + 0x1000),

/* UMB Sector List */
       UMB_SECTOR_LIST = (0x425 + 0x1000),

/* UMB MAC Access Attempt Command */
       UMB_MAC_ACCESS_ATTEMPT_CMD = (0x426 + 0x1000),

/* UMB MAC Access Probe Information */
       UMB_MAC_ACCESS_PROBE_INFO = (0x427 + 0x1000),

/* UMB MAC RTCMAC Package Information */
       UMB_MAC_RTCMAC_PKG_INFO = (0x428 + 0x1000),

/* UMB MAC Super Frame Information */
       UMB_MAC_SI_INFO = (0x429 + 0x1000),

/* UMB MAC Quick Channel Information */
       UMB_MAC_QCI_INFO = (0x42A + 0x1000),

/* UMB MAC Paging Id List */
       UMB_MAC_PAGING_ID_LIST = (0x42B + 0x1000),

/* UMB MAC Quick Paging Channel Information */
       UMB_MAC_QPCH_INFO = (0x42C + 0x1000),

/* UMB MAC FTCMAC Information */
       UMB_MAC_FTCMAC_PKG_INFO = (0x42D + 0x1000),

/* UMB MAC Access Grant Receiving */
       UMB_MAC_ACCESS_GRANT = (0x42E + 0x1000),

/* UMB MAC Generic Debug Log */
       UMB_MAC_GEN_DEBUG_LOG_PKG = (0x42F + 0x1000),

/* CGPS Frequency Bias Estimate */
       CGPS_MC_FREQ_BIAS_EST = (0x430 + 0x1000),

/* UMB MAC Request Report Information Log */
       UMB_MAC_REQCH_REPORT_INFO = (0x431 + 0x1000),

/* UMB MAC Reverse Link QoS Token Bucket Information Log */
       UMB_MAC_RLQOS_TOKEN_BUCKET_INFO = (0x432 + 0x1000),

/* UMB MAC Reverse Link QoS Stream Information Log */
       UMB_MAC_RLQOS_STREAM_INFO = (0x433 + 0x1000),

/* UMB MAC Reverse Link QoS Allotment Information Log */
       UMB_MAC_RLQOS_ALLOTMENT_INFO = (0x434 + 0x1000),

/* UMB Searcher Recent State Machine Transactions */
       UMB_SRCH_STM_ACTIVITY = (0x435 + 0x1000),

/* Performance Counters on ARM11 Profiling Information */
       ARM11_PERF_CNT_INFO = (0x436 + 0x1000),

/* Protocol Services describe all flow instances */
       PS_STAT_DESC_ALL_FLOW_INST = (0x437 + 0x1000),

/* Protocol Services describe all physical link instances */
       PS_STAT_DESC_ALL_PHYS_LINK_INST = (0x438 + 0x1000),

/* Protocol Services describe all UDP instances */
       PS_STAT_DESC_ALL_UDP_INST = (0x439 + 0x1000),

/* Searcher 4 Multi-Carrier HDR */
       SRCH4_MC_HDR = (0x43A + 0x1000),

/* Protocol Services describe all IPHC instances */
       PS_STAT_DESC_ALL_IPHC_INST = (0x43B + 0x1000),

/* Protocol Services describe all ROHC instances */
       PS_STAT_DESC_ALL_ROHC_INST = (0x43C + 0x1000),

/* BCast security add program information */
       BCAST_SEC_ADD_PROGRAM_INFO = (0x43D + 0x1000),

/* BCast security add program complete */
       BCAST_SEC_ADD_PROGRAM_COMPLETE = (0x43E + 0x1000),

/* BCast security SDP parse */
       BCAST_SEC_SDP_PARSE = (0x43F + 0x1000),

/* CGPS ME dynamic power optimization status */
       CGPS_ME_DPO_STATUS = (0x440 + 0x1000),

/* CGPS PDSM on demand session start */
       CGPS_PDSM_ON_DEMAND_SESSION_START = (0x441 + 0x1000),

/* CGPS PDSM on demand session stop */
       CGPS_PDSM_ON_DEMAND_SESSION_STOP = (0x442 + 0x1000),

/* CGPS PDSM on demand session not started */
       CGPS_PDSM_ON_DEMAND_SESSION_NOT_STARTED = (0x443 + 0x1000),

/* CGPS PDSM extern coarse position inject start */
       CGPS_PDSM_EXTERN_COARSE_POS_INJ_START = (0x444 + 0x1000),

/* DTV ISDB-T TMCC information */
       DTV_ISDB_TMCC = (0x445 + 0x1000),

/* RF development */
       RF_DEV = (0x446 + 0x1000),

/* RF RFM API */
       RF_RFM_API = (0x447 + 0x1000),

/* RF RFM state */
       RF_RFM_STATE = (0x448 + 0x1000),

/* 1X RF Warmup */
      LOG_1X_RF_WARMUP = (0x449 + 0x1000),

/* 1X RF power limiting */
      LOG_1X_RF_PWR_LMT = (0x44A + 0x1000),

/* 1X RF state */
      LOG_1X_RF_STATE = (0x44B + 0x1000),

/* 1X RF sleep */
      LOG_1X_RF_SLEEP = (0x44C + 0x1000),

/* 1X RF TX state */
      LOG_1X_RF_TX_STATE = (0x44D + 0x1000),

/* 1X RF IntelliCeiver state */
      LOG_1X_RF_INT_STATE = (0x44E + 0x1000),

/* 1X RF RX ADC clock */
      LOG_1X_RF_RX_ADC_CLK = (0x44F + 0x1000),

/* 1X RF LNA switch point */
      LOG_1X_RF_LNA_SWITCHP = (0x450 + 0x1000),

/* 1X RF RX calibration */
      LOG_1X_RF_RX_CAL = (0x451 + 0x1000),

/* 1X RF API */
      LOG_1X_RF_API = (0x452 + 0x1000),

/* 1X RF RX PLL locking status */
      LOG_1X_RF_RX_PLL_LOCK = (0x453 + 0x1000),

/* 1X RF voltage regulator */
      LOG_1X_RF_VREG = (0x454 + 0x1000),

/* CGPS DIAG successful fix count */
       CGPS_DIAG_SUCCESSFUL_FIX_COUNT = (0x455 + 0x1000),

/* CGPS MC track dynamic power optimization status */
       CGPS_MC_TRACK_DPO_STATUS = (0x456 + 0x1000),

/* CGPS MC SBAS demodulated bits */
       CGPS_MC_SBAS_DEMOD_BITS = (0x457 + 0x1000),

/* CGPS MC SBAS demodulated soft symbols */
       CGPS_MC_SBAS_DEMOD_SOFT_SYMBOLS = (0x458 + 0x1000),

/* Data Services PPP configuration */
       DS_PPP_CONFIG_PARAMS = (0x459 + 0x1000),

/* Data Services physical link configuration */
       DS_PHYS_LINK_CONFIG_PARAMS = (0x45A + 0x1000),

/* Data Services PPP device configuration */
       PS_PPP_DEV_CONFIG_PARAMS = (0x45B + 0x1000),

/* CGPS PDSM GPS state information */
       CGPS_PDSM_GPS_STATE_INFO = (0x45C + 0x1000),

/* CGPS PDSM EXT status GPS state information */
       CGPS_PDSM_EXT_STATUS_GPS_STATE_INFO = (0x45D + 0x1000),

/* CGPS ME Rapid Search Report */
       CGPS_ME_RAPID_SEARCH_REPORT = (0x45E + 0x1000),

/* CGPS PDSM XTRA-T session */
       CGPS_PDSM_XTRA_T_SESSION = (0x45F + 0x1000),

/* CGPS PDSM XTRA-T upload */
       CGPS_PDSM_XTRA_T_UPLOAD = (0x460 + 0x1000),

/* CGPS Wiper Position Report */
       CGPS_WIPER_POSITION_REPORT = (0x461 + 0x1000),

/* DTV DVBH Security SmartCard HTTP Digest Request Info */
       DTV_DVBH_SEC_SC_HTTP_DIGEST_REQ = (0x462 + 0x1000),

/* DTV DVBH Security SmartCard HTTP Digest Response Info */
       DTV_DVBH_SEC_SC_HTTP_DIGEST_RSP = (0x463 + 0x1000),

/* DTV DVBH Security SmartCard Services Registration Request Info */
       DTV_DVBH_SEC_SC_SVC_REG_REQ = (0x464 + 0x1000),

/* DTV DVBH Security SmartCard Services Registration Complete Info */
       DTV_DVBH_SEC_SC_SVC_REG_COMPLETE = (0x465 + 0x1000),

/* DTV DVBH Security SmartCard Services Deregistration Request Info */
       DTV_DVBH_SEC_SC_SVC_DEREG_REQ = (0x466 + 0x1000),

/* DTV DVBH Security SmartCard Services Deregistration Complete Info */
       DTV_DVBH_SEC_SC_SVC_DEREG_COMPLETE = (0x467 + 0x1000),

/* DTV DVBH Security SmartCard LTKM Request Info */
       DTV_DVBH_SEC_SC_LTKM_REQ = (0x468 + 0x1000),

/* DTV DVBH Security SmartCard LTKM Request Complete Info */
       DTV_DVBH_SEC_SC_LTKM_REQ_COMPLETE = (0x469 + 0x1000),

/* DTV DVBH Security SmartCard Program Selection Info */
       DTV_DVBH_SEC_SC_PROG_SEL = (0x46A + 0x1000),

/* DTV DVBH Security SmartCard Program Selection Complete Info */
       DTV_DVBH_SEC_SC_PROG_SEL_COMPLETE = (0x46B + 0x1000),

/* DTV DVBH Security SmartCard LTKM */
       DTV_DVBH_SEC_SC_LTKM = (0x46C + 0x1000),

/* DTV DVBH Security SmartCard LTKM Verification Message */
       DTV_DVBH_SEC_SC_LTKM_VERIFICATION = (0x46D + 0x1000),

/* DTV DVBH Security SmartCard Parental Control Message */
       DTV_DVBH_SEC_SC_PARENTAL_CTRL = (0x46E + 0x1000),

/* DTV DVBH Security SmartCard STKM */
       DTV_DVBH_SEC_SC_STKM = (0x46F + 0x1000),

/* Protocol Services Statistics Global Socket */
       PS_STAT_GLOBAL_SOCK = (0x470 + 0x1000),

/* MCS Application Manager */
       MCS_APPMGR = (0x471 + 0x1000),

/* MCS MSGR */
       MCS_MSGR = (0x472 + 0x1000),

/* MCS QTF  */
       MCS_QTF = (0x473 + 0x1000),

/* Sensors Stationary Detector Output */
       STATIONARY_DETECTOR_OUTPUT = (0x474 + 0x1000),

/* Print out the ppm data portion  */
       CGPS_PDSM_EXT_STATUS_MEAS_REPORT_PPM = (0x475 + 0x1000),

/* GNSS Position Report */
       GNSS_POSITION_REPORT = (0x476 + 0x1000),

/* GNSS GPS Measurement Report */
       GNSS_GPS_MEASUREMENT_REPORT = (0x477 + 0x1000),

/* GNSS Clock Report */
       GNSS_CLOCK_REPORT = (0x478 + 0x1000),

/* GNSS Demod Soft Decision */
       GNSS_DEMOD_SOFT_DECISIONS = (0x479 + 0x1000),

/* GNSS ME 5MS IQ sum */
       GNSS_ME_5MS_IQ_SUMS = (0x47A + 0x1000),

/* GNSS CD DB report */
       GNSS_CD_DB_REPORT = (0x47B + 0x1000),

/* GNSS PE WLS position report */
       GNSS_PE_WLS_POSITION_REPORT = (0x47C + 0x1000),

/* GNSS PE KF position report */
       GNSS_PE_KF_POSITION_REPORT = (0x47D + 0x1000),

/* GNSS PRX RF HW status report */
       GNSS_PRX_RF_HW_STATUS_REPORT = (0x47E + 0x1000),

/* GNSS DRX RF HW status report */
       GNSS_DRX_RF_HW_STATUS_REPORT = (0x47F + 0x1000),

/* GNSS Glonass Measurement report */
       GNSS_GLONASS_MEASUREMENT_REPORT = (0x480 + 0x1000),

/* GNSS GPS HBW RXD measurement */
       GNSS_GPS_HBW_RXD_MEASUREMENT = (0x481 + 0x1000),

/* GNSS PDSM position report callback */
       GNSS_PDSM_POSITION_REPORT_CALLBACK = (0x482 + 0x1000),

/* ISense Request String  */
       ISENSE_REQUEST_STR = (0x483 + 0x1000),

/* ISense Response String */
       ISENSE_RESPONSE_STR = (0x484 + 0x1000),

/* Bluetooth SOC General Log Packet*/
       BT_SOC_GENERAL = (0x485 + 0x1000),

/* QCRil Call Flow */
       QCRIL_CALL_FLOW = (0x486 + 0x1000),

/* CGPS Wideband FFT stats */
       CGPS_WB_FFT_STATS = (0x487 + 0x1000),

/* CGPS Slow Clock Calibration Report*/
       CGPS_SLOW_CLOCK_CALIB_REPORT = (0x488 + 0x1000),

/* SNS GPS TIMESTAMP */
       SNS_GPS_TIMESTAMP = (0x489 + 0x1000),

/* GNSS Search Strategy Task Allocation */
       GNSS_SEARCH_STRATEGY_TASK_ALLOCATION = (0x48A + 0x1000),

/* RF MC STM state */
       LOG_1XHDR_MC_STATE = (0x48B + 0x1000),

/* Record in the Sparse Network DB */
       CGPS_SNDB_RECORD = (0x48C + 0x1000),

/* Record removed from the DB */
       CGPS_SNDB_REMOVE = (0x48D + 0x1000),

/* CGPS Reserved */
       GNSS_CC_PERFORMANCE_STATS = (0x48E + 0x1000),

/* GNSS PDSM Set Paramerters */
       GNSS_PDSM_SET_PARAMETERS = (0x48F + 0x1000),

/* GNSS PDSM PD Event Callback */
       GNSS_PDSM_PD_EVENT_CALLBACK = (0x490 + 0x1000),

/* GNSS PDSM PA Event Callback */
       GNSS_PDSM_PA_EVENT_CALLBACK = (0x491 + 0x1000),

/* CGPS Reserved */
       CGPS_RESERVED2 = (0x492 + 0x1000),

/* CGPS Reserved */
       CGPS_RESERVED3 = (0x493 + 0x1000),

/* GNSS PDSM EXT Status MEAS Report */
       GNSS_PDSM_EXT_STATUS_MEAS_REPORT = (0x494 + 0x1000),

/* GNSS SM Error */
       GNSS_SM_ERROR = (0x495 + 0x1000),

/* WLAN Scan */
       WLAN_SCAN = (0x496 + 0x1000),

/* WLAN IBSS */
       WLAN_IBSS = (0x497 + 0x1000),

/* WLAN 802.11d*/
       WLAN_80211D = (0x498 + 0x1000),

/* WLAN Handoff */
       WLAN_HANDOFF = (0x499 + 0x1000),

/* WLAN QoS EDCA */
       WLAN_QOS_EDCA = (0x49A + 0x1000),

/* WLAN Beacon Update */
       WLAN_BEACON_UPDATE = (0x49B + 0x1000),

/* WLAN Power save wow add pattern */
       WLAN_POWERSAVE_WOW_ADD_PTRN = (0x49C + 0x1000),

/* WLAN WCM link metrics */
       WLAN_WCM_LINKMETRICS = (0x49D + 0x1000),

/* WLAN wps scan complete*/
       WLAN_WPS_SCAN_COMPLETE = (0x49E + 0x1000),

/* WLAN WPS WSC Message */
       WLAN_WPS_WSC_MESSAGE = (0x49F + 0x1000),

/* WLAN WPS credentials */
       WLAN_WPS_CREDENTIALS = (0x4A0 + 0x1000),

/* WLAN Linklayer stat*/
       WLAN_LINKLAYER_STAT = (0x4A1 + 0x1000),

/* WLAN Qos TSpec*/
       WLAN_QOS_TSPEC = (0x4A2 + 0x1000),

/* PMIC Vreg Control */
       PM_VREG_CONTROL = (0x4A3 + 0x1000),

/* PMIC Vreg Level */
       PM_VREG_LEVEL = (0x4A4 + 0x1000),

/* PMIC Vreg State */
       PM_VREG_STATE = (0x4A5 + 0x1000),

/* CGPS SM EPH Randomization info */
       CGPS_SM_EPH_RANDOMIZATION_INFO = (0x4A6 + 0x1000),

/* Audio calibration data */
       QACT_DATA = (0x4A7 + 0x1000),

/* Compass 2D Tracked Calibration Set */
       SNS_VCPS_2D_TRACKED_CAL_SET = (0x4A8 + 0x1000),

/* Compass 3D Tracked Calibration Set  */
       SNS_VCPS_3D_TRACKED_CAL_SET = (0x4A9 + 0x1000),

/* Calibration metric */
       SNS_VCPS_CAL_METRIC = (0x4AA + 0x1000),

/* Accelerometer distance */
       SNS_VCPS_ACCEL_DIST = (0x4AB + 0x1000),

/* Plane update */
       SNS_VCPS_PLANE_UPDATE = (0x4AC + 0x1000),

/* Location report  */
       SNS_VCPS_LOC_REPORT = (0x4AD + 0x1000),

/* CM Active subscription */
       CM_PH_EVENT_SUBSCRIPTION_PREF_INFO = (0x4AE + 0x1000),

/* DSDS version of CM call event */
       CM_DS_CALL_EVENT = (0x4AF + 0x1000),

/* Sensors ?MobiSens Output */
       MOBISENS_OUTPUT = (0x4B0 + 0x1000),

/* Accelerometer Data   */
       ACCEL_DATA = (0x4B1 + 0x1000),

/* Accelerometer Compensated Data  */
       ACCEL_COMP_DATA = (0x4B2 + 0x1000),

/* Motion State Data  */
       MOTION_STATE_DATA = (0x4B3 + 0x1000),

/* Stationary Position Indicator  */
       STAT_POS_IND = (0x4B4 + 0x1000),

/* Motion State Features   */
       MOTION_STATE_FEATURES = (0x4B5 + 0x1000),

/* Motion State Hard Decision */
       MOTION_STATE_HARD_DECISION = (0x4B6 + 0x1000),

/* Motion State Soft Decision */
       MOTION_STATE_SOFT_DECISION = (0x4B7 + 0x1000),

/* Sensors Software Version */
       SENSORS_SOFTWARE_VERSION = (0x4B8 + 0x1000),

/* MobiSens Stationary Position Indicator Log Packet */
       MOBISENS_SPI = (0x4B9 + 0x1000),

/* XO calibration raw IQ data */
       XO_IQ_DATA = (0x4BA + 0x1000),

/*DTV CMMB Control Tabl Updated*/
       DTV_CMMB_CONTROL_TABLE_UPDATE = ((0x4BB) + 0x1000),

/*DTV CMMB Media API Buffering Status*/
       DTV_CMMB_MEDIA_BUFFERING_STATUS = ((0x4BC) + 0x1000),

/*DTV CMMB *Emergency Broadcast Data*/
       DTV_CMMB_CONTROL_EMERGENCY_BCAST = ((0x4BD) + 0x1000),

/*DTV CMMB EMM/ECM Data*/
       DTV_CMMB_CAS_EMM_ECM = ((0x4BE) + 0x1000),

/*DTV CMMB HW Status*/
       DTV_CMMB_HW_PERFORMANCE = ((0x4BF) + 0x1000),

/*DTV CMMB ESSG Program Indication Information*/
       DTV_CMMB_ESG_PROGRAM_INDICATION_INFORMATION = ((0x4C0) + 0x1000),

/* Sensors �C binary output of converted sensor data */
       CONVERTED_SENSOR_DATA = ((0x4C1) + 0x1000),

/* CM Subscription event */
       CM_SUBSCRIPTION_EVENT = ((0x4C2) + 0x1000),

/* Sensor Ambient Light Data */
       SNS_ALS_DATA = ((0x4C3) + 0x1000),

/*Sensor Ambient Light Adaptive Data */
       SNS_ALS_DATA_ADAPTIVE = ((0x4C4) + 0x1000),

/*Sensor Proximity Distance Data */
       SNS_PRX_DIST_DATA = ((0x4C5) + 0x1000),

/*Sensor Proximity Data */
       SNS_PRX_DATA = ((0x4C6) + 0x1000),

       GNSS_SBAS_REPORT = ((0x4C7) + 0x1000),

       CPU_MONITOR_MODEM = ((0x4C8) + 0x1000),

       CPU_MONITOR_APPS = ((0x4C9) + 0x1000),

       BLAST_TASKPROFILE = ((0x4CA) + 0x1000),

       BLAST_SYSPROFILE = ((0x4CB) + 0x1000),

/* Aliasing instead of replacing to keep backwards compatibility */
       FM_RADIO_FTM = ((0x4CC) + 0x1000),

       FM_RADIO = ((0x4CD) + 0x1000),

       UIM_DS_DATA = ((0x4CE) + 0x1000),

       QMI_CALL_FLOW = ((0x4CF) + 0x1000),

       APR_MODEM = ((0x4D0) + 0x1000),

       APR_APPS = ((0x4D1) + 0x1000),

       APR_ADSP = ((0x4D2) + 0x1000),

       DATA_MUX_RX_RAW_PACKET = ((0x4D3) + 0x1000),

       DATA_MUX_TX_RAW_PACKET = ((0x4D4) + 0x1000),

       DATA_MUX_RX_FRAME_PACKET = ((0x4D5) + 0x1000),

       DATA_MUX_TX_FRAME_PACKET = ((0x4D6) + 0x1000),

       CGPS_PDSM_EXT_STATUS_POS_INJ_REQ_INFO = ((0x4D7) + 0x1000),

       TEMPERATURE_MONITOR = ((0x4D8) + 0x1000),

       SNS_GESTURES_REST_DETECT = ((0x4D9) + 0x1000),

       SNS_GESTURES_ORIENTATION = ((0x4DA) + 0x1000),

       SNS_GESTURES_FACING = ((0x4DB) + 0x1000),

       SNS_GESTURES_BASIC = ((0x4DC) + 0x1000),

       SNS_GESTURES_HINBYE = ((0x4DD) + 0x1000),

       GNSS_OEMDRE_MEASUREMENT_REPORT = ((0x4DE) + 0x1000),

       GNSS_OEMDRE_POSITION_REPORT = ((0x4E0) + 0x1000),

       GNSS_OEMDRE_SVPOLY_REPORT = ((0x4E1) + 0x1000),

       GNSS_OEMDRSYNC = ((0x4E2) + 0x1000),

       SNS_MGR_EVENT_NOTIFY = ((0x4E3) + 0x1000),

       SNS_MGR_EVENT_REGISTER = ((0x4E4) + 0x1000),

       GNSS_PDSM_PPM_SESSION_BEGIN = ((0x4E5) + 0x1000),

       GNSS_PDSM_PPM_SESSION_PPM_SUSPEND = ((0x4E6) + 0x1000),

       GNSS_PDSM_PPM_REPORT_THROTTLED = ((0x4E7) + 0x1000),

       GNSS_PDSM_PPM_REPORT_FIRED = ((0x4E8) + 0x1000),

       GNSS_PDSM_PPM_SESSION_END = ((0x4E9) + 0x1000),

       SNS_REGISTRY_OPERATION = ((0x4EA) + 0x1000),

       WMK_TRACE = ((0x4EB) + 0x1000),

      LOG_1X_ADV_FET_STATS = ((0x4EC) + 0x1000),

      LOG_1X_ADV_L1_PERF = ((0x4ED) + 0x1000),

       AUDIO_VOCODER_STREAM_DATA_PATH = ((0x4EE) + 0x1000),

       BLAST_PM = ((0x4EF) + 0x1000),

       SNS_SENSOR1_REQUEST = ((0x4F0) + 0x1000),

       SNS_SENSOR1_RESPONSE = ((0x4F1) + 0x1000),

       SNS_SENSOR1_INDICATION = ((0x4F2) + 0x1000),

       SNS_SMR_REQUEST = ((0x4F3) + 0x1000),

       SNS_SMR_RESPONSE = ((0x4F4) + 0x1000),

       SNS_SMR_INDICATION = ((0x4F5) + 0x1000),

       INTERNAL_TX_AUDIO_PCM_ADSP = ((0x4F6) + 0x1000),

       INTERNAL_RX_AUDIO_PCM_ADSP = ((0x4F7) + 0x1000),

       EXTERNAL_TX_AUDIO_PCM_ADSP = ((0x4F8) + 0x1000),

       EXTERNAL_RX_AUDIO_PCM_ADSP = ((0x4F9) + 0x1000),

       FM_RX_AUDIO_PCM_ADSP = ((0x4FA) + 0x1000),

       HDMI_RX_AUDIO_PCM_ADSP = ((0x4FB) + 0x1000),

       TLM_SNDB_RECORD = ((0x4FC) + 0x1000),

       TLM_CELLDB_RECORD = ((0x4FD) + 0x1000),

       TLM_OPS_MEASUREMENTS = ((0x4FE) + 0x1000),

       TLM_MOBILE_STATUS_HEADER = ((0x4FF) + 0x1000),

       TLM_MOBILE_STATUS_DATA = ((0x500) + 0x1000),

       TLM_XTA_PARTITION = ((0x501) + 0x1000),

       TLM_CLIENT_DOWNLOAD_DATA = ((0x502) + 0x1000),

       XTM_XTA_MSG_WRITE = ((0x503) + 0x1000),

       XTM_XTA_MSG_READ = ((0x504) + 0x1000),

       XTM_HTTP_RESPONSE_STATUS = ((0x505) + 0x1000),

       XTM_XTA_RESPONSE_STATUS = ((0x506) + 0x1000),

       TLM_FAILED_LOOKUP = ((0x507) + 0x1000),

       SENSORS_SDP_VIRGO = ((0x508) + 0x1000),

       SENSORS_SDP_SSD = ((0x509) + 0x1000),

       SENSORS_SDP_CRD = ((0x50A) + 0x1000),

       SENSORS_SDP_TIME_SYNC = ((0x50B) + 0x1000),

       SENSORS_SDP_MSD = ((0x50C) + 0x1000),

       GNSS_SENSOR_STREAMING_READY_STATUS = ((0x50D) + 0x1000),

       GNSS_TIME_SYNC_REQ = ((0x50E) + 0x1000),

       GNSS_INJECT_TIME_SYNC_DATA = ((0x50F) + 0x1000),

       GNSS_INJECT_SENSOR_DATA = ((0x510) + 0x1000),

       GNSS_GET_SENSOR_CONFIG_RESPONSE = ((0x511) + 0x1000),

       GNSS_SET_SENSOR_CONFIG = ((0x512) + 0x1000),

       GNSS_PE_HEADING_FILTER = ((0x513) + 0x1000),

       GNSS_PE_NHC = ((0x514) + 0x1000),

       GNSS_PE_CRD = ((0x515) + 0x1000),

/* The below two logs are the same. This is done so we don't break any build that
   is using the older name  (LOG_GNSS_PE_RESERVED) */
       GNSS_PE_RESERVED = ((0x516) + 0x1000),

       GNSS_CONFIGURATION_STATE = ((0x516) + 0x1000),

       HSU_HEALTH_TXTHROUGHPUT = ((0x517) + 0x1000),

       HSU_HEALTH_RXTHROUGHPUT = ((0x518) + 0x1000),

       GNSS_YAW_GYRO_CALIBRATION = ((0x519) + 0x1000),

       SENSORS_SDP_INTERNAL = ((0x51A) + 0x1000),

       SNS_DSPS_PWR = ((0x51B) + 0x1000),

       SNS_RAW_I2C_DATA = ((0x51C) + 0x1000),

       SNS_QMD_CONFIG = ((0x51D) + 0x1000),

       SNS_QMD_RESULT = ((0x51E) + 0x1000),

       SNS_QMD_REPORT = ((0x51F) + 0x1000),

       GNSS_BP_AMP_INFO = ((0x520) + 0x1000),

       CORE_AUDIO_DRIVER_DATA = ((0x521) + 0x1000),

       CORE_AUDIO_DRIVER_CONTROL = ((0x522) + 0x1000),

       SNS_FNS_CONFIG = ((0x523) + 0x1000),

       SNS_FNS_RESULT = ((0x524) + 0x1000),

       SNS_FNS_REPORT = ((0x525) + 0x1000),

       GNSS_BROADBAND_JAMMER_INFO = ((0x526) + 0x1000),

       ADSP_PERFMON = ((0x527) + 0x1000),

       SNS_BTE_CONFIG = ((0x528) + 0x1000),

       SNS_BTE_RESULT = ((0x529) + 0x1000),

       SNS_BTE_REPORT = ((0x52A) + 0x1000),

       SNS_GYRO_SIMP_CAL_CONFIG = ((0x52B) + 0x1000),

       SNS_GYRO_SIMP_CAL_RESULT = ((0x52C) + 0x1000),

       SNS_GYRO_SIMP_CAL_REPORT = ((0x52D) + 0x1000),

       ADSP_AUD_DEC_IN = ((0x52E) + 0x1000),

       ADSP_AUD_POPP_IN = ((0x52F) + 0x1000),

       ADSP_AUD_MTMX_RX_IN = ((0x530) + 0x1000),

       ADSP_AUD_COPP_IN = ((0x531) + 0x1000),

       ADSP_AUD_COPREP_IN = ((0x532) + 0x1000),

       ADSP_AUD_MTMX_TX_IN = ((0x533) + 0x1000),

       ADSP_AUD_POPREP_IN = ((0x534) + 0x1000),

       ADSP_AUD_ENC_IN = ((0x535) + 0x1000),

       ADSP_AUD_ENC_OUT = ((0x536) + 0x1000),

       QTV_HTTP_BUFFER_OCCUPANCY = ((0x537) + 0x1000),

       QTV_HTTP_INCOMING_DATARATE = ((0x538) + 0x1000),

       QTV_HTTP_DOWNLOAD_BITRATE_SWITCH_C = ((0x539) + 0x1000),

       QTV_HTTP_PLAYBACK_BITRATE_SWITCH_C = ((0x53A) + 0x1000),

       DS_EPC_PDN_INFO = ((0x53B) + 0x1000),

       SNS_QUAT_CONFIG = ((0x53C) + 0x1000),

       SNS_QUAT_RESULT = ((0x53D) + 0x1000),

       SNS_QUAT_REPORT = ((0x53E) + 0x1000),

       SNS_GRAVITY_CONFIG = ((0x53F) + 0x1000),

       SNS_GRAVITY_RESULT = ((0x540) + 0x1000),

       SNS_GRAVITY_REPORT = ((0x541) + 0x1000),

       SENSOR_FULL_CALIBRATION = ((0x542) + 0x1000),

       QCHATUPK = ((0x543) + 0x1000),

       MCS_QCSI_PKT = ((0x544) + 0x1000),

       QBI_RX_CONTEXT_0 = ((0x545) + 0x1000),

       QBI_TX_CONTEXT_0 = ((0x546) + 0x1000),

       QBI_RX_CONTEXT_1 = ((0x547) + 0x1000),

       QBI_TX_CONTEXT_1 = ((0x548) + 0x1000),

       QBI_RX_CONTEXT_2 = ((0x549) + 0x1000),

       QBI_TX_CONTEXT_2 = ((0x54A) + 0x1000),

       QBI_RX_CONTEXT_3 = ((0x54B) + 0x1000),

       QBI_TX_CONTEXT_3 = ((0x54C) + 0x1000),

       QBI_RX_CONTEXT_4 = ((0x54D) + 0x1000),

       QBI_TX_CONTEXT_4 = ((0x54E) + 0x1000),

       QBI_RX_CONTEXT_5 = ((0x54F) + 0x1000),

       QBI_TX_CONTEXT_5 = ((0x550) + 0x1000),

       QBI_RX_CONTEXT_6 = ((0x551) + 0x1000),

       QBI_TX_CONTEXT_6 = ((0x552) + 0x1000),

       QBI_RX_CONTEXT_7 = ((0x553) + 0x1000),

       QBI_TX_CONTEXT_7 = ((0x554) + 0x1000),

       WMGR = ((0x555) + 0x1000),

       DS_MEMORY_PACKETS = ((0x556) + 0x1000),

       MMODE_CALL_FLOW = ((0x557) + 0x1000),

       WCNSS_AUDIO_DATA = ((0x558) + 0x1000),

       SNS_DRV_MD_IRQ = ((0x559) + 0x1000),

       SNS_MAG_CAL_CONFIG = ((0x55A) + 0x1000),

       SNS_MAG_CAL_RESULT = ((0x55B) + 0x1000),

       SNS_MAG_CAL_REPORT = ((0x55C) + 0x1000),

       GNSS_QUIPS_POSITION_REPORT_C = ((0x55D) + 0x1000),

       GNSS_QUIPS_AP_MEAS_BLOCKS = ((0x55E) + 0x1000),

       SNS_ROTATION_VECTOR_CONFIG_C = ((0x55F) + 0x1000),

       SNS_ROTATION_VECTOR_RESULT_C = ((0x560) + 0x1000),

       SNS_ROTATION_VECTOR_REPORT_C = ((0x561) + 0x1000),

       SNS_FMV_CONFIG = ((0x562) + 0x1000),

       SNS_FMV_QUAT_UPDATE = ((0x563) + 0x1000),

       SNS_FMV_MAG_UPDATE = ((0x564) + 0x1000),

       SNS_FMV_GYRO_UPDATE = ((0x565) + 0x1000),

       SNS_FMV_REPORT = ((0x566) + 0x1000),

       GNSS_FAST_TCAL = ((0x567) + 0x1000),

       IMS_RTP_SN_AND_PAYLOAD_LOG_PACKET_C = ((0x568) + 0x1000),

       IMS_RTP_PACKET_LOSS = ((0x569) + 0x1000),

       IMS_RTCP_PACKET = ((0x56A) + 0x1000),

       IMS_QDJ_ENQUEUE = ((0x56B) + 0x1000),

       IMS_QDJ_DEQUEUE = ((0x56C) + 0x1000),

       IMS_QDJ_UPDATE = ((0x56D) + 0x1000),

       IMS_MESSAGE = ((0x56E) + 0x1000),

       GNSS_QUIPS_IN_USE_AP_DATABASE = ((0x56F) + 0x1000),

       CGPS_PRS_OCCASION_MEAS = ((0x570) + 0x1000),

       IMS_AMR_REDUNDANCY = ((0x571) + 0x1000),

       DATA_PROTOCOL_LOGGING_NETWORK_IP_RM_TX_80_BYTES = ((0x572) + 0x1000),
       DATA_PROTOCOL_LOGGING_NETWORK_IP_RM_RX_80_BYTES = ((0x573) + 0x1000),
       DATA_PROTOCOL_LOGGING_NETWORK_IP_RM_TX_FULL = ((0x574) + 0x1000),
       DATA_PROTOCOL_LOGGING_NETWORK_IP_RM_RX_FULL = ((0x575) + 0x1000),
       DATA_PROTOCOL_LOGGING_NETWORK_IP_UM_TX_80_BYTES = ((0x576) + 0x1000),
       DATA_PROTOCOL_LOGGING_NETWORK_IP_UM_RX_80_BYTES = ((0x577) + 0x1000),
       DATA_PROTOCOL_LOGGING_NETWORK_IP_UM_TX_FULL = ((0x578) + 0x1000),
       DATA_PROTOCOL_LOGGING_NETWORK_IP_UM_RX_FULL = ((0x579) + 0x1000),
       DATA_PROTOCOL_LOGGING_LINK_RM_TX_80_BYTES = ((0x57A) + 0x1000),
       DATA_PROTOCOL_LOGGING_LINK_RM_RX_80_BYTES = ((0x57B) + 0x1000),
       DATA_PROTOCOL_LOGGING_LINK_RM_TX_FULL = ((0x57C) + 0x1000),
       DATA_PROTOCOL_LOGGING_LINK_RM_RX_FULL = ((0x57D) + 0x1000),
       DATA_PROTOCOL_LOGGING_LINK_UM_TX_80_BYTES = ((0x57E) + 0x1000),
       DATA_PROTOCOL_LOGGING_LINK_UM_RX_80_BYTES = ((0x57F) + 0x1000),
       DATA_PROTOCOL_LOGGING_LINK_UM_TX_FULL = ((0x580) + 0x1000),
       DATA_PROTOCOL_LOGGING_LINK_UM_RX_FULL = ((0x581) + 0x1000),
       DATA_PROTOCOL_LOGGING_FLOW_RM_TX_80_BYTES = ((0x582) + 0x1000),
       DATA_PROTOCOL_LOGGING_FLOW_RM_TX_FULL = ((0x583) + 0x1000),
       DATA_PROTOCOL_LOGGING_FLOW_UM_TX_80_BYTES = ((0x584) + 0x1000),
       DATA_PROTOCOL_LOGGING_FLOW_UM_TX_FULL = ((0x585) + 0x1000),

       ADSP_AFE_PCM_RX_TX = ((0x586) + 0x1000),

       GNSS_PE_EVENTS = ((0x587) + 0x1000),

       QMI_SUPPORTED_INTERFACES = ((0x588) + 0x1000),

       GNSS_ISAGNAV_SDP_EVENTS = ((0x589) + 0x1000),

       ADSP_VCP_VOICEPROC_RX_TX = ((0x58A) + 0x1000),
       ADSP_VCP_VOICESTRM_RX_TX = ((0x58B) + 0x1000),

       XOADC = ((0x58C) + 0x1000),

       FM_RADIO_HCI_COMMAND = ((0x58D) + 0x1000),
       FM_RADIO_HCI_EVENT = ((0x58E) + 0x1000),

       SNS_TIME_SERVICE_OFFSETS = ((0x58F) + 0x1000),

       CXM_CP_BT_MSG = ((0x590) + 0x1000),
       CXM_CP_WLAN_MSG = ((0x591) + 0x1000),
       CXM_CP_LTE_MSG = ((0x592) + 0x1000),
       CXM_DP_BT_MSG = ((0x593) + 0x1000),
       CXM_DP_WLAN_MSG = ((0x594) + 0x1000),
       CXM_DP_LTE_MSG = ((0x595) + 0x1000),

       GNSS_WWAN_WLAN_IMD_JAMMER_STATUS = ((0x596) + 0x1000),

       TCXOMGR_IFC_SUMMARY = ((0x597) + 0x1000),
       TCXOMGR_IFC_RPUSH = ((0x598) + 0x1000),

       LOC_LTE_OTDOA_PRS_RSTD_MEAS = ((0x599) + 0x1000),
       LOC_LTE_OTDOA_PRS_TOA_MEAS = ((0x59A) + 0x1000),

       INTEG_ANGLE_CONFIG = ((0x59B) + 0x1000),
       INTEG_ANGLE_RESULT = ((0x59C) + 0x1000),
       INTEG_ANGLE_REPORT = ((0x59D) + 0x1000),

       GTAP_CONFIG = ((0x59E) + 0x1000),
       GTAP_RESULT = ((0x59F) + 0x1000),
       GTAP_REPORT = ((0x5A0) + 0x1000),

       SNS_BASIC_GESTURES_CONFIG = ((0x5A1) + 0x1000),
       SNS_BASIC_GESTURES_RESULT = ((0x5A2) + 0x1000),
       SNS_BASIC_GESTURES_REPORT = ((0x5A3) + 0x1000),

       SNS_FACING_CONFIG = ((0x5A4) + 0x1000),
       SNS_FACING_RESULT = ((0x5A5) + 0x1000),
       SNS_FACING_REPORT = ((0x5A6) + 0x1000),

       CLKRGM_DRIVER_CLOCKS = ((0x5A7) + 0x1000),

       TIME_TOD_ERROR_NOTIFY = ((0x5A8) + 0x1000),

       SNS_ALGO_INPUT = ((0x5A9) + 0x1000),

       GYROINT_CONFIG = ((0x5AA) + 0x1000),
       GYROINT_UPDATE = ((0x5AB) + 0x1000),
       GYROINT_REPORT = ((0x5AC) + 0x1000),
       GYROINT_REPORT_REQ = ((0x5AD) + 0x1000),
       GYROBUF_CONFIG = ((0x5AE) + 0x1000),
       GYROBUF_REPORT_REQ = ((0x5AF) + 0x1000),
       GYROBUF_REPORT = ((0x5B0) + 0x1000),

       GNSS_PDSM_BEST_AVAIL_POS_INFO = ((0x5B1) + 0x1000),
       GNSS_PDSM_EXT_STATUS_BEST_AVAIL_POS_INFO = ((0x5B2) + 0x1000),

       KERNEL_TASKPROFILE_V3 = ((0x5B3) + 0x1000),
       KERNEL_SYSPROFILE_V3 = ((0x5B4) + 0x1000),

       SYSTEMPROFILING_ID_LOOKUP = ((0x5B5) + 0x1000),
       SYSTEM_PROFILING = ((0x5B6) + 0x1000),

       DS_3GPP_EVENT = ((0x5B7) + 0x1000),

       SNS_ACCEL_CAL_CONFIG = ((0x5B8) + 0x1000),
       SNS_ACCEL_CAL_RESULT = ((0x5B9) + 0x1000),
       SNS_ACCEL_CAL_REPORT = ((0x5BA) + 0x1000),

        GNSS_SOC_RFDEV_MSGS = ((0x5BB) + 0x1000),
        GNSS_SOC_UBP_MSGS = ((0x5BC) + 0x1000),

       TCXOMGR_RGS = ((0x5BD) + 0x1000),

       RFIC_PMIC_STATUS = ((0x5BE) + 0x1000),

       HDR_RF_WARMUP = ((0x5BF) + 0x1000),
       HDR_RF_PWR_LMT = ((0x5C0) + 0x1000),
       HDR_RF_STATE = ((0x5C1) + 0x1000),
       HDR_RF_SLEEP = ((0x5C2) + 0x1000),
       HDR_RF_TX_STATE = ((0x5C3) + 0x1000),
       HDR_RF_INT_STATE = ((0x5C4) + 0x1000),
       HDR_RF_LNA_SWITCHP = ((0x5C5) + 0x1000),
       HDR_RF_RX_CAL = ((0x5C6) + 0x1000),
       HDR_RF_API = ((0x5C7) + 0x1000),
       HDR_RF_RX_PLL_LOCK = ((0x5C8) + 0x1000),
       HDR_RF_RX_QUALITY = ((0x5C9) + 0x1000),
      LOG_1X_RF_RX_QUALITY = ((0x5CA) + 0x1000),

       IMS_VDJ_ENQUEUE = ((0x5CB) + 0x1000),
       IMS_VDJ_DEQUEUE = ((0x5CC) + 0x1000),

       LOC_WWAN_MEDB_DUMP = ((0x5CD) + 0x1000),
/* 0x15CE -- 0x1632 a total of 100 log codes are reserved for 1x and DO */

       IMS_AVPF_FEEDBACK = ((0x633) + 0x1000),
       GNSS_SPECTRUM_ANALYZER_SCAN_PARAMS = ((0x634) + 0x1000),
       GNSS_SPECTRUM_ANALYZER_JAMMER_MEASUREMENTS = ((0x635) + 0x1000),
       GNSS_SPECTRUM_ANALYZER_NOTCH_ASSIGNMENT = ((0x636) + 0x1000),
       SNS_PED_CONFIG = ((0x637) + 0x1000),
       SNS_PED_RESULT = ((0x638) + 0x1000),
       SNS_PED_REPORT = ((0x639) + 0x1000),
       SNS_QMAG_CAL_CONFIG = ((0x63A) + 0x1000),
       SNS_QMAG_CAL_RESULT = ((0x63B) + 0x1000),
       SNS_QMAG_CAL_REPORT = ((0x63C) + 0x1000),
       GNSS_ME_PQME1 = ((0x63D) + 0x1000),
       GNSS_ME_PQME2 = ((0x63E) + 0x1000),
       GNSS_ME_PQME3 = ((0x63F) + 0x1000),
       PAM_CONFIG = ((0x640) + 0x1000),
       PAM_RESULT = ((0x641) + 0x1000),
       PAM_REPORT = ((0x642) + 0x1000),
       MCS_QCSI_EVENT_PKT = ((0x643) + 0x1000),
       QURT_TASKPROFILE = ((0x644) + 0x1000),
       QURT_PM = ((0x645) + 0x1000),
       TCXOMGR_RGS_RETRIEVAL = ((0x646) + 0x1000),
       LOC_LTE_OTDOA_ASSIST_DATA = ((0x647) + 0x1000),

/* 1648-1747 Indoor reserved log codes */
       INDOOR_INFO = ((0x648) + 0x1000),
       INDOOR_RTS_CTS_SCAN = (1 +INDOOR_INFO), /*0x1649*/
       INDOOR_ACTIVE_SCAN = (2 +INDOOR_INFO), /*0x1650*/
       INDOOR_IPE_IPC_DATA = (3 +INDOOR_INFO),
       INDOOR_SDP_IPC_DATA = (4 +INDOOR_INFO),
       INDOOR_IMC_IPC_DATA = (5 +INDOOR_INFO),
       INDOOR_IWMM_IPC_DATA = (6 +INDOOR_INFO),

       INDOOR_LAST = (99 +INDOOR_INFO),

       TLM_MOBILE_NW_POS_INFO = ((0x748) + 0x1000),
       ANT_HCI_CMD = ((0x749) + 0x1000),
       ANT_HCI_EV = ((0x750) + 0x1000),
       IMS_CAMERA = ((0x751) + 0x1000),
       IMS_VIDEO_ENCODER = ((0x752) + 0x1000),
       IMS_VIDEO_PLAYOUT = ((0x753) + 0x1000),
       C_MCS_IRATMAN = ((0x754) + 0x1000),
       TCXOMGR_TEMP_SUBSCRIPTION = ((0x755) + 0x1000),
       GNSS_BDS_MEASUREMENT_REPORT = ((0x756) + 0x1000),

/*0x1757 to 0x17D7 a total of 128 log codes reserved for eMBMS Service Layer */
       EMBMS_SL_RESERVED_CODES_BASE = ((0x757) + 0x1000),
       EMBMS_SL_SESSION = (EMBMS_SL_RESERVED_CODES_BASE), /*0x1757*/
       EMBMS_SL_FLUTE = (1 +EMBMS_SL_RESERVED_CODES_BASE), /*0x1758*/
       EMBMS_SL_LOCAL_HTTP_SERVER = (2 +EMBMS_SL_RESERVED_CODES_BASE), /*0x1759*/
       EMBMS_SL_BOOTSTRAP = (3 +EMBMS_SL_RESERVED_CODES_BASE), /*0x175A*/
       EMBMS_SL_SERVICE_DISCOVERY = (4 +EMBMS_SL_RESERVED_CODES_BASE), /*0x175B*/
       EMBMS_SL_I2 = (5 +EMBMS_SL_RESERVED_CODES_BASE), /*0x175C*/
       EMBMS_SL_I1_COMMON = (6 +EMBMS_SL_RESERVED_CODES_BASE), /*0x175D*/
       EMBMS_SL_I1_STREAMING = (7 +EMBMS_SL_RESERVED_CODES_BASE), /*0x175E*/
       EMBMS_SL_STREAMING = (8 +EMBMS_SL_RESERVED_CODES_BASE), /*0x175F*/
       EMBMS_SL_I1_FILE_DOWNLOAD = (9 +EMBMS_SL_RESERVED_CODES_BASE), /*0x1760*/
       EMBMS_SL_SCHEDULE = (10 +EMBMS_SL_RESERVED_CODES_BASE), /*0x1761*/
       EMBMS_SL_FILE_REPAIR = (11 +EMBMS_SL_RESERVED_CODES_BASE), /*0x1762*/
       EMBMS_SL_RECEPTION_REPORTING = (12 +EMBMS_SL_RESERVED_CODES_BASE), /*0x1763*/
       EMBMS_SL_MSP_COMMON = (13 +EMBMS_SL_RESERVED_CODES_BASE), /*0x1764*/
       EMBMS_SL_USD_DATA = (14 +EMBMS_SL_RESERVED_CODES_BASE), /*0x1765*/
       EMBMS_CONFIGURATION = (15 +EMBMS_SL_RESERVED_CODES_BASE), /*0x1766*/
       EMBMS_FD_STORE = (16 +EMBMS_SL_RESERVED_CODES_BASE), /*0x1767*/

       EMBMS_SL_LAST = (128 +EMBMS_SL_RESERVED_CODES_BASE), /*0x17D7*/

       ADSP_AFE_CALIBRATION_DATA = ((0x7D8) + 0x1000),
       RFA_DEVICE_PA = ((0x7D9) + 0x1000),
       RFA_DEVICE_ASM = ((0x7DA) + 0x1000),
       RFA_DEVICE_PAPM = ((0x7DB) + 0x1000),
       RFA_DEVICE_TRASCEIVER = ((0x7DC) + 0x1000),
       RFA_DEVICE_TUNER = ((0x7DD) + 0x1000),
       RFA_DEVICE_THERM = ((0x7DE) + 0x1000),
       RFA_DEVICE_HDET = ((0x7DF) + 0x1000),
       RFA_RFC_SIGNALS = ((0x7E0) + 0x1000),
       RFA_RFC_DEVICES = ((0x7E1) + 0x1000),
       RFA_GSM_CMN = ((0x7E2) + 0x1000),
       RFA_GSM_RX = ((0x7E3) + 0x1000),
       RFA_GSM_TX = ((0x7E4) + 0x1000),
       RFA_GSM_TEMP_COMP = ((0x7E5) + 0x1000),
       RFA_GSM_VBATT_COMP = ((0x7E6) + 0x1000),
       RFA_GSM_IRAT = ((0x7E7) + 0x1000),
       RFA_GSM_FTM = ((0x7E8) + 0x1000),
       RFA_GSM_CAL = ((0x7E9) + 0x1000),
       SNS_CMC_CONFIG = ((0x7EA) + 0x1000),
       SNS_CMC_RESULT = ((0x7EB) + 0x1000),
       SNS_CMC_REPORT = ((0x7EC) + 0x1000),
       SNS_DB_CONFIG = ((0x7ED) + 0x1000),
       SNS_DB_RESULT = ((0x7EE) + 0x1000),
       SNS_DB_REPORT = ((0x7EF) + 0x1000),
       SNS_CMC_RESULT2 = ((0x7F0) + 0x1000),
       PKT_MEM_PROFILING = ((0x7F1) + 0x1000),
       VOICE_CALL_STATISTICS = ((0x7F2) + 0x1000),
       SENSOR_FIFO_EVENT = ((0x7F3) + 0x1000),
       EFS_MONITOR = ((0x7F4) + 0x1000),
       EFS_MONITOR_LOOKUP = ((0x7F5) + 0x1000),
       MCS_WWCOEX_STATE_INFO = ((0x7F6) + 0x1000),
       MCS_WWCOEX_POWER_INFO = ((0x7F7) + 0x1000),
       SNS_SMD_CONFIG = ((0x7F8) + 0x1000),
       SNS_SMD_RESULT = ((0x7F9) + 0x1000),
       SNS_SMD_REPORT = ((0x7FA) + 0x1000),
       SNS_LATENCY_SAMPLING_POLL = ((0x7FB) + 0x1000),
       SNS_LATENCY_SAMPLING_DRI = ((0x7FC) + 0x1000),
       SNS_LATENCY_DELIVERY = ((0x7FD) + 0x1000),
       SNS_GAME_ROTATION_VECTOR_CONFIG = ((0x7FE) + 0x1000),
       SNS_GAME_ROTATION_VECTOR_RESULT = ((0x7FF) + 0x1000),
       SNS_GAME_ROTATION_VECTOR_REPORT = ((0x800) + 0x1000),
       TRSP_DATA_STALL = ((0x801) + 0x1000),
       NFC_FTM = ((0x802) + 0x1000),
       TCXOMGR_COARSE_DC_CAL = ((0x803) + 0x1000),
       ADSP_CVD_STREAM_TX = ((0x804) + 0x1000),
       ADSP_CVD_STREAM_RX = ((0x805) + 0x1000),
       GNSS_MBM = ((0x806) + 0x1000),
       GNSS_PLE_UPDATE = ((0x807) + 0x1000),
       WLAN_SLM_RA_LINK = ((0x808) + 0x1000),
       RF_LTE_MTPL = ((0x809) + 0x1000),
       RF_LTE_HDET = ((0x80A) + 0x1000),

/* New QMI reserved logs 0x180B - 0x182B*/
       QMI_RESERVED_NEW_CODES_BASE = (0x80B + 0x1000),
       QMI_NEW_LAST = (32 +QMI_RESERVED_CODES_BASE),

       DATA_PROTOCOL_LOGGING_EX = ((0x82C) + 0x1000),
       RF_WCDMA_LOG_V3 = ((0x82D) + 0x1000),
       ROHC_DECOMPRESSOR_INPUT = ((0x82E) + 0x1000),
       ROHC_COMPRESSOR_OUTPUT = ((0x82F) + 0x1000),
       VOIP_SESSION_SETUP_SUMMARY = ((0x830) + 0x1000),
       VOIP_SESSION_END_SUMMARY = ((0x831) + 0x1000),
       IMS_REGISTRATION_SUMMARY = ((0x832) + 0x1000),
       GNSS_GEOFENCE_MOTION_DETECTION_REPORT = ((0x833) + 0x1000),
       SNS_RUN_TIME_TUNING_REQUEST = ((0x834) + 0x1000),
       SNS_RUN_TIME_TUNING_RESPONSE = ((0x835) + 0x1000),
       SNS_BMA2X2_DOUBLETAP_TUNING_MESSAGE = ((0x836) + 0x1000),
       GNSS_GEOFENCE_POSITION_REPORT = ((0x837) + 0x1000),
       GNSS_ME_DPO_STATUS = ((0x838) + 0x1000),
       GNSS_SLIM_TIME_SYNC = ((0x839) + 0x1000),
       SNS_GEOMAG_ROT_VEC_CONFIG = ((0x83A) + 0x1000),
       SNS_GEOMAG_ROT_VEC_RESULT = ((0x83B) + 0x1000),
       SNS_GEOMAG_ROT_VEC_REPORT = ((0x83C) + 0x1000),
       IPDC_COMPRESSOR_PER_PKT_METRICS = ((0x83D) + 0x1000),
       IPDC_COMPRESSOR_STATS = ((0x83E) + 0x1000),
       ROHC_COMPRESSOR_STATISTICS_EX = ((0x83F) + 0x1000),
       ROHC_DECOMPRESSOR_STATISTICS_EX = ((0x840) + 0x1000),
       RFA_ASDIV = ((0x841) + 0x1000),
       RFLM_GENERIC_DEBUG_1 = ((0x842) + 0x1000),
       RFLM_GENERIC_DEBUG_2 = ((0x843) + 0x1000),
       RFLM_TXAGC_UPDATE = ((0x844) + 0x1000),
       RFLM_TXAGC_TABLES = ((0x845) + 0x1000),
       RFLM_DTR_TX = ((0x846) + 0x1000),
       RFLM_DTR_RX = ((0x847) + 0x1000),
       RFLM_DTR_CMN = ((0x848) + 0x1000),
       RFLM_FBRX_ONLINE_CORRECTION = ((0x849) + 0x1000),
       RFLM_FBRX_SAMPLE_CAPTURE = ((0x84A) + 0x1000),
       ADSP_VCP_VOICEPROC_RTM = ((0x84B) + 0x1000),
       LTE_RF_FED_TXAGC = ((0x84C) + 0x1000),
       LTE_RF_FED_TXAGC_TIMING = ((0x84D) + 0x1000),
       CM_SS_MSIM_EVENT = ((0x84E) + 0x1000),
       DATA_MODEM_IPA_STATS = ((0x84F) + 0x1000),
       DATA_MODEM_IPA_IPFLTR_STATS = ((0x850) + 0x1000),
       DATA_MODEM_IPA_PKT_STATUS_DL = ((0x851) + 0x1000),
       DATA_MODEM_IPA_PKT_STATUS_UL = ((0x852) + 0x1000),
       DATA_MODEM_IPA_SIO_CFG = ((0x853) + 0x1000),
       DATA_MODEM_IPA_WAN_CFG = ((0x854) + 0x1000),
       DATA_MODEM_IPA_FLTR_TBL_UPDATE = ((0x855) + 0x1000),
       DATA_MODEM_IPA_RING_TBL_UPDATE = ((0x856) + 0x1000),
       WLAN_QCA_RA_STATS = ((0x857) + 0x1000),
       IMS_VOIP_HANDOVER_CRITERIA_CHANGE = ((0x858) + 0x1000),
       DS_FIRST_REORIG_IP_PACKET_HEADER = ((0x859) + 0x1000),
       TOUCH_FRAME_RAW = ((0x85A) + 0x1000),
       TOUCH_FRAME_POST_PROC = ((0x85B) + 0x1000),
       TOUCH_BASELINE = ((0x85C) + 0x1000),
       TOUCH_FRAME_TYPE_0 = ((0x85D) + 0x1000),
       TOUCH_FRAME_TYPE_1 = ((0x85E) + 0x1000),
       TOUCH_FRAME_TYPE_2 = ((0x85F) + 0x1000),
       TOUCH_FRAME_TYPE_3 = ((0x860) + 0x1000),
       TOUCH_FRAME_TYPE_4 = ((0x861) + 0x1000),
       TOUCH_FRAME_TYPE_5 = ((0x862) + 0x1000),
       TOUCH_FRAME_TYPE_6 = ((0x863) + 0x1000),
       TOUCH_FRAME_TYPE_7 = ((0x864) + 0x1000),
       TOUCH_FRAME_TYPE_8 = ((0x865) + 0x1000),
       TOUCH_FRAME_TYPE_9 = ((0x866) + 0x1000),
       LOC_WWAN_ME_EVENTS = ((0x867) + 0x1000),
       RFLM_TDSCDMA_UPLINK_REPORT = ((0x868) + 0x1000),
       RFLM_TDSCDMA_DOWNLINK_REPORT = ((0x869) + 0x1000),
       RFLM_TDSCDMA_DEBUG = ((0x86A) + 0x1000),
       DSP_MODEM_FW_CXM = ((0x86B) + 0x1000),
       SNS_PED_ALIGN_CONFIG = ((0x86C) + 0x1000),
       SNS_PED_ALIGN_RESULT1 = ((0x86D) + 0x1000),
       SNS_PED_ALIGN_RESULT2 = ((0x86E) + 0x1000),
       SNS_PED_ALIGN_REPORT = ((0x86F) + 0x1000),
       MCS_WWCOEX_BA_SERV_POWER_INFO = ((0x870) + 0x1000),
       MCS_WWCOEX_BA_BLACKLIST_INFO = ((0x871) + 0x1000),
       AOSTLM_REPORT = ((0x872) + 0x1000),
       MCPM_DEVICE_POWER_INFO = ((0x873) + 0x1000),
       MCPM_GENERAL_SESSOPM_POWER = ((0x874) + 0x1000),
       MCPM_CHIPSET_CONFIG_POWER_INFO = ((0x875) + 0x1000),
       MCPM_IDLE_AWALE_POWER_INFO = ((0x876) + 0x1000),
      LOG_1X_PHYSICAL_LAYER_POWER_INFO = ((0x877) + 0x1000),
       EVDO_PHYSICAL_LAYER_POWER_INFO = ((0x878) + 0x1000),
       GERAN_PHYSICAL_LAYER_POWER_INFO = ((0x879) + 0x1000),
       WCDMA_SESSION_POWER_INFO = ((0x87A) + 0x1000),
       WCDMA_PHYSICAL_LAYER_POWER_INFO = ((0x87B) + 0x1000),
       TDSCDMA_PHYSICAL_LAYER_POWER_INFO = ((0x87C) + 0x1000),
       LTE_SESSION_POWER_INFO = ((0x87D) + 0x1000),
       LTE_PHYSICAL_LAYER_POWER_INFO = ((0x87E) + 0x1000),
       PA_POWER = ((0x87F) + 0x1000),
       WTR_POWER = ((0x880) + 0x1000),
       Q6_POWER = ((0x881) + 0x1000),
       ADSP_LSM_OUT = ((0x882) + 0x1000),
       GNSS_GEOFENCE_WWAN_MOT_CLASS = ((0x883) + 0x1000),
       SENSOR_SAMLITE_ALGO_STATES_OUTPUT = ((0x884) + 0x1000),
       GNSS_SLIM_EVENT = ((0x885) + 0x1000),
       GNSS_GAL_MEASUREMENT_REPORT = ((0x886) + 0x1000),
       SNS_TILT_DETECTOR_CONFIG = ((0x887) + 0x1000),
       SNS_TILT_DETECTOR_RESULT = ((0x888) + 0x1000),
       SNS_TILT_DETECTOR_REPORT = ((0x889) + 0x1000),
       ADSP_CVD_CAL_DATA = ((0x88A) + 0x1000),
       TLM_UPDATE_CONSISTENCY_INFO = ((0x88B) + 0x1000),
       LOC_LTE_OTDOA_TDP_MEAS = ((0x88C) + 0x1000),
       SNS_UIMG_MODE = ((0x88D) + 0x1000),
       GNSS_OEMCPE_MEASUREMENT_REPORT = ((0x88E) + 0x1000),
       RFLM_WTX = ((0x88F) + 0x1000),
       ADSP_CVD_VP3 = ((0x890) + 0x1000),
       MPLM_ECS_LOGPACKET = ((0x891) + 0x1000),
       CXM_SMEM_DATA = ((0x892) + 0x1000),
       CXM_LOW_PRIO = ((0x893) + 0x1000),
       CXM_MED_PRIO = ((0x894) + 0x1000),
       CXM_HIGH_PRIO = ((0x895) + 0x1000),
       IMS_STATE_SWITCH = ((0x896) + 0x1000),
       IMS_SYSTEM_ANCHOR = ((0x897) + 0x1000),
       MCS_WWCOEX_SLOT_ACTIVITY_TIMELINE_INFO = ((0x898) + 0x1000),
       GNSS_GEOFENCE_MOTION_WIFI_STATE = ((0x899) + 0x1000),
       WLAN_QCA_MEM_INFO = ((0x89A) + 0x1000),
       SNS_DPC_CONFIG = ((0x89B) + 0x1000),
       SNS_DPC_RESULT = ((0x89C) + 0x1000),
       SNS_DPC_REPORT = ((0x89D) + 0x1000),
       DPL_IFACE_DESCRIPTION_AND_STATUS = ((0x89E) + 0x1000),
       MCS_WWCOEX_SPUR_INFO = ((0x89F) + 0x1000),
       LOC_LTE_TDP_GLOBAL_CELL_PARAMS = ((0x8A0) + 0x1000),
       LOC_LTE_TDP_TIMESTAMPED_MEAS = ((0x8A1) + 0x1000),
       LOC_LTE_TDP_MEAS_DATABASE = ((0x8A2) + 0x1000),
       GNSS_GTP_TDP_CONFIG = ((0x8A3) + 0x1000),
       GNSS_TLM_TDP_SCANLIST = ((0x8A4) + 0x1000),
       DiagnosticVersion = 0x1FFD
    }
}