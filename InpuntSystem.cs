
using UnityEngine;

namespace CGLabUtils.InpuntSystem
{
    public class InpuntSystem 
    {
        public static Vector2 Axis
        {
            get => new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }
    }
}
