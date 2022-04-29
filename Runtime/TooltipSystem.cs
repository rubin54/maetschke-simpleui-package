using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace maetschke.simpleui.runtime
{
    public class TooltipSystem : MonoBehaviour
    {
        #region Fields

        private static TooltipSystem instance;

        public Tooltip tooltip;
        #endregion Fields

        #region Awake/Start/Update

        private void Awake()
        {
            instance = this;
        }
        #endregion Awake/Start/Update

        #region Methodes
        public static void Show(string content, string header = "")
        {
            instance.tooltip.SetText(content, header);
            instance.tooltip.gameObject.SetActive(true);
        }

        public static void Hide()
        {
            instance.tooltip.gameObject.SetActive(false);
        }
        #endregion Methodes
    }
}

