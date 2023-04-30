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
        Checks(0, 90, 1);
        Checks(90, 180, 2);
        Checks(180, 270, 3);
        Checks(270, 360, 4);
    }

    // Update is called once per frame
    void Update()
    {
        Checks(0, 90, 1);
        Checks(90, 180, 2);
        Checks(180, 270, 3);
        Checks(270, 360, 4);

        Debug.Log("Transform by Z: " + _parent.transform.eulerAngles.z);
    }

    private void Checks(int minAngle,int maxAngle,int activePicture)
    {
        if (_parent.transform.eulerAngles.z < maxAngle && _parent.transform.eulerAngles.z > minAngle)
        {
            _up.SetActive(activePicture==1);
            _down.SetActive(activePicture==2);
            _left.SetActive(activePicture==3);
            _right.SetActive(activePicture==4);
        }
    }
}
