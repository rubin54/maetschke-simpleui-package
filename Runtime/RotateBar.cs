using UnityEngine;

namespace maetschke.simpleui.runtime
{
    public class RotateBar : MonoBehaviour
    {

        public float speed = 3;

        void Update()
        {
            transform.Rotate(0, 0, speed * Time.deltaTime); // rotation on the Z axis.
        }

    }
}

