using System;

namespace MenuManager.Core
{
    public interface IMenuDataProvider
    {
        /// <summary>
        /// Implement this to get data instance for menu 
        /// </summary>
        /// <returns> menuData</returns>
        public T GetMenuData<T>() where T : MenuData,new();
    }
}