using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public string WEB_URL = "";

    // Start is called before the first frame update
    void Start()
    {
        //  StartCoroutine(RestClient.Instance.Get(WEB_URL, GetLegendas));

        StartCoroutine(RestClient.Instance.Post(WEB_URL, GetEvent, new Event {
            Action = "lookAt",
            Interface = "999",
            Value = "987",
        }));
    }

    void GetEvent(EventList events)
    {
        foreach(Event serviceEvent in events.Events)
        {
            Debug.Log("Action: " + serviceEvent.Action);
            Debug.Log("Interface: " + serviceEvent.Interface);
            Debug.Log("Value: " + serviceEvent.Value);
        }
    }
}
