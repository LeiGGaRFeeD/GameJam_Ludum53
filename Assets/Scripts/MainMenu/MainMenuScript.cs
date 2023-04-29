using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void MainPlayButton()
    {
        Debug.Log("Play button pressed");
        SceneManager.LoadScene("SampleLevelV2");
    }
    public void MainMenuButton()
    {
        Debug.Log("Main menu button pressed");
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitFromGame()
    {
        Debug.Log("Quit from application pressed");
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
