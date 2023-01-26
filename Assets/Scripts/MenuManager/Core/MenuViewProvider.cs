using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MenuManager.Core
{
    public class MenuViewProvider : MonoBehaviour, IMenuViewProvider
    {
        public TMenuView GetMenuView<TMenuView, TMenuContext>(TMenuContext context)
            where TMenuView : MenuView
            where TMenuContext : MenuContext
        {
            if (string.IsNullOrEmpty(context.AssetName))
            {
                Debug.LogError($"{context.AssetName} cannot be null");
                return null;
            }

            var view = Resources.Load<TMenuView>(context.AssetName);
            if (view != null)
            {
                return view;
            }

            Debug.LogError($"View for {context.AssetName} does not found");
            return null;
        }
    }
}