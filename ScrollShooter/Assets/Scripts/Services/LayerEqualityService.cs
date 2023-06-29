using UnityEngine;

namespace Service
{
    public class LayerEqualityService
    {
        public static bool Equal(int layerIndex, LayerMask layerMask) =>
            layerIndex == (int)Mathf.Log(layerMask.value, 2);
    }
}