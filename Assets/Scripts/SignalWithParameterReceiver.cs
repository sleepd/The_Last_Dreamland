using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class SignalWithParameterReceiver : MonoBehaviour, INotificationReceiver
{
    [SerializeField] Text text;
    
    public void OnNotify(Playable origin, INotification notification, object context)
    {
        if (notification is SignalWithParameter signal)
        {
            Debug.Log($"Signal received! message={signal.message}");
            HandleSignal(signal.message);
        }
    }

    void HandleSignal(string msg)
    {
        text.text = msg;
    }
}