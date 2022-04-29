using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace maetschke.simpleui.runtime
{
    public class Settings : MonoBehaviour
    {
        public void LoadGame()
        {
            GameManager.instance.LoadGame();
        }

        public void LoadToolTipScene()
        {
            GameManager.instance.LoadToolTipScene();
        }

        public void LoadInventory()
        {
            GameManager.instance.LoadInventoryScene();
        }

        public void LoadShop()
        {
            GameManager.instance.LoadShopScene();
        }
        public void LoadSaveLoad()
        {
            GameManager.instance.LoadSaveLoadScene();
        }

        public void StartShowcase()
        {
            ///GameManager.instance.Unload();
            GameManager.instance.StartShowcase();
        }

        public void UnloadTooltip()
        {
            GameManager.instance.UnloadTooltipScene();
        }
        public void UnloadInventory()
        {
            GameManager.instance.UnloadInventoryScene();
        }
    }
}

