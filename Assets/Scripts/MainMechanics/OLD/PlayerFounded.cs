using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFounded : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private PointDetector _pointDetector;
    private bool _enabled = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {

        }
        if (_pointDetector.Player != null && _enabled)
        {
            if (_pointDetector.Player.GetComponent<FinishPoint>() != null)
            {
                _pointDetector.Player.GetComponent<FinishPoint>().enabled = true;
            }
            if ( _pointDetector.Player.GetComponent<Rotation>() != null)
           {
        /*        _pointDetector.Player.layer = 0;
               _pointDetector.Player.GetComponent<Rotation>().enabled = true;
               _pointDetector.Player.GetComponent<PointDetector>().enabled = true;
             //   _pointDetector.Player.GetComponent<BulletScript>().enabled = true;
                gameObject.GetComponent<PointDetector>().enabled = false;
                gameObject.GetComponent<Rotation>().enabled = false;
                _enabled = false;*/
           }
        }

    }
}
