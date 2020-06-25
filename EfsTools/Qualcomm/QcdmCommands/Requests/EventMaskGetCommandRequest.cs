using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests
{
    [QcdmCommand(QcdmCommand.EventMaskGet)]

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
    internal class EventMaskGetCommandRequest : BaseCommandRequest
    {
        public override byte[] GetData()
        {
            var data = new byte[4];
            data[0] = (byte) Command;
            data[1] = 0;
            data[2] = 0;
            data[3] = 0;
            return data;
        }
    }
}