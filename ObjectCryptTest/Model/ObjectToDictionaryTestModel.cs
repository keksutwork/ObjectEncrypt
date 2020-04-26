using ObjectEncryptTest.Enum;
using System;

namespace ObjectCryptTest.Model
{
    public class ObjectToDictionaryTestModel : ObjectToDictionaryTestModelFather
    {
        public int IntProp { get; set; }
        public string StringProp { get; set; }
        public decimal DecimalProp { get; set; }
        public NumberToEnglish EnumProp { get; set; }
        public DateTime DatetimeProp { get; set; }
    }
    public class ObjectToDictionaryTestModelFather
    {
        public string InheritProp { get; set; }
    }
}
