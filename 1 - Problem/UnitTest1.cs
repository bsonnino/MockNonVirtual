using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace _1___InheritanceInterface
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

        [TestMethod]
        public void TestVirtualMethodWithMockClass()
        {
            var mock = new MockClassWithNonVirtualMethods();
            var sut = new ClassToTest();
            sut.CallVirtualMethod(mock);
        }

        [TestMethod]
        public void TestNonVirtualMethodWithMockClass()
        {
            var mock = new MockClassWithNonVirtualMethods();
            var sut = new ClassToTest();
            sut.CallNonVirtualMethod(mock);
        }
    }
}
