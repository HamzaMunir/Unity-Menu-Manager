using System;
using MenuManager.Common;

namespace MenuManager.Core
{
    public class MenuProvider
    {
        public static Menu<TMenuData,TMenuContext,TMenuView> GetMenu<TMenuData, TMenuContext, TMenuView>(TMenuData data, TMenuContext context, TMenuView view)
            where TMenuData : MenuData where TMenuContext : MenuContext where TMenuView : MenuView
        {
            var menu = (Menu<TMenuData,TMenuContext,TMenuView>)Activator.CreateInstance(typeof(Menu<TMenuData,TMenuContext,TMenuView>));
            menu.Spawn(data,context,view);
            return menu;
        }
    }
}