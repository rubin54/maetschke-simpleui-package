using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace maetschke.simpleui.runtime
{
    public class OptionScreen : MonoBehaviour
    {
        #region Fields
        public Toggle fullscreenToggle;
        public Toggle vsyncTog;

        public List<ResItem> resolutions = new List<ResItem>();

        private int selectedResolution;

        public TMP_Text resolutionLabel;
        #endregion Fields

        #region Awake/Start/Update
        private void Start()
        {
            fullscreenToggle.isOn = Screen.fullScreen;

            if (QualitySettings.vSyncCount == 0)
            {
                vsyncTog.isOn = false;
            }
            else
            {
                vsyncTog.isOn = true;
            }

            bool foundRes = false;
            for (int i = 0; i < resolutions.Count; i++)
            {
                if (Screen.width == resolutions[i].horizontal && Screen.height == resolutions[i].vertical)
                {
                    foundRes = true;

                    selectedResolution = i;

                    UpdateResLabel();
                }
            }

            if (!foundRes)
            {
                ResItem newRes = new ResItem();
                newRes.horizontal = Screen.width;
                newRes.vertical = Screen.height;

                resolutions.Add(newRes);
                selectedResolution = resolutions.Count - 1;

                UpdateResLabel();
            }
        }

        private void Update()
        {

        }
        #endregion Awake/Start/Update

        #region Methodes

        public void ResLeft()
        {
            selectedResolution--;
            if (selectedResolution < 0)
            {
                selectedResolution = 0;
            }

            UpdateResLabel();
        }
        public void ResRight()
        {
            selectedResolution++;
            if (selectedResolution > resolutions.Count - 1)
            {
                selectedResolution = resolutions.Count - 1;
            }

            UpdateResLabel();
        }

        public void UpdateResLabel()
        {
            resolutionLabel.text = resolutions[selectedResolution].horizontal.ToString() + " x " + resolutions[selectedResolution].vertical.ToString();
        }
        public void ApplyGraphics()
        {
            //Screen.fullScreen = fullscreenToggle.isOn;

            if (vsyncTog.isOn)
            {
                QualitySettings.vSyncCount = 1;
            }
            else
            {
                QualitySettings.vSyncCount = 0;
            }

            Screen.SetResolution(resolutions[selectedResolution].horizontal, resolutions[selectedResolution].vertical, fullscreenToggle.isOn);
        }
        #endregion Methodes
    }

    [System.Serializable]
    public class ResItem
    {
        public int horizontal;
        public int vertical;
    }
}

