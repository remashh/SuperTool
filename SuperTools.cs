using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Playtika
{
    public static class SuperTools
    {

        public static void AddXPosition(this Transform t, float x)
        {
            t.position += new Vector3(x, 0, 0);
        }
    
    }
}