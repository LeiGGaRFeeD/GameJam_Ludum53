using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelResetScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            PlayerPrefs.SetInt("level", 1);
            Debug.Log("LevelCount reseted");
        }
    }
}
