using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComicsHelper : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _text;
    void Start()
    {
        InvokeRepeating("TextOff", 1.5f, 0);
    }
    private void TextOff()
    {
        _text.SetActive(false);
        Debug.Log("Text is off");
    }
    public void GoToLevelOne()
    {
        Debug.Log("Going to level one");
        SceneManager.LoadScene("Level1");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
