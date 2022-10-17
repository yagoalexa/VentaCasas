using Moq;
using VentaCasas.DTOs;
using VentaCasas.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Test.Interface_Adapters.Presenters
{

    public class PropertyMock
    {
        public Mock<IGetPropertyOutputPort> GetMockPopertyOutput()
        {
            var propertyOutput = new Mock<IGetPropertyOutputPort>(MockBehavior.Default);
            propertyOutput.Setup(x => x.Handle(new PropertyDTO()));
            return propertyOutput;
        }
        public Mock<IGetPropertyInputPort> GetMockPopertyInput(int id)
        {
            var propertyInput = new Mock<IGetPropertyInputPort>(MockBehavior.Strict);
            propertyInput.Setup(x => x.Handle(id));
            return propertyInput;
        }
    }
}
