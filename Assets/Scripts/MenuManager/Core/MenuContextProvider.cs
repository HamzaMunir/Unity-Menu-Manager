using System;

namespace MenuManager.Core
{
    public class MenuContextProvider : IMenuContextProvider
    {
        /// <summary>
        /// Get menu context for the menus
        /// </summary>
        /// <param name="assetName"></param>
        /// <returns>Context instance</returns>
        public TMenuContext GetMenuContext<TMenuContext>(string assetName) where TMenuContext : MenuContext,new()
        {
            TMenuContext contextInstance = new TMenuContext
            {
                AssetName = assetName
            };
            return contextInstance;
        }
    }
}