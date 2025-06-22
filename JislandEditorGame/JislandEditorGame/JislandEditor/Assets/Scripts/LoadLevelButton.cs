using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LoadLevelButton : MonoBehaviour
{
    public TextMeshProUGUI text;

    public void SetLevel()
    {
        FindObjectOfType<SaveLoad>().SetLevel(this);
    }

    public void NewLevel()
    {
        FindObjectOfType<SaveLoad>().NewLevel();
    }
}
