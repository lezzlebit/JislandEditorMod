using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EditorTransformGizmo : MonoBehaviour
{
    CameraController controller;
    [Header("Exposed")]
    public Transform selected;
    public TransformAxis moving;

    [Header("References")]
    public Transform cameraView;
    public Transform cameraViewIndicator;
    public Transform flipper;
    public Transform visual;
    public TransformAxis[] axes;
    public GameObject[] planes;
    public LayerMask planesMask;
    Vector3 startDrag;
    Vector3 startPosition;
    bool Dragging;
    private void Awake()
    {
        controller = FindObjectOfType<CameraController>();
    }
    void Update()
    {
        cameraView.transform.rotation = controller.cam.transform.rotation;
        selected = controller.selectedObject;
        cameraViewIndicator.gameObject.SetActive(Input.GetKey(KeyCode.LeftShift));
        if (selected != null && (Input.GetKey("t") || Input.GetKey(KeyCode.LeftShift) && !Input.GetMouseButton(1)))
        {
            flipper.gameObject.SetActive(true);
        }
        else
        {
            flipper.gameObject.SetActive(false);
        }
        foreach(GameObject b in planes) b.SetActive(false);
        if (Input.GetMouseButton(0) && selected != null)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                flipper.transform.localScale = Vector3.one;
                moving = axes[0];
                cameraView.gameObject.SetActive(true);
                Ray ray = controller.cam.ScreenPointToRay(Input.mousePosition);
                Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, planesMask);
                selected.transform.position = hit.point;
            } else
            {
                if (controller.selectedGizmo != null)
                {
                    foreach (TransformAxis a in axes)
                    {
                        if (a.transform == controller.selectedGizmo)
                        {
                            moving = a;
                            foreach (GameObject b in a.planes) b.SetActive(true);
                            Ray ray = controller.cam.ScreenPointToRay(Input.mousePosition);
                            Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, planesMask);
                            if (hit.distance > 0)
                            {
                                if (!Dragging)
                                {
                                    startPosition = a.transform.position;
                                    Dragging = true;
                                    startDrag = hit.point;
                                }
                                Debug.Log(hit.point);
                                a.transform.position = startPosition + (hit.point - startDrag);
                                Vector3 l = a.transform.localPosition;
                                a.transform.localPosition = new Vector3(l.x * a.axis.x, l.y * a.axis.y, l.z * a.axis.z);
                                selected.transform.position = a.transform.position;
                            }
                        }
                    }
                }
            }
        } else
        {
            Vector3 localCam = transform.InverseTransformPoint(controller.cam.transform.position);
            Debug.Log(localCam);
            flipper.transform.localScale = new Vector3(Mathf.Sign(localCam.x) * -1, Mathf.Sign(localCam.y), Mathf.Sign(localCam.z) * -1);
            moving = null;
            foreach (TransformAxis a in axes) a.transform.localPosition = Vector3.zero;
            Dragging = false;
            if (selected != null) transform.position = selected.position;
        }
        if (selected != null) visual.position = selected.position;
        cameraViewIndicator.transform.rotation = controller.cam.transform.rotation;


    }
}
