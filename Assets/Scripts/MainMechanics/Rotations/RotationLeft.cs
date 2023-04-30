using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationLeft : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int _deepOfRotation;

    void Start()
    {
        
    }
    public void LeftRotation()
    {
        transform.rotation *= Quaternion.Euler(0f, 0f, _deepOfRotation);
        PlayerPrefs.SetInt("do", (PlayerPrefs.GetInt("do" + 1)));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
