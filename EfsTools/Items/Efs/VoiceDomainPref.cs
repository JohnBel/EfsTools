using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    public enum VoiceDomainType : byte
    {
        None = byte.MaxValue, /* FOR INTERNAL USE ONLY */
        CsVoiceOnly = 0,

        /**
         * < CS Voice only.
         */
        ImsPsVoiceOnly = 1,

        /**
         * < IMS PS Voice only.
         */
        CsVoicePreferred = 2,

        /**
         * < CS voice preferred, IMS PS Voice as secondary.
         */
        ImsPsVoicePreferred = 3 /**< IMS PS voice preferred, CS Voice as secondary. */
    }

    [Serializable]
    [Subscription]
    [EfsFile("/nv/item_files/modem/mmode/voice_domain_pref", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class VoiceDomainPref
    {
        [JsonIgnore]
        public byte Value { get; set; }

        public string StringValue
        {
            get => $"{(VoiceDomainType) Value}";
            set => Value = EnumUtils.ParseEnumByte(typeof(VoiceDomainType), value);
        }
    }
}