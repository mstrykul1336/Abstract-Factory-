using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Log : MonoBehaviour
{
    public TextMeshProUGUI logText;

    void OnEnable()
    {
        Application.logMessageReceived += LogCallback;
    }

    void OnDisable()
    {
        Application.logMessageReceived -= LogCallback;
    }

    void LogCallback(string logString, string stackTrace, LogType type)
    {
        logText.text = logString;
    }
}