using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private GameObject[] _cellTypeOne;
    [SerializeField] private int _rotateAngle = 10;
    private int _nowRotate = 0;
    [SerializeField] private int _maxAngle;
  //  [SerializeField] private GameObject[] _sprites;
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
                _cellTypeOne[i].transform.Rotate(0, 0, (_rotateAngle - _maxAngle));
            }
        }
        else
        {
            _nowRotate += _rotateAngle;
        }
        for (int i = 0; i < _cellTypeOne.Length; i++) {
            _cellTypeOne[i].transform.Rotate(0, 0, _rotateAngle);
        }
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("_nowRotate is "+_nowRotate);
        if (gameObject.transform.rotation.z >30)
        {
            Debug.Log("More 30");
        }
        Debug.Log("Rotattion Transform" + transform.rotation.z);
        
       //     gameObject.SetActive(false);
        
    }
}
