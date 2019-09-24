using UnityEngine;
using System.Collections;

namespace Utility
{
    public static class Utils
    {
        public static Vector3 CopyVector(Vector3 v)
        {
            return new Vector3(v.x, v.y, v.z);
        }
        public static Quaternion CopyQuaternion(Quaternion v)
        {
            return new Quaternion(v.x, v.y, v.z, v.w);
        }

        public static void SetLocalPos(Transform t, Vector3 newpos, Vector3 axis)
        {
            Vector3 oldp = t.localPosition;
            t.localPosition = new Vector3(
                oldp.x * (1-axis.x) + axis.x * newpos.x,
                oldp.y * (1 - axis.y) + axis.y * newpos.y,
                oldp.z * (1 - axis.z) + axis.z * newpos.z);
        }

        
        public static string[] LoadStrings(string fileName)
        {
            string[] strs = System.IO.File.ReadAllLines(fileName);
        

            return strs;
        }


    }

}