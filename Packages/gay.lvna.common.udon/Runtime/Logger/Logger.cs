
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Logger : UdonSharpBehaviour
{
    [HideInInspector]
    public string Name = "LvnCommon";
    [HideInInspector]
    public string Color = "#ca3bcc";

    string Format(string message, string color)
    {
        return $"[<color={color}>{Name}</color>]: {message}";
    }
    string Format(string message)
    {
        return Format(message, Color);
    }

    public void Log(string message)
    {
        Debug.Log(Format(message));
    }

    public void LogWarning(string message)
    {
        Debug.LogWarning(Format(message, "#bbcc3b"));
    }

    public void LogError(string message)
    {
        Debug.LogError(Format(message, "#cc3b3b"));
    }
}
