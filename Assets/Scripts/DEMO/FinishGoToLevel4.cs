using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishGoToLevel4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Signal>())
        {
            Debug.Log("GoToLevel 4");
            SceneManager.LoadScene("Level4");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
