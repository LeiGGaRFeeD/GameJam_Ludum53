using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCreator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject _sound;
    void Start()
    {
        
    }
    public void CreateSound()
    {
        Instantiate(_sound,gameObject.transform.position,gameObject.transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
