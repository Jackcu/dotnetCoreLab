using commLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace commLibTest
{
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {

            Assert.Equal("123", Dt.ToT1(DateTime.Now));   
              
        }

    }
}
