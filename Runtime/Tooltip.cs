using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace maetschke.simpleui.runtime
{
    [ExecuteInEditMode()]
    public class Tooltip : MonoBehaviour
    {
        #region Fields
        public TextMeshProUGUI headerField;

        public TextMeshProUGUI contentField;

        public LayoutElement layoutElement;

        public RectTransform rectTransform;

        public int characterWrapLimit;

        #endregion Fields

        #region Awake/Start/Update
        private void Awake()
        {
            rectTransform = GetComponent<RectTransform>();
        }
        private void Update()
        {

            // Didnt want to move it into it's own methode but for preview purpose i wrap it 
            if (Application.isEditor)
            {
                int headerLength = headerField.text.Length;
                int contentLength = contentField.text.Length;

                layoutElement.enabled = (headerLength > characterWrapLimit || contentLength > characterWrapLimit) ? true : false;
            }

            Vector2 position = Input.mousePosition;

            float pivotX = position.x / Screen.width;
            float pivotY = position.y / Screen.height;


            rectTransform.pivot = new Vector2(pivotX, pivotY);
            transform.position = position;


        }
        #endregion Awake/Start/Update

        #region Methodes
        public void SetText(string content, string header = "")
        {
            if (string.IsNullOrEmpty(header))
            {
                headerField.gameObject.SetActive(false);
            }
            else
            {
                headerField.gameObject.SetActive(true);
                headerField.text = header;
            }

            contentField.text = content;
        }
        #endregion Methodes
    }
}


