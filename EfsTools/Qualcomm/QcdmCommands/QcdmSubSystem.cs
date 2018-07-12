using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfsTools.Qualcomm.QcdmCommands
{
    internal enum QcdmSubSystem : byte
    {
        Oem = 0, /* Reserved for OEM use */
        Zrex = 1, /* ZREX */
        Sd = 2, /* System Determination */
        Bt = 3, /* Bluetooth */
        Wcdma = 4, /* WCDMA */
        Hdr = 5, /* 1xEvDO */
        Diablo = 6, /* DIABLO */
        Trex = 7, /* TREX - Off-target testing environments */
        Gsm = 8, /* GSM */
        Umts = 9, /* UMTS */
        Hwtc = 10, /* HWTC */
        FactoryTestMode = 11, /* Factory Test Mode */
        Rex = 12, /* Rex */
        Gps = 13, /* Global Positioning System */
        Wms = 14, /* Wireless Messaging Service (WMS, SMS) */
        CallManager = 15, /* Call Manager */
        Hs = 16, /* Handset */
        AudioSettings = 17, /* Audio Settings */
        DiagServ = 18, /* DIAG Services */
        Efs = 19, /* File System - EFS2 */
        PortMapSettings = 20, /* Port Map Settings */
        Mediaplayer = 21, /* QCT Mediaplayer */
        Qcamera = 22, /* QCT QCamera */
        Mobimon = 23, /* QCT MobiMon */
        Gunimon = 24, /* QCT GuniMon */
        Lsm = 25, /* Location Services Manager */
        Qcamcorder = 26, /* QCT QCamcorder */
        Mux1x = 27, /* Multiplexer */
        Data1x = 28, /* Data */
        Srch1x = 29, /* Searcher */
        Callp1x = 30, /* Call Processor */
        Apps = 31, /* Applications */
        Settings = 32, /* Settings */
        Gsdi = 33, /* Generic SIM Driver Interface */
        Tmc = 34, /* Task Main Controller */
        Usb = 35, /* Universal Serial Bus */
        Pm = 36, /* Power Management */
        Debug = 37,
        Qtv = 38,
        Clkrgm = 39, /* Clock Regime */
        Devices = 40,
        Wlan = 41, /* 802.11 Technology */
        PsDataLogging = 42, /* Data Path Logging */
        Mflo = 43, /* MediaFLO */
        Dtv = 44, /* Digital TV */
        Rrc = 45, /* WCDMA Radio Resource Control state */
        Prof = 46, /* Miscellaneous Profiling Related */
        Tcxomgr = 47,
        Nv = 48, /* Non Volatile Memory */
        Autoconfig = 49,
        Params = 50, /* Parameters required for debugging subsystems */
        Mddi = 51, /* Mobile Display Digital Interface */
        DsAtcop = 52,
        L4linux = 53, /* L4/Linux */
        Mvs = 54, /* Multimode Voice Services */
        Cnv = 55, /* Compact NV */
        ApioneProgram = 56, /* apiOne */
        Hit = 57, /* Hardware Integration Test */
        Drm = 58, /* Digital Rights Management */
        Dm = 59, /* Device Management */
        Fc = 60, /* Flow Controller */
        Memory = 61, /* Malloc Manager */
        EfsAlternate = 62, /* Alternate File System */
        Regression = 63, /* Regression Test Commands */
        Sensors = 64, /* The sensors subsystem */
        Flute = 65, /* FLUTE */
        Analog = 66, /* Analog die subsystem */
        ApioneProgramModem = 67, /* apiOne Program On Modem Processor */
        Lte = 68, /* LTE */
        Brew = 69, /* BREW */
        Pwrdb = 70, /* Power Debug Tool */
        Chord = 71, /* Chaos Coordinator */
        Sec = 72, /* Security */
        Time = 73, /* Time Services */
        Q6Core = 74, /* Q6 core services */
        Corebsp = 75, /* CoreBSP */
        /* Command code allocation:
        [0 - 2047]  - HWENGINES
        [2048 - 2147]   - MPROC
        [2148 - 2247]   - BUSES
        [2248 - 2347]   - USB
        [2348 - 2447]   - FLASH
        [2448 - 3447]   - UART
        [3448 - 3547]   - PRODUCTS
        [3547 - 65535]  - Reserved
        */

        Mflo2 = 76, /* Media Flow */

        /* Command code allocation:
        [0 - 1023]       - APPs
        [1024 - 65535]   - Reserved
        */
        Ulog = 77, /* ULog Services */
        Apr = 78, /* Asynchronous Packet Router (Yu, Andy)*/
        Qnp = 79, /*QNP (Ravinder Are , Arun Harnoor)*/
        Stride = 80, /* Ivailo Petrov */
        OemDPP = 81, /* to read/write calibration to DPP partition */
        Q5Core = 82, /* Requested by ADSP team */
        Uscript = 83, /* core/power team USCRIPT tool */
        Nas = 84, /* Requested by 3GPP NAS team */
        CmAPI = 85, /* Requested by CMAPI */
        Ssm = 86,
        Tdscdma = 87, /* Requested by TDSCDMA team */
        SsmTest = 88,
        Mpower = 89, /* Requested by MPOWER team */
        Qdss = 90, /* For QDSS STM commands */
        Cxm = 91,
        GnssSoc = 92, /* Secondary GNSS system */
        Ttlite = 93,
        TmAnt = 94,
        Mlog = 95,
        Limitsmgr = 96,
        Efsmonitor = 97,
        DisplayCalibration = 98,
        VersionReport = 99,
        DsIpa = 100,
        SystemOperations = 101,
        CnssPower = 102,
        Last,

        /* Subsystem IDs reserved for OEM use */
        Oem0 = 250,
        Oem1 = 251,
        Oem2 = 252,
        Oem3 = 253,
        Oem4 = 254,
        Legacy = 255
    };
}