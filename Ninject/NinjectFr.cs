using System;
using Ninject;
using Ninject.Modules;
using Interfaces;
using Ataques;

namespace NinjectFramework
{
    public class NinjectFr : NinjectModule
    {
        public override void Load()
        {
            this.Bind<ITecnica>().To<Tecnica>();
        }
    }
}
