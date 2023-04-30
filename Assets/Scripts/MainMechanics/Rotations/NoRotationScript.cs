using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoRotationScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform _transform;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        //gameObject.transform.rotation = _transform.rotation;
    }
}
