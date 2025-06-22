using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CreateObjectButton : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject prefab;
    public void CreateObject()
    {
        FindObjectOfType<CameraController>().CreateObject(prefab);
    }
}
