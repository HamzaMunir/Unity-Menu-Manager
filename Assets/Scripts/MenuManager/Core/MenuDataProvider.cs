using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MenuManager.Core
{
    public class MenuDataProvider : IMenuDataProvider
    {
        /// <summary>
        /// Get data for given menu
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>Data Instance</returns>
        public T GetMenuData<T>() where T : MenuData, new()
        {
            var dataInstance = new T();
            return dataInstance;
        }
    }
}