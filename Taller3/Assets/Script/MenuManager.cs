  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public int XR
 public void BotonStart()
    {
        SceneManager.LoadScene(XR);
    }
    public void BotonQuit()
    {
   
        Application.Quit();
    }
}
