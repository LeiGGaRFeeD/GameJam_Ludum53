using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPoint : MonoBehaviour
{
    // Start is called before the first frame update
    private Moving _moving;
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Moving>())
        {
            //  collision.gameObject.GetComponent<Moving>()._state
          //  Moving._state = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
