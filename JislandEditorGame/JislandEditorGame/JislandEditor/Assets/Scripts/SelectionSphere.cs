using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionSphere : MonoBehaviour
{
    CameraController controller;
    public MeshRenderer render;

    private void Awake()
    {
        controller = FindObjectOfType<CameraController>();
    }
    void Update()
    {
        if (controller.selectedObject != null)
        {
            render.enabled = true;
            transform.position = controller.selectedObject.transform.position;
            transform.localScale = controller.selectedObject.transform.localScale;
        } else
        {
            render.enabled = false;
        }

    }
}
