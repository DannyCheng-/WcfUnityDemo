using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Web;

namespace WcfDemo
{
    public class UnityServiceHostFactory : ServiceHostFactory
    {
        private readonly IUnityContainer container;

        public UnityServiceHostFactory()
        {
            container = new UnityContainer();
            RegisterTypes(container);
        }

        protected override ServiceHost CreateServiceHost(
          Type serviceType, Uri[] baseAddresses)
        {
            return new UnityServiceHost(this.container,
              serviceType, baseAddresses);
        }

        private void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<ICompute, Compute>();
        }
    }
}