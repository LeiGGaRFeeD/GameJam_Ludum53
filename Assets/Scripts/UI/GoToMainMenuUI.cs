using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMainMenuUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.M))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
