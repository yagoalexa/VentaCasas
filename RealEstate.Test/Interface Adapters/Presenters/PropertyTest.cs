using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using VentaCasas.Api;
using VentaCasas.Controllers;
using VentaCasas.DTOs;
using VentaCasas.IoC;
using VentaCasas.Presenters;
using VentaCasas.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Test.Interface_Adapters.Presenters
{
    [TestFixture]
    public class PropertyTest
    {
        private IGetPropertyInputPort _inputPort;
        private PropertyMock PropertyMock;
        [OneTimeSetUp]
        public void Setup()
        {
            PropertyMock = new PropertyMock();
        }

        [Test]
        public async Task GetProperty()
        {

            var test = PropertyMock.GetMockPopertyInput(3);
            Assert.IsInstanceOf<PropertyDTO>(test.Object);
        }
    }
}
