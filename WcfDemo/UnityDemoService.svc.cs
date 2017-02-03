using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class UnityDemoService : IUnityDemoService
    {
        private IUnityContainer _container;
        private ICompute _compute;

        public UnityDemoService(IUnityContainer container, ICompute compute)
        {
            _container = container.CreateChildContainer();
            _compute = compute;
        }

        public string GetData(int value1, int value2, int version)
        {
            if (version == 2)
            {
                _container.RegisterType<ICompute, ComputeNew>();
                _compute = _container.Resolve<ICompute>();
            }
            return string.Format($"You entered: {value1} + {value2}, result: {_compute.Add(value1, value2)}");
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
