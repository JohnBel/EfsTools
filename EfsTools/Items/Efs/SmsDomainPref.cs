using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
//    SYS_SMS_DOMAIN_PREF_NONE   = -1,  /* FOR INTERNAL USE ONLY */
//    /** @endcond */


//    SYS_SMS_DOMAIN_PREF_PS_SMS_NOT_ALLOWED   = 0,
//    /**< SMS service is not to be invoked over IP network */    


//    SYS_SMS_DOMAIN_PREF_PS_SMS_PREF   = 1,
//    /**< SMS service is preferred to be invoked over IP network*/    

//    /**@cond
//    */
//    SYS_SMS_DOMAIN_PREF_MAX   /* FOR INTERNAL USE ONLY */
    ///**@endcond */
    ///
    public enum SmsDomainPrefValue : byte
    {
        None = byte.MaxValue,
        PsSmsNotAllowed = 0, /**< SMS service is not to be invoked over IP network */
        PsSmsPref = 1 /**< SMS service is preferred to be invoked over IP network*/    
    }
    
    [Serializable]
    [Subscription]
    [EfsFile("/nv/item_files/modem/mmode/sms_domain_pref", true, 0xE1FF)]
    [Attributes(9)]
    public class SmsDomainPref
    {
        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }

        public string StringValue
        {
            get => $"{(SmsDomainPrefValue) Value}";
            set => Value = EnumUtils.ParseEnumByte(typeof(SmsDomainPrefValue), value);
        }
    }
}