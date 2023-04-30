using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTracer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            Debug.Log("Go to level1");
            SceneManager.LoadScene("Level1");
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            Debug.Log("Go to level2");
            SceneManager.LoadScene("Level2");
        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            Debug.Log("Go to level3");
            SceneManager.LoadScene("Level3");
        }
        if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            Debug.Log("Go to level4");
            SceneManager.LoadScene("Level4");
        }
        if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            Debug.Log("Go to level5");
            SceneManager.LoadScene("Level5");
        }
        if (Input.GetKeyUp(KeyCode.Alpha6))
        {
            Debug.Log("Go to level6");
            SceneManager.LoadScene("Level6");
        }
        if (Input.GetKeyUp(KeyCode.Alpha0))
        {
            Debug.Log("Go to level0");
            SceneManager.LoadScene("MainMenu");
        }
        if (Input.GetKeyUp(KeyCode.Alpha7))
        {
            Debug.Log("Go to finished scene");
            SceneManager.LoadScene("Finished");
        }
        if (Input.GetKeyUp(KeyCode.Alpha8))
        {
            Debug.Log("Go to StartComics");
            SceneManager.LoadScene("StartComics");
        }
    }
}
