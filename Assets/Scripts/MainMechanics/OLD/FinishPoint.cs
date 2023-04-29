using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<BulletScript>())
        {
            Debug.Log("Finished");
            SceneManager.LoadScene("Finished");
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
