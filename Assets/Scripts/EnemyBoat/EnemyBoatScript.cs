using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoatScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
     /*   if (collision.gameObject.GetComponent<BulletScript>() != null)
        {
            Application.LoadLevel(Application.loadedLevel);
        }*/
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Signal>())
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
