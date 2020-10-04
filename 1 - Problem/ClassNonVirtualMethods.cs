using System;

namespace _1___InheritanceInterface
{
    public class ClassNonVirtualMethods
    {
        public void NonVirtualMethod()
        {
             Console.WriteLine("Executing Non Virtual Method");
        }

        public virtual void VirtualMethod()
        {
            Console.WriteLine("Executing Virtual Method");
        }
    }
}