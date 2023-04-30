using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPoint : MonoBehaviour
{
    // Start is called before the first frame update
    private Moving _moving;
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Moving>() != null)
        {
            //  collision.gameObject.GetComponent<Moving>()._state
          //  Moving._state = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
