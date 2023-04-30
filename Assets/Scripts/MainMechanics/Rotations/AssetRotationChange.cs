using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetRotationChange : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _up;
    [SerializeField] private GameObject _down;
    [SerializeField] private GameObject _left;
    [SerializeField] private GameObject _right;
    [SerializeField] private GameObject _rotationOriginal;

    void Start()
    {
        
    }
    private void AngleSpriteChange()
    {

    }
    // Update is called once per frame
    void Update()
    {
      //  _up.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
