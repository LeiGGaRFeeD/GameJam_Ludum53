using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarPointTypeFour : MonoBehaviour
{
    [SerializeField] private GameObject _active;
    [SerializeField] private GameObject _disabled;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (RadarSystemNew.ButtonFourActive == 1)
        {
            _active.SetActive(true);
            _disabled.SetActive(false);
        }
        if (RadarSystemNew.ButtonFourActive == 0)
        {
            _active.SetActive(false);
            _disabled.SetActive(true);
        }
    }
}
