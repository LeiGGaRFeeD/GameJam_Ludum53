using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalSoundScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private GameObject music;
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Signal>())
        {
            Instantiate(music);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
