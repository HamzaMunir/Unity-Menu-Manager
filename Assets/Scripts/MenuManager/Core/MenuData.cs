using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MenuManager.Core
{
    public class MenuData
    {
        public enum MenuType
        {
            Screen = 0,
            PopupUnderHud =4000,
            HUD = 5000,
            PopupOverHud = 6000,
            HudOverAll =7000,
            Loading = 8000,
            ToolTip = 9000,
            PopupOverAll = 10000
        }

        public MenuType Type;
    }
}