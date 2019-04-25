using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Qualcomm.QcdmCommands.Base;
using EfsTools.Utils;

namespace EfsTools.Qualcomm.QcdmCommands.Requests
{
    [QcdmCommand(QcdmCommand.EventMaskSet)]

    // C:\Projects\Tmp\QualcommModem\msm8626\adsp_proc\core\services\diag\LSM\common\src\diagdiag_v.h
    //typedef PACK(struct)
    //{
    //byte opaque_header;  /*!< -- Header for the diagnostic packet */
    //}
    //diagpkt_header_type;

    //typedef struct {
    //diagpkt_header_type header;
    //uint8 pad;
    //uint16 reserved;
    //uint16 numbits;         /* number of bits in the mask           */
    //unsigned char mask[1];  /* size of this field = (numbits + 7)/8 */
    //} event_mask_set_req_type;

    internal class EventMaskSetCommandRequest : BaseCommandRequest
    {
        private readonly EventId[] _enableEvents;

        public EventMaskSetCommandRequest(EventId[] enableEvents)
        {
            _enableEvents = enableEvents;
        }

        public override byte[] GetData()
        {
            var maskLength = (MaxMaskBitsCount + 7) / 8;
            var data = new byte[6 + maskLength];
            data[0] = (byte) Command;
            data[1] = 0;
            data[2] = 0;
            data[3] = 0;
            data[4] = (byte)(MaxMaskBitsCount & 0xFF);
            data[5] = (byte)((MaxMaskBitsCount >> 8) & 0xFF);
            foreach (var enableEvent in _enableEvents)
            {
                BitsUtils.SetBitAsBool(data, 6, (int) enableEvent, true);
            }
            return data;
        }

        public int MaxMaskBitsCount => 0x0C86;
    }
}