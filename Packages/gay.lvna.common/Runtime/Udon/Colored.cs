﻿
using UdonSharp;
using UnityEngine;

namespace gay.lvna.common.udon
{
    public class Colored : UdonSharpBehaviour
    {
        public static string C(string text, string color)
        {
            return "<color=" + color + ">" + text + "</color>";
        }

        public static string C(string text, Color32 color)
        {
            return "<color=#" + ColorUtility.ToHtmlStringRGB(color) + ">" + text + "</color>";
        }
    }
}