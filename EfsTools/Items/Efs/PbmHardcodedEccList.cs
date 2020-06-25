using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    public sealed class PbmHardcodedEcc
    {
        public string DigitsString { get; set; }

        public byte Value { get; set; }

        public byte CategoryLength { get; set; }

        public byte EmergencyCategory { get; set; }

        public byte Reserved { get; set; }

        public byte EmergencyMode { get; set; }

        public byte HardcodedType { get; set; }
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(69737)]
    [EfsFile("/nv/item_files/pbm/pbm_hardcoded_ecc_list", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class PbmHardcodedEccList
    {
        [JsonIgnore]
        public byte NumDigits1 { get; set; }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
        public byte[] Digits1 { get; set; }

        [JsonIgnore]
        public string Digits1String
        {
            get => StringUtils.GetString(Digits1);
            set
            {
                Digits1 = StringUtils.GetBytes(value, 28);
                NumDigits1 = (byte) value.Length;
            }
        }

        [JsonIgnore]
        public byte Value1 { get; set; }

        [JsonIgnore]
        public byte CategoryLength1 { get; set; }

        [JsonIgnore]
        public byte EmergencyCategory1 { get; set; }

        [JsonIgnore]
        public byte Reserved1 { get; set; }

        [JsonIgnore]
        public byte EmergencyMode1 { get; set; }

        [JsonIgnore]
        public byte HardcodedType1 { get; set; }

        [JsonIgnore]
        public byte NumDigits2 { get; set; }


        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
        public byte[] Digits2 { get; set; }

        [JsonIgnore]
        public string Digits2String
        {
            get => StringUtils.GetString(Digits2);
            set
            {
                Digits2 = StringUtils.GetBytes(value, 28);
                NumDigits2 = (byte) value.Length;
            }
        }

        [JsonIgnore]
        public byte Value2 { get; set; }

        [JsonIgnore]
        public byte CategoryLength2 { get; set; }

        [JsonIgnore]
        public byte EmergencyCategory2 { get; set; }

        [JsonIgnore]
        public byte Reserved2 { get; set; }

        [JsonIgnore]
        public byte EmergencyMode2 { get; set; }

        [JsonIgnore]
        public byte HardcodedType2 { get; set; }

        [JsonIgnore]
        public byte NumDigits3 { get; set; }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
        public byte[] Digits3 { get; set; }

        [JsonIgnore]
        public string Digits3String
        {
            get => StringUtils.GetString(Digits3);
            set
            {
                Digits3 = StringUtils.GetBytes(value, 28);
                NumDigits3 = (byte) value.Length;
            }
        }

        [JsonIgnore]
        public byte Value3 { get; set; }

        [JsonIgnore]
        public byte CategoryLength3 { get; set; }

        [JsonIgnore]
        public byte EmergencyCategory3 { get; set; }

        [JsonIgnore]
        public byte Reserved3 { get; set; }

        [JsonIgnore]
        public byte EmergencyMode3 { get; set; }

        [JsonIgnore]
        public byte HardcodedType3 { get; set; }

        [JsonIgnore]
        public byte NumDigits4 { get; set; }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
        public byte[] Digits4 { get; set; }

        [JsonIgnore]
        public string Digits4String
        {
            get => StringUtils.GetString(Digits4);
            set
            {
                Digits4 = StringUtils.GetBytes(value, 28);
                NumDigits4 = (byte) value.Length;
            }
        }

        [JsonIgnore]
        public byte Value4 { get; set; }

        [JsonIgnore]
        public byte CategoryLength4 { get; set; }

        [JsonIgnore]
        public byte EmergencyCategory4 { get; set; }

        [JsonIgnore]
        public byte Reserved4 { get; set; }

        [JsonIgnore]
        public byte EmergencyMode4 { get; set; }

        [JsonIgnore]
        public byte HardcodedType4 { get; set; }

        [JsonIgnore]
        public byte NumDigits5 { get; set; }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
        public byte[] Digits5 { get; set; }

        [JsonIgnore]
        public string Digits5String
        {
            get => StringUtils.GetString(Digits5);
            set
            {
                Digits5 = StringUtils.GetBytes(value, 28);
                NumDigits5 = (byte) value.Length;
            }
        }

        [JsonIgnore]
        public byte Value5 { get; set; }

        [JsonIgnore]
        public byte CategoryLength5 { get; set; }

        [JsonIgnore]
        public byte EmergencyCategory5 { get; set; }

        [JsonIgnore]
        public byte Reserved5 { get; set; }

        [JsonIgnore]
        public byte EmergencyMode5 { get; set; }

        [JsonIgnore]
        public byte HardcodedType5 { get; set; }

        [JsonIgnore]
        public byte NumDigits6 { get; set; }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
        public byte[] Digits6 { get; set; }

        [JsonIgnore]
        public string Digits6String
        {
            get => StringUtils.GetString(Digits6);
            set
            {
                Digits6 = StringUtils.GetBytes(value, 28);
                NumDigits6 = (byte) value.Length;
            }
        }

        [JsonIgnore]
        public byte Value6 { get; set; }

        [JsonIgnore]
        public byte CategoryLength6 { get; set; }

        [JsonIgnore]
        public byte EmergencyCategory6 { get; set; }

        [JsonIgnore]
        public byte Reserved6 { get; set; }

        [JsonIgnore]
        public byte EmergencyMode6 { get; set; }

        [JsonIgnore]
        public byte HardcodedType6 { get; set; }

        [JsonIgnore]
        public byte NumDigits7 { get; set; }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
        public byte[] Digits7 { get; set; }

        [JsonIgnore]
        public string Digits7String
        {
            get => StringUtils.GetString(Digits7);
            set
            {
                Digits7 = StringUtils.GetBytes(value, 28);
                NumDigits7 = (byte) value.Length;
            }
        }

        [JsonIgnore]
        public byte Value7 { get; set; }

        [JsonIgnore]
        public byte CategoryLength7 { get; set; }

        [JsonIgnore]
        public byte EmergencyCategory7 { get; set; }

        [JsonIgnore]
        public byte Reserved7 { get; set; }

        [JsonIgnore]
        public byte EmergencyMode7 { get; set; }

        [JsonIgnore]
        public byte HardcodedType7 { get; set; }

        [JsonIgnore]
        public byte NumDigits8 { get; set; }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
        public byte[] Digits8 { get; set; }

        [JsonIgnore]
        public string Digits8String
        {
            get => StringUtils.GetString(Digits8);
            set
            {
                Digits8 = StringUtils.GetBytes(value, 28);
                NumDigits8 = (byte) value.Length;
            }
        }

        [JsonIgnore]
        public byte Value8 { get; set; }

        [JsonIgnore]
        public byte CategoryLength8 { get; set; }

        [JsonIgnore]
        public byte EmergencyCategory8 { get; set; }

        [JsonIgnore]
        public byte Reserved8 { get; set; }

        [JsonIgnore]
        public byte EmergencyMode8 { get; set; }

        [JsonIgnore]
        public byte HardcodedType8 { get; set; }

        [JsonIgnore]
        public byte NumDigits9 { get; set; }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
        public byte[] Digits9 { get; set; }

        [JsonIgnore]
        public string Digits9String
        {
            get => StringUtils.GetString(Digits9);
            set
            {
                Digits9 = StringUtils.GetBytes(value, 28);
                NumDigits9 = (byte) value.Length;
            }
        }

        [JsonIgnore]
        public byte Value9 { get; set; }

        [JsonIgnore]
        public byte CategoryLength9 { get; set; }

        [JsonIgnore]
        public byte EmergencyCategory9 { get; set; }

        [JsonIgnore]
        public byte Reserved9 { get; set; }

        [JsonIgnore]
        public byte EmergencyMode9 { get; set; }

        [JsonIgnore]
        public byte HardcodedType9 { get; set; }

        [JsonIgnore]
        public byte NumDigits10 { get; set; }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
        public byte[] Digits10 { get; set; }

        [JsonIgnore]
        public string Digits10String
        {
            get => StringUtils.GetString(Digits10);
            set
            {
                Digits10 = StringUtils.GetBytes(value, 28);
                NumDigits10 = (byte) value.Length;
            }
        }

        [JsonIgnore]
        public byte Value10 { get; set; }

        [JsonIgnore]
        public byte CategoryLength10 { get; set; }

        [JsonIgnore]
        public byte EmergencyCategory10 { get; set; }

        [JsonIgnore]
        public byte Reserved10 { get; set; }

        [JsonIgnore]
        public byte EmergencyMode10 { get; set; }

        [JsonIgnore]
        public byte HardcodedType10 { get; set; }


        public PbmHardcodedEcc[] Items
        {
            get =>
                new[]
                {
                    new PbmHardcodedEcc
                    {
                        Value = Value1, CategoryLength = CategoryLength1, DigitsString = Digits1String,
                        EmergencyCategory = EmergencyCategory1, EmergencyMode = EmergencyMode1,
                        HardcodedType = HardcodedType1, Reserved = Reserved1
                    },
                    new PbmHardcodedEcc
                    {
                        Value = Value2, CategoryLength = CategoryLength2, DigitsString = Digits2String,
                        EmergencyCategory = EmergencyCategory2, EmergencyMode = EmergencyMode2,
                        HardcodedType = HardcodedType2, Reserved = Reserved2
                    },
                    new PbmHardcodedEcc
                    {
                        Value = Value3, CategoryLength = CategoryLength3, DigitsString = Digits3String,
                        EmergencyCategory = EmergencyCategory3, EmergencyMode = EmergencyMode3,
                        HardcodedType = HardcodedType3, Reserved = Reserved3
                    },
                    new PbmHardcodedEcc
                    {
                        Value = Value4, CategoryLength = CategoryLength4, DigitsString = Digits4String,
                        EmergencyCategory = EmergencyCategory4, EmergencyMode = EmergencyMode4,
                        HardcodedType = HardcodedType4, Reserved = Reserved4
                    },
                    new PbmHardcodedEcc
                    {
                        Value = Value5, CategoryLength = CategoryLength5, DigitsString = Digits5String,
                        EmergencyCategory = EmergencyCategory5, EmergencyMode = EmergencyMode5,
                        HardcodedType = HardcodedType5, Reserved = Reserved5
                    },
                    new PbmHardcodedEcc
                    {
                        Value = Value6, CategoryLength = CategoryLength6, DigitsString = Digits6String,
                        EmergencyCategory = EmergencyCategory6, EmergencyMode = EmergencyMode6,
                        HardcodedType = HardcodedType6, Reserved = Reserved6
                    },
                    new PbmHardcodedEcc
                    {
                        Value = Value7, CategoryLength = CategoryLength7, DigitsString = Digits7String,
                        EmergencyCategory = EmergencyCategory7, EmergencyMode = EmergencyMode7,
                        HardcodedType = HardcodedType7, Reserved = Reserved7
                    },
                    new PbmHardcodedEcc
                    {
                        Value = Value8, CategoryLength = CategoryLength8, DigitsString = Digits8String,
                        EmergencyCategory = EmergencyCategory8, EmergencyMode = EmergencyMode8,
                        HardcodedType = HardcodedType8, Reserved = Reserved8
                    },
                    new PbmHardcodedEcc
                    {
                        Value = Value9, CategoryLength = CategoryLength9, DigitsString = Digits9String,
                        EmergencyCategory = EmergencyCategory9, EmergencyMode = EmergencyMode9,
                        HardcodedType = HardcodedType9, Reserved = Reserved9
                    },
                    new PbmHardcodedEcc
                    {
                        Value = Value10, CategoryLength = CategoryLength10, DigitsString = Digits10String,
                        EmergencyCategory = EmergencyCategory10, EmergencyMode = EmergencyMode10,
                        HardcodedType = HardcodedType10, Reserved = Reserved10
                    }
                };
            set
            {
                if (value == null)
                {
                    return;
                }

                if (value.Length > 0)
                {
                    var val = Items[0];
                    Value1 = val.Value;
                    CategoryLength1 = val.CategoryLength;
                    Digits1String = val.DigitsString;
                    EmergencyCategory1 = val.EmergencyCategory;
                    EmergencyMode1 = val.EmergencyMode;
                    HardcodedType1 = val.HardcodedType;
                    Reserved1 = val.Reserved;
                }

                if (value.Length > 1)
                {
                    var val = Items[1];
                    Value2 = val.Value;
                    CategoryLength2 = val.CategoryLength;
                    Digits2String = val.DigitsString;
                    EmergencyCategory2 = val.EmergencyCategory;
                    EmergencyMode2 = val.EmergencyMode;
                    HardcodedType2 = val.HardcodedType;
                    Reserved2 = val.Reserved;
                }

                if (value.Length > 2)
                {
                    var val = Items[2];
                    Value3 = val.Value;
                    CategoryLength3 = val.CategoryLength;
                    Digits3String = val.DigitsString;
                    EmergencyCategory3 = val.EmergencyCategory;
                    EmergencyMode3 = val.EmergencyMode;
                    HardcodedType3 = val.HardcodedType;
                    Reserved3 = val.Reserved;
                }

                if (value.Length > 3)
                {
                    var val = Items[3];
                    Value4 = val.Value;
                    CategoryLength4 = val.CategoryLength;
                    Digits4String = val.DigitsString;
                    EmergencyCategory4 = val.EmergencyCategory;
                    EmergencyMode4 = val.EmergencyMode;
                    HardcodedType4 = val.HardcodedType;
                    Reserved4 = val.Reserved;
                }

                if (value.Length > 4)
                {
                    var val = Items[4];
                    Value5 = val.Value;
                    CategoryLength5 = val.CategoryLength;
                    Digits5String = val.DigitsString;
                    EmergencyCategory5 = val.EmergencyCategory;
                    EmergencyMode5 = val.EmergencyMode;
                    HardcodedType5 = val.HardcodedType;
                    Reserved5 = val.Reserved;
                }

                if (value.Length > 5)
                {
                    var val = Items[5];
                    Value6 = val.Value;
                    CategoryLength6 = val.CategoryLength;
                    Digits6String = val.DigitsString;
                    EmergencyCategory6 = val.EmergencyCategory;
                    EmergencyMode6 = val.EmergencyMode;
                    HardcodedType6 = val.HardcodedType;
                    Reserved6 = val.Reserved;
                }

                if (value.Length > 6)
                {
                    var val = Items[6];
                    Value7 = val.Value;
                    CategoryLength7 = val.CategoryLength;
                    Digits7String = val.DigitsString;
                    EmergencyCategory7 = val.EmergencyCategory;
                    EmergencyMode7 = val.EmergencyMode;
                    HardcodedType7 = val.HardcodedType;
                    Reserved7 = val.Reserved;
                }

                if (value.Length > 7)
                {
                    var val = Items[7];
                    Value8 = val.Value;
                    CategoryLength8 = val.CategoryLength;
                    Digits8String = val.DigitsString;
                    EmergencyCategory8 = val.EmergencyCategory;
                    EmergencyMode8 = val.EmergencyMode;
                    HardcodedType8 = val.HardcodedType;
                    Reserved8 = val.Reserved;
                }

                if (value.Length > 8)
                {
                    var val = Items[8];
                    Value9 = val.Value;
                    CategoryLength9 = val.CategoryLength;
                    Digits9String = val.DigitsString;
                    EmergencyCategory9 = val.EmergencyCategory;
                    EmergencyMode9 = val.EmergencyMode;
                    HardcodedType9 = val.HardcodedType;
                    Reserved9 = val.Reserved;
                }

                if (value.Length > 9)
                {
                    var val = Items[9];
                    Value10 = val.Value;
                    CategoryLength10 = val.CategoryLength;
                    Digits10String = val.DigitsString;
                    EmergencyCategory10 = val.EmergencyCategory;
                    EmergencyMode10 = val.EmergencyMode;
                    HardcodedType10 = val.HardcodedType;
                    Reserved10 = val.Reserved;
                }
            }
        }
    }
}