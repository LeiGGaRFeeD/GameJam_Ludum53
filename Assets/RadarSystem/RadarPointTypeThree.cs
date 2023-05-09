using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarPointTypeThree : MonoBehaviour
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
        if (RadarSystemNew.ButtonThreeActive == 1)
        {
            _active.SetActive(true);
            _disabled.SetActive(false);
        }
        if (RadarSystemNew.ButtonThreeActive == 0)
        {
            _active.SetActive(false);
            _disabled.SetActive(true);
        }
    }
}
