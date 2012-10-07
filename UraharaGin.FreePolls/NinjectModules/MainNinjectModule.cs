using Ninject.Modules;
using Ninject.Web.Common;
using UraharaGin.Core.DataAccess;
using UraharaGin.FreePolls.Security;

namespace UraharaGin.FreePolls.NinjectModules
{
    public class MainNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IUserRepository>().To<UserRepository>().InRequestScope();
            this.Bind<IHashProvider>().To<HashProvider>().InRequestScope();
        }
    }
}