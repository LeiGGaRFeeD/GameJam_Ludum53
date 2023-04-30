using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DEMO_GoToFinish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Signal>())
        {
            Debug.Log("Go to finish scene");
            SceneManager.LoadScene("Finished");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
