using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    /*Finalize gets called by the GC when this object is no longer in use.

    Dispose is just a normal method which the user of this class can call to release any resources.

    If user forgot to call Dispose and if the class have Finalize implemented then GC will make sure it gets called.*/

    internal class GCFinalize
    {

    }
}

 
