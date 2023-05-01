using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandStopperScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Signal>())
        {
            Debug.Log("Signal destroyed!");
            Destroy(collision.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
