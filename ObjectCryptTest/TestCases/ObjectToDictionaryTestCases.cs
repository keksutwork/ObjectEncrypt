using ObjectCryptTest.Model;
using ObjectEncryptTest.Enum;
using System;
using System.Collections.Generic;

namespace ObjectEncryptTest.TestCases
{
    public class ObjectToDictionaryTestCases
    {
        public static IEnumerable<ObjectToDictionaryTestModel> TestCases
        {
            get
            {
                yield return new ObjectToDictionaryTestModel()
                {
                    IntProp = 1,
                    StringProp = "1",
                    DecimalProp = 1.1M,
                    EnumProp = NumberToEnglish.One,
                    DatetimeProp = DateTime.Now
                };
                yield return new ObjectToDictionaryTestModel()
                {
                    IntProp = 2,
                    StringProp = "2",
                    DecimalProp = 2.2M,
                    EnumProp = NumberToEnglish.Two,
                    DatetimeProp = DateTime.Now,
                    InheritProp = "Inh"
                };
            }
        }
    }
}
