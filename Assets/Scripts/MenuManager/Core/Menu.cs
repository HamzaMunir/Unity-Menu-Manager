using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MenuManager.Core
{
    public class Menu<TMenuData, TMenuContext, TMenuView> : IMenu<TMenuData, TMenuContext, TMenuView>
        where TMenuData : MenuData
        where TMenuContext : MenuContext
        where TMenuView : MenuView

    {
        /// <summary>
        /// Data assigned for this menu
        /// </summary>
        protected virtual MenuData Data { get; set; }
        /// <summary>
        /// Context assigned for this menu
        /// </summary>
        protected virtual MenuContext Context { get; private set; }
        /// <summary>
        /// View assigned for this menu
        /// </summary>
        public virtual MenuView View { get; protected set; }

        public void Spawn(TMenuData menuData, TMenuContext context, TMenuView view)
        {
            Data = menuData;
            Context = context;
            View = view;
            OnSpawn(menuData);
            OnAnimateOpen();
        }

        public void SetView(MenuView view)
        {
            View = view;
        }

        public virtual void RefreshView()
        {
        }

        public void Despawn()
        {
            OnDespawn();
            OnAnimateClose();
        }

        protected virtual void OnSpawn(TMenuData data)
        {
        }

        protected virtual void OnDespawn()
        {
        }

        protected virtual void OnAnimateOpen(){}

        protected virtual void OnAnimateClose()
        {
        }
    }
}