using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
    ButtonAudio aud;
    private void Awake()
    {
        aud = FindObjectOfType<ButtonAudio>();
        GetComponent<Button>().onClick.AddListener(Click);
    }
    public void Click()
    {
        aud.clickButton.Invoke();
    }
}
