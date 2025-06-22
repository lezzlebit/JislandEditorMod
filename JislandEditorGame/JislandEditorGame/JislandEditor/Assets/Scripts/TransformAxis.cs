using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformAxis : MonoBehaviour
{
    CameraController controller;
    EditorTransformGizmo gizmo;
    private void Awake()
    {
        gizmo = FindObjectOfType<EditorTransformGizmo>();
        controller = FindObjectOfType<CameraController>();
    }

    public GameObject[] planes;
    public Vector3 axis;
    public MeshRenderer visual;

    public void Update()
    {
        if (gizmo.moving != null)
        {
            if (gizmo.moving == this)
            {
                visual.enabled = true;
            } else
            {
                visual.enabled = false;
            }
        } else
        {
            visual.enabled = true;
        }
        if (Input.GetKey(KeyCode.LeftShift)) visual.enabled = false;
        visual.material.SetFloat("_Highlight", 0);
        if (controller.selectedGizmo == this.transform)
        {
            visual.material.SetFloat("_Highlight", 1);
        } 
    }
}
