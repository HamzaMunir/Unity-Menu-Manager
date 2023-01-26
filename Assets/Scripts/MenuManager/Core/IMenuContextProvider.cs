
using System;

namespace MenuManager.Core
{
    public interface IMenuContextProvider
    {
        public TMenuContext GetMenuContext<TMenuContext>(string assetName)
            where TMenuContext : MenuContext, new();
    }
}