using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuScript : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject levelselect;
    public List<string> levels;
    public void PressStart()
    {
        startMenu.SetActive(false);
    }
    public void PressOptions()
    {

    }
    public void PressQuit()
    {
        Application.Quit();
    }

    public void SelectLevel(int level)
    {

    }

    private void Start()
    {
       
    }

}
