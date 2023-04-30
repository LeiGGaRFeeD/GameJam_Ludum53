using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIoffScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject _canvas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.U))
        {
            _canvas.SetActive(false);
            Debug.Log("Canvas deactivated");
        }
        if (Input.GetKeyUp(KeyCode.I))
        {
            _canvas.SetActive(true);
            Debug.Log("Canvas activated");
        }
    }
}
