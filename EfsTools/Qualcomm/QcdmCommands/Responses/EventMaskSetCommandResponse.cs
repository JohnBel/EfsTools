using System;
using System.Collections.Generic;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Qualcomm.QcdmCommands.Base;
using EfsTools.Resourses;
using EfsTools.Utils;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    //typedef struct {
    //    diagpkt_header_type header;
    //    uint8 error_code;
    //    uint16 reserved;
    //    uint16 numbits;         /* number of bits in the mask           */
    //    unsigned char mask[1];  /* size of this field = (numbits + 7)/8 */
    //    } event_mask_set_rsp_type;
    
    [QcdmCommand(QcdmCommand.EventMaskSet)]
    [QcdmMinResponseLength(10)]
    internal class EventMaskSetCommandResponse : BaseCommandResponse
    {
        private EventMaskSetCommandResponse()
        {
        }

        public bool IsError { get; private set; }

        public EventId[] EnabledEvents { get; private set; }

        public static EventMaskSetCommandResponse Parse(byte[] data)
        {
            var result = new EventMaskSetCommandResponse();
            result.CheckResponse(data);
            var status = data[1];
            result.IsError = status != 0;
            if (!result.IsError)
            {
                var numBits = data[4] + (data[5] << 8);
                var maskLength = (numBits + 7) / 8;
                if (data.Length < (maskLength + 6))
                {
                    throw new QcdmManagerException(Strings.QcdmInvalidResponseCommand);
                }

                var enabledEvents = new List<EventId>();
                for (var i = 0; i < numBits; ++i)
                {
                    if (BitsUtils.GetBitAsBool(data, 6, i))
                    {
                        enabledEvents.Add((EventId) i);
                    }
                }

                result.EnabledEvents = enabledEvents.ToArray();
            }
            return result;
        }
    }
}