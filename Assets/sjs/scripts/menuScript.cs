using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject levelSelect;
    public GameObject levelselect;
    public GameObject button;
    public List<string> levels;
    public void PressStart()
    {
        startMenu.SetActive(false);
        levelselect.SetActive(true);
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
        SceneManager.LoadScene(levels[level]);
    }

    private void Start()
    {
        Instantiate(button);
    }

}
