using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Sportsblog.Tests
{
   public class HomeControllerTests
    {
        [Fact]
        public void Index_Returns_Hello_World()
        {
            var underTest = new HomeController();

            var result = underTest.Index();

            Assert.Equal("Hello world", result);
        }

    }
}
