namespace MenuManager.Core
{
    public interface IMenu<TMenuData, TMenuContext, TMenuView> 
        where TMenuData : class
        where TMenuContext : class
        where TMenuView : class
    {
        /// <summary>
        /// When the menu is spawned this <see cref="Spawn"/> will be called
        /// </summary>
        public void Spawn(TMenuData data, TMenuContext context, TMenuView view);

        /// <summary>
        /// Setting the view for this menu
        /// </summary>
        /// <param name="view"></param>
        public void SetView(MenuView view);

        /// <summary>
        /// When the menu refresh <see cref="RefreshView"/> will be called
        /// </summary>
        public void RefreshView();

        /// <summary>
        /// When the menu is despawned <see cref="Despawn"/> will be called 
        /// </summary>
        public void Despawn();
    }
}