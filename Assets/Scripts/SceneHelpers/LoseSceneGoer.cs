using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoseSceneGoer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
      //  if (collision.GetComponent<Signal>())
        {
        //    Debug.Log("You lose!");
         //   SceneManager.LoadScene("LoseScene");
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Signal>() != null)
        {
            Debug.Log("You lose!");
            SceneManager.LoadScene("LoseScene");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
