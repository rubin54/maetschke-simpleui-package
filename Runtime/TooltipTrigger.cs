using UnityEngine;
using UnityEngine.EventSystems;

namespace maetschke.simpleui.runtime
{
    public class TooltipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        #region Fields

        public string header;

        [Multiline()]
        public string content;
        #endregion Fields;

        #region Methodes
        public void OnPointerEnter(PointerEventData eventData)
        {
            //Coroutine for delay
            TooltipSystem.Show(content, header);
        }
        public void OnPointerExit(PointerEventData eventData)
        {
            TooltipSystem.Hide();
        }

        public void OnMouseEnter()
        {
            TooltipSystem.Show(content, header);
        }
        public void OnMouseExit()
        {
            TooltipSystem.Hide();
        }

        #endregion Methodes
    }
}

