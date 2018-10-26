using System;
using System.ComponentModel;
using System.Text;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/qp_ims_param_config", true, 0xE1FF)]
	[Attributes(9)]
	public class QpImsParamConfig
	{
		public QpImsParamConfig()
		{
		}

	    [JsonIgnore]
        [ElementsCount(128)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] Field1 { get; set; }

	    public string Field1String
	    {
	        get { return StringUtils.GetString(Field1); }
	        set { Field1 = StringUtils.GetBytes(value, 128); }
        }

	    [JsonIgnore]
        [ElementsCount(128)]
		[ElementType("uint8")]
		[Description("")]
        public byte[] Field2 { get; set; }

	    public string Field2String
	    {
	        get { return StringUtils.GetString(Field2); }
	        set { Field2 = StringUtils.GetBytes(value, 128); }
        }


	    [JsonIgnore]
        [ElementsCount(128)]
		[ElementType("uint8")]
		[Description("")]
        public byte[] Field3 { get; set; }

	    public string Field3String
	    {
	        get { return StringUtils.GetString(Field3); }
	        set { Field3 = StringUtils.GetBytes(value, 128); }
        }

	    [JsonIgnore]
        [ElementsCount(128)]
		[ElementType("uint8")]
		[Description("")]
        public byte[] Field4 { get; set; }

	    public string Field4String
	    {
	        get { return StringUtils.GetString(Field4); }
	        set { Field4 = StringUtils.GetBytes(value, 128); }
        }

	    [JsonIgnore]
        [ElementsCount(256)]
		[ElementType("uint8")]
		[Description("")]
        public byte[] Field5 { get; set; }

	    public string Field5String
	    {
	        get { return StringUtils.GetString(Field5); }
	        set { Field5 = StringUtils.GetBytes(value, 256); }
        }

	    [JsonIgnore]
        [ElementsCount(32)]
		[ElementType("uint8")]
		[Description("")]
        public byte[] Field6 { get; set; }

	    public string Field6String
	    {
	        get { return StringUtils.GetString(Field6); }
	        set { Field6 = StringUtils.GetBytes(value, 32); }
        }

	    [ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field7 { get; set; }

	    [JsonIgnore]
        [ElementsCount(32)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] Field8 { get; set; }

	    public string Field8String
	    {
	        get { return StringUtils.GetString(Field8); }
	        set { Field8 = StringUtils.GetBytes(value, 32); }
        }
    }
}
