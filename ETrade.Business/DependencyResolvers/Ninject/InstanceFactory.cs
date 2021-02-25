﻿using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.Business.DependencyResolvers.Ninject
{
    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var kernel = new StandardKernel(new BusinessModule());
            return kernel.Get<T>();
        }
    }
}
