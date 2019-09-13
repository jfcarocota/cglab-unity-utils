
using UnityEngine;

namespace CGLabUtils.InpuntSystem
{
    public class InpuntSystem 
    {
        ///<summary>
        ///This functions returns the vector2 Axis direction.
        ///</summary>
        public static Vector2 Axis
        {
            get => new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }
    }
}
