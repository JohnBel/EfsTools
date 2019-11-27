using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    public enum SupplementServiceDomainPrefValue : byte
    {
        None   = Byte.MaxValue,  /* FOR INTERNAL USE ONLY */
        Auto = 0,  /* use voice domain pref result */
        CsOnly = 1, /* use CS domain for supplement service otherwise reject*/
        PsOnly = 2, /* use PS domain for supplement service otherwise reject */
        PsPref = 3     /* The Supplementary service is expected  to be  routed to  PS
                                      domain if ICS interface is supported (or UT/SIP interface is available).
                                       Otherwise, send it to CS. */
    }
    
    [Serializable]
    [Subscription]
    [EfsFile("/nv/item_files/modem/mmode/supplement_service_domain_pref", true, 0xE1FF)]
    [Attributes(9)]
    public class SupplementServiceDomainPref
    {
        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }

        public string StringValue
        {
            get => $"{(SupplementServiceDomainPrefValue) Value}";
            set => Value = EnumUtils.ParseEnumByte(typeof(SupplementServiceDomainPrefValue), value);
        }
    }
}