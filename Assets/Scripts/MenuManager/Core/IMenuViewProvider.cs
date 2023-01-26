using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MenuManager.Core
{
    public interface IMenuViewProvider
    {
        /// <summary>
        /// Get view for provided menu context
        /// </summary>
        /// <param name="context"></param>
        /// <typeparam name="TMenuView"></typeparam>
        /// <typeparam name="TMenuContext"></typeparam>
        /// <returns></returns>
        public TMenuView GetMenuView<TMenuView,TMenuContext>(TMenuContext context) where TMenuView : MenuView where TMenuContext : MenuContext;
    }
}