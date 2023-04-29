using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private BulletScript _bullet;
    [SerializeField] private Transform _firePlace;
    void Start()
    {
        
    }
    public void FireNow()
    {
        Debug.Log("Go!");
        
       Instantiate(_bullet, _firePlace.position,_firePlace.rotation).Firegun = this;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
