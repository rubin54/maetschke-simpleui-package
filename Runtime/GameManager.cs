using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace maetschke.simpleui.runtime
{
    public class GameManager : MonoBehaviour
    {
        #region Fields
        public static GameManager instance;
        public GameObject loadingScreen;
        public ProgressBar bar;
        public TextMeshProUGUI textField;
        public Sprite[] backgrounds;
        public Image backgroundImage;
        public TextMeshProUGUI tipsText;
        public CanvasGroup alphaCanvas;
        public string[] tips;
        #endregion Fields

        #region Awake/Start/Update
        private void Awake()
        {
            instance = this;

            StartShowcase();
        }
        #endregion Awake/Start/Update

        #region Methodes

        List<AsyncOperation> scenesLoading = new List<AsyncOperation>();

        public void LoadGame()
        {
            //backgroundImage.sprite = backgrounds[Random.Range(0, backgrounds.Length)];
            loadingScreen.gameObject.SetActive(true);

            StartCoroutine(GenerateTips());

            scenesLoading.Add(SceneManager.UnloadSceneAsync((int)SceneIndexes.TITLE_SCREEN));
            scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.MAP, LoadSceneMode.Additive));
            //scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.UI, LoadSceneMode.Additive));

            StartCoroutine(GetSceneLoadProgress());
        }

        public void StartShowcase()
        {
            //scenesLoading.Add(SceneManager.UnloadSceneAsync((int)SceneIndexes.ToolTip));
            //scenesLoading.Add(SceneManager.UnloadSceneAsync((int)SceneIndexes.Inventory));
            //scenesLoading.Add(SceneManager.UnloadSceneAsync((int)SceneIndexes.Shop));
            //scenesLoading.Add(SceneManager.UnloadSceneAsync((int)SceneIndexes.SaveLoad));
            if (scenesLoading.Count > 2)
            {
                scenesLoading.Add(SceneManager.UnloadSceneAsync((int)SceneIndexes.ToolTip));

            }
            SceneManager.LoadSceneAsync((int)SceneIndexes.TITLE_SCREEN, LoadSceneMode.Additive);
        }

        float totalSceneProgress;
        public IEnumerator GetSceneLoadProgress()
        {
            for (int i = 0; i < scenesLoading.Count; i++)
            {
                while (!scenesLoading[i].isDone)
                {
                    totalSceneProgress = 0;

                    foreach (AsyncOperation operation in scenesLoading)
                    {
                        totalSceneProgress += operation.progress;
                    }

                    totalSceneProgress = (totalSceneProgress / scenesLoading.Count) * 100f;

                    textField.text = string.Format("Loading Scene: {0}%", totalSceneProgress);

                    yield return null;
                }
            }
            loadingScreen.gameObject.SetActive(false);
        }

        public int tipCount;
        public IEnumerator GenerateTips()
        {
            tipCount = Random.Range(0, tips.Length);
            tipsText.text = tips[tipCount];
            while (loadingScreen.activeInHierarchy)
            {
                yield return new WaitForSeconds(3f);

                //LeanTween.alphaCanvas(alphaCanvas, 0, 0.5f);

                yield return new WaitForSeconds(0.5f);

                tipCount++;
                if (tipCount > tips.Length)
                {
                    tipCount = 0;
                }

                tipsText.text = tips[tipCount];

                //LeanTween.alphaCanvas(alphaCanvas, 1, 0.5f);
            }
        }
        #endregion Methodes

        #region NeedToChange
        public void LoadToolTipScene()
        {
            //backgroundImage.sprite = backgrounds[Random.Range(0, backgrounds.Length)];
            loadingScreen.gameObject.SetActive(true);

            StartCoroutine(GenerateTips());

            scenesLoading.Add(SceneManager.UnloadSceneAsync((int)SceneIndexes.TITLE_SCREEN));
            scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.ToolTip, LoadSceneMode.Additive));

            StartCoroutine(GetSceneLoadProgress());
        }
        public void LoadInventoryScene()
        {
            //backgroundImage.sprite = backgrounds[Random.Range(0, backgrounds.Length)];
            loadingScreen.gameObject.SetActive(true);

            StartCoroutine(GenerateTips());

            scenesLoading.Add(SceneManager.UnloadSceneAsync((int)SceneIndexes.TITLE_SCREEN));
            scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.Inventory, LoadSceneMode.Additive));

            StartCoroutine(GetSceneLoadProgress());
        }
        public void LoadShopScene()
        {
            //backgroundImage.sprite = backgrounds[Random.Range(0, backgrounds.Length)];
            loadingScreen.gameObject.SetActive(true);

            StartCoroutine(GenerateTips());

            scenesLoading.Add(SceneManager.UnloadSceneAsync((int)SceneIndexes.TITLE_SCREEN));
            scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.Shop, LoadSceneMode.Additive));

            StartCoroutine(GetSceneLoadProgress());
        }
        public void LoadSaveLoadScene()
        {
            //backgroundImage.sprite = backgrounds[Random.Range(0, backgrounds.Length)];
            loadingScreen.gameObject.SetActive(true);

            StartCoroutine(GenerateTips());

            scenesLoading.Add(SceneManager.UnloadSceneAsync((int)SceneIndexes.TITLE_SCREEN));
            scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.SaveLoad, LoadSceneMode.Additive));

            StartCoroutine(GetSceneLoadProgress());
        }

        public void UnloadTooltipScene()
        {
            loadingScreen.gameObject.SetActive(true);

            StartCoroutine(GenerateTips());
            scenesLoading.Add(SceneManager.UnloadSceneAsync((int)SceneIndexes.ToolTip));
            scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.TITLE_SCREEN, LoadSceneMode.Additive));

            StartCoroutine(GetSceneLoadProgress());
        }
        public void UnloadInventoryScene()
        {
            loadingScreen.gameObject.SetActive(true);

            StartCoroutine(GenerateTips());
            scenesLoading.Add(SceneManager.UnloadSceneAsync((int)SceneIndexes.Inventory));
            scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.TITLE_SCREEN, LoadSceneMode.Additive));

            StartCoroutine(GetSceneLoadProgress());
        }
        #endregion
    }
}

