
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using gay.lvna.common.udon.extensions;
public class Test : UdonSharpBehaviour
{
    void Start()
    {
        string[] arr = new string[] { "a", "b", "c" };

        arr = arr.Add("d");

        Debug.Log(arr[3]);
    }
}
