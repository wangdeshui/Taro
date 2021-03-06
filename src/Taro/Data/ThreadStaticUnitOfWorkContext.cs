﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taro.Data;
using Taro.Events;
using Taro.Utils;

namespace Taro.Data
{
    public static class ThreadStaticUnitOfWorkContext
    {
        [ThreadStatic]
        private static IUnitOfWork _current;

        public static IUnitOfWork Current
        {
            get
            {
                return _current;
            }
        }

        public static void Bind(IUnitOfWork unitOfWork)
        {
            Require.NotNull(unitOfWork, "unitOfWork");
            _current = unitOfWork;
        }

        public static void Unbind()
        {
            _current = null;
        }
    }
}
