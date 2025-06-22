using RuntimeGizmos;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CameraController : MonoBehaviour
{
    public UnityEvent onDelete;
    public UnityEvent onDuplicate;
    [Header("References")]
    public GameObject ctrlHToggle;
    public GameObject gizmoEnableCopy;
    public TransformGizmo gizmo;
    public GameObject[] createActive;
    public Camera cam;
    public LayerMask gizmos;
    public LayerMask objects;
    [Header("Prefs")]
    public float MoveSpeed;
    float moveMultiplier;
    [Header("Exposed")]
    public Transform selectedGizmo;
    public Transform selectedObject;
    SaveLoad load;


    private void Awake()
    {
        load = FindObjectOfType<SaveLoad>();
    }

    public bool Gizmoing()
    {
        return Input.GetKey("t") || Input.GetKey(KeyCode.LeftShift);
    }


    public void CreateObject(GameObject obj)
    {
        GameObject prefab = Instantiate(obj);
        prefab.AddComponent<MeshCollider>().sharedMesh = prefab.GetComponent<MeshFilter>().sharedMesh;
        prefab.transform.parent = null;
        Physics.Raycast(cam.transform.position, cam.transform.forward, out RaycastHit hit, 50, objects);
        if (hit.distance > 0)
        {
            prefab.transform.position = hit.point;
        } else
        {
            prefab.transform.position = cam.transform.position + (cam.transform.forward * 15f);
        }
    }
    void Update()
    {
        gizmo.enabled = !gizmoEnableCopy.activeSelf;
        foreach(GameObject obj in createActive) obj.SetActive(!gizmoEnableCopy.activeSelf);

        if (Input.GetMouseButton(1))
        {
            //gizmo.enabled = false;
            Cursor.lockState = CursorLockMode.Locked;
            cam.transform.eulerAngles += new Vector3(Input.GetAxis("Mouse Y") * -1, Input.GetAxis("Mouse X"), 0);

            Vector3 movement = Vector3.zero;
            if (Input.GetKey("w")) movement += Vector3.forward;
            if (Input.GetKey("a")) movement += Vector3.left;
            if (Input.GetKey("s")) movement += Vector3.back;
            if (Input.GetKey("d")) movement += Vector3.right;
            movement.Normalize();
            float multiplier = 1;
            if (Input.GetKey(KeyCode.LeftShift)) multiplier = 2;
            cam.transform.Translate(movement * Time.deltaTime * MoveSpeed * moveMultiplier * multiplier);
            if (movement.magnitude != 0)
            {
                moveMultiplier += Time.deltaTime * 10;
            } else
            {
                moveMultiplier = 1;
            }
            selectedGizmo = null;
        } else
        {
            //gizmo.enabled = true;
            Cursor.lockState = CursorLockMode.None;
            //if (!Input.GetMouseButton(0) && Gizmoing())
            //{
            //    Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            //    Physics.Raycast(ray, out RaycastHit gizmosHit, Mathf.Infinity, gizmos);
            //    selectedGizmo = null;
            //    if (gizmosHit.distance != 0)
            //    {
            //        if (gizmosHit.collider != null) selectedGizmo = gizmosHit.collider.transform;
            //    }
            //}
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, objects);
                selectedObject = null;
                if (hit.distance != 0)
                {
                    if (hit.collider != null) selectedObject = hit.collider.transform;
                }
            }
            if (Input.GetKeyDown(KeyCode.Delete) && gizmo.mainTargetRoot != null)
            {
                load.SavedLevel = false;
                Destroy(gizmo.mainTargetRoot.gameObject);
                gizmo.ClearTargets();
                onDelete.Invoke();
            }
            if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
            {
                if (Input.GetKeyDown(KeyCode.F) && gizmo.mainTargetRoot != null)
                {
                    Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                    Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, objects);
                    if (hit.distance > 0)
                    {
                        load.SavedLevel = false;
                        Transform target = gizmo.mainTargetRoot.transform;
                        target.position = hit.point;
                        target.rotation = Quaternion.LookRotation(hit.normal, Vector3.up);
                        target.Rotate(90, 0, 0);
                    }
                }
                if (Input.GetKeyDown(KeyCode.H)) ctrlHToggle.SetActive(!ctrlHToggle.activeSelf);
                if (Input.GetKeyDown(KeyCode.D) && gizmo.mainTargetRoot != null)
                {
                    load.SavedLevel = false;
                    Transform newTarget = Instantiate(gizmo.mainTargetRoot.gameObject).transform;
                    gizmo.ClearTargets();
                    gizmo.AddTarget(newTarget);
                    onDuplicate.Invoke();
                }
                if (Input.GetKeyDown(KeyCode.R) && gizmo.mainTargetRoot != null)
                {
                    load.SavedLevel = false;
                    gizmo.mainTargetRoot.transform.localScale = Vector3.one;
                    gizmo.mainTargetRoot.transform.rotation = Quaternion.identity;
                }
            }

        }
    }
}
