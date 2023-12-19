using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//tutorial used: https://www.youtube.com/watch?v=8kVeDbuqokU
public class Menu : MonoBehaviour
{
    public void OnPlayButton()
    {
        Cursor.visible = false;
        SceneManager.LoadScene("Primary");
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }
    public void LoadMenu()
    {

        Time.timeScale = 1f;
        Cursor.visible = true;
        SceneManager.LoadScene("Menu");
    }

    public void Controls()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene("Controls");
    }
}
