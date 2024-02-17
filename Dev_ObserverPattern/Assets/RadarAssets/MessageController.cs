using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MessageController : MonoBehaviour
{
    TextMeshProUGUI message;

    private void Start()
    {
        message = GetComponent<TextMeshProUGUI>();
        message.enabled = false;
    }
    public void ShowMessage(GameObject go)
    {
        message.text = "You picked up an item";
        message.enabled = true;

        Invoke("HideMessage",2f);
    }

    public void HideMessage()
    {
        message.enabled = false;
    }
}
