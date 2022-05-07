using Ninject.Modules;
using PhoneDictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_6.Util
{
    public class NinjectRegistration : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<Phone>>().To<MSSQL_DB.PhoneRepository>().InTransientScope();

            //Bind<IRepository<Phone>>().To<JSON_DB.PhoneRepository>().InSingletonScope(); 

        }
    }
}