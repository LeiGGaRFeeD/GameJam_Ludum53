using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBoatSctipt : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private GameObject[] Boats;
    [SerializeField] private int _rotateAngle = 10;
    private int _nowRotate = 0;
    [SerializeField] private int _maxAngle;
    [SerializeField] private GameObject[] _sprites;
    [SerializeField] private bool _negative;
    void Start()
    {
        
    }
    public void RotateRight()
    {
        if (_nowRotate > _maxAngle)
        {
            _nowRotate = 0;

        }
        else
        {
   
        }
        for (int i = 0; i < Boats.Length; i++) {
            if (_negative == true)
            {
                Boats[i].transform.Rotate(0, 0, _rotateAngle);
            }
            else
            {
                Boats[i].transform.Rotate(0, 0, -_rotateAngle);
            }
        }
        _nowRotate += _rotateAngle;
    }
    // Update is called once per frame
    void Update()
    {
        //if (_nowRotate )
    }
}
