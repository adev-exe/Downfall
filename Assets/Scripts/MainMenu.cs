using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    
    public void PlayGame()
    {
        Debug.Log("Loading Scene");
        SceneManager.LoadScene(1);
        Debug.Log("Scene Loaded");
        HUD.gas_Collected = 0;
    }
    
    public void PlayGameHard()
    {
        Debug.Log("Loading Scene");
        Lava.speed = Lava.speed * 3;
        SceneManager.LoadScene(1);
        Debug.Log("Scene Loaded");
    }
    
    public void EndGame()
    {
        Application.Quit();
    }

}
