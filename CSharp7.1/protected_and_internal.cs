using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Animal
{
    //This is protected OR internal.
    //It is still visible outside this assembly
    protected internal class SuperSecretInternalBehavior
        //C# 7.1
        //private internal class InternalBehavior
    {
        public SuperSecretInternalBehavior()
        {
        }
    }
}

public class Giraffe : Animal
{
    public Giraffe()
    {
        var behavior = new SuperSecretInternalBehavior();
    }
}