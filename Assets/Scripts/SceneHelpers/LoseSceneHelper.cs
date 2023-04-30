using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseSceneHelper : MonoBehaviour
{
    private int _level;
    // Start is called before the first frame update
    void Start()
    {
        _level = PlayerPrefs.GetInt("level");
    }
    public void GoToMainMenu()
    {
        Debug.Log("Go to main menu");
        SceneManager.LoadScene("MainMenu");
    }
    public void GoToLastLevel()
    {
        Debug.Log("Go to last level");
        _levelFound(_level);
    }
    private void _levelFound(int _level)
    {
        if (_level == 1)
        {
            Debug.Log("GoToLevel1");
            SceneManager.LoadScene("Level1");
        }
        if (_level == 2)
        {
            Debug.Log("GoToLevel2");
            SceneManager.LoadScene("Level2");
        }
        if (_level == 3)
        {
            Debug.Log("GoToLevel3");
            SceneManager.LoadScene("Level3");
        }
        if (_level == 4)
        {
            Debug.Log("GoToLevel4");
            SceneManager.LoadScene("Level4");
        }
        if (_level == 5)
        {
            Debug.Log("GoToLevel5");
            SceneManager.LoadScene("Level5");
        }
        if (_level == 6)
        {
            Debug.Log("GoToLevel6");
            SceneManager.LoadScene("Level6");
        }
        else
        {
            Debug.Log("ERROR!!!");
            SceneManager.LoadScene("Main menu");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
