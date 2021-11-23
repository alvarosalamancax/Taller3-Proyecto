using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
 public void BotonStart()
    {
        SceneManager.LoadScene("XR");
    }
    public void BotonQuit()
    {
        Debug.Log("Quitamos la aplicacion");
        Application.Quit();
    }
}
