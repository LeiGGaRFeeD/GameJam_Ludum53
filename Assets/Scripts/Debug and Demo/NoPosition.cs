using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoPosition : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _parent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = _parent.transform.position;
    }
}
