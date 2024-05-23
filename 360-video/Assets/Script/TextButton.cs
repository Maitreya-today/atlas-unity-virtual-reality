using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextButton : MonoBehaviour
{
    public GameObject TextBar;
    public void ShowText()
    {
        if (TextBar.activeInHierarchy)
        {
            TextBar.SetActive(false);
        }
        else
        {
            TextBar.SetActive(true);
        }
    }
}
