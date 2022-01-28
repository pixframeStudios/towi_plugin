namespace PixframeStudios.TowiPlugin
{ 
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public static class TowiUtils
    {
        /// <summary>
        /// This util will return the screen size of the current device in unity units
        /// x is the width of the device
        /// y is the height of the device
        /// </summary>
        /// <returns></returns>
        public static Vector2 GetScreenSize()
        { 
            var camera = Camera.main;
            if (camera == null) 
            {
                Debug.LogWarning("You need a cemera to perform this action");
                return Vector2.zero;
            }

            return new Vector2(camera.orthographicSize * Screen.width / Screen.height, camera.orthographicSize);
        }

    }
}
