using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _firePoint;
    void Start()
    {
     //   Instantiate(_bullet, _firePoint.position,_firePoint.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_bullet, _firePoint.position, _firePoint.rotation);
        }
    }
}
