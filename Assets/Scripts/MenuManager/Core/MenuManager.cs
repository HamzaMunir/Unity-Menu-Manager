using System.Collections;
using System.Collections.Generic;
using MenuManager.Core;
using UnityEngine;

namespace MenuManager
{
    public class MenuManager : GenericSingleton<MenuManager>
    {
        public enum MenuActions
        {
            None,
            CloseOthers
        }

        public static MenuDataProvider MenuDataProvider;

        public static MenuContextProvider MenuContextProvider;

        public static MenuViewProvider MenuViewProvider;

        private Dictionary<MenuContext, Menu<MenuData, MenuContext, MenuView>> _activeMenus =
            new Dictionary<MenuContext, Menu<MenuData, MenuContext, MenuView>>();

        private bool HasMenu(string menuName)
        {
            foreach (var activeMenusKey in _activeMenus.Keys)
            {
                if (menuName == activeMenusKey.AssetName)
                {
                    return true;
                }
            }

            return false;
        }

        public void PushMenu(MenuContext menuContext, MenuData menuData, MenuActions menuAction = MenuActions.None)
        {
            var view = MenuViewProvider.GetMenuView<MenuView,MenuContext>(menuContext);
            var menu = MenuProvider.GetMenu(menuData, menuContext, view);
        }
    }
}