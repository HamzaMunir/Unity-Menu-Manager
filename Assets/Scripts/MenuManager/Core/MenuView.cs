using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MenuManager.Core
{
    [RequireComponent(typeof(Canvas))]
    public abstract class MenuView : MonoBehaviour
    {
        public virtual Canvas m_Canvas { get; private set; }
        protected virtual void Awake()
        {
            m_Canvas = GetComponent<Canvas>();
        }
    }
}