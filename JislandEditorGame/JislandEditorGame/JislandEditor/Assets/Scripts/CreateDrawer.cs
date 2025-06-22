using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateDrawer : MonoBehaviour
{
    public RectTransform rect;
    public bool Open = true;
    float OpenAmount = 0;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) Open = !Open;
        if (Open) OpenAmount = Mathf.MoveTowards(OpenAmount, 100, Time.deltaTime * 1000);
        if (!Open) OpenAmount = Mathf.MoveTowards(OpenAmount, -100, Time.deltaTime * 1000);
        rect.anchoredPosition = new Vector2(OpenAmount, rect.anchoredPosition.y);
    }
}
