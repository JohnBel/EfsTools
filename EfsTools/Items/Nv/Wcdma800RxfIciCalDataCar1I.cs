using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7159)]
    [Attributes(9)]
    public class Wcdma800RxfIciCalDataCar1I
    {
        [ElementsCount(17)]
        [ElementType("uint32")]
        [Description("")]
        public uint[] Value { get; set; }
        
    }
}
