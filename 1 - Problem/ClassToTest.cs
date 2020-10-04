namespace _1___InheritanceInterface
{
    public class ClassToTest
    {
        public void CallVirtualMethod(ClassNonVirtualMethods param)
        {
            param.VirtualMethod(); 
        }

        public void CallNonVirtualMethod(ClassNonVirtualMethods param)
        {
            param.NonVirtualMethod();
        }
    }
}