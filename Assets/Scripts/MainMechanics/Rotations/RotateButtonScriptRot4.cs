using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateButtonScriptRot4 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private GameObject[] _cellTypeOne;
    [SerializeField] private int _rotateAngle = 10;
    private int _nowRotate = 0;
    [SerializeField] private int _maxAngle;
    void Start()
    {
        
    }
    public void RotateRight()
    {
        if (_nowRotate > _maxAngle)
        {
            _nowRotate = 0;
            for (int i = 0; i < _cellTypeOne.Length; i++)
            {

             //   _cellTypeOne[i].transform.Rotate(0, 0,( _rotateAngle-_maxAngle));
            }
        }
        else
        {
   
        }
        for (int i = 0; i < _cellTypeOne.Length; i++) {
            if (i % 2 == 0)
            {
                _cellTypeOne[i].transform.Rotate(0, 0, _rotateAngle);
            }
            else
            {
                _cellTypeOne[i].transform.Rotate(0, 0, -_rotateAngle);
            }
        }
        _nowRotate += _rotateAngle;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
