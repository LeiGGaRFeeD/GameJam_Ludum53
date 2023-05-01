using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDisabler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Button _fireButton;
    [SerializeField] private Button[] _rotateButton;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale > 0)
        {
            _fireButton.interactable = true;
            for (int i = 0; i < _rotateButton.Length; i++)
            {
                _rotateButton[i].interactable = true;
            }
        }
        if (Time.timeScale == 0)
        {
            _fireButton.interactable = false;
            for (int i = 0; i < _rotateButton.Length; i++)
            {
                _rotateButton[i].interactable = false;
            }
        }
    }
}
