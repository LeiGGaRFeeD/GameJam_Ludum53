using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetChange : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _up;
    [SerializeField] private GameObject _down;
    [SerializeField] private GameObject _left;
    [SerializeField] private GameObject _right;
    [SerializeField] private GameObject _parent;
    void Start()
    {
        Checks(0, 90, 1, (int)_parent.transform.eulerAngles.z);
        Checks(90, 180, 2, (int)_parent.transform.eulerAngles.z);
        Checks(180, 270, 3, (int)_parent.transform.eulerAngles.z);
        Checks(270, 360, 4, (int)_parent.transform.eulerAngles.z);
    }

    // Update is called once per frame
    void Update()
    {
        Checks(-1, 89, 1, (int)_parent.transform.eulerAngles.z);
        Checks(89, 180, 2, (int)_parent.transform.eulerAngles.z);
        Checks(179, 270, 3, (int)_parent.transform.eulerAngles.z);
        Checks(269, 360, 4, (int)_parent.transform.eulerAngles.z);

        Debug.Log("Transform by Z: " + _parent.transform.eulerAngles.z);
    }

    private void Checks(int minAngle,int maxAngle,int activePicture,int nowAngle)
    {
        /*  */ if (_parent.transform.eulerAngles.z < maxAngle && _parent.transform.eulerAngles.z > minAngle)
           {
               _up.SetActive(activePicture==1);
               _down.SetActive(activePicture==3);
               _left.SetActive(activePicture==2);
               _right.SetActive(activePicture==4);
           }
      /*  _up.SetActive(nowAngle == 0);
        _down.SetActive(nowAngle == 180);
        _left.SetActive(nowAngle == -90);
        _right.SetActive(nowAngle == 360);
      //  _up.SetActive(nowAngle == 360);*/
    }
}
