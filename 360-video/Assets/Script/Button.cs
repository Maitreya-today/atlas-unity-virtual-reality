using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public void CubeButton()
    {
        SceneManager.LoadScene("Cube");
    }
    public void CantinaButton()
    {
        SceneManager.LoadScene("Cantina");
    }
    public void LivingRoom()
    {
        SceneManager.LoadScene("LivingRoom");
    }
    public void Mezzanine()
    {
        SceneManager.LoadScene("Mezzanine");
    }
}
