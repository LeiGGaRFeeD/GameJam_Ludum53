using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject _soundOfButton;
    void Start()
    {
        
    }
    public void CreateSound()
    {
        Instantiate(_soundOfButton,gameObject.transform.position,gameObject.transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
