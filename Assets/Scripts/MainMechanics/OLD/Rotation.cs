using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

            if (Input.GetKey(KeyCode.A))
                transform.rotation *= Quaternion.Euler(0f, 0f, -50f * Time.deltaTime);
            if (Input.GetKey(KeyCode.D))
                transform.rotation *= Quaternion.Euler(0f, 0f, 50f * Time.deltaTime);
        
    }
}
