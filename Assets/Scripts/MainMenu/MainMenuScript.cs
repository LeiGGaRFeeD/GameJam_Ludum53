using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private AudioSource _audioSource;
    void Start()
    {
        if (PlayerPrefs.GetInt("level") == 0 || PlayerPrefs.GetInt("level") == null)
        {
            PlayerPrefs.SetInt("level",1);
        }
    }
    public void MainPlayButton()
    {

        InvokeRepeating("GoToPlay", 0.4f, 0);
    }
    private void GoToPlay()
    {
        //    _audioSource.Play();
        Debug.Log("Play button pressed");
        PlayerPrefs.SetInt("level", 1);
        //  SceneManager.LoadScene("SampleLevelV2");
        SceneManager.LoadScene("StartComics");
    }
    public void MainMenuButton()
    {
    //    _audioSource.Play();
        Debug.Log("Main menu button pressed");
        PlayerPrefs.SetInt("level", 1);
        Debug.Log("Level counter reseted");
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitFromGame()
    {
        InvokeRepeating("GoTouit", 0.4f, 0);
    }
    private void GoToQuit()
    {
        Debug.Log("Quit from application pressed");
        Application.Quit();
    }
    public
    // Update is called once per frame
    void Update()
    {
        
    }
}
