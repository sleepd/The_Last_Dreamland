using UnityEngine;
using UnityEngine.Timeline;

[System.Serializable]
[CustomStyle("SignalWithParameter")]
public class SignalWithParameter : SignalEmitter
{
    public string message;
}