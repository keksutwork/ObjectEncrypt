using NUnit.Framework;
using ObjectCryptTest.Model;
using ObjectHashGenerator;
using ObjectEncryptTest.TestCases;
using System.Collections.Generic;
using System.Linq;

namespace ObjectCryptTest
{
    [TestFixture]
    public class ObjectToDictionaryTests
    {


        [Test]
        [TestCaseSource(typeof(ObjectToDictionaryTestCases), nameof(ObjectToDictionaryTestCases.TestCases))]
        public void Test(ObjectToDictionaryTestModel o)
        {
            Dictionary<string, object> expect = new Dictionary<string, object>()
            {
                ["IntProp"] = o.IntProp,
                ["StringProp"] = o.StringProp,
                ["DecimalProp"] = o.DecimalProp,
                ["EnumProp"] = o.EnumProp,
                ["DatetimeProp"] = o.DatetimeProp,
                ["InheritProp"] = o.InheritProp
            };

            //Act
            Dictionary<string, object> actual = o.ObjectToDictionary();

            //Assert
            bool isSame = (actual.Count == expect.Count) //檢查資料數量
                          && !actual.Except(expect).Any(); //檢查key value pair

            Assert.IsTrue(isSame);
        }
    }
}