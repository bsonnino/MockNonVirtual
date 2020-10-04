using _1___InheritanceInterface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace _2___DynamicProxy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestVirtualMethod()
        {
            var mock = Substitute.For<ClassNonVirtualMethods>();
            var sut = new ClassToTest();
            sut.CallVirtualMethod(mock);
        }

        [TestMethod]
        public void TestNonVirtualMethod()
        {
            var mock = Substitute.For<ClassNonVirtualMethods>();
            var sut = new ClassToTest();
            sut.CallNonVirtualMethod(mock);
        }
    }
}
