using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPointV2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int _levelNow;
    private bool _isFinished;
    void Start()
    {
        _levelNow = PlayerPrefs.GetInt("level");
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
    /*    else
        {
            Debug.Log("ERROR!!!");
            SceneManager.LoadScene("MainMenu");
        }*/
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Signal>())
        {
            if (_isFinished == false)
            {
                _levelNow = PlayerPrefs.GetInt("level");
                Debug.Log("Collision works. Target achived");
                _levelNow++;
                PlayerPrefs.SetInt("level", _levelNow);
                InvokeRepeating("Call", 3, 0);
                _isFinished = true;
                //_levelFound(_levelNow);
            }
            if (_isFinished == true)
            {
                Destroy(collision.gameObject);
            }
        }
    }
    private void Call()
    {
        _levelFound(_levelNow);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("_load = "+PlayerPrefs.GetInt("level"));
        
    }
}
