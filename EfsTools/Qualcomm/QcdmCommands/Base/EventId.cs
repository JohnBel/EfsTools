namespace EfsTools.Qualcomm.QcdmCommands.Base
{
    internal enum EventId
    {
        DROP_ID = 0,

        BAND_CLASS_CHANGE = 0x0100, /* Includes band class as payload */
        CDMA_CH_CHANGE = 0x0101, /* Includes cdma channel as payload */
        BS_P_REV_CHANGE = 0x0102, /* Includes BS p_rev as payload */
        P_REV_IN_USE_CHANGE = 0x0103, /* Includes p_rev_in_use as payload */
        SID_CHANGE = 0x0104, /* Includes SID as payload */
        NID_CHANGE = 0x0105, /* Includes NID as payload */
        PZID_CHANGE = 0x0106, /* Includes PZID as payload */
        PDE_SESSION_END = 0x0107, /* No payload */
        OP_MODE_CHANGE = 0x0108, /* Includes operation mode as payload */
        MESSAGE_RECEIVED = 0x0109, /* Includes channel and message ID as
				               payload */
        MESSAGE_TRANSMITTED = 0x010a, /* Includes channel and message ID as
                                                payload */
        TIMER_EXPIRED = 0x010b, /* Includes timer ID as payload */
        COUNTER_THRESHOLD = 0x10c, /* Includes counter ID as payload */
        CALL_PROCESSING_STATE_CHANGE = 0x010d, /* Includes new state and old state as
                                                 payload */
        CALL_CONTROL_INSTANTIATED = 0x10e, /* Includes con_ref as payload */
        CALL_CONTROL_STATE_CHANGE = 0x10f, /* Includes con_ref, old substate and
                                                 new substate as payload */
        CALL_CONTROL_TERMINATED = 0x0110, /* Includes con_ref as payload */
        REG_ZONE_CHANGE = 0x0111, /* Includes reg_zone as payload */
        SLOTTED_MODE_OPERATION = 0x0112, /* Includes enter/exit bit as payload */
        QPCH_IN_USE, /* Includes enable/disable bit as payload */
        IDLE_HANDOFF, /* Includes pn_offset as payload */
        ACCESS_HANDOFF, /* Includes pn_offset as payload */
        ACCESS_PROBE_HANDOFF, /* Includes pn_offset as payload */
        SOFT_HANDOFF,

        /* Includes pn_offsets of each BS in aset and indicators whether BS in SCH
           aset*/
        HARD_HANDOFF_FREQ_CHANGE,

        /* Includes pn_offsets of each BS in aset and indicators whether BS in SCH
           aset*/
        HARD_HANDOFF_FRAME_OFFSET_CHANGE,

        /* Includes pn_offsets of each BS in aset and indicators whether BS in SCH
           aset*/
        HARD_HANDOFF_DISJOINT_ASET,

        /* Includes pn_offsets of each BS in aset and indicators whether BS in SCH
           aset*/
        UNSUCCESSFUL_HARD_HANDOFF, /* No payload */
        TMSI_ASSIGNED, /* Includes TMSI as payload */
        SERVICE_NEGOTIATION_COMPLETED, /* No payload */
        SO_NEGOTIATION_COMPLETED, /* No payload */
        ENTER_CONTROL_HOLD_MODE, /* No payload */
        EXIT_CONTROL_HOLD_MODE, /* No payload */
        START_FWD_SUPP_BURST_ASSGN, /* Includes SCH rate as payload */
        END_FWD_SUPP_BURST_ASSGN, /* No payload */
        START_REV_SUPP_BURST_ASSGN, /* Includes SCH rate as payload */
        END_REV_SUPP_BURST_ASSGN, /* No payload */
        DTX, /* No payload */
        T_ADD_ABORT, /* No payload */
        CH_IND_CHANGE, /* Include ch_ind as payload */
        TRANSMITTER_DISABLED, /* No payload */
        TRANSMITTER_ENABLED, /* No payload */
        SMS_RECEIVED, /* No payload */
        SMS_SENT, /* No payload */
        INACTIVITY_TIMER_EXPIRED, /* No payload */
        DORMANT_TIMER_EXPIRED, /* No payload */
        ACCESS_ATTEMPT_FAIL_MAX_PROBES_SENT, /* No payload */
        ACCESS_ATTEMPT_FAIL_LOSS_OF_PC_OR_FCCC, /* No payload */
        PCH_ACQUIRED, /* Includes pagech and pn_offset
                                                 as payload */
        BCCH_ACQUIRED, /* Includes walsh code for BCCH and
                                                 pn_offset as payload */
        FFCH_ACQUIRED, /* Payload: 14 bytes */
        FDCCH_ACQUIRED, /* Payload: 14 bytes */
        FFCH_PLUS_DCCH_ACQUIRED, /* No payload */
        REGISTRATION_PERFORMED, /* Includes reg_type as payload */
        NEW_SYSTEM_IDLE_HANDOFF, /* No payload */
        SYSTEM_RESELECTION, /* Includes ecio and ps as payload */
        RESCAN, /* No payload */
        PROTOCOL_MISMATCH, /* No payload */
        LOCK, /* No payload */
        UNLOCK, /* No payload */
        ACCESS_DENIED, /* No payload */
        NDSS_OFF, /* No payload */
        RELEASE, /* Payload: 1 byte */
        ERROR, /* No payload */
        REDIRECTION, /* No payload */
        REGISTRATION_REJECTED, /* No payload */
        WRONG_SYSTEM, /* No payload */
        WRONG_NETWORK, /* No payload */
        LOSS_OF_ACQ_AFTER_SLEEP, /* No payload */
        POWER_DOWN, /* No payload */
        CALL_RELEASE_REQUEST, /* No payload */
        SERVICE_INACTIVE, /* No payload */
        EXTENDED_RELEASE, /* No payload */

        HDR_MSG_RX, /* protocol, msg- 3 bytes */
        HDR_RXMSG_IGNORED_STATE, /* protocol, msg- 3 bytes */
        HDR_RXMSG_IGNORED_SEQ, /* protocol, msg- 3 bytes */
        HDR_TXMSG_ACKED, /* protocol, msg- 3 bytes */
        HDR_TXMSG_DROPPED, /* protocol, msg- 3 bytes */
        HDR_STATE_CHANGE, /* protocol, from, to - 5 bytes */
        HDR_ALMP_OBEYING_REDIRECTION, /* No payload */
        HDR_ALMP_CONNECTION_CLOSED, /* No payload */
        HDR_ALMP_T_SD_RESELECT, /* No payload */
        HDR_ALMP_CONNECTION_OPENED, /* No payload */
        HDR_HMP_QUEUED_MSG, /* protocol, msg- 3 bytes */
        HDR_HMP_SENT_MSG, /* protocol, msg, chan, is_reliable - 5 bytes */
        HDR_HMP_ABORTING_ACMAC_ACTIVATION, /* No payload */
        HDR_IDLE_T_CONFIG_RSP, /* No payload */
        HDR_IDLE_T_AT_SETUP, /* No payload */
        HDR_IDLE_T_SUSPEND, /* No payload */
        HDR_IDLE_CONNECTION_DENIED, /* No payload */
        HDR_INIT_T_SYNC_ACQ, /* No payload */
        HDR_INIT_PROTOCOL_MISMATCH, /* No payload */
        HDR_OVHD_INFO_CURRENT, /* No payload */
        HDR_OVHD_T_QC_SUPERVISION, /* No payload */
        HDR_OVHD_T_SP_SUPERVISION, /* No payload */
        HDR_OVHD_T_AP_SUPERVISION, /* No payload */
        HDR_OVHD_IGNORED_MSG_UNEXPECTED_LINK, /* msg, exp_link.chan_num,
                                                      exp_link.pilot, rx_link.chan_num,
                                                      rx_link.pilot - 10 bytes */
        HDR_OVHD_IGNORED_SP_MSG_DIFF_SEC_SIG, /* exp_sig, rx_sig - 8 bytes */
        HDR_OVHD_IGNORED_AP_MSG_DIFF_ACC_SIG, /* exp_sig, rx_sig - 8 bytes */
        HDR_OVHD_IGNORED_SP_MSG_DIFF_SEC_ID, /* No payload */
        HDR_OVHD_SP_MSG_RX, /* No payload */
        HDR_OVHD_AP_MSG_RX, /* No payload */
        HDR_RUP_T_CONNECTION_SETUP, /* No payload */
        HDR_SLP_MAX_RETRIES, /* msg - 2 bytes */
        HDR_LMAC_ACQ_FAIL_PILOT, /* No payload */
        HDR_LMAC_ACQ_SUCCESS, /* No payload */
        HDR_LMAC_NETWORK_LOST, /* No payload */
        HDR_LMAC_IDLE_HO, /* new_pilot - 2 bytes */
        HDR_LMAC_CHAN_CHANGE_COMPLETE, /* No payload */
        HDR_LMAC_ACCESS_HO_NEEDED, /* suggested_pilot - 2 bytes */
        HDR_LMAC_ACCESS_HO_COMPLETE, /* new_pilot - 2 bytes */
        HDR_LMAC_ACQUIRE, /* channel 2 bytes */
        HDR_LMAC_CHANGING_CC_HASH, /* cc_hash - 1 byte */
        HDR_LMAC_IDLE_CHAN_CHANGE, /* channel - 2 bytes */
        HDR_CMAC_T_SUPERVISION, /* No payload */
        HDR_AMAC_START_ACCESS, /* No payload */
        HDR_AMAC_PROBING_STOPPED, /* No payload */
        HDR_AMAC_ACCESS_COMPLETE, /* No payload */
        HDR_AMAC_ACCESS_ABORTED, /* No payload */
        HDR_AMAC_MAX_PROBES, /* No payload */
        HDR_FMAC_DROP_PKT, /* No payload */
        HDR_RMAC_T_RATE_LIMIT, /* No payload */
        HDR_RMAC_TX_STARTED, /* No payload */
        HDR_RMAC_TX_STOPPED, /* No payload */
        HDR_SMP_T_KEEP_ALIVE, /* No payload */
        HDR_AMP_ASSIGN_MSG_IGNORED_FRESH, /* No payload */
        HDR_AMP_T_AT_RESPONSE, /* No payload */
        HDR_AMP_T_DUAL_ADDRESS, /* No payload */
        HDR_SCP_BEGIN_CONFIGURATION, /* No payload */
        HDR_SCP_T_CONFIG_RSP, /* No payload */
        HDR_SCP_T_AN_INIT_STATE, /* No payload */

        WCDMA_L1_STATE, /* l1_state - 1 byte */
        WCDMA_IMSI, /* IMSI - 9 bytes */
        GSM_L1_STATE, /* GSM l1_state - 1 byte */
        RANDOM_ACCESS_REQUEST, /* GSM Random Access Request - 4 bytes */
        HIGH_LEVEL_CALL_PROCESSING_STATE_CHANGE, /* Puma requested event */

        /* (same payload as CALL_PROCESSING_STATE_CHANGE) */
        ENCRYPTION_FAILURE, /* Puma event, no payload */
        ACCT_BLOCKED, /* Puma event, no payload */
        COMMON_CHANNEL_MONITORED, /* Puma event, 1 byte payload */
        SOFT_HANDOFF_V2, /* Puma event, 14 byte payload */
        HARD_HANDOFF_FREQ_CHANGE_V2, /* Puma event, 14 byte payload */
        HARD_HANDOFF_FRAME_OFFSET_CHANGE_V2, /* Puma event, 14 byte payload */
        HARD_HANDOFF_DISJOINT_ASET_V2, /* Puma event, 14 byte payload */
        WCDMA_NEW_REFERENCE_CELL,
        CALL_CONTROL_CONREF_CHANGE, /* Puma event, 2 byte payload */

        GPS_SESSION_BEGIN,
        GPS_SESSION_END,
        GPS_WAITING_ON_SA,
        GPS_PPM_START,
        GPS_PPM_RESULTS,
        GPS_PPM_END,
        GPS_VISIT_BEGIN,
        GPS_VISIT_END,
        GPS_CDMA_RESUMED_AFTER_GPS_VISIT,
        GPS_PD_SESSION_BEGIN,
        GPS_PD_SESSION_END, /* Payload: 1 byte PDSM substate */
        GPS_IS801_RX, /* Payload, 1 byte msg_type */
        GPS_IS801_TX, /* Payload: 1 byte msg_type */
        POWERUP,
        WCDMA_ASET,
        CM_CALL_STATE, /* (1 byte payload: overall call state) */
        CM_OPERATIONAL_MODE, /* (1 byte payload: op mode) */
        CM_SYSTEM_MODE, /* (1 byte payload: sys_mode) */

        DEEP_SLEEP, /* no payload */
        WAKEUP, /* unsigned long (4 bytes) payload */
        ACQUISITION_MODE, /* unsigned char (1 byte) payload */
        ACQUISITION_TYPE, /* unsigned char (1 byte) payload */
        ACP_EXIT, /* unsigned char (1 byte) payload */
        CDMA_EXIT, /* unsigned char (1 byte) payload */

        HDR_HYBRID_POWER_SAVE, /* No payload */
        HDR_DEEP_SLEEP, /* No payload */
        HDR_RESELECTION, /* No payload */
        SAM_LOCK_GRANTED, /* <NewOwner (1 byte) <Duration (2 bytes) */
        SAM_LOCK_RELEASED, /* <OldOwner (1 byte) */

        GSM_HANDOVER_START,
        GSM_HANDOVER_END,
        GSM_LINK_FAILURE,
        GSM_RESELECT_START,
        GSM_RESELECT_END,
        GSM_CAMP_ATTEMPT_START,
        GSM_RR_IN_SERVICE,
        GSM_RR_OUT_OF_SERVICE,
        GSM_PAGE_RECEIVED,
        GSM_CAMP_ATTEMPT_END,
        GPS_IS801_TIMEOUT,
        GPS_IS801_DISCARD, /* Payload: 1 byte msg type */
        GSM_CELL_SELECTION_START, /* Payload: 1 byte cell_selection_reason */
        GSM_CELL_SELECTION_END, /* Payload: 1 byte end_status success/failure reason */
        GSM_POWER_SCAN_STATUS, /* Payload: 1 byte status (started or completed) */
        GSM_PLMN_LIST_START, /* Payload: 1 byte */
        GSM_PLMN_LIST_END,
        WCDMA_INTER_RAT_HANDOVER_START, /* Payload: 4 bytes handover type, BCCH ARFCN, BSIC */
        WCDMA_INTER_RAT_HANDOVER_END, /* Payload: 2 bytes success, failure reason */

        GSM_MESSAGE_SENT, /* Payload: 2 bytes indicating identity of the message */
        GSM_MESSAGE_RECEIVED, /* Payload: 2 bytes indicating identity of the message */
        GSM_TIMER_EXPIRED, /* Payload: 2 bytes indicating identity of the message */
        GSM_COUNTER_EXPIRED, /* Payload: 2 bytes indicating identity of the message */

        NAS_MESSAGE_SENT,
        NAS_MESSAGE_RECEIVED,
        RRC_MESSAGE_SENT,
        RRC_MESSAGE_RECEIVED,

        /* Camera events: No Payload */
        CAMERA_CANNOT_CAPTURE, /* Cannot capture, transition to ready */
        CAMERA_CANNOT_CONFIG_JPEG, /* Cannot config JPEG, transition to ready */
        CAMERA_CANNOT_CONFIG_VFE, /* Cannot config VFE, transition to ready */
        CAMERA_CANNOT_ENCODE, /* Cannot encode, transition to ready */
        CAMERA_CANNOT_IDLE_DSP, /* Cannot idle DSP, transition to ready */
        CAMERA_CANNOT_LOAD_DSP, /* Cannot load DSP, transition to ready */
        CAMERA_DSP_FATAL, /* DSP fatal error, transition to ready */
        CAMERA_DSP_REQ_ILLEGAL, /* DSP request illegal, transition to ready */
        CAMERA_EFS_FAILED, /* EFS failed, transition to ready */
        CAMERA_EXIT, /* Stop, transition to ready */
        CAMERA_FORMAT_NOT_SUPPORTED, /* Format not supported */
        CAMERA_FUNCTION_REJECTED, /* Function rejected, transition to ready */
        CAMERA_IMAGE_CORRUPT, /* Image corrupted, reconfig */
        CAMERA_INVALID_CONFIG_PARM, /* Invalid config parm, to ready */
        CAMERA_INVALID_SET_ID, /* Invalid set param ID type */
        CAMERA_INVALID_STATE, /* Invalid state */
        CAMERA_JPEG_ENCODED, /* JPEG encoded */
        CAMERA_NO_MEMORY, /* No memory, transition to ready */
        CAMERA_NO_PICTURE, /* Picture not ready */
        CAMERA_PICTURE_SAVED, /* Picture saved, transition to ready */
        CAMERA_PICTURE_TAKEN, /* Picture taken, transition to ready */
        CAMERA_PREVIEW, /* Enter preview */
        CAMERA_RECORD, /* Enter recording */
        CAMERA_SAVE_PICTURE, /* Enter save picture */
        CAMERA_SET_FAILED, /* Set failed */
        CAMERA_SET_SUCCEEDED, /* Set succeeded */
        CAMERA_START, /* Start, transition to ready */
        CAMERA_STOP, /* Stop, transition to init */
        CAMERA_TAKE_PICTURE, /* Enter take picture */

        DIAG_STRESS_TEST_NO_PAYLOAD,
        DIAG_STRESS_TEST_WITH_PAYLOAD,

        CM_CALL_ORIG_START_P1, /* Payload: 5 single bytes */
        CM_CALL_ORIG_START_P2, /* Payload: 3 single bytes */
        CM_CALL_ORIG_START_P3, /* Payload: 3 single bytes */
        CM_CALL_ORIG_SWITCH_TO_HDR, /* No payload */
        CM_CALL_ORIG_REDIAL, /* Payload: 4 bytes */
        CM_CALL_ORIG_SEND_HDR_ORIG, /* No payload */
        CM_CALL_ORIG_SEND_MC_ORIG, /* No payload */
        CM_CALL_ORIG_END, /* Payload: 2 bytes */
        CM_CALL_ORIG_CONNECTED, /* Payload: 3 bytes */

        MT_SMS_NOTIFY, /* Payload: 1 byte mem_type, 4 byte msg_index */
        SMS_SLOT_WAKEUP, /* Payload: 1 byte slot_mask */
        MO_SMS_STATUS, /* Payload: 4 byte transaction_id, 1 byte mem_type,
                                                        4 byte msg_index, 1 byte report_status,
                                                        1 byte case_code */
        GPRS_SURROUND_SEARCH_START,
        GPRS_SURROUND_SEARCH_END,
        GPRS_MAC_RESELECT_IND,
        GPRS_PAGE_RECEIVED,
        GPRS_LINK_FAILURE,
        GPRS_CELL_UPDATE_START,
        GPRS_CELL_UPDATE_END,
        GPRS_EARLY_CAMPING,
        PACKET_RANDOM_ACCESS_REQ,
        GPRS_MAC_MSG_SENT, /* Payload: 3 bytes giving message identity and channel */
        GPRS_MAC_MSG_RECEIVED, /* Payload: 3 bytes giving message identity and channel */
        GPRS_SMGMM_MSG_SENT, /* Payload: 3 bytes giving message identity and channel */
        GPRS_SMGMM_MSG_RECEIVED, /* Payload: 3 bytes giving message identity and channel */

        CP_MATCHED_MSG, /* Payload: 1 byte */
        PREF_SYS_RESEL, /* Payload: none */

        WCDMA_LAYER1_PRACH, /* Payload: 4 bytes */
        WCDMA_LAYER1_MEASUREMENT, /* Payload: Unspecified */

        MOBILITY_MANAGEMENT_STATE_CHANGE, /* Payload: 1 byte old state, 1 byte new state */

        LSM_STATE_CHANGE, /* Payload: 1 byte */
        RLP, /* Payload: 2 bytes */

        CM_MODE_PREF, /* Payload: 4 bytes */
        CM_BAND_PREF, /* Payload: 4 bytes */
        CM_ROAM_PREF, /* Payload: 4 bytes */
        CM_SRV_DOMAIN_PREF, /* Payload: 4 bytes */
        CM_GW_ACQ_ORDER_PREF, /* Payload: 4 bytes */
        CM_HYBRID_PREF, /* Payload: 4 bytes */
        CM_NETWORK_SEL_MODE_PREF, /* Payload: 4 bytes */

        WCDMA_L1_SUSPEND, /* Payload: 3 bytes */
        WCDMA_L1_RESUME, /* Payload: 5 bytes */
        WCDMA_L1_STOPPED, /* Payload: 4 bytes */
        WCDMA_TO_WCDMA_RESELECTION_START, /* Payload: 6 bytes */
        WCDMA_TO_GSM_RESELECTION_START, /* Payload: 4 bytes */
        WCDMA_TO_GSM_RESELECTION_END, /* Payload: 2 bytes */
        WCDMA_TO_WCDMA_RESELECTION_END, /* Payload: 4 bytes */
        WCDMA_RACH_ATTEMPT, /* Payload: 3 bytes */

        START_FWD_SUPP_BURST_ASSIGN, /* Payload: 3 bytes */
        START_REV_SUPP_BURST_ASSIGN, /* Payload: 3 bytes */
        REV_FCH_GATING_IN_USE, /* Payload: 1 byte  */
        PPP, /* Payload: 7 bytes */
        MIP, /* Payload: 2 bytes */
        TCP, /* Payload: 5 bytes */
        CAMERA_EXIF_FAILED, /* EXIF encoding failed */
        CAMERA_VIDEO_FAILED, /* Video encoding failed */
        CAMERA_NO_SENSOR, /* No sensor */
        CAMERA_ABORT, /* Operation aborted */

        CM_BLOCK_HDR_ORIG_DURING_GPS, /* No payload */
        CM_ALLOW_HDR_ORIG_DURING_GPS, /* No payload */

        GSM_AMR_STATE_CHANGE, /* 2 bytes payload */
        GSM_RATSCCH_IN_DTX, /* No Payload */
        GSM_FACCH_IN_DTX, /* No Payload */
        GSM_FACCH_AND_RATSCCH_COLLISION, /* No Payload */
        GSM_FACCH_AND_SID_UPDATE_COLLISION, /* No Payload */
        GSM_RATSCCH_AND_SID_UPDATE_COLLISION, /* No Payload */
        GSM_RATSCCH_CMI_PHASE_CHANGE, /* 2 bytes payload */
        GSM_RATSCCH_REQ_ACT_TIMER_EXPIRY, /* 8 bytes payload */
        GSM_RATSCCH_ACK_ACT_TIMER_EXPIRY, /* 2 bytes payload */
        GSM_AMR_CMC_TURNAROUND_TIME, /* 2 bytes payload */
        CM_PLMN_FOUND, /* 12 bytes */
        CM_SERVICE_CONFIRMED, /* 12 bytes */

        GPRS_MAC_CAMPED_ON_CELL, /* Event Id : 559, No payload */
        GPRS_LLC_READY_TIMER_START, /* Event Id : 560, No payload */
        GPRS_LLC_READY_TIMER_END, /* Event Id : 561, No payload */

        WCDMA_PHYCHAN_ESTABLISHED, /* Payload TBD */
        HS_DISPLAY_BMP_CAPTURE_STATUS, /* Payload 4 bytes */

        WCDMA_CELL_SELECTED, /* 4 byte Payload */
        WCDMA_PAGE_RECEIVED, /* 2 byte Payload */
        WCDMA_SEND_KEY, /* Payload TBD */
        WCDMA_RL_FAILURE, /* No Payload */
        WCDMA_MAX_RESET, /* 2 byte Payload */
        WCDMA_CALL_SETUP, /* Payload TBD */
        WCDMA_CALL_DROPPED, /* Payload TBD */
        WCDMA_RRC_STATE, /* 3 byte Payload */
        GPS_PD_CONNECTION_TIMEOUT, /* No Payload */
        GPS_PD_DISCONNECTION_COMPLETE, /* No Payload */

        MEDIA_PLAYER_START, /* media player starts playing a clip, no payload */
        MEDIA_PLAYER_STOP, /* media player stopped playing a clip, no payload */
        MEDIA_PLAYER_SEEK, /* media player repositioned itself, no payload */

        GPS_SRCH_START, /* Payload: session_type (1 byte) */

        GPS_SRCH_END, /* No Payload */
        GPS_PPM_PAUSE, /* Payload: pause_reason (1 byte) */
        GPS_PPM_RESUME, /* No Payload */
        GPS_SA_RECEIVED, /* Payload: REF_BIT_NUM (2 bytes),
                                                        DR_SIZE     (1byte)
                                            */
        GPS_CLK_ON, /* No Payload */
        GPS_CLK_OFF, /* No Payload */
        GPS_VISIT_REQUEST, /* No Payload */
        GPS_VISIT_RESPONSE, /* Payload: response_result (1 byte)
                                            */
        GPS_TA_START, /* No Payload */
        GPS_DSP_READY, /* No Payload */
        GPS_DSP_CHANNEL_START, /* Payload: SV_ID         (1 byte),
                                                        SRCH_MODE     (1 byte),
                                                        CHANNEL_NUM   (1 byte),
                                                        RESERVED      (1 byte)
                                            */
        GPS_DSP_CHANNEL_DONE, /* Payload: channel_num (1 byte) */
        GPS_DSP_STOP, /* No Payload */
        GPS_DSP_DONE, /* No Payload */
        GPS_TB_END, /* No Payload */
        GPS_SRCH_LARGE_DOPP_WIN, /* Payload: sv_prn_num (1 byte),
                                                        srch_mode (1 byte),
                                                        dopp_wind (2 byte)
                                            */
        GPS_SRCH_EXCEPTION, /* Payload: grid_log_id (2 byte),
                                                        exception_type (1 byte)
                                            */
        GPS_SRCH_HW_POLLING1, /* Payload: agc_val (2 byte),
                                                        dci_off (2 byte),
                                                        dcq_off (2 byte),
                                                        trk_lo (2 byte),
                                                        lo_bias (2 byte)
                                            */

        GPS_SRCH_HW_POLLING2, /* Payload: sync80 (2 byte)
                                            */
        GPS_PGI_ACTION_PROCESS, /* Payload: pgi_substate (1 byte),
                                                        pgi_cmd (1 byte)
                                            */
        GPS_GSC_ACTION_PROCESS, /* Payload: gsc_substate (1 byte),
                                                        gsc_cmd (1 byte)
                                            */
        GPS_PGI_ABORT, /* Payload: pgi_subsate (1 byte) */
        GPS_GSC_ABORT, /* Payload: gsc_subsate (1 byte) */


        GPS_PD_FIX_START, /* Payload: log_cnt  (2 byte),
                                                        operation_mode (1 byte)
                                                 */
        GPS_PD_FIX_END, /* Payload: end_status     (1 byte)  */
        GPS_DATA_DOWNLOAD_START, /* Payload: data_type   (1 byte),
                                                             sv_mask     (4 byte)     */
        GPS_DATA_DOWNLOAD_END, /* Payload: end_status      (1 byte) */
        GPS_PD_SESSION_START, /* Payload: start_source    (4 bit)
                                                             operation_mode  (4 bit)
                                                             session_type    (4 bit)
                                                             privacy         (4 bit)
                                                             num_fixed       (2 byte)
                                                             fix_period      (2 byte)
                                                             nav_data_dl     (4 bit)
                                                             prq             (1 byte)
                                                             threshold       (2 byte)
                                                             transport_type  (4 bit)  */
        GPS_DORMANCY_BEGIN, /* No Payload */
        GPS_DORMANCY_END, /* No Payload */
        GPS_PRQ_TIMEOUT, /* No Payload */
        GPS_PD_CONNECTION_START, /* No Payload */
        GPS_PD_CONNECTION_ESTABLISHED, /* No Payload */
        GPS_PD_DISCONNECTION_START, /* No Payload */
        GPS_FTEST_FIX_START, /* Payload: reserved (4 byte) */
        GPS_FTEST_FIX_END, /* Payload: reserved (4 byte) */
        GPS_PD_POSITION, /* No Payload */
        GPS_E911_START, /* No Payload */
        GPS_E911_END, /* No Payload */
        GPS_DBM_SEND_FAILURE, /* No Payload */
        GPS_UAPDMS_STATE_CHANGE, /* Payload: new_state (1 byte)
                                                              reason    (1 byte) */
        WCDMA_OUT_OF_SERVICE, /* No Payload */
        GSM_L1_SUBSTATE, /* 2 bytes payload */
        SD_ACTION, /* 8 byte payload */
        SD_ACTION_HYBR, /* 8 byte payload */

        UMTS_CALLS_STATISTICS, /* 1 byte payload */
        PZID_HAT_STARTED, /* No payload */
        WCDMA_DRX_CYCLE, /* 3 byte payload */
        WCDMA_RE_ACQUISITION_FAIL, /* No payload */
        WCDMA_RRC_RB0_SETUP_FAILURE, /* No payload */
        WCDMA_RRC_PHYCHAN_EST_FAILURE, /* No payload */
        CM_CALL_ORIG, /* 3 byte payload */
        CM_CALL_CONNECT, /* 3 byte payload */
        CM_CALL_END, /* 2 byte payload */
        CM_ENTER_EMERGENCY_CB, /* No payload */
        CM_EXIT_EMERGENCY_CB, /* No payload */
        PZID_HAT_EXPIRED, /* No payload */
        HDR_SMP_SESSION_CLOSED, /* 1 byte payload */
        WCDMA_MEMORY_LEAK, /* No payload */
        PZID_HT_STARTED, /* 1 byte payload */
        PZID_HT_EXPIRED, /* 1 byte payload */
        ACCESS_ENTRY_HANDOFF, /* 2 byte payload */

        BREW_APP_START, /* 8 byte payload */
        BREW_APP_STOP, /* 8 byte payload */
        BREW_APP_PAUSE, /* 8 byte payload */
        BREW_APP_RESUME, /* 8 byte payload */
        BREW_EXT_MODULE_START, /* 8 byte payload */
        BREW_EXT_MODULE_STOP, /* 8 byte payload */
        BREW_ERROR, /* 8 byte payload */
        BREW_RESERVED_647, /* BREW internal use only */
        BREW_RESERVED_648, /* BREW internal use only */
        BREW_RESERVED_649, /* BREW internal use only */
        BREW_RESERVED_650, /* BREW internal use only */
        BREW_RESERVED_651, /* BREW internal use only */
        BREW_RESERVED_652, /* BREW internal use only */
        BREW_RESERVED_653, /* BREW internal use only */
        BREW_RESERVED_654, /* BREW internal use only */
        BREW_RESERVED_655, /* BREW internal use only */
        BREW_USER_656, /* Start of BREW user events */
        BREW_GENERIC, /* 8 byte payload: clsid + data */
        BREW_MEDIAPLAYER_SELECT_FILE, /* no payload */
        BREW_MEDIAPLAYER_CONTROL, /* no payload */
        BREW_APP_FORMITEM_STACK_CHANGE, /* 1 byte payload */
        BREW_CATAPP_RECV_PROACTIVE_CMD, /* No payload */
        BREW_CATAPP_TERMINAL_RSP, /* No payload */
        BREW_CATAPP_NO_DISPLAY, /* No payload */
        BREW_SIRIUS_EMAIL_DELETE, /* No payload */
        BREW_SIRIUS_EMAIL_OPERATION_COMPLETE, /* 8 byte payload */
        BREW_SIRIUS_EMAIL_NEW_EMAIL_NOTIFICATION, /* No payload */
        BREW_UNDEFINED_667,
        BREW_UNDEFINED_668,
        BREW_UNDEFINED_669,
        BREW_UNDEFINED_670,
        BREW_UNDEFINED_671,
        BREW_UNDEFINED_672,
        BREW_UNDEFINED_673,
        BREW_UNDEFINED_674,
        BREW_UNDEFINED_675,
        BREW_UNDEFINED_676,
        BREW_UNDEFINED_677,
        BREW_UNDEFINED_678,
        BREW_UNDEFINED_679,
        BREW_UNDEFINED_680,
        BREW_UNDEFINED_681,
        BREW_UNDEFINED_682,
        BREW_UNDEFINED_683,
        BREW_UNDEFINED_684,
        BREW_UNDEFINED_685,
        BREW_UNDEFINED_686,
        BREW_UNDEFINED_687,
        BREW_UNDEFINED_688,
        BREW_UNDEFINED_689,
        BREW_UNDEFINED_690,
        BREW_UNDEFINED_691,
        BREW_UNDEFINED_692,
        BREW_UNDEFINED_693,
        BREW_UNDEFINED_694,
        BREW_UNDEFINED_695,
        BREW_UNDEFINED_696,
        BREW_UNDEFINED_697,
        BREW_UNDEFINED_698,
        BREW_UNDEFINED_699,
        BREW_UNDEFINED_700,
        BREW_UNDEFINED_701,
        BREW_UNDEFINED_702,
        BREW_UNDEFINED_703,
        BREW_UNDEFINED_704,
        BREW_UNDEFINED_705,
        BREW_UNDEFINED_706,
        BREW_UNDEFINED_707,
        BREW_UNDEFINED_708,
        BREW_UNDEFINED_709,
        BREW_UNDEFINED_710,
        BREW_UNDEFINED_711,
        BREW_UNDEFINED_712,
        BREW_UNDEFINED_713,
        BREW_UNDEFINED_714,
        BREW_UNDEFINED_715,
        BREW_UNDEFINED_716,
        BREW_UNDEFINED_717,
        BREW_UNDEFINED_718,
        BREW_UNDEFINED_719,
        BREW_UNDEFINED_720,
        BREW_UNDEFINED_721,
        BREW_UNDEFINED_722,
        BREW_UNDEFINED_723,
        BREW_UNDEFINED_724,
        BREW_UNDEFINED_725,
        BREW_UNDEFINED_726,
        BREW_UNDEFINED_727,
        BREW_UNDEFINED_728,
        BREW_UNDEFINED_729,
        BREW_UNDEFINED_730,
        BREW_UNDEFINED_731,
        BREW_UNDEFINED_732,
        BREW_UNDEFINED_733,
        BREW_UNDEFINED_734,
        BREW_UNDEFINED_735,
        BREW_UNDEFINED_736,
        BREW_UNDEFINED_737,
        BREW_UNDEFINED_738,
        BREW_UNDEFINED_739,
        BREW_UNDEFINED_740,
        BREW_UNDEFINED_741,
        BREW_UNDEFINED_742,
        BREW_UNDEFINED_743,
        BREW_UNDEFINED_744,
        BREW_UNDEFINED_745,
        BREW_UNDEFINED_746,
        BREW_UNDEFINED_747,
        BREW_UNDEFINED_748,
        BREW_UNDEFINED_749,
        BREW_UNDEFINED_750,
        BREW_UNDEFINED_751,
        BREW_UNDEFINED_752,
        BREW_UNDEFINED_753,
        BREW_UNDEFINED_754,
        BREW_UNDEFINED_755,
        BREW_UNDEFINED_756,
        BREW_UNDEFINED_757,
        BREW_UNDEFINED_758,
        BREW_UNDEFINED_759,
        BREW_UNDEFINED_760,
        BREW_UNDEFINED_761,
        BREW_UNDEFINED_762,
        BREW_UNDEFINED_763,
        BREW_UNDEFINED_764,
        BREW_UNDEFINED_765,
        BREW_UNDEFINED_766,
        BREW_UNDEFINED_767,
        BREW_UNDEFINED_768,
        BREW_UNDEFINED_769,
        BREW_UNDEFINED_770,
        BREW_UNDEFINED_771,
        BREW_UNDEFINED_772,
        BREW_UNDEFINED_773,
        BREW_UNDEFINED_774,
        BREW_UNDEFINED_775,
        BREW_UNDEFINED_776,
        BREW_UNDEFINED_777,
        BREW_UNDEFINED_778,
        BREW_UNDEFINED_779,
        BREW_UNDEFINED_780,
        BREW_UNDEFINED_781,
        BREW_UNDEFINED_782,
        BREW_UNDEFINED_783,
        BREW_UNDEFINED_784,
        BREW_UNDEFINED_785,
        BREW_UNDEFINED_786,
        BREW_UNDEFINED_787,
        BREW_UNDEFINED_788,
        BREW_UNDEFINED_789,
        BREW_UNDEFINED_790,
        BREW_UNDEFINED_791,
        BREW_UNDEFINED_792,
        BREW_UNDEFINED_793,
        BREW_UNDEFINED_794,
        BREW_UNDEFINED_795,
        BREW_UNDEFINED_796,
        BREW_UNDEFINED_797,
        BREW_UNDEFINED_798,
        BREW_UNDEFINED_799,
        BREW_UNDEFINED_800,
        BREW_UNDEFINED_801,
        BREW_UNDEFINED_802,
        BREW_UNDEFINED_803,
        BREW_UNDEFINED_804,
        BREW_UNDEFINED_805,
        BREW_UNDEFINED_806,
        BREW_UNDEFINED_807,
        BREW_UNDEFINED_808,
        BREW_UNDEFINED_809,
        BREW_UNDEFINED_810,
        BREW_UNDEFINED_811,
        BREW_UNDEFINED_812,
        BREW_UNDEFINED_813,
        BREW_UNDEFINED_814,
        BREW_UNDEFINED_815,
        BREW_UNDEFINED_816,
        BREW_UNDEFINED_817,
        BREW_UNDEFINED_818,
        BREW_UNDEFINED_819,
        BREW_UNDEFINED_820,
        BREW_UNDEFINED_821,
        BREW_UNDEFINED_822,
        BREW_UNDEFINED_823,
        BREW_UNDEFINED_824,
        BREW_UNDEFINED_825,
        BREW_UNDEFINED_826,
        BREW_UNDEFINED_827,
        BREW_UNDEFINED_828,
        BREW_UNDEFINED_829,
        BREW_UNDEFINED_830,
        BREW_UNDEFINED_831,
        BREW_UNDEFINED_832,
        BREW_UNDEFINED_833,
        BREW_UNDEFINED_834,
        BREW_UNDEFINED_835,
        BREW_UNDEFINED_836,
        BREW_UNDEFINED_837,
        BREW_UNDEFINED_838,
        BREW_UNDEFINED_839,
        BREW_UNDEFINED_840,
        BREW_UNDEFINED_841,
        BREW_UNDEFINED_842,
        BREW_UNDEFINED_843,
        BREW_UNDEFINED_844,
        BREW_UNDEFINED_845,
        BREW_UNDEFINED_846,
        BREW_UNDEFINED_847,
        BREW_UNDEFINED_848,
        BREW_UNDEFINED_849,
        BREW_UNDEFINED_850,
        BREW_UNDEFINED_851,
        BREW_UNDEFINED_852,
        BREW_UNDEFINED_853,
        BREW_UNDEFINED_854,
        BREW_UNDEFINED_855,
        BREW_UNDEFINED_856,
        BREW_UNDEFINED_857,
        BREW_UNDEFINED_858,
        BREW_UNDEFINED_859,
        BREW_UNDEFINED_860,
        BREW_UNDEFINED_861,
        BREW_UNDEFINED_862,
        BREW_UNDEFINED_863,
        BREW_UNDEFINED_864,
        BREW_UNDEFINED_865,
        BREW_UNDEFINED_866,
        BREW_UNDEFINED_867,
        BREW_UNDEFINED_868,
        BREW_UNDEFINED_869,
        BREW_UNDEFINED_870,
        BREW_UNDEFINED_871,
        BREW_UNDEFINED_872,
        BREW_UNDEFINED_873,
        BREW_UNDEFINED_874,
        BREW_UNDEFINED_875,
        BREW_UNDEFINED_876,
        BREW_UNDEFINED_877,
        BREW_UNDEFINED_878,
        BREW_UNDEFINED_879,
        BREW_UNDEFINED_880,
        BREW_UNDEFINED_881,
        BREW_UNDEFINED_882,
        BREW_UNDEFINED_883,
        BREW_UNDEFINED_884,
        BREW_UNDEFINED_885,
        BREW_UNDEFINED_886,
        BREW_UNDEFINED_887,
        BREW_UNDEFINED_888,
        BREW_UNDEFINED_889,
        BREW_UNDEFINED_890,
        BREW_UNDEFINED_891,
        BREW_UNDEFINED_892,
        BREW_UNDEFINED_893,
        BREW_UNDEFINED_894,
        BREW_UNDEFINED_895,

        WCDMA_PS_DATA_RATE, /* 2 byte payload */
        GSM_TO_WCDMA_RESELECT_END, /* 5 byte payload */
        PZID_HAI_ENABLED, /* No payload*/
        PZID_HAI_DISABLED, /* No payload*/
        GSM_TO_WCDMA_HANDOVER_START, /* 4 byte payload */
        WCDMA_RRC_MODE, /* 1 byte payload */
        WCDMA_L1_ACQ_SUBSTATE, /* 1 byte payload */
        WCDMA_PHYCHAN_CFG_CHANGED, /* 1 byte payload */

        QTV_CLIP_STARTED, /* 7 byte payload */
        QTV_CLIP_ENDED, /* 5 byte payload */
        QTV_SDP_PARSER_REJECT, /* No payload */
        QTV_CLIP_PAUSE, /* 4 byte payload */
        QTV_CLIP_REPOSITIONING, /* 4 byte payload */
        QTV_CLIP_ZOOM_IN, /* No payload */
        QTV_CLIP_ZOOM_OUT, /* No payload */
        QTV_CLIP_ROTATE, /* 4 byte payload */
        QTV_CLIP_PAUSE_RESUME, /* 4 byte payload */
        QTV_CLIP_REPOSITION_RESUME, /* 4 byte payload */
        QTV_DSP_INIT, /* No payload */
        QTV_STREAMING_SERVER_URL, /* 22 byte payload */
        QTV_SERVER_PORTS_USED, /* 4 byte payload */
        QTV_USING_PROXY_SERVER, /* 6 byte payload */
        QTV_STREAMER_STATE_IDLE, /* No payload */
        QTV_STREAMER_STATE_CONNECTING, /* No payload */
        QTV_STREAMER_STATE_SETTING_TRACKS, /* No payload */
        QTV_STREAMER_STATE_STREAMING, /* No payload */
        QTV_STREAMER_STATE_PAUSED, /* No payload */
        QTV_STREAMER_STATE_SUSPENDED, /* No payload */
        QTV_STREAMER_CONNECTED, /* No payload */
        QTV_STREAMER_INITSTREAM_FAIL, /* No payload */
        QTV_BUFFERING_STARTED, /* 5 byte payload */
        QTV_BUFFERING_ENDED, /* 5 byte payload */
        QTV_CLIP_FULLSCREEN, /* No payload */
        QTV_PS_DOWNLOAD_STARTED, /* 8 byte payload */
        QTV_PSEUDO_STREAM_STARTED, /* No Payload */
        QTV_PS_PLAYER_STATE_PSEUDO_PAUSE, /* No payload */
        QTV_PS_PLAYER_STATE_PSEUDO_RESUME, /* 4 byte payload */
        QTV_PARSER_STATE_READY, /* 14 byte payload */
        QTV_FRAGMENT_PLAYBACK_BEGIN, /* 2 byte payload */
        QTV_FRAGMENT_PLAYBACK_COMPLETE, /* 2 byte payload */
        QTV_PARSER_STATE_PSEUDO_PAUSE, /* No payload */
        QTV_PLAYER_STATE_PSEUDO_PAUSE, /* No payload */
        QTV_PARSER_STATE_PSEUDO_RESUME, /* 4 byte payload */
        QTV_PLAYER_STATE_PSEUDO_RESUME, /* 4 byte payload */
        QTV_FRAGMENTED_FILE_DECODE_START, /* 2 byte payload */
        QTV_FRAGMENTED_FILE_END_SUCCESS, /* 2 byte payload */
        QTV_DOWNLOAD_DATA_REPORT, /* 4 byte payload */
        QTV_VDEC_DIAG_DECODE_CALLBACK, /* 5 byte payload */
        QTV_URL_PLAYED_IS_MULTICAST, /* No payload */
        QTV_VDEC_DIAG_STATUS, /* 4 byte payload */
        QTV_STREAMING_URL_OPEN, /* 4 byte payload */
        QTV_STREAMING_URL_OPENING, /* No payload */
        QTV_CLIP_ENDED_VER2, /* 13 byte payload */
        QTV_SILENCE_INSERTION_STARTED, /* No payload */
        QTV_SILENCE_INSERTION_ENDED, /* 8 byte payload */
        QTV_AUDIO_CHANNEL_SWITCH_FRAME, /* 8 byte payload */
        QTV_FIRST_VIDEO_FRAME_RENDERED, /* No payload */
        QTV_FIRST_VIDEO_I_FRAME_RENDERED, /* No payload */
        QTV_SDP_SELECTED, /* No payload */
        QTV_DIAG_PLAYER_STATUS, /* 12 byte payload */
        QTV_SILENCE_INSERTION_DURATION, /* 4 byte payload */
        QTV_UNDEFINED_957,
        QTV_UNDEFINED_958,
        QTV_UNDEFINED_959,
        QTV_UNDEFINED_960,
        QTV_UNDEFINED_961,
        QTV_UNDEFINED_962,
        QTV_UNDEFINED_963,
        QTV_UNDEFINED_964,
        QTV_UNDEFINED_965,
        QTV_UNDEFINED_966,
        QTV_UNDEFINED_967,

        DS_SETS_ARM_CLOCK_FASTER, /* No payload */
        DS_SETS_ARM_CLOCK_SLOWER, /* No payload */

        SMS_STATISTICS, /* 2 byte payload */
        SM_PDP_STATE, /* 4 byte payload */
        MVS_STATE, /* 2 byte payload */

        SECSSL, /* 16 byte payload */
        SECTEST, /* 16 byte payload */
        SECVPN, /* 16 byte payload */
        SECCRYPT, /* 16 byte payload */
        SECCRYPT_CMD, /* 16 byte payload */

        SEC_RESERVED_978, /* unknown payload */
        SEC_RESERVED_979, /* unknown payload */
        SEC_RESERVED_980, /* unknown payload */
        SEC_RESERVED_981, /* unknown payload */

        ARM_CLK_FREQUENCY_CHANGE, /* 12 byte payload */
        ADSP_CLK_FREQUENCY_CHANGE, /* 4 byte payload */
        MDSP_CLK_FREQUENCY_CHANGE, /* 4 byte payload */

        CELL_CHANGE_INDICATION, /* 1 byte payload */
        CB_STATE_CHANGE, /* 4 byte payload */
        SMSCB_L1_STATE_CHANGE, /* 3 byte payload */
        SMSCB_L1_COLLISION, /* 1 byte payload */
        WMS_SEARCH_REQUEST, /* 1 byte payload */
        CM_GET_PASSWORD_IND, /* 2 byte payload */
        CM_PASSWORD_AUTHENTICATION_STATUS, /* 2 byte payload */
        CM_USS_RESPONSE_NOTIFY_IND, /* 3 byte payload */
        CM_USS_CONF, /* 4 byte payload */
        CM_RELEASE_USS_IND, /* 4 byte payload */
        CM_FWD_AOC_IND, /* 1 byte payload */
        PZID_ID, /* 2 byte payload */
        PZID_HT_VALUE, /* 9 byte payload */
        PZID_EXISTS_IN_LIST, /* 1 byte payload */
        GSDI_GET_FILE_ATTRIBUTES, /* 6 byte payload */
        GSDI_SIM_READ, /* 6 byte payload */
        GSDI_SIM_WRITE, /* 6 byte payload */
        GSDI_GET_PIN_STATUS, /* 8 byte payload */
        GSDI_VERIFY_PIN, /* 7 byte payload */
        GSDI_UNBLOCK_PIN, /* 7 byte payload */
        GSDI_DISABLE_PIN, /* 7 byte payload */
        GSDI_ENABLE_PIN, /* 7 byte payload */
        GSDI_SIM_INCREASE, /* 6 byte payload */
        GSDI_EXECUTE_APDU_REQ, /* 6 byte payload */
        SEG_UPM_ADDR_MISMATCH, /* 2 byte payload */
        WCDMA_PRACH, /* 3 byte payload */
        GSDI_SELECT, /* 6 byte payload */
        WCDMA_RAB_RATE_RECONFIG, /* 2 byte payload */
        WCDMA_RLC_RESETS, /* 3 byte payload */
        WCDMA_RLC_OPEN_CLOSE, /* 2 byte payload */
        WCDMA_RLC_MRW, /* 3 byte payload */
        QVP_APP_PROCESS_EVENT, /* 2 byte payload */
        QVP_APP_STATE_CHANGED_EVENT, /* 2 byte payload */
        QVP_APP_CALL_CONNECTED_EVENT, /* 1 byte payload */
        GSDI_CARD_NOTIFICATION, /* 4 byte payload */
        CM_DATA_AVAILABLE, /* 1 byte payload */
        CM_DS_INTERRAT_STATE, /* 2 byte payload */
        MM_STATE, /* 2 byte payload */
        GMM_STATE, /* 2 byte payload */
        PLMN_INFORMATION, /* 8 byte payload */
        COREAPP_SET_VOICE_PRIVACY, /* 5 byte payload */
        COREAPP_GET_VOICE_PRIVACY, /* 5 byte payload */
        HARD_HANDOFF_LONG_CODE_MASK_CHANGE, /* 14 byte payload */
        VCTCXO_FREEZE, /* payload */
        VCTCXO_UNFREEZE, /* payload */
        SMS_SLOT_WAKEUP_V2, /* 2 byte payload */
        QVP_RCVD_FIRST_VIDEO_FRAME, /* no payload */
        QVP_CALL_RELEASED, /* 8 byte payload */
        CB_SMS_NOTIFY, /* 10 byte payload */
        GPS_PDSM_REPORT, /* 6 byte payload */
        LONG_CODE_MASK_CHANGED, /* 2 byte payload */
        DS707, /* 5 byte payload */

        GSDI_ACTIVATE_FEATURE_IND, /* 8 byte payload */
        GSDI_DEACTIVATE_FEATURE_IND, /* 8 byte payload */
        GSDI_GET_FEATURE_IND, /* 11 byte payload */
        GSDI_SET_FEATURE_DATA, /* 6 byte payload */
        GSDI_UNBLOCK_FEATURE_IND, /* 8 byte payload */
        GSDI_GET_CONTROL_KEY, /* 6 byte payload */
        GSDI_OTA_DEPERSO, /* 26 byte payload */
        GSDI_GET_PERM_FEATURE_IND, /* 11 byte payload */
        GSDI_PERM_DISBALE_FEATURE_IND, /* 8 byte payload */
        GSM_L1_VOCODER_INITIALIZE, /* TBD */
        GSM_L1_ALIGN_VFR, /* TBD */
        GSM_L1_VOCODER_ENABLED, /* TBD */
        HDR_AMAC_PERSISTENCE_FAILED, /* no payload */
        HDR_AMAC_PERSISTENCE_PASSED, /* no payload */

        /* 20 events reserved for MediaFLO */
        MFLO_STREAM_STATE, /* 12 byte payload */
        MFLO_CONTROL_CHANNEL_STATE_CHANGE, /* 12 byte payload */
        MFLO_SLEEP_STATE_CHANGE, /* 12 byte payload */
        MFLO_NETWORK_STATE_CHANGE, /* 20 byte payload */
        MFLO_TRANS_STATE, /* 12 byte payload */
        MFLO_OIS_STATE, /* 16 byte payload */
        MFLO_RXD_STATE, /* 12 byte payload */
        MFLO_HIPRI_STATE_CHANGE, /* 8  byte payload */
        MFLO_CAS_STATE, /* 12 byte payload */
        MFLO_ACQ_STATE, /* 8  byte payload */
        MFLO_OSCAR_FRAME_DECODED, /* 8  byte payload */
        MFLO_CHAN_SWITCH_RENDERED, /* 16 byte payload */
        MFLO_OSCAR_DEC_EXCEPTION_DETECTED, /* 4  byte payload */
        MFLO_MFN_SUBSTATE, /* 8  byte payload */
        MFLO_MFN_STATE, /* 12  byte payload */
        MFLO_MFN_VERTICAL_HANDOFF, /* 16  byte payload */
        MFLO_MFN_ACQ_STATE, /* 10  byte payload */
        MFLO_FLOW_STATUS, /* 12  byte payload */
        MFLO_NETWORK_STATUS, /* 12  byte payload */
        MFLO_UNDEFINED_1070,

        CM_LCS_MOLR_CONF, /* 1 byte payload */
        PPP_NETMODEL, /* 7 byte payload */
        CAMERA_PROFILING, /* 1 byte payload */
        MAC_HS_T1_EXPIRY, /* 2 byte payload */
        ASYNC_DS707, /* 4 byte payload */
        PKT_DS707, /* 4 byte payload */
        GPRS_TIMER_EXPIRY, /* 1 byte payload */
        GPRS_MAC_IDLE_IND, /* no payload */
        GPRS_PACKET_CHANNEL_REQUEST, /* 1 byte payload */
        GPRS_ACCESS_REJECT, /* 1 byte payload */
        GPRS_PACKET_RESOURCE_REQUEST, /* 1 byte payload */
        GPRS_PACKET_UPLINK_ASSIGNMENT, /* 2 byte payload */
        GPRS_PACKET_DOWNLINK_ASSIGNMENT, /* 2 byte payload */
        PACKET_TIMESLOT_RECONFIGURE, /* 3 byte payload */
        GPRS_TBF_RELEASE, /* 1 byte payload */
        GPRS_CELL_CHANGE_ORDER, /* 1 byte payload */
        GPRS_CELL_CHANGE_FAILURE, /* 1 byte payload */
        GSM_AMR_RATSCCH_REQ, /* 1 byte payload */
        GSM_AMR_RATSCCH_RSP, /* 1 byte payload */
        SD_SRV_IND_HYBR_WLAN,
        SD_ACTION_HYBR_WLAN,
        GPS_PD_DEMOD_SESS_START, /* 5 byte payload */
        GPS_PD_DEMOD_SESS_END, /* 1 byte payload */
        GPS_SV_ACQUIRED, /* 4 byte payload */
        GPS_SV_BIT_EDGE_FOUND, /* 4 byte payload */
        GPS_DEMOD_STARTED, /* 4 byte payload */
        GPS_DEMOD_OUT_OF_LOCK, /* 3 byte payload */
        GPS_DEMOD_STOPPED, /* 3 byte payload */
        GPS_DEMOD_PREAMBLE_FOUND, /* 3 byte payload */
        GPS_DEMOD_FRAME_SYNC_STATUS, /* 4 byte payload */
        GPS_DEMOD_SUBFRAME, /* 6 byte payload */
        GPS_DEMOD_EPHEMERIS_COMPLETE, /* 1 byte payload */
        GPS_DEMOD_ALMANAC_COMPLETE, /* 1 byte payload */
        GPS_DEMOD_BIT_EDGE_STATUS, /* 4 byte payload */
        RAT_CHANGE, /* 1 byte payload */
        REGISTRATION_SUPPRESSED, /* 1 byte payload */
        HDR_RUP_DIST_BASED_REG, /* 3 byte payload */
        GPS_DIAG_APP_TRACKING_START, /* 4 byte payload */
        GPS_DIAG_APP_TRACKING_END, /* 12 byte payload */
        GPS_DIAG_APP_POSITION_SUCCESS, /* 16 byte payload */
        GPS_DIAG_APP_POSITION_FAILURE, /* 6 byte payload */
        GSM_AMR_MULTIRATE_IE, /* 9 byte payload */
        EPZID_HYSTERESIS_ENABLED, /* no payload */
        EPZID_HYSTERESIS_DISABLED, /* no payload */
        EPZID_HT_STARTED, /* 10 byte payload */
        EPZID_HT_EXPIRED, /* 10 byte payload */
        HDR_BCMCS_FLOW_STATE_CHANGE, /* 6 byte payload */
        HDR_LMAC_UPDATE_BC_STATUS, /* 1 byte payload */
        DS_CAM_TIMER, /* 5 byte payload */
        DS_RDUD_TIMER, /* 5 byte payload */
        DS_CTA_TIMER, /* 8 bytes payload */
        DS_FALLBACK, /* 1 byte payload */
        DS3G_CAM_FLOW_CTRL_TIMER, /* 5 byte payload */
        GPS_JAMMER_DETECTION_TEST_PASS, /* no payload */
        GPS_JAMMER_DETECTION_TEST_FAILURE, /* 8 byte payload */
        JAMMER_DETECT_NOISE_STATS, /* 8 byte payload */
        GPS_GET_PARAM, /* 8 byte payload */
        GPS_GET_PARAM_BS_INFO, /* 18 byte payload */
        HS_SERVING_CELL_CHANGE, /* 8 byte payload */
        HS_DSCH_STATUS, /* 1 byte payload */
        SMGMM_REQUEST_SENT, /* 2 byte payload */
        SMGMM_REJECT_RECEIVED, /* 2 byte payload */
        LINUX_APP_STOP, /* 8 byte payload */
        GPS_PD_CME_SESSION_START, /* 1 byte payload */
        GPS_PD_CME_SESSION_END, /* 1 byte payload */

        /* 20 events reserved for QVideoPhone */
        SIP_REGISTER_START, /* 4 byte payload */
        SIP_REGISTER_DONE, /* 1 byte payload */
        SIP_CALL_SETUP_START, /* 5 byte payload */
        SIP_CALL_SETUP_DONE, /* No payload */
        SIP_CALL_RELEASE_START, /* 5 byte payload */
        SIP_CALL_RELEASE_DONE, /* No payload */
        AUDIO_FRAME_SENT_TO_DECODER, /* 12 byte payload */
        VIDEO_FRAME_SENT_TO_DECODER, /* 12 byte payload */
        DEC_RENDER_FRAME, /* 8 byte payload */
        DEC_RENDER_DONE, /* No payload */
        DEC_START_DECODING, /* 4 byte payload */
        DEC_FRAME_DECODED, /* 4 byte payload */
        V_ENCODED, /* 13 byte payload */
        DEC_START_DECODING_EXT, /* 8 byte payload */
        DEC_FRAME_DECODED_EXT, /* 8 byte payload */
        QVIDEOPHONE_UNDEFINED_1151,
        QVIDEOPHONE_UNDEFINED_1152,
        QVIDEOPHONE_UNDEFINED_1153,
        QVIDEOPHONE_UNDEFINED_1154,
        QVIDEOPHONE_UNDEFINED_1155,

        GPS_CME_POS_REQ, /* no payload */
        GPS_CME_FIX_START, /* no payload */
        GPS_CME_FIX_END, /* no payload */
        GPS_SEED_CLM, /* 12 byte payload */
        GPS_SEED_SID, /* 10 byte payload */
        GPS_SEED_SL, /* 11 byte payload */
        GPS_SEED_GET, /* 13 byte payload */

        HDR_OVHD_BC_MSG_RX, /* no payload */
        HDR_OVHD_T_BC_SUPERVISION, /* no payload */
        HDR_LMAC_SET_BCMCS_PAGE_CYCLE, /* 1 byte payload */
        HDR_HMP_SESSION_CLOSED, /* 2 byte payload */

        WLAN_CP, /* 15 byte payload */
        ARP, /* 12 byte payload */
        DHCP, /* 10 byte payload */
        WLAN_WPA, /* 7 byte payload */
        EAP, /* 7 byte payload */
        LAN_1X, /* 7 byte payload */

        CAMERA_SVCS_START, /* no payload */
        CAMERA_SVCS_STOP, /* no payload */

        BCMCS_SRVC_AVAILABLE, /* 1 byte payload */
        BCMCS_SRVC_LOST, /* 1 byte payload */
        BCMCS_FLOW_REGISTERED, /* 18 byte payload */
        BCMCS_FLOW_DEREGISTERED, /* 18 byte payload */
        BCMCS_FLOW_STATUS_CHANGED, /* 19 byte payload */

        CAMERA_SVCS_X, /* 2 byte payload */
        CM_CALL_ORIG_THR, /* 3 byte payload */

        VFE_MSG_CONFIG_COMPLETE, /* No payload */
        VFE_MSG_IDLE_COMPLETE, /* No payload */
        VFE_MSG_UPDATE_COMPLETE, /* No payload */
        VFE_MSG_AE_AWB_STATS, /* No payload */
        DSP_VIDEO_ENC_DOWNLOAD_DONE, /* No payload */
        DSP_VIDEO_ENC_SELECTION_DONE, /* No payload */
        DSP_VIDEO_ENC_CONFIG_DONE, /* No payload */
        DSP_VIDEO_ENC_FRAME_DONE, /* No payload */

        HDR_OVHD_BCMCS_CHAN_CHANGE, /* 6 byte payload */

        QVS_REGISTER_START, /* 4 byte payload */
        QVS_REGISTER_DONE, /* 4 byte payload */
        QVS_REGISTER_FAILED, /* No payload */
        QVS_CALL_SETUP_START, /* 5 byte payload */
        QVS_CALL_SETUP_DONE, /* No payload */
        QVS_CALL_SETUP_FAILED, /* No payload */
        QVS_CALL_RELEASE_START, /* 5 byte payload */
        QVS_CALL_RELEASE_DONE, /* No payload */
        QVS_CALL_RELEASE_FAILED, /* No payload */

        CAMCORDER_START_RECORD, /* 9 byte payload */
        CAMCORDER_START_TRANSCODE, /* 6 byte payload */
        CAMCORDER_FRAME_DROP, /* No payload */
        CAMCORDER_AUDIODUB, /* 2 byte payload */

        PSMM_SENT, /* 16 byte payload */
        GPS_PD_FALLBACK_MODE, /* 3 byte payload */

        PEAP, /* 4 byte payload */
        TTLS, /* 3 byte payload */
        TLS, /* 2 byte payload */

        WCDMA_TO_WCDMA_RESELECTION_VER2_START, /* 7 byte payload */

        EUL_RECONFIG_OR_ASU, /* 10 byte payload */
        EUL_SERVING_CELL_CHANGE, /* 4 byte payload */
        EUL_PHYSICAL_LAYER_RECONFIG, /* 10 byte payload */

        DRM_ROAP_TRIGGER_RECIEVED, /* 1 byte payload */
        DRM_ROAP_PROTOCOL_START, /* 1 byte payload */
        DRM_ROAP_REQUEST, /* 1 byte payload */
        DRM_ROAP_REQUEST_EXTENSION, /* 2 byte payload */
        DRM_ROAP_RESPONSE, /* 2 byte payload */
        DRM_ROAP_RESPONSE_EXTENSION, /* 2 byte payload */
        DRM_ROAP_RI_CONTEXT, /* 1 byte payload */
        DRM_ROAP_ERROR, /* 1 byte payload */
        DRM_ROAP_RSP_VALIDATION, /* 3 byte payload */
        DRM_ROAP_PROTOCOL_END, /* 2 byte payload */

        DS_WMK_ALLOCATED, /* 16 byte payload */
        DS_WMK_DEALLOCATED, /* 8  byte payload */
        DS_WMK_FLUSHED, /* 12 byte payload */
        DS_WMK_FLOW_ENABLED, /* 12 byte payload */
        DS_WMK_FLOW_DISABLED, /* 12 byte payload */

        HDR_IDLE_SET_SLEEP_DURATION, /* 2 byte payload */
        HDR_SCM_SESSION_CHANGED, /* 1 byte payload */

        UMTS_TO_CDMA_DATA_HANDOVER, /* No payload */
        UMTS_TO_CDMA_VOICE_HANDOVER, /* 18 byte payload */

        MO_SMS_RETRY_ATTEMPT, /* 14 byte payload */

        HDR_LMAC_UPDATE_QSM_STATUS, /* 1 byte payload */

        CM_CELL_SRV_IND, /* 5 byte payload */

        RLP_NAK_ABORT, /* 9 byte payload */

        DRM_RIGHTS_OPERATION, /* 2 byte payload */

        DS_RESV_MSG_SENT_REV_FLOWS, /* 15 byte payload */
        DS_RESV_MSG_SENT_FWD_FLOWS, /* 15 byte payload */
        DS_RESV_RESP_SUCCESS_RECD, /* 4 byte payload */
        DS_RESV_RESP_FAILURE_RECD, /* 4 byte payload */

        GPS_PD_COMM_FAILURE, /* 2 byte payload */
        GPS_PD_COMM_DONE, /* No payload */
        GPS_PD_END, /* 1 byte payload */
        GPS_PA_CALLBACK, /* 1 byte payload */
        GPS_PD_CMD_ERR_CALLBACK, /* 2 byte payload */
        GPS_PA_CMD_ERR_CALLBACK, /* 2 byte payload */

        GPS_LM_ENTER_SA_RF_VERIF, /* 1 byte payload */
        GPS_LM_EXIT_SA_RF_VERIF, /* 1 byte payload */
        GPS_LM_ERROR_SA_RF_VERIF, /* 1 byte payload */
        GPS_LM_PD_COMPLETE, /* No payload */
        GPS_LM_IQ_TEST_COMPLETE, /* No payload */

        PM_APP_OTG_INIT, /* No payload */
        PM_APP_OTG_RESET, /* No payload */
        PM_APP_OTG_ACQUIRE_BUS_REQ, /* 2 byte payload */
        PM_APP_OTG_RELINQUISH_BUS_REQ, /* No payload */
        PM_APP_OTG_SUSPEND, /* No payload */
        PM_APP_OTG_RESUME, /* No payload */
        PM_APP_OTG_DEVICE_ATTACHED, /* 1 byTe payload */
        PM_APP_OTG_DEVICE_DETACHED, /* No payload */
        PM_APP_OTG_HOST_MODE_REM_PERI_DIS, /* No payload */
        PM_APP_OTG_PERI_MODE_PREPARE_FOR_REM_HOST_WAKEUP_SIG, /* No payload */
        PM_APP_OTG_PERI_MODE_REM_HOST_WAKEUP_SIG_DONE, /* No payload */
        PM_APP_OTG_SET_REM_WAKEUP_CAPABILITY, /* 1 byte payload */
        PM_APP_OTG_OPERATIONAL_ERROR, /* 1 byte Payload */
        PM_APP_OTG_CONFIGURE_USB_POWER_CONSUMER, /* No payload */
        PM_APP_OTG_SET_USB_POWER_CONSUMPTION_REQUIREMENT, /* 1 byte payload */
        PM_APP_OTG_PERI_MODE_PROCESS_USB_POWER_LINE_CONT_REQ, /* 1 byte payload */
        PM_APP_OTG_PERI_MODE_SET_REM_A_DEV_INFO, /* 3 byte payload */
        PM_APP_OTG_STATE_TRANSITION, /* 2 byte payload */

        DTV_TABLE_ACQ_SUCCESS, /* 10 byte payload */
        DTV_TABLE_ACQ_FAIL, /* 5 byte payload */
        DTV_DVBH_SEL_PLTFM_REQ_RCVD, /* 4 byte payload */
        DTV_DVBH_PLTFM_ACQ_SUCCESS, /* 4 byte payload */
        DTV_DVBH_PLTFM_ACQ_FAIL, /* 4 byte payload */
        DTV_DVBH_TBL_MGR_STATE_CHANGED, /* 2 byte payload */
        DTV_DVBH_CE_STATE_CHANGED, /* 2 byte payload */
        DTV_DVBH_MCAST_JOIN_REQ_RCVD, /* 18 byte payload */
        DTV_DVBH_MCAST_LEAVE_REQ_RCVD, /* 18 byte payload */
        DTV_DVBH_INIT_REQ_RCVD, /* No payload */
        DTV_DVBH_MCAST_JOIN_SUCCESS, /* 18 byte payload */
        DTV_DVBH_MCAST_JOIN_FAILURE, /* 18 byte payload */
        DTV_DVBH_MCAST_LEAVE_SUCCESS, /* 18 byte payload */
        DTV_DVBH_MCAST_LEAVE_FAILURE, /* 18 byte payload */
        DTV_DVBH_INIT_SUCCESS, /* No payload */
        DTV_DVBH_INIT_FAILURE, /* No payload */

        GPS_LM_SESSION_START, /* 1 byte payload */
        GPS_LM_SESSION_END, /* No payload */
        GPS_LM_FIX_REQUEST_START, /* No payload */
        GPS_LM_FIX_REQUEST_END, /* No payload */
        GPS_LM_PRM_REQUEST_START, /* No payload */
        GPS_LM_PRM_REQUEST_END, /* No payload */
        GPS_LM_SESSION_CONTINUE, /* 1 byte payload */
        GPS_LM_FIX_REQUEST_CONTINUE, /* No payload */
        GPS_LM_PRM_REQUEST_CONTINUE, /* No payload */
        GPS_LM_PPM_REQUEST_CONTINUE, /* No payload */
        GPS_LM_AIDING_DATA_RECEIVED, /* 1 byte payload */
        GPS_LM_RC_ON_TIMER_TIMEOUT, /* No payload */
        GPS_LM_SHUT_OFF_TIMER_TIMEOUT, /* No payload */
        GPS_LM_MGP_ON, /* No payload */
        GPS_LM_MGP_IDLE, /* No payload */
        GPS_LM_MGP_OFF, /* No payload */

        DRM_RO_CONSUMPTION_VALIDATION, /* 2 byte payload */
        DRM_RO_INSTALLATION_VALIDATION, /* 2 byte payload */

        FLUTE_FDT_INST_RCVD, /* 8 byte payload */
        FLUTE_FDT_INST_RCV_FAIL, /* 9 byte payload */
        FLUTE_FDT_INST_EXPIRED, /* 8 byte payload */
        FLUTE_JOIN_SESSION_REQ_RCVD, /* 24 byte payload */
        FLUTE_LEAVE_SESSION_REQ_RCVD, /* 4 byte payload */
        FLUTE_SESSION_CLOSED, /* 5 byte payload */
        FLUTE_SESSION_CLOSED_BY_APP, /* 4 byte payload */
        FLUTE_B_FLAG_RCVD, /* 8 byte payload */
        FLUTE_GET_FILE_REQUEST_RCVD, /* 8 byte payload */
        FLUTE_JOIN_SESSION_RSP, /* 6 byte payload */
        FLUTE_FILE_STATUS_RSP, /* 16 byte payload */
        FLUTE_CANCEL_FILE_REQ_RCVD, /* 8 byte payload */

        DTV_DVBH_DEINIT_REQ_RCVD, /* No payload */
        DTV_DVBH_DEINIT_SUCCESS, /* No payload */
        DTV_DVBH_DEINIT_FAILURE, /* No payload */

        CONTENT_INSTALL_BEGIN, /* No payload */
        CONTENT_INSTALL_COMPLETE, /* 2 byte payload */
        CONTENT_RETRIEVAL_BEGIN, /* No payload */
        CONTENT_RETRIEVAL_COMPLETE, /* 4 byte payload */
        CONTENT_BACKUP_BEGIN, /* No payload */
        CONTENT_BACKUP_COMPLETE, /* 2 byte payload */
        CONTENT_FWD_BEGIN, /* No payload */
        CONTENT_FWD_COMPLETE, /* 2 byte payload */

        HARD_HANDOFF_VOIP_TO_CDMA, /* 14 byte payload */

        EAP_SIM_AKA, /* 14 byte payload */
        WLAN_CP_MEAS, /* 16 byte payload */
        WLAN_CP_HO, /* 13 byte payload */
        WLAN_CP_11D, /* 9  byte payload */
        WLAN_MC, /* 2  byte payload */

        SVG_CONTENT_SET, /* 2  byte payload */
        SVG_CONTENT_PLAY, /* 2  byte payload */
        SVG_CONTENT_RESUME, /* 1  byte payload */
        SVG_CONTENT_PAUSE, /* 1  byte payload */
        SVG_CONTENT_STOP, /* 1  byte payload */
        SVG_CONTENT_USEREVENT, /* 10 byte payload */
        SVG_CONTENT_GETURIDATA, /* 3  byte payload */
        SVG_CONTENT_TRANSFORM, /* 10 byte payload */
        SVG_GET_PARAM, /* 3  byte payload */
        SVG_SET_PARAM, /* 3  byte payload */

        WLAN_WPA2, /* 5 byte payload */

        WCDMA_PSC_SCANNER_STOP, /* 1 byte payload */

        MEDIA_PLAYER_KEYPRESS, /* 4 byte payload */

        WLAN_MC_QOS, /* 5 byte payload */

        WCDMA_PSC_SCANNER_STATE, /* 1 byte payload */

        WLAN_CP_ADHOC, /* 16 byte payload */

        DMB_STACK_SHUTDOWN, /* 4 byte payload */
        DMB_TUNE_DONE_SUCCESS, /* 4 byte payload */
        DMB_TUNE_DONE_FAILURE, /* 4 byte payload */
        DMB_SEARCH_DONE, /* 4 byte payload */
        DMB_SCAN_DONE, /* 4 byte payload */
        DMB_RECEPTION_INFO_CHANGED, /* 4 byte payload */
        DMB_DMB_GUIDE_CHANGED, /* 4 byte payload */
        DMB_LOCATION_INFO_CHANGED, /* 4 byte payload */
        DMB_LOST_ENSEMBLE, /* 4 byte payload */
        DMB_STREAM_TERMINATED, /* 4 byte payload */
        DMB_STREAM_DATA_AVAILABLE, /* 4 byte payload */
        DMB_RESERVED1, /* 4 byte payload */
        DMB_RESERVED2, /* 4 byte payload */
        DMB_RESERVED3, /* 4 byte payload */
        DMB_RESERVED4, /* 4 byte payload */
        DMB_RESERVED5, /* 4 byte payload */
        DMB_RESERVED6, /* 4 byte payload */
        DMB_RESERVED7, /* 4 byte payload */
        DMB_RESERVED8, /* 4 byte payload */
        DMB_RESERVED9, /* 4 byte payload */
        DMB_RESERVED10, /* 4 byte payload */

        MOBILEVIEW_RESERVED1, /* TBD */
        MOBILEVIEW_RESERVED2, /* TBD */
        MOBILEVIEW_RESERVED3, /* TBD */
        MOBILEVIEW_RESERVED4, /* TBD */
        MOBILEVIEW_RESERVED5, /* TBD */

        HDR_DOS_MO_DOS_STATUS, /* 3 byte payload */

        GPSONEXTRA_START_DOWNLOAD, /* 4 byte payload */
        GPSONEXTRA_END_DOWNLOAD, /* 4 byte payload */

        SNSD_GENERIC, /* 8 byte payload */
        SNSD_DEVICE_INIT, /* 8 byte payload */
        SNSD_DEVICE_CONFIGURED, /* 8 byte payload */
        SNSD_DATA_READY, /* 8 byte payload */
        SNSD_COND_MET, /* 8 byte payload */
        SNSD_DEVICE_DOWN, /* 8 byte payload */
        SNSD_ERROR, /* 8 byte payload */

        CM_COUNTRY_SELECTED, /* 2 byte payload */
        CM_SELECT_COUNTRY, /* 7 byte payload */

        GPS_DCME_NEW_SV_ADDED_IN_AA, /* 1 byte payload */
        GPS_DCME_SV_REMOVED_FROM_AA, /* 1 byte payload */

        ESG_GET_PROV_LIST_REQ_RCVD, /* No payload */
        ESG_GET_PROV_LIST_REQ_FAIL, /* No payload */
        ESG_PROV_LIST_AVAILABLE, /* No payload */
        ESG_ACQ_REQ_RCVD, /* 2 byte payload */
        ESG_ACQ_REQ_FAIL, /* 2 byte payload */
        ESG_STOP_REQ_RCVD, /* No payload */
        ESG_STOP_REQ_FAIL, /* No payload */
        ESG_STOP_COMPLETE, /* 1 byte payload */

        ADC_ONDIE_THERM_READ, /* 2 byte payload */

        CONTENT_NO_VALID_OR_EXPIRED_RIGHTS, /* No Payload */

        MOBILEVIEW_RESERVED30, /* EVENT TO BE REPLACED */
        MOBILEVIEW_RESERVED31, /* EVENT TO BE REPLACED */
        MOBILEVIEW_RESERVED32, /* EVENT TO BE REPLACED */

        GPS_DCME_MEAS_CYCLE_START, /* No payload */
        GPS_DCME_MEAS_CYCLE_END, /* No payload */
        GPS_CME_ENGAGED, /* No payload */
        GPS_CME_NOT_ENGAGED, /* No payload */
        GPS_DCME_ENGAGED, /* No payload */
        GPS_DCME_NOT_ENGAGED, /* No payload */

        HS_USB_DEVICE_ATTACHED, /* No payload */
        HS_USB_HID_DISCONECT, /* No payload */
        HS_USB_HID_CONNECT, /* 2 byte payload */
        HS_USB_MSD_CONNECT, /* No payload */
        HS_USB_MSD_DISCONECT, /* No payload */
        HS_USB_STACK_SUSPENDED, /* 1 byte payload */
        HS_USB_STACK_RESUMED, /* 1 byte payload */
        HS_USB_ENTER_HOST_MODE, /* No payload */
        HS_USB_OPERATIONAL_ERROR, /* 2 byte payload */

        DTV_L1_ACQ_DONE, /* 5 byte payload */
        DTV_L1_SCAN, /* 4 byte payload */
        DTV_L1_ONLINE, /* 1 byte payload */
        DTV_L1_SNOOZE, /* No payload */
        DTV_L1_SLEEP, /* No payload */
        DTV_L1_HANDOFF, /* 5 byte payload */
        DTV_L1_SIGNAL_LOST, /* No payload */

        IMS_SIP_REGISTRATION_START, /* 4 byte payload */
        IMS_SIP_REGISTER_END, /* 4 byte payload */
        IMS_SIP_DEREGISTER_START, /* 4 byte payload */
        IMS_SIP_DEREGISTER_END, /* 4 byte payload */
        IMS_SIP_SESSION_START, /* 4 byte payload */
        IMS_SIP_SESSION_RINGING, /* 4 byte payload */
        IMS_SIP_SESSION_ESTABLISHED, /* 4 byte payload */
        IMS_SIP_SESSION_TERMINATED, /* 4 byte payload */
        IMS_SIP_SESSION_CANCEL, /* 4 byte payload */
        IMS_SIP_SESSION_FAILURE, /* 4 byte payload */
        IMS_SIP_RESPONSE_RECV, /* 4 byte payload */
        IMS_SIP_REQUEST_RECV, /* 4 byte payload */
        IMS_SIP_RESPONSE_SEND, /* 4 byte payload */
        IMS_SIP_REQUEST_SEND, /* 4 byte payload */

        WLAN_TKIP_COUNTER_MEAS, /* 2 byte payload */

        GPS_BLANKING_OFF, /* No payload */
        GPS_BLANKING_ON, /* No payload */

        MMGSDI_EVENT, /* 16 byte payload */

        WLAN_CP_SYS_MGR_STATE_TRANS, /* 3 byte payload */

        GPS_OPTIMISTIC_PUNC_START, /* 4 byte payload */
        GPS_OPTIMISTIC_PUNC_END, /* 4 byte payload */

        QVP_SEND_RTP_PACKET, /* 7 byte payload */
        QVP_RECV_RTP_PACKET, /* 7 byte payload */

        HDR_IDLE_REACQ_FAIL_DDARF, /* 3 byte payload */

        BCAST_SEC_STKM_PARSE_STATUS, /* 2 byte payload */
        BCAST_SEC_STKM_RECEIVED, /* No payload */
        BCAST_SEC_SDP_PARSE_STATUS, /* 2 byte payload */

        CGPS_ME_DPO_STATUS, /* 1 byte payload */
        GPS_SV_SEARCH_STATE, /* 6 byte payload */
        GPS_TM_ON_DEMAND_MODE_CHANGE, /* 3 byte payload */
        GPS_TM_ON_DEMAND_BEGIN, /* 6 byte payload */
        GPS_TM_ON_DEMAND_DONE, /* 1 byte payload */

        RMAC_CARRIER_STATE_CHANGED, /* 6 byte payload */

        GPS_SBAS_DEMOD_REPORT, /* 9 byte payload */
        GPS_EXTERN_COARSE_POS_INJ_START, /* No payload */
        GPS_EXTERN_COARSE_POS_INJ_END, /* 1 byte payload */
        GPS_EPH_REREQUEST_TIME, /* 2 byte payload */

        WLAN_QOS_PSTREAM, /* 3 byte payload */
        WLAN_CP_VCC, /* 9 byte payload */

        CGPS_DIAG_FIRST_SUCCESSFUL_FIX, /* No payload */

        EUL_RECONFIG_OR_ASU_OR_TTI_RECFG, /* 12 byte payload */

        DS707_PKT_LN_UPDATE, /* 3 byte payload */
        DS707_PKT_IDM_CHANGE, /* 2 byte payload */

        RLP_QN_ADD, /* 3 byte payload */
        RLP_QN_DROP, /* 3 byte payload */
        RLP_MULTILINK_NAK, /* 9 byte payload */
        RLP_REV_LINK_NAK, /* 9 byte payload */
        GSTK_EVENT, /* 16 byte payload */

        GAN_REGISTRATION_REQUEST, /* 1 byte payload */
        GAN_REGISTER_ACCEPT, /* 1 byte payload */
        CALL_RINGING_ALERT, /* 1 byte payload */
        GAN_PAGING_RECEIVED, /* 1 byte payload */
        GAN_CALL_DISCONNECT, /* 1 byte payload */
        GAN_CALL_RELEASE_COMPLETE, /* 1 byte payload */
        GAN_HANDIN_COMMAND, /* 1 byte payload */
        GAN_HANDIN_COMPLETE, /* 1 byte payload */
        GAN_HANDOUT_COMMAND, /* 1 byte payload */
        GAN_HANDOUT_COMPLETE, /* 1 byte payload */
        GAN_SMS_START, /* 1 byte payload */
        GAN_SMS_ACK, /* 1 byte payload */
        GAN_QDJ_ENQUEUE, /* No payload */
        GAN_QDJ_DEQUEUE, /* No payload */
        GAN_ACTIVATE_DATA_CHANNEL, /* 1 byte payload */
        GAN_DATA_CHANNEL_CONNECTED, /* 1 byte payload */
        GAN_RLP_SUSPEND, /* 1 byte payload */
        GAN_RLP_RESUME, /* 1 byte payload */
        GAN_WAKEUP_REQ, /* No payload */
        GAN_WAKEUP_CNF, /* No payload */
        GAN_HIBERNATION_REQ, /* No payload */
        GAN_HIBERNATION_CNF, /* No payload */

        WCDMA_UL_AMR_RATE, /* 11 byte payload */
        EUL_TTI_RECONFIG, /* 1 byte payload */
        WCDMA_CONN_REL_CAUSE, /* 1 byte payload */
        WCDMA_CONN_REQ_CAUSE, /* 1 byte payload */

        LTE_TIMING_ADVANCE, /* 3 byte payload */
        LTE_UL_OUT_OF_SYNC, /* No payload */
        LTE_SPS_DEACTIVATED, /* 1 byte payload */
        LTE_RACH_ACCESS_START, /* 2 byte payload */
        LTE_RACH_RAID_MATCH, /* 1 byte payload */
        LTE_RACH_ACCESS_RESULT, /* 1 byte payload */

        DTV_L1_POWERUP, /* 2 byte payload */
        DTV_L1_POWERDOWN, /* 2 byte payload */
        DTV_L1_SOFT_RESET, /* 2 byte payload */
        DTV_L1_STATE_CHANGE, /* 8 byte payload */
        DTV_L1_ACQ_TUNE_STATUS, /* 9 byte payload */
        DTV_L1_ACQ_DONE_STATUS, /* 9 byte payload */
        DTV_L1_ACQ_FAIL, /* 3 byte payload */
        DTV_L1_TRAFFIC_STARTED, /* 2 byte payload */
        DTV_L1_BAD_FRAME_RECEIVED, /* 6 byte payload */
        DTV_L1_TMCC_FAILURE, /* 4 byte payload */
        DTV_L1_RECOVERY_STATUS, /* 5 byte payload */
        DTV_L1_INTERRUPT_LOG_RECEIVED, /* 2 byte payload */
        DTV_L1_L3_API_COMMAND, /* 4 byte payload */
        DTV_L1_MODEM_FAILURE, /* 6 byte payload */

        GSM_CALL_DROP, /* 2 byte payload */
        GSM_ACCESS_FAILURE, /* 3 byte payload */

        DTV_ISDB_ACTIVATE, /* 9 byte payload */
        DTV_ISDB_DEACTIVATE, /* 9 byte payload */
        DTV_ISDB_TUNE, /* 13 byte payload */
        DTV_ISDB_UNTUNE, /* 9 byte payload */
        DTV_ISDB_SELECT_SERVICE, /* 11 byte payload */
        DTV_ISDB_SERVICE_AVAILABLE, /* 6 byte payload */
        DTV_ISDB_TRAFFIC_LOST, /* 4 byte payload */
        DTV_ISDB_TABLE_UPDATE, /* 7 byte payload */
        DTV_ISDB_TRACKS_SELECTED, /* 13 byte payload */
        DTV_ISDB_PES_BUFFER_OVERFLOW, /* 5 byte payload */
        DTV_ISDB_PES_BUFFER_UNDERFLOW, /* 5 byte payload */
        DTV_ISDB_ACQUIRE_DATA_COMPONENT, /* 10 byte payload */
        DTV_ISDB_STOP_COMPONENT_ACQUISITION, /* 10 byte payload */
        DTV_ISDB_DII_CHANGED, /* 5 byte payload */
        DTV_ISDB_DATA_MESSAGE, /* 5 byte payload */
        DTV_ISDB_MODULE_CONSTRUCTION, /* 13 byte payload */
        DTV_ISDB_PARSING_ERROR, /* 13 byte payload */

        HDR_SLP_SLPQH_TIMER_STARTED, /* No payload */
        HDR_SLP_SLPQH_TIMER_STOPPED, /* 1 byte payload */
        HDR_SLP_SLPQH_NUM_PENDING_MSGS, /* 1 byte payload */
        HDR_OVHD_FIND_CACHED_MSG, /* 1 byte payload */

        WCDMA_RRC_TIMER_EXPIRED, /* 1 byte payload */
        WCDMA_UOOS_TIMER_USED, /* 4 byte payload */
        WCDMA_UOOS_TIMER_START, /* 1 byte payload */
        WCDMA_UOOS_TIMER_STOP, /* 1 byte payload */
        WCDMA_UOOS_TIME_REMAINING, /* 6 byte payload */
        WCDMA_RRCCSP_SCAN_START, /* 1 byte payload */
        WCDMA_ACQUISITON_SUCCESS, /* 5 byte payload */
        WCDMA_CELL_SELECTION_FAIL, /* 1 byte payload */
        WCDMA_BPLMN_START, /* 1 byte payload */
        WCDMA_BPLMN_END, /* 1 byte payload */
        WCDMA_BPLMN_SCAN_START, /* 1 byte payload */
        WCDMA_BPLMN_SCAN_END, /* 1 byte payload */

        MSG_HIGH, /* 32 byte payload */
        MSG_MED, /* 32 byte payload */
        MSG_LOW, /* 32 byte payload */
        MSG_ERROR, /* 32 byte payload */
        MSG_FATAL, /* 32 byte payload */

        GAN_START_TU3910, /* No payload */
        GAN_STOP_TU3910, /* No payload */
        GAN_EXPIRY_TU3910, /* No payload */
        GAN_START_TU3920, /* No payload */
        GAN_STOP_TU3920, /* No payload */
        GAN_EXPIRY_TU3920, /* No payload */
        GAN_START_TU3906, /* No payload */
        GAN_STOP_TU3906, /* No payload */
        GAN_EXPIRY_TU3906, /* No payload */
        GAN_URR_REGISTER_UPDATE, /* 1 byte payload */

        IPSEC_IKE_SA_INIT_SENT, /* 8 bytes payload */
        IPSEC_IKE_SA_INIT_RECV, /* 16 bytes payload */
        IPSEC_IKE_SA_ESTABLISHED, /* 16 bytes payload */
        IPSEC_IKE_AUTH_SENT, /* 16 bytes payload */
        IPSEC_IKE_AUTH_RECV, /* 16 bytes payload */
        IPSEC_IKE_EAP_START, /* No payload */
        IPSEC_IKE_EAP_FINISH, /* 1 byte payload */
        IPSEC_CHILD_SA_ESTABLISHED, /* 8 bytes payload */
        IPSEC_IKE_INFO_MSG_SENT, /* 16 bytes payload */
        IPSEC_IKE_INFO_MSG_RECV, /* 16 bytes payload */
        IPSEC_CREATE_CHILD_SA_SENT, /* 16 bytes payload */
        IPSEC_CREATE_CHILD_SA_RECV, /* 16 bytes payload */
        IPSEC_IKE_SA_DELETE_START, /* 16 bytes payload */
        IPSEC_IKE_SA_DELETE_DONE, /* 16 bytes payload */
        IPSEC_CHILD_SA_DELETE_START, /* 8 bytes payload */
        IPSEC_CHILD_SA_DELETE_DONE, /* 8 bytes payload */
        IPSEC_IKE_SA_REKEY_START, /* 16 bytes payload */
        IPSEC_IKE_SA_REKEY_DONE, /* 16 bytes payload */
        IPSEC_CHILD_SA_REKEY_START, /* 8 bytes payload */
        IPSEC_CHILD_SA_REKEY_DONE, /* 8 bytes payload */
        IPSEC_IKE_MESG_RETRANSMIT, /* 4 bytes payload */
        IPSEC_IKE_NAT_DETECTED, /* No payload */
        IPSEC_IKE_NAT_KEEPALIVE_SENT, /* 16 bytes payload */
        IPSEC_IKE_DPD_SENT, /* 16 bytes payload */
        IPSEC_IKE_ERR_NOTIFY_SENT, /* 4 bytes payload */
        IPSEC_IKE_ERR_NOTIFY_RECV, /* 4 bytes payload */

        GAN_ROVEIN_CNF, /* No payload */
        GAN_ROVEOUT_CNF, /* No payload */
        GAN_RRC_ROVEIN_CNF, /* No payload */
        GAN_RRC_ROVEIN_REJ, /* 1 byte payload */
        GAN_RRC_ROVEOUT_CNF, /* No payload */
        GAN_RRC_ROVEOUT_REJ, /* 1 byte payload */

        GPSXTRA_T_SESS_BEGIN, /* 1 byte payload */
        GPSXTRA_T_SESS_DATA, /* 8 byte payload */
        GPSXTRA_T_SESS_DONE, /* 1 byte payload */
        GPSXTRA_T_SESS_END, /* 4 byte payload */

        DS_GO_NULL_TIMER, /* 5 byte payload */

        LTE_RRC_TIMER_STATUS, /* 6 byte payload */
        LTE_RRC_STATE_CHANGE, /* 1 byte payload */
        LTE_RRC_OUT_OF_SERVICE, /* 2 byte payload */
        LTE_RRC_RADIO_LINK_FAILURE, /* 2 byte payload */
        LTE_RRC_DL_MSG, /* 2 byte payload */
        LTE_RRC_UL_MSG, /* 2 byte payload */
        LTE_RRC_NEW_CELL_IND, /* 5 byte payload */
        LTE_RRC_CELL_RESEL_FAILURE, /* 5 byte payload */
        LTE_RRC_HO_FAILURE, /* 5 byte payload */
        LTE_RRC_PAGING_DRX_CYCLE, /* 2 byte payload */
        LTE_RRC_IRAT_HO_FROM_EUTRAN, /* 1 byte payload */
        LTE_RRC_IRAT_HO_FROM_EUTRAN_FAILURE, /* 1 byte payload */
        LTE_RRC_IRAT_RESEL_FROM_EUTRAN, /* 1 byte payload */
        LTE_RRC_IRAT_RESEL_FROM_EUTRAN_FAILURE, /* 1 byte payload */
        LTE_RRC_SIB_READ_FAILURE, /* 6 byte payload */

        GAN_ROVEIN_REQ, /* No payload */
        GAN_ROVEOUT_REQ, /* No payload */

        MBP_RF_ANALOG_JD_MODE_CHANGE, /* 7 byte payload */
        MBP_RF_ANALOG_JD_INT, /* 4 byte payload */

        CGPS_QWIP_SYSD_TRANSITION, /* 4 byte payload */

        HPLMN_TIMER_EXPIRED, /* No Payload */

        GSDI_GET_FEATURE_INDICATOR_DATA, /* 6 byte payload */

        LTE_CM_INCOMING_MSG, /* 1 byte payload */
        LTE_CM_OUTGOING_MSG, /* 1 byte payload */
        LTE_EMM_INCOMING_MSG, /* 1 byte payload */
        LTE_EMM_OUTGOING_MSG, /* 1 byte payload */
        LTE_EMM_TIMER_START, /* 1 byte payload */
        LTE_EMM_TIMER_EXPIRY, /* 1 byte payload */

        LTE_REG_INCOMING_MSG, /* 1 byte payload */
        LTE_REG_OUTGOING_MSG, /* 1 byte payload */
        LTE_ESM_INCOMING_MSG, /* 1 byte payload */
        LTE_ESM_OUTGOING_MSG, /* 1 byte payload */
        LTE_ESM_TIMER_START, /* 1 byte payload */
        LTE_ESM_TIMER_EXPIRY, /* 1 byte payload */

        SNS_CONTEXT_OPEN, /* 4 byte payload */
        SNS_CONTEXT_CLOSE, /* 4 byte payload */
        SNS_COND_SET, /* 8 byte payload */
        SNS_COND_CANCEL, /* 8 byte payload */
        SNS_COND_MET, /* 8 byte payload */
        SNS_DATA_START, /* 12 byte payload */
        SNS_DATA_STOP, /* 8 byte payload */

        WCDMA_RLC_CONFIG, /* 4 byte payload */

        HSPA_PLUS_CFG, /* 6 byte payload */

        SNS_DRIVER_STATE_CHANGE, /* 9 byte payload */

        WCDMA_TIMER_DISCARD_EXPIRY, /* 3 byte payload */

        NAS_CB_PAGE_RECEIVED, /* 5 byte payload */

        WCDMA_RLC_RESET, /* 1 byte payload */

        HDR_MRLP_EHRPD_PERSONALITY_IS_ACTIVE, /* 1 byte payload */

        WLAN_SECURITY, /* 13 byte payload */
        WLAN_STATUS, /* 15 byte payload */
        WLAN_HANDOFF, /* 15 byte payload */
        WLAN_VCC, /* 8 byte payload */
        WLAN_QOS, /* 2 byte payload */
        WLAN_PE, /* 16 byte payload */
        WLAN_ADD_BLOCK_ACK_SUCCESS, /* 11 byte payload */
        WLAN_ADD_BLOCK_ACK_FAILED, /* 9 byte payload */
        WLAN_DELETE_BLOCK_ACK_SUCCESS, /* 8 byte payload */
        WLAN_DELETE_BLOCK_ACK_FAILED, /* 8 byte payload */
        WLAN_BSS_PROTECTION, /* 2 byte payload */
        WLAN_BRINGUP_STATUS, /* 12 byte payload */
        WLAN_POWERSAVE_GENERIC, /* 16 byte payload */
        WLAN_POWERSAVE_WOW, /* 11 byte payload */
        WLAN_WCM, /* 17 byte payload */
        WLAN_WPS_SCAN_START, /* 16 byte payload */
        WLAN_WPS_SCAN_COMPLETE, /* 2 byte payload */
        WLAN_WPS_CONNECT_REQUEST, /* 9 byte payload */
        WLAN_WPS_CONNECT_RESPONSE, /* 6 byte payload */
        WLAN_WPS_PBC_SESSION_OVERLAP, /* 16 byte payload */
        WLAN_WPS_PBC_WALK_TIMER_START, /* No payload */
        WLAN_WPS_PBC_WALK_TIMER_STOP, /* No payload */
        WLAN_WPS_PBC_AP_DETECTED, /* 14 byte payload */
        WLAN_WPS_REGISTRATION_START, /* 1 byte payload */
        WLAN_WPS_WSC_MESSAGE, /* 1 byte payload */
        WLAN_WPS_DISCOVERY, /* 7 byte payload */
        WLAN_WPS_REGISTRATION_COMPLETE, /* 1 byte payload */
        WLAN_WPS_DISCONNECT, /* No payload */
        WLAN_BTC, /* 15 byte payload */

        IPV6_SM_EVENT, /* 4 byte payload */
        IPV6_SM_TRANSITION, /* 5 byte payload */
        IPV6_PREFIX_UPDATE, /* 13 byte payload */

        LTE_ML1_STATE_CHANGE, /* 2 byte payload */

        AUTH_PROTO, /* 2 byte payload */
        VSNCP, /* 2 byte payload */
        IID, /* 2 byte payload */

        IMS_VIDEOSHARE_REGISTRATION_SUCCESS, /* 4 byte payload */
        IMS_VIDEOSHARE_INVITE_SENT, /* 4 byte payload */
        IMS_VIDEOSHARE_INCOMING_INVITE, /* 4 byte payload */
        IMS_VIDEOSHARE_ACCEPT_REJECT_INVITE, /* 4 byte payload */
        IMS_VIDEOSHARE_ACCEPTING_SESSION, /* 4 byte payload */
        IMS_VIDEOSHARE_SESSION_ESTABLISHED, /* 4 byte payload */
        IMS_VIDEOSHARE_END_SESSION, /* 4 byte payload */
        IMS_VIDEOSHARE_PREVIEW_VIDEO_FRAME, /* 4 byte payload */
        IMS_VIDEOSHARE_DECODED_VIDEO_FRAME, /* 4 byte payload */
        IMS_VIDEOSHARE_RECEIVING, /* 4 byte payload */
        IMS_VIDEOSHARE_START_APPLICATION, /* 4 byte payload */
        IMS_VIDEOSHARE_END_APPLICATION, /* 4 byte payload */
        IMS_VIDEOSHARE_CAPABILITY_SUCCESS, /* 4 byte payload */
        IMS_VIDEOSHARE_MEDIA_RECORDING_RESOURCE_ACQUIRED, /* 4 byte payload */
        IMS_VIDEOSHARE_MEDIA_RECORDING_RESOURCE_RELEASED, /* 4 byte payload */
        IMS_VIDEOSHARE_SENDING, /* 4 byte payload */
        IMS_VIDEOSHARE_INCOMING_OPTION_RECEIVED, /* 4 byte payload */
        IMS_VIDEOSHARE_INCOMING_OPTION_RESPONDED, /* 4 byte payload */
        IMS_VIDEOSHARE_ERR_CALL_FAILED, /* 4 byte payload */
        IMS_VIDEOSHARE_ERR_REGISTRATION_FAILED, /* 4 byte payload */
        IMS_VIDEOSHARE_ERR_RECORDER_ERROR, /* 4 byte payload */
        IMS_VIDEOSHARE_ERR_PLAYER_ERROR, /* 4 byte payload */
        IMS_VIDEOSHARE_ERR_MEDIA_SESSION_FAILURE, /* 4 byte payload */
        IMS_VIDEOSHARE_ERR_CAPABILITY_FAILURE, /* 4 byte payload */
        IMS_VIDEOSHARE_ERR_MEDIA_RECORDING_FAILED, /* 4 byte payload */

        WLAN_PE_FRAME, /* 16 byte payload */

        SNS_VCPS_HEADING_COMPUTED, /* 12 byte payload */
        SNS_VCPS_TRACKED_CAL_SET_SAVED, /* 22 byte payload */

        GNSS_PRESC_DWELL_COMPLETE, /* 2 byte payload */

        LTE_MAC_RESET, /* 1 byte payload */
        LTE_BSR_SR_REQUEST, /* 1 byte payload */
        LTE_MAC_TIMER, /* 2 byte payload */

        CM_DS_OPERATIONAL_MODE, /* 2 byte payload */
        CM_DS_MODE_PREF, /* 5 byte payload */
        CM_DS_GW_ACQ_ORDER_PREF, /* 5 byte payload */
        CM_DS_SRV_DOMAIN_PREF, /* 5 byte payload */
        CM_DS_BAND_PREF, /* 5 byte payload */
        CM_DS_ROAM_PREF, /* 5 byte payload */
        CM_DS_HYBRID_PREF, /* 5 byte payload */
        CM_DS_NETWORK_SEL_MODE_PREF, /* 5 byte payload */
        CM_DS_CALL_ORIG, /* 4 byte payload */
        CM_DS_CALL_CONNECT, /* 4 byte payload */
        CM_DS_CALL_END, /* 3 byte payload */
        CM_DS_ENTER_EMERGENCY_CB, /* 1 byte payload */
        CM_DS_EXIT_EMERGENCY_CB, /* 1 byte payload */
        CM_DS_CALL_STATE, /* 2 byte payload */
        CM_DS_DS_INTERRAT_STATE, /* 3 byte payload */
        CM_DS_CELL_SRV_IND, /* 6 byte payload */
        CM_DS_COUNTRY_SELECTED, /* 3 byte payload */
        CM_DS_DATA_AVAILABLE, /* 2 byte payload */
        CM_DS_SELECT_COUNTRY, /* 8 byte payload */
        CM_DS_CALL_ORIG_THR, /* 4 byte payload */
        CM_DS_PLMN_FOUND, /* 13 byte payload */
        CM_DS_SERVICE_CONFIRMED, /* 13 byte payload */
        CM_DS_GET_PASSWORD_IND, /* 3 byte payload */
        CM_DS_PASSWORD_AUTHENTICATION_STATUS, /* 3 byte payload */
        CM_DS_USS_RESPONSE_NOTIFY_IND, /* 4 byte payload */
        CM_DS_LCS_MOLR_CONF, /* 2 byte payload */

        DS_NAS_MESSAGE_SENT, /* 5 byte payload */
        DS_NAS_MESSAGE_RECEIVED, /* 5 byte payload */
        DS_MM_STATE, /* 3 byte payload */
        DS_GMM_STATE, /* 3 byte payload */
        DS_PLMN_INFORMATION, /* 10 byte payload */

        DIAG_STRESS_TEST_COMPLETED, /* 4 byte payload */

        GNSS_CC_STATUS, /* 2 byte payload */

        SNS_USER_STATE_CHANGE, /* 6 byte payload */

        DS_HPLMN_TIMER_EXPIRED, /* 1 byte payload */
        DS_RAT_CHANGE, /* 2 byte payload */

        DTV_CMMB_API_CALL_ACTIVATE, /*9 byte payload*/ /*ID=1757*/
        DTV_CMMB_API_CALL_DEACTIVATE, /*9 byte payload*/
        DTV_CMMB_API_CALL_TUNE, /*13 byte payload*/
        DTV_CMMB_API_CALL_SELECT_SERVICE, /*11 byte payload*/
        DTV_CMMB_API_CALL_DESELECT_SERVICE, /*11 byte payload*/
        DTV_CMMB_API_CALL_GET_SIGNAL_PARAMETERS, /*9 byte payload*/
        DTV_CMMB_API_CALL_GET_NIT, /*9 byte payload*/
        DTV_CMMB_API_CALL_GET_CMCT, /*9 byte payload*/
        DTV_CMMB_API_CALL_GET_SMCT, /*9 byte payload*/
        DTV_CMMB_API_CALL_GET_CSCT, /*9 byte payload*/
        DTV_CMMB_API_CALL_GET_SSCT, /*9 byte payload*/
        DTV_CMMB_API_CALL_GET_EADT, /*9 byte payload*/
        DTV_CMMB_API_CALL_REQUEST_CA_CARD_NUMBER, /*9 byte payload*/
        DTV_CMMB_API_CALL_REQUEST_CAS_ID, /*9 byte payload*/
        DTV_CMMB_API_CALL_REGISTER_FOR_CONTROL_NOTIFICATIONS, /*9 byte payload*/
        DTV_CMMB_API_CALL_DEREGISTER_FROM_CONTROL_NOTIFICATIONS, /*9 byte payload*/
        DTV_CMMB_API_NOTIFICATION_ACTIVATE, /*9 byte payload*/
        DTV_CMMB_API_NOTIFICATION_DEACTIVATE, /*9 byte payload*/
        DTV_CMMB_API_NOTIFICATION_TUNE, /*13 byte payload*/
        DTV_CMMB_API_NOTIFICATION_SELECT_SERVICE, /*11 byte payload*/
        DTV_CMMB_API_NOTIFICATION_DESELECT_SERVICE, /*11 byte payload*/
        DTV_CMMB_API_NOTIFICATION_TABLE_UPDATE, /*6 byte payload*/
        DTV_CMMB_API_NOTIFICATION_SIGNAL_PARAMETERS, /*14 byte payload*/
        DTV_CMMB_API_NOTIFICATION_AUTHORIZATION_FAILURE, /*11 byte payload*/
        DTV_CMMB_API_NOTIFICATION_REGISTER_FOR_CONTROL_NOTIFICATIONS_COMPLETE, /*9 byte payload*/
        DTV_CMMB_API_NOTIFICATION_DEREGISTER_FROM_CONTROL_NOTIFICATIONS_COMPLETE, /*9 byte payload*/
        DTV_CMMB_API_NOTIFICATION_CA_CARD_NUMBER, /*9 byte payload*/
        DTV_CMMB_API_NOTIFICATION_CAS_ID, /*9 byte payload*/
        DTV_CMMB_API_NOTIFICATION_EMERGENCY_BROADCASTING_TRIGGER, /*9 byte payload*/
        DTV_CMMB_API_NOTIFICATION_EMERGENCY_BROADCASTING_MESSAGE, /*9 byte payload*/
        DTV_CMMB_API_CALL_REGISTER_FOR_ESG_NOTIFICATIONS, /*9 byte payload*/
        DTV_CMMB_API_CALL_DEREGISTER_FROM_ESG_NOTIFICATIONS, /*9 byte payload*/
        DTV_CMMB_API_CALL_GET_BASIC_DESCRIPTION_INFORMATION, /*9 byte payload*/
        DTV_CMMB_API_CALL_SET_OUTPUT_PATH, /*9 byte payload*/
        DTV_CMMB_API_NOTIFICATION_ESG_DATA_INFORMATION, /*6 byte payload*/
        DTV_CMMB_API_NOTIFICATION_ESG_DATA_INFORMATION_DOWNLOAD_COMPLETE, /*9 byte payload*/
        DTV_CMMB_API_NOTIFICATION_ESG_PROGRAM_INDICATION_INFORMATION, /*9 byte payload*/
        DTV_CMMB_API_NOTIFICATION_REGISTER_FOR_ESG_NOTIFICATIONS_COMPLETE, /*9 byte payload*/
        DTV_CMMB_API_NOTIFICATION_DEREGISTER_FROM_ESG_NOTIFICATIONS_COMPLETE, /*9 byte payload*/
        DTV_CMMB_CAS_INITIALIZED, /*9 byte payload*/
        DTV_CMMB_CAS_EMM_RECEIVED_AND_PROCESSED, /*9 byte payload*/
        DTV_CMMB_CAS_ECM_RECEIVED_AND_PROCESSED, /*11 byte payload*/ /*ID=1798*/

        ECALL_START, /*3 byte payload*/
        ECALL_STOP, /*1 byte payload*/
        ECALL_SESSION_START, /*1 byte payload*/
        ECALL_SESSION_FAILURE, /*1 byte payload*/
        ECALL_SESSION_COMPLETE, /*3 byte payload*/
        ECALL_SESSION_RESET, /*1 byte payload*/
        ECALL_PSAP_MSD_DECODE_SUCCESS, /*2 byte payload*/
        ECALL_PSAP_LOST_SYNC, /*1 byte payload*/ /*ID = 1806*/

        LTE_RRC_IRAT_REDIR_FROM_EUTRAN_START, /*1 byte payload */
        LTE_RRC_IRAT_REDIR_FROM_EUTRAN_END, /* 2 byte payload */ /*ID = 1808*/

        GPRS_DS_CELL_CHANGE_ORDER, /* 2 byte payload */ /*1809*/
        GSM_DS_CELL_SELECTION_END, /* 2 byte payload */ /*1810*/
        GSM_DS_L1_STATE, /* 2 byte payload */ /*1811*/
        GSM_DS_PLMN_LIST_START, /* 2 byte payload */ /*1812*/
        GSM_DS_PLMN_LIST_END, /* 1 byte payload */ /*1813*/
        GSM_DS_POWER_SCAN_STATUS, /* 2 byte payload */ /*1814*/
        GSM_DS_RESELECT_START, /* 2 byte payload */ /*1815*/
        GSM_DS_RR_IN_SERVICE, /* 1 byte payload */ /*1816*/
        GSM_DS_RR_OUT_OF_SERVICE, /* 1 byte payload */ /*1817*/
        GSM_DS_TIMER_EXPIRED, /* 3 byte payload */ /*1818*/
        GSM_DS_TO_WCDMA_RESELECT_END, /* 6 byte payload */ /*1819*/

        CM_DS_SYSTEM_MODE, /*2 byte payload*/ /*1820*/
        SD_DS_ACTION = 0x71d, /*9 byte payload*/ /*1821*/
        SMGMM_DS_REQUEST_SENT = 0x71e, /*3 byte payload*/ /*1822*/
        IFACE = 0x71F, /*4 byte payload*/ /*1823*/
        DS_GSM_L1_ALIGN_VFR = 0x720,
        DS_GSM_L1_STATE = 0x721,
        DS_GSM_RATSCCH_IN_DTX = 0x722,
        DS_GSM_FACCH_IN_DTX = 0x723,
        DS_GSM_FACCH_AND_RATSCCH_COLLISION = 0x724,
        DS_GSM_FACCH_AND_SID_UPDATE_COLLISION = 0x725,
        DS_GSM_RATSCCH_AND_SID_UPDATE_COLLISION = 0x726,
        DS_GSM_AMR_STATE_CHANGE = 0x727,
        DS_GSM_RATSCCH_CMI_PHASE_CHANGE = 0x728,
        DS_GSM_RATSCCH_REQ_ACT_TIMER_EXPIRY = 0x729,
        DS_GSM_RATSCCH_ACK_ACT_TIMER_EXPIRY = 0x72a,
        DS_GSM_AMR_RATSCCH_REQ = 0x72b,
        DS_GSM_AMR_RATSCCH_RSP = 0x72c,
        DS_GSM_AMR_CMC_TURNAROUND_TIME = 0x72d,
        DS_GPRS_SMGMM_MSG_RECEIVED = 0x72e,
        DS_GPRS_SMGMM_MSG_SENT = 0x72f,
        DS_GPRS_LLC_READY_TIMER_START = 0x730,
        DS_GPRS_LLC_READY_TIMER_END = 0x731,
        DS_PACKET_TIMESLOT_RECONFIGURE = 0x732,
        DS_GPRS_MAC_MSG_RECEIVED = 0x733,
        DS_GPRS_MAC_MSG_SENT = 0x734,
        DS_GPRS_MAC_CAMPED_ON_CELL = 0x735,
        DS_GPRS_CELL_CHANGE_FAILURE = 0x736,
        DS_GPRS_PACKET_CHANNEL_REQUEST = 0x737,
        DS_GPRS_PACKET_UPLINK_ASSIGNMENT = 0x738,
        DS_GPRS_PACKET_DOWNLINK_ASSIGNMENT = 0x739,
        DS_GPRS_TBF_RELEASE = 0x73a,
        DS_GPRS_TIMER_EXPIRY = 0x73b,
        DS_GPRS_PACKET_RESOURCE_REQUEST = 0x73c,
        DS_RANDOM_ACCESS_REQUEST = 0x73d,
        DS_GSM_HANDOVER_START = 0x73e,
        DS_GSM_HANDOVER_END = 0x73f,
        DS_GSM_RESELECT_START = 0x740,
        DS_GSM_RESELECT_END = 0x741,
        DS_GSM_TO_WCDMA_RESELECT_END = 0x742,
        DS_GSM_MESSAGE_RECEIVED = 0x743,
        DS_GSM_RR_IN_SERVICE = 0x744,
        DS_GSM_RR_OUT_OF_SERVICE = 0x745,
        DS_GSM_PAGE_RECEIVED = 0x746,
        DS_GSM_CAMP_ATTEMPT_START = 0x747,
        DS_GSM_CAMP_ATTEMPT_END = 0x748,
        DS_GSM_CALL_DROP = 0x749,
        DS_GSM_ACCESS_FAILURE = 0x74a,
        DS_GSM_CELL_SELECTION_START = 0x74b,
        DS_GSM_CELL_SELECTION_END = 0x74c,
        DS_GSM_POWER_SCAN_STATUS = 0x74d,
        DS_GSM_PLMN_LIST_START = 0x74e,
        DS_GSM_PLMN_LIST_END = 0x74f,
        DS_GSM_AMR_MULTIRATE_IE = 0x750,
        DS_GPRS_LINK_FAILURE = 0x751,
        DS_GPRS_PAGE_RECEIVED = 0x752,
        DS_GPRS_SURROUND_SEARCH_START = 0x753,
        DS_GPRS_SURROUND_SEARCH_END = 0x754,
        DS_GPRS_EARLY_CAMPING = 0x755,
        DS_GSM_LINK_FAILURE = 0x756,

        MTP_FILE_DELETED = 0x757,
        MTP_PLAYLIST_REMOVED_OBJECT = 0x758,
        MTP_SYNC_STARTED = 0x759,
        MTP_SYNC_FINISHED = 0x75a,
        MTP_SAVE_ALBUMART_STARTED = 0x75b,
        MTP_SAVE_ALBUMART_FINISHED = 0x75c,
        MTP_FORMAT_STORE_STARTED = 0x75d,
        MTP_FORMAT_STORE_DONE = 0x75e,
        MTP_FORMAT_STORE_ERROR = 0x75f,
        LTE_RRC_SECURITY_CONFIG = 0x760,
        LTE_RRC_IRAT_RESEL_FROM_EUTRAN_START = 0x761,
        LTE_RRC_IRAT_RESEL_FROM_EUTRAN_END = 0x762,
        SNS_REST_DETECT_ACCEL_ACTIVE_TS = 0x763,
        SNS_REST_DETECT_ACCEL_STOP_TS = 0x764,
        CPC_CONFIG_ACTION = 0x765,
        FDPCH_CONFIG_ACTION = 0x766,
        SNS_DRV_MOTION_DETECT_SIG = 0x767,
        SNS_DRV_OPMODE_CHANGE = 0x768,
        PM_BATT_CONNECT = 0x769,
        PM_BATT_DISCONNECT = 0x76a,
        PM_BATT_TEMP_OUT_OF_RANGE = 0x76b,
        PM_CHARGE_STATE_CHANGED = 0x76c,
        PM_CHARGE_DONE = 0x76d,
        PM_CHARGE_FAIL = 0x76e,
        PM_VBAT_DET = 0x76f,
        PM_AUTO_CHARGING_EOC_ITERM_SW_TIMER = 0x770,
        PM_AUTO_CHARGING_EOC_DETECTION_SW_TIMER = 0x771,
        PM_AUTO_CHARGING_MAX_CHARGE_SW_TIMER = 0x772,
        PM_AUTO_CHARGING_RESUME_CHARGE_DETECTION_TIMER = 0x773,
        PM_OVP_TRIGGERED = 0x774,
        PM_GEN_VERIFY_REGISTER_DEFAULTS = 0x775,
        EVENT_1X_FPC_MODE = 0x776,
        EVENT_1X_FPC_RATCHET = 0x777,
        EVENT_1X_FSCH_ASSIGN = 0x778,
        EVENT_1X_RSCH_ASSIGN = 0x779,
        EVENT_1X_RSCH_REQUEST = 0x77a,
        EVENT_1X_ADV_FL_SB_STATUS = 0x77b,
        EVENT_1X_ADV_RL_SB_STATUS = 0x77c,
        EVENT_1X_ADV_N2M_CHANGE = 0x77d,
        PM_COMMON_TEST = 0x77e,
        PM_COMMON_TEST_PAYLOAD = 0x77f,
        CGPS_PREEMPTION_FLAG = 0x780,
        CM_LTE_BAND_PREF = 0x781,
        PS_ARBITRATION = 0x782,
        SD_AVOIDANCE_LOG = 0x783,
        HSPAPLUS_DC = 0x784,
        HS_SCCH_ORDER = 0x785,
        DSM_POOL_LEVEL = 0x786,
        GPSONEXTRA_DATA_ACK = 0x787,
        MCS_MSGR_SEND = 0x788,
        MCS_MSGR_RECV = 0x789,
        WCDMA_TO_LTE_RESELECTION_START = 0x78A,
        WCDMA_TO_LTE_RESELECTION_END = 0x78B,
        WCDMA_EOOS_SKIP_FULL_SCAN_TIMER_START = 0x78C,
        WCDMA_EOOS_SKIP_FULL_SCAN_TIMER_STOP = 0x78D,
        WCDMA_EOOS_SKIP_FULL_SCAN_TIMER_EXPIRED = 0x78E,
        LTE_RRC_CELL_BLACKLIST_IND = 0x78F,
        LTE_RRC_AS_RESET = 0x790,
        WCDMA_OL_MTD_CONFIG_ACTION = 0x791,
        LTE_ML1_PHR_REPORT = 0x792,
        SMS_COMMAND_PROCESSED = 0x793,
        SMS_MT_NOTIFY = 0x794,
        GPSXTRA_T_CONN_BEGIN = 0x795,
        GPSXTRA_T_CONN_CONNECT = 0x796,
        GPSXTRA_T_CONN_DISCONNET = 0x797,
        GPSXTRA_T_CONN_DONE = 0x798,
        GPSXTRA_T_CONN_FAILURE = 0x799,
        GNSS_TLE_SRV_CHANGE_C = 0x79A,
        GNSS_TLE_CELL_CHANGE_C = 0x79B,
        GNSS_TLE_POS_UPDATE_C = 0x79C,
        GNSS_TLE_TIME_TAG_C = 0x79D,
        GNSS_TLE_DELETE_C = 0x79E,
        GNSS_TLE_TIME_UPDATE_C = 0x79F,
        GNSS_TLE_POSITION_REPORT = 0x7A0,
        WCDMA_TO_LTE_REDIRECTION_START = 0x7A1,
        WCDMA_TO_LTE_REDIRECTION_END = 0x7A2,
        WCDMA_DED_PRIORITIES_VALIDITY_TIMER_START = 0x7A3,
        WCDMA_DED_PRIORITIES_VALIDITY_TIMER_EXPIRED = 0x7A4,
        LTE_RRC_IRAT_RTT_FROM_EUTRAN_START = 0x7A5,
        LTE_RRC_IRAT_RTT_FROM_EUTRAN_END = 0x7A6,
        WCDMA_RRC_DSIM_TUNEAWAY_START = 0x7A7,
        WCDMA_RRC_DSIM_TUNEAWAY_STOP = 0x7A8,
        SMS_ETWS_PRIM_RECEIVED = 0x7A9,
        SMS_CBS_MSG_RECEIVED = 0x7AA,
        LTE_ML1_TX_POWER_BACKOFF = 0x7AB,
        WCDMA_CELL_EFACH_EPCH_ERACH_SUPPORT = 0x7AC,
        GPSXTRA_T_CONN_TYPE = 0x7AD,
        LTE_EMM_OTA_INCOMING_MSG = 0x7AE,
        LTE_EMM_OTA_OUTGOING_MSG = 0x7AF,
        LTE_ESM_OTA_INCOMING_MSG = 0x7B0,
        LTE_ESM_OTA_OUTGOING_MSG = 0x7B1,
        LTE_RRC_PLMN_SEARCH_START = 0x7B2,
        LTE_RRC_PLMN_SEARCH_STOP = 0x7B3,
        LTE_RRC_BG_TO_FG_PLMN_SEARCH = 0x7B4,
        LTE_RRC_LATE_PLMN_SEARCH_RESPONSE = 0x7B5,
        WCDMA_RRC_CRNTI = 0x7B6,
        WCDMA_RRC_URNTI = 0x7B7,
        DS_EPC_PDN = 0x7B8,
        DS_EPC_SRAT_CLEANUP_TIMER = 0x7B9,
        DS_EPC_EDCT_TIMER = 0x7BA,
        GERAN_GRR_PLMN_LIST_RAT_SEARCH_STARTED = 0x7BB,
        GERAN_GRR_PLMN_LIST_RAT_SEARCH_COMPLETED = 0x7BC,
        GERAN_GRR_PLMN_LIST_RAT_SEARCH_ABORTED = 0x7BD,
        GERAN_GRR_REDIR_STARTED = 0x7BE,
        GERAN_GRR_REDIR_COMPLETED = 0x7BF,
        GERAN_GRR_REDIR_ABORTED = 0x7C0,
        EVENT_1X_FSCH0_BURST_ASSIGN = 0x7C1,
        EVENT_1X_RSCH0_BURST_ASSIGN = 0x7C2,
        SENSOR_STATE = 0x7C3,
        SENSOR_TIMELINE = 0x7C4,
        GSM_TO_LTE_RESEL_STARTED = 0x7C5,
        GSM_TO_LTE_RESEL_ENDED = 0x7C6,
        GSM_TO_LTE_REDIR_STARTED = 0x7C7,
        GSM_TO_LTE_REDIR_ENDED = 0x7C8,
        SD_SS_TIMER_LOG = 0x7C9,
        LTE_RRC_STATE_CHANGE_TRIGGER = 0x7CA,
        LTE_RRC_RADIO_LINK_FAILURE_STAT = 0x7CB,
        TDSCDMA_MAC_UL_AMR_RATE = 0x7CC,
        TDSCDMA_MAC_HS_T1_EXPIRY = 0x7CD,
        TDSCDMA_RLC_MAX_RESET = 0x7CE,
        TDSCDMA_RLC_RESETS = 0x7CF,
        TDSCDMA_RLC_OPEN_CLOSE = 0x7D0,
        TDSCDMA_RLC_MRW = 0x7D1,
        TDSCDMA_RLC_CONFIG = 0x7D2,
        TDSCDMA_RLC_TIMER_DISCARD_EXPIRY = 0x7D3,
        TDSCDMA_RRC_INTER_RAT_HANDOVER_START = 0x7D4,
        TDSCDMA_RRC_INTER_RAT_HANDOVER_END = 0x7D5,
        TDSCDMA_RRC_TDSCDMA_TO_GSM_RESELECTION_START = 0x7D6,
        TDSCDMA_RRC_TDSCDMA_TO_GSM_RESELECTION_END = 0x7D7,
        TDSCDMA_RRC_CELL_SELECTED = 0x7D8,
        TDSCDMA_RRC_PAGE_RECEIVED = 0x7D9,
        TDSCDMA_RRC_RL_FAILURE = 0x7DA,
        TDSCDMA_RRC_STATE = 0x7DB,
        TDSCDMA_RRC_OUT_OF_SERVICE = 0x7DC,
        TDSCDMA_RRC_RB0_SETUP_FAILURE = 0x7DD,
        TDSCDMA_RRC_PHYCHAN_EST_FAILURE = 0x7DE,
        TDSCDMA_RRC_GSM_TO_TDSCDMA_HANDOVER_START = 0x7DF,
        TDSCDMA_RRC_MODE = 0x7E0,
        TDSCDMA_RRC_PHYCHAN_CFG_CHANGED = 0x7E1,
        TDSCDMA_RRC_CONN_REL_CAUSE = 0x7E2,
        TDSCDMA_RRC_CONN_REQ_CAUSE = 0x7E3,
        TDSCDMA_RRC_TIMER_EXPIRED = 0x7E4,
        TDSCDMA_RRC_UOOS_TIMER_USED = 0x7E5,
        TDSCDMA_RRC_UOOS_TIMER_START = 0x7E6,
        TDSCDMA_RRC_UOOS_TIMER_STOP = 0x7E7,
        TDSCDMA_RRC_CSP_SCAN_START = 0x7E8,
        TDSCDMA_RRC_CELL_SELECTION_FAIL = 0x7E9,
        TDSCDMA_RRC_BPLMN_START = 0x7EA,
        TDSCDMA_RRC_BPLMN_END = 0x7EB,
        TDSCDMA_RRC_BPLMN_SCAN_START = 0x7EC,
        TDSCDMA_RRC_BPLMN_SCAN_END = 0x7ED,
        TDSCDMA_RRC_EOOS_SKIP_FULL_SCAN_TIMER_START = 0x7EE,
        TDSCDMA_RRC_EOOS_SKIP_FULL_SCAN_TIMER_STOP = 0x7EF,
        TDSCDMA_RRC_EOOS_SKIP_FULL_SCAN_TIMER_EXPIRED = 0x7F0,
        TDSCDMA_RRC_MESSAGE_SENT = 0x7F1,
        TDSCDMA_RRC_MESSAGE_RECEIVED = 0x7F2,
        LTE_ML1_UL_SPS_REPORT = 0x7F8,
        LTE_ML1_DL_SPS_REPORT = 0x7F9,
        TDSCDMA_RRC_CSP_STATE = 0x7FA,
        TDSCDMA_RRC_HSDPA_START = 0x7FB,
        TDSCDMA_RRC_HSDPA_STOP = 0x7FC,
        TDSCDMA_RRC_HSUPA_START = 0x7FD,
        TDSCDMA_RRC_HSUPA_STOP = 0x7FE,
        TDSCDMA_RRC_SIB_RCVD = 0x7FF,
        RSVD_START = 0x0800,
        RSVD_END = 0x083F,
        TDSCDMA_RRC_LLC_SUBSTATE = 0x840,
        TDSCDMA_RRC_MCM_SUBSTATE = 0x841,
        TDSCDMA_RRC_CCM_SUBSTATE = 0x842,
        TDSCDMA_RRC_CU_SUBSTATE = 0x843,
        TDSCDMA_RRC_NV_RRC_VERSION = 0x844,
        TDSCDMA_RRC_LLC_TOC_USAGE = 0x845,
        TDSCDMA_RRC_LLC_OC_STATUS = 0x846,
        TDSCDMA_RRC_OOS_TRIGGERED = 0x847,
        WCDMA_RRC_RELEASE_CAUSE = 0x848,
        WCDMA_RRC_REJECT_CAUSE = 0x849,
        DS_MO_SMS_STATUS = 0x84A,
        DS_MO_SMS_RETRY_ATTEMPT = 0x84B,
        DS_MT_SMS_NOTIFY = 0x84C,
        DS_WMS_SEARCH_REQUEST = 0x84D,
        DS_SMS_COMMAND_PROCESSED = 0x84E,
        DS_SMS_MT_NOTIFY = 0x84F,
        DS_SMS_CBS_MSG_RECEIVED = 0x850,
        DS_SMS_ETWS_PRIM_RECEIVED = 0x851,
        TDSCDMA_RRC_ACQUISITION_COMPLETE = 0x852,
        TDSCDMA_L1_STATE = 0x853,
        TDSCDMA_NEW_SERVING_CELL = 0x854,
        TDSCDMA_L1_SUSPEND = 0x855,
        TDSCDMA_L1_RESUME = 0x856,
        TDSCDMA_L1_STOPPED = 0x857,
        TDSCDMA_L1_ACQ_SUBSTATE = 0x858,
        TDSCDMA_PHYCHAN_CFG_CHANGED = 0x859,
        TDSCDMA_RACH_STATUS = 0x85A,
        TDSCDMA_MEASUREMENT_EVENT = 0x85B,
        GNSS_FAST_TCAL_END = 0x85C,
        IMS_CODEC_INITIALIZATION = 0x85D,
        IMS_CODEC_RATE_CHANGE_EVENT = 0x85E,
        T_HDR_CSNA_DUP_3GEVENT_1X_SRV_MSG = 0x85F,
        T_HDR_IDLE_CONNECT_REASON = 0x860,
        T_HDR_IDLE_CONNECTION_DENIED_REASON = 0x861,
        T_HDR_IDLE_CONNECTION_SETUP_FAIL_REASON = 0x862,
        T_HDR_OVHD_PRE_REG_IS_ALLOWED = 0x863,
        T_HDR_SAP_TUNNEL_IS_ENABLED = 0x864,
        T_HDR_SAP_CONNECTION_IS_OPEN = 0x865,
        T_HDR_ALMP_LTE_RESELECT = 0x866,
        T_HDR_OVHD_ORNL_IS_UPDATED = 0x867,
        T_HDR_LTE_RESEL_STATUS = 0x868,
        LTE_TO_EVENT_1X_TT = 0x869,
        LTE_TO_EVENT_1X_HO = 0x86A,
        LTE_TO_EVENT_1X_DL_GCSNA_MSG = 0x86B,
        LTE_TO_EVENT_1X_UL_GCSNA_MSG = 0x86C,
        LTE_RRC_UL_MSG_MEAS_REPORT = 0x86D,
        IMS_QIPCALL_SIP_SESSION_EVENT = 0x86E,
        SIP_REG_START_EVENT = 0x86F,
        SIP_REG_REQ_SENT_EVENT = 0x870,
        SIP_REG_RESP_RCVD_EVENT = 0x871,
        SIP_REG_END_EVENT = 0x872,
        SIP_REG_DREG_START_EVENT = 0x873,
        SIP_REG_DREG_END_EVENT = 0x874,
        WCDMA_FACH_DRX_ACTION = 0x875,
        RRC_COMPLETE_SIB_RECEIVED = 0x876,
        EVENT_1X_TO_LTE_RESEL_DONE = 0x877,
        SSR_SUBSYS_PWR_DOWN = 0x878,
        SSR_SUBSYS_PWR_UP = 0x879,
        DS_DSD_PREFERRED_RADIO = 0x87A,
        DS_DSD_TIMER_STARTED = 0x87B,
        DS_DSD_TIMER_STOPPED = 0x87C,
        DS_DSD_TIMER_EXPIRED = 0x87D,
        DS_DSD_RADIO_THROTTLE = 0x87E,
        DS_DSD_RADIO_UNTHROTTLE = 0x87F,
        TDSCDMA_TO_TDSCDMA_RESELECTION_START = 0x880,
        TDSCDMA_TO_TDSCDMA_RESELECTION_END = 0x881,
        GSM_CS_CALL_ESTABLISHMENT_FAILURE = 0x882,
        GSM_CS_CALL_DROPPED = 0x883,
        GSM_LOST_SERVICE = 0x884,
        GSM_IN_SERVICE = 0x885,
        GSM_PLMN_LIST_GSM_SUB_SEARCH_ENDED = 0x886,
        SD_WRLF_2MIN_TIMER_EXPIRY = 0x887,
        CM_RLF_RECOVERY_START = 0x888,
        CM_RLF_RECOVERY_END = 0x889,
        T_HDR_CONN_ATTEMPT_ENDED = 0x88A,
        T_HDR_CONN_TERMINATED = 0x88B,
        MM_TIMER_EXPIRY = 0x88C,
        GNSS_RESET_LOCATION_SERVICE_RECEIVED = 0x88D,
        GNSS_RESET_LOCATION_SERVICE_DONE = 0x88E,
        TDSCDMA_HANDOVER_START = 0x88F,
        TDSCDMA_HANDOVER_END = 0x890,
        TDSCDMA_TS0_JDS_UPDATE = 0x891,
        TDSCDMA_NONTS0_JDS_UPDATE = 0x892,
        TDSCDMA_UE_PAGED = 0x893,
        TDSCDMA_DRX_REACQ = 0x894,
        TDSCDMA_DL_SYNC_STATUS = 0x895,
        TDSCDMA_HSDPA_STATUS = 0x896,
        TDSCDMA_HSUPA_STATUS = 0x897,
        GHDI_MVS_STATE = 0x898,
        LTE_RRC_CELL_RESEL_STARTED = 0x899,
        WCDMA_CM_STATE_CHANGE = 0x89A,
        TDSCDMA_TO_LTE_RESELECTION_START = 0x89B,
        TDSCDMA_TO_LTE_RESELECTION_END = 0x89C,
        TDSCDMA_TO_LTE_REDIRECTION_START = 0x89D,
        TDSCDMA_TO_LTE_REDIRECTION_END = 0x89E,
        TDSCDMA_DED_PRIORITIES_VALIDITY_TIMER_START = 0x89F,
        TDSCDMA_DED_PRIORITIES_VALIDITY_TIMER_EXPIRED = 0x8A0,
        LTE_RRC_IRAT_CCO_FROM_EUTRAN_START = 0x8A1,
        LTE_RRC_IRAT_CCO_FROM_EUTRAN_END = 0x8A2,
        HOCM_TRANSMITTED = 0x8A3,
        RESERVED_000 = 0x8A4,
        RESERVED_001 = 0x8A5,
        RESERVED_002 = 0x8A6,
        RESERVED_003 = 0x8A7,
        RESERVED_004 = 0x8A8,
        RESERVED_005 = 0x8A9,
        RESERVED_006 = 0x8AA,
        RESERVED_007 = 0x8AB,
        RESERVED_008 = 0x8AC,
        RESERVED_009 = 0x8AD,
        DS_DSD_ATTACH_PDN_CHANGE = 0x8AE,
        TDSCDMA_INTER_RAT_PFR_START = 0x8AF,
        TDSCDMA_INTER_RAT_PFR_END = 0x8B0,
        TDSCDMA_RRC_INTER_RAT_CCO_START = 0x8B1,
        WCDMA_RRC_CSFB_SIB_CONTAINER = 0x8B2,
        LTE_RRC_EMBMS_OOS_WARN_IND = 0x8B3,
        LTE_RRC_EMBMS_ACT_TMGI_LIST_IND = 0x8B4,
        LTE_RRC_EMBMS_AVAIL_TMGI_LIST_IND = 0x8B5,
        LTE_RRC_MCCH_CHANGE_NOTIFICATION = 0x8B6,
        RPM_MCC_MNC_VALUE = 0x8B7,
        RPM_ENABLED = 0x8B8,
        CPDP_COUNTERS_UPDATE = 0x8B9,
        RPM_START_LR3_TIMER = 0x8BA,
        RPM_LR3_TIMER_EXPIRED = 0x8BB,
        RPM_BACKOFF_TIMER_VAL = 0x8BC,
        RPM_READ_ALL_PARAM = 0x8BD,
        RPM_BACKOFF_TIMER_EXP = 0x8BE,
        LTE_SCELL_CONFIGURATION = 0x8BF,
        LTE_SCELL_ACTIVATION_COMMAND = 0x8C0,
        LTE_SCELL_DEACTIVATION_TIMER_EXPIRY = 0x8C1,
        SCELL_STATE_CHANGE = 0x8C2,
        GNSS_SPECTRUM_ANALYZER_STATUS = 0x8C3,
        GSM_TO_TDSCDMA_RESEL_START = 0x8C4,
        GSM_TO_TDSCDMA_RESEL_END = 0x8C5,
        AUDIO_MWS_DIAG_SERVICE = 0x8C6,
        WCDMA_ASF_TIMER_EXPIRED = 0x8C7,
        ASF_SCAN_START = 0x8C8,
        ASF_SCAN_END = 0x8C9,
        TDSCDMA_RRC_INTER_RAT_CCO_END = 0x8CA,
        SECAPITEST_TESTCASE_START = 0x8CB,
        SECAPITEST_TESTCASE_END = 0x8CC,
        TDSCDMA_RXD_STATE = 0x8CD,
        WCDMA_RRC_ASF_TIMER_STATUS = 0x8CE,
        WCDMA_RRC_CSG_DETECTED = 0x8CF,
        CM_SSAC_CALL = 0x8D0,
        CM_SSAC_TIME = 0x8D1,
        PAGE_MATCH = 0x8D2,
        CSFB_CALL_TYPE = 0x8D3,
        OEM_START_ID = 0x8D4,

        /*Reserved for OEM . Range: 2260 - 2459 */
        OEM_END_ID = 0x99B,
        WCDMA_ASF_MEAS_REQ_RCVD = 0x99C,
        SECAPITEST_TESTCASE_SUCCESS = 0x99D,
        SECAPITEST_TESTCASE_FAILURE = 0x99E,
        HDR_MSG_RX_PAGE = 0x99F,
        TDSCDMA_RRC_HANDOVER_START = 0x9A0,
        TDSCDMA_RRC_HANDOVER_END = 0x9A1,
        CODEC_INIT = 0x9A2,
        CODEC_RATE_CHANGE = 0x9A3,
        GPSXTRA_T_POSITION_INJECTION = 0x9A4,
        TDSCDMA_RRC_X_TO_TDSCDMA_HANDOVER_START = 0x9A5,
        WCDMA_ENH_L1_STATE = 0x9A6,
        CM_CALL_ORIG_2 = 0x9A7,
        CM_CALL_CONNECT_2 = 0x9A8,
        CM_CALL_END_2 = 0x9A9,
        TDSCDMA_RRC_X_TO_TDSCDMA_HANDOVER_END = 0x9AA,
        EVENT_1X_TO_LTE_RESEL_START = 0x9AB,
        DS_DORMANCY_STATUS_UM_QUEUE_STATS = 0x9AC,
        DS_DORMANCY_STATUS_RM_QUEUE_STATS = 0x9AD,
        DS_CALL_STATUS = 0x9AE,
        LTE_RRC_IRAT_HO_FROM_EUTRAN_END = 0x9AF,
        LTE_RRC_IRAT_HO_TO_EUTRAN_START = 0x9B0,
        LTE_RRC_UL_MSG_MEAS_REPORT_MEASOBJ_MODE = 0x9B1,
        TDSCDMA_RRC_ACQUISITION_START = 0x9B2,
        LTE_SCELL_STATE_CHANGE_ENHANCED = 0x9B3,
        SD_ACTION_HYBR2 = 0x9B4,
        UMTS_NAS_CB_CTCH_START = 0x9B5,
        UMTS_NAS_CB_BMC_MSG_DECODE_FAIL = 0x9B6,
        WCDMA_RLC_UL_CONFIG = 0x9B7,
        NAS_CB_CTCH_STOP = 0x9B8,
        GPS_PD_COMM_NW_CONNECTING = 0x9B9,
        GPS_PD_COMM_NW_CONNECTED = 0x9BA,
        GPS_PD_COMM_SERVER_CONNECTING = 0x9BB,
        GPS_PD_COMM_SERVER_CONNECTED = 0x9BC,
        BROADCAST_CYCLE_DISABLED = 0x9BD,
        BROADCAST_CYCLE_ENABLED = 0x9BE,
        WCDMA_ASDIV_TYPE1_SWITCH_RSCP_BASED = 0x9BF,
        WCDMA_ASDIV_TYPE1_SWITCH_TXAGC_BASED = 0x9C0,
        WCDMA_ASDIV_TYPE1_SWITCHBACK_MTPL_BASED = 0x9C1,
        WCDMA_ASDIV_TYPE1_SWITCHBACK_TXAGC_BASED = 0x9C2,
        WCDMA_ASDIV_TYPE2_SWITCH_RSCP_BASED = 0x9C3,
        WCDMA_ASDIV_TYPE2_SWITCH_MTPL_BASED = 0x9C4,
        WCDMA_ASDIV_TYPE2_SWITCH_RSCP_LOOPBACK_BASED = 0x9C5,
        WCDMA_ASDIV_TYPE2_SWITCHBACK_DEGRADATION_BASED = 0x9C6,
        WCDMA_ASDIV_PROBE_BOTH_ANTENNAS = 0x9C7,
        TDSCDMA_RRC_HSUPA_SUPPORT_STATUS = 0x9C8,
        WCDMA_HS_RACH_OP = 0x9C9,
        WLAN_FW_SLM_CONS_BCN_MISS = 0x9CA,
        WLAN_FW_SLM_RSSI_MONITOR = 0x9CB,
        SD_HYBR2_BSR_START = 0x9CC,
        SD_HYBR2_BSR_END = 0x9CD,
        IWLAN_S2B_CALL_TRACER_LOGGING = 0x9CE,
        WCDMA_RRC_FAILURE = 0x9CF,
        WCDMA_CME_STATE = 0x9D0,
        WCDMA_RxD_STATE = 0x9D1,
        WCDMA_RACH_ABORT_CAUSE = 0x9D2,
        CM_PH_DYN_SWITCH = 0x9D3,
        TDSCDMA_RRC_DMCR_ENABLED = 0x9D4,
        ASDIV_TESTMODE1_SWITCH = 0x9D5,
        PM_UE_MODE = 0x9D6,
        TDSCDMA_SELF_HOSTING = 0x9D7,
        LTE_ML1_SEARCH_IDLE = 0x9D8,
        GSTK_BIP_STATUS = 0x9D9,
        TDSCDMA_RRC_DSDS_TA_BLOCK = 0x9DA,
        PS_SYSTEM_STATUS = 0x9DB,
        QMI_SYSTEM_STATUS = 0x9DC,
        PS_SYSTEM_STATUS_EX = 0x9DD,
        QMI_SYSTEM_STATUS_EX = 0x9DE,
        ASDIV_IDLE_SWITCH_FACH_INIT = 0x9DF,
        ASDIV_IDLE_SWITCHBACK_FACH_INIT = 0x9E0,
        ASDIV_IDLE_SWITCH_OOS_TIMER = 0x9E1,
        ASDIV_IDLE_SWITCHBACK_OOS_TIMER = 0x9E2,
        ASDIV_IDLE_SWITCH_RACH_NACK = 0x9E3,
        ASDIV_IDLE_SWITCHBACK_RACH_NACK = 0x9E4,
        ASDIV_ACQ_SWITCH = 0x9E5,
        ASDIV_ACQ_SWITCHBACK = 0x9E6,
        LTE_RRC_PAGING_UE_ID = 0x9E7,
        LTE_ML1_ASDIV = 0x9E8,
        LTE_RRC_CGI_START_INDI = 0x9E9,
        DS_UM_QUEUE_STATS_EX = 0x9EA,
        HSPA = 0x9EB,
        TDSCDMA_TO_GSM_REDIRECTION_START = 0x9EC,
        TDSCDMA_TO_GSM_REDIRECTION_END = 0x9ED,
        LTE_RRC_EMBMS_AVAIL_SAI_LIST_IND = 0x9EE,
        LTE_RRC_EMBMS_INTEREST_IND = 0x9EF,
        LTE_RRC_EMBMS_SIGNAL_STRENGTH_REPORTING = 0x9F0,
        GSM_VS_INTERFACE_TYPE_1 = 0x9F1,
        GSM_VS_INTERFACE_TYPE_2 = 0x9F2,
        GSM_VS_INTERFACE_GHDI_CONTROL = 0x9F3,
        WCDMA_EUL_REL7_FEAT_OP = 0x9F4,
        WCDMA_RRC_CU_STATUS = 0x9F5,
        WCDMA_HS_SCCH_ORDER_VER2 = 0x9F6,
        AUDIO_PATH_DELAY_CHANGE = 0x9F7,
        LTE_RRC_CAMPED_CELL_STATUS = 0x9F8,
        DATAMODEM_IPA_DROP_PKT_DL = 0x9F9,
        DATAMODEM_IPA_DROP_PKT_UL = 0x9FA,
        NAS_LAU = 0x9FB,
        NAS_ATTACH = 0x9FC,
        NAS_RAU = 0x9FD,
        NAS_MO_DETACH = 0x9FE,
        NAS_MT_DETACH = 0x9FF,
        NAS_TAU = 0xA00,
        GSM_CELL_SELECTED = 0xA01,
        GSM_DS_CELL_SELECTED = 0xA02,
        WLAN_QCA_BMISS = 0xA03,
        WLAN_QCA_RSSI_MONITOR = 0xA04,
        DS_EPC_PDN_EX = 0xA05,
        DS_EPC_SRAT_CLEANUP_TIMER_EX = 0xA06,
        DS_DSD_PREFERRED_RADIO_INFO = 0xA07,
        LTE_RRC_NEW_CELL_IND_EXT_EARFCN = 0xA08,
        LTE_RRC_CELL_RESEL_FAILURE_EXT_EARFCN = 0xA09,
        LTE_RRC_HO_FAILURE_EXT_EARFCN = 0xA0A,
        LTE_RRC_SIB_READ_FAILURE_EXT_EARFCN = 0xA0B,
        LTE_RRC_CELL_RESEL_STARTED_EXT_EARFCN = 0xA0C,
        LTE_RRC_MCCH_CHANGE_NOTIFICATION_EXT_EARFCN = 0xA0D,
        LTE_RRC_CELL_BLACKLIST_IND_EXT_EARFCN = 0xA0E,
        WCDMA_RRC_INTER_FREQ_HHO_STATUS = 0xA0F,
        DS_DSD_TIMER = 0xA10,
        TDSCDMA_TO_TDSCDMA_REDIRECTION_START = 0xA11,
        TDSCDMA_TO_TDSCDMA_REDIRECTION_END = 0xA12,
        WLAN_QCA_HEARTBEAT_FAILURE = 0xA13,
        DS_3GPP_SVC_THROTTLE = 0xA14,
        DS_3GPP_PDN_THROTTLE = 0xA15,
        GSM_TO_TDSCDMA_REDIR_STARTED = 0xA16,
        GSM_TO_TDSCDMA_REDIR_ENDED = 0xA17,
        DS_GSM_PAGE_MISSED = 0xA18,
        GSM_TO_WCDMA_REDIR_STARTED = 0xA19,
        GSM_TO_WCDMA_REDIR_ENDED = 0xA1A,
        DS_RADIO_STACK_STATE = 0xA1B,
        DS_CALL_CONTROL_STATE = 0xA1C,
        DS_BEARER_CONTROL_STATE = 0xA1D,
        LTE_SCELL_STATE_CHANGE_ENHANCED2 = 0xA1E,
        LTE_SCELL_PCELL_TIME_DRIFT = 0xA1F,
        LTE_SCELL_WB_NB_TIME_DRIFT = 0xA20,
        TDSCDMA_RRC_SIB_RCVD_V2 = 0xA21,
        LTE_ML1_EPHR_REPORT = 0xA22,
        LTE_TO_LTE_REDIRECTION = 0xA23,
        TDSCDMA_DA_BACKOFF_TIMER_START = 0xA24,
        TDSCDMA_DA_BACKOFF_TIMER_STOP = 0xA25,
        TDSCDMA_DA_BACKOFF_TIMER_EXPIRED = 0xA26,
        WCDMA_TO_GSM_REDIRECTION_START = 0xA27,
        WCDMA_TO_GSM_REDIRECTION_END = 0xA28,
        WCDMA_TO_WCDMA_REDIRECTION_START = 0xA29,
        WCDMA_TO_WCDMA_REDIRECTION_END = 0xA2A,
        GNSS_RCVR_STATE = 0xA2B,
        GSM_SI_CACHE_UPDATE_ENTRY = 0xA2C,
        GSM_SI_CACHE_RETRIEVE = 0xA2D,
        GSM_SI_CACHE_FLUSH = 0xA2E,
        NAS_PLMN_FOUND = 0xA2F,
        LTE_SUB_FRAME_NUMBER = 0xA30,
        GNSS_POSITION_INCONSISTENCY = 0xA31,
        IPV6_EXT_ADDRESS = 0xA32,
        DS3G_COEX_FLOW_CONTROL = 0xA33,
        NAS_LTE_IRAT_SHORT_TIMER_STARTED = 0xA34,
        NAS_LTE_IRAT_LONG_TIMER_STARTED = 0xA35,
        NAS_LTE_IRAT_SEARCH_STARTED = 0xA36,
        NAS_HPLMN_IRAT_SEARCH_STARTED = 0xA37,
        NAS_LTE_IRAT_NOTAVAIL_TO_AVAIL = 0xA38,
        NAS_LTE_IRAT_AVAIL_TO_NOTAVAIL = 0xA39,
        DIAG_DROP_DEBUG = 0xA3A,
        FULL_SRV_EMC_CALL = 0xA3B,
        LTE_EMM_TIMER_STOP = 0xA3C,
        LTE_ESM_TIMER_STOP = 0xA3D,

        DS_GSM_MESSAGE_SENT = 0xA3F,
        DS_GSM_COUNTER_EXPIRED = 0xA40,
        DS_GPRS_MAC_RESELECT_IND = 0xA41,
        DS_GPRS_CELL_UPDATE_START = 0xA42,
        DS_GPRS_CELL_UPDATE_END = 0xA43,
        DS_PACKET_RANDOM_ACCESS_REQ = 0xA44,
        DS_GSM_L1_SUBSTATE = 0xA45,
        DS_GSM_TO_WCDMA_HANDOVER_START = 0xA46,
        DS_GSM_L1_VOCODER_INITIALIZE = 0xA47,
        DS_GSM_L1_VOCODER_ENABLED = 0xA48,
        DS_GPRS_MAC_IDLE_IND = 0xA49,
        DS_GPRS_ACCESS_REJECT = 0xA4A,
        DS_GERAN_GRR_PLMN_LIST_RAT_SEARCH_STARTED = 0xA4B,
        DS_GERAN_GRR_PLMN_LIST_RAT_SEARCH_COMPLETED = 0xA4C,
        DS_GERAN_GRR_PLMN_LIST_RAT_SEARCH_ABORTED = 0xA4D,
        DS_GERAN_GRR_REDIR_STARTED = 0xA4E,
        DS_GERAN_GRR_REDIR_COMPLETED = 0xA4F,
        DS_GERAN_GRR_REDIR_ABORTED = 0xA50,
        DS_GSM_TO_LTE_RESEL_STARTED = 0xA51,
        DS_GSM_TO_LTE_RESEL_ENDED = 0xA52,
        DS_GSM_TO_LTE_REDIR_STARTED = 0xA53,
        DS_GSM_TO_LTE_REDIR_ENDED = 0xA54,
        DS_GSM_CS_CALL_ESTABLISHMENT_FAILURE = 0xA55,
        DS_GSM_CS_CALL_DROPPED = 0xA56,
        DS_GSM_LOST_SERVICE = 0xA57,
        DS_GSM_IN_SERVICE = 0xA58,
        DS_GSM_PLMN_LIST_GSM_SUB_SEARCH_ENDED = 0xA59,
        DS_GSM_TO_TDSCDMA_RESEL_START = 0xA5A,
        DS_GSM_TO_TDSCDMA_RESEL_END = 0xA5B,
        DS_GSM_VS_INTERFACE_TYPE_1 = 0xA5C,
        DS_GSM_VS_INTERFACE_TYPE_2 = 0xA5D,
        DS_GSM_VS_INTERFACE_GHDI_CONTROL = 0xA5E,
        DS_GSM_TO_TDSCDMA_REDIR_STARTED = 0xA5F,
        DS_GSM_TO_TDSCDMA_REDIR_ENDED = 0xA60,
        DS_GSM_TO_WCDMA_REDIR_STARTED = 0xA61,
        DS_GSM_TO_WCDMA_REDIR_ENDED = 0xA62,
        GNSS_GDT_SESS_START_REQ = 0xA63,
        GNSS_GDT_SESS_START_RESP = 0xA64,
        GNSS_GDT_SEND_REQ = 0xA65,
        GNSS_GDT_SEND_RESP = 0xA66,
        GNSS_GDT_SESS_END_REQ = 0xA67,
        GNSS_GDT_SESS_END_RESP = 0xA68,
        GNSS_GDT_SESS_OPEN_REQ = 0xA69,
        GNSS_GDT_SESS_CLOSE_REQ = 0xA6A,
        GNSS_GTP_TDP_MEASURMENT_ENABLE = 0xA6B,
        GNSS_GTP_TDP_MEASURMENT_DISABLE = 0xA6C,
        GNSS_GTP_TDP_MEASURMENT_REQUEST = 0xA6D,
        GNSS_GTP_TDP_MEASURMENT_RCVD = 0xA6E,
        GPS_GTP_TDP_SESS_START = 0xA6F,
        GPS_GTP_TDP_SESS_END = 0xA70,

        LAST_ID = 0xA70,
        NEXT_UNUSED_EVENT,

        MAX_ID = 0x0FFF
    }
}