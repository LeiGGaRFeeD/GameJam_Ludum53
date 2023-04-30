using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private GameObject _pauseLogo;
    [SerializeField] private GameObject[] _uiButtons;
    [SerializeField] private GameObject _pauseButton;
    void Start()
    {
        _pauseLogo.SetActive(false);
        Time.timeScale = 1;
    }
    public void PauseActivation()
    {

        if (Time.timeScale == 1)
        {
            _pauseLogo.SetActive(true);
            Time.timeScale = 0;
            for (int i = 0; i < _uiButtons.Length; i++)
            {
                _uiButtons[i].SetActive(false);
            }
            _pauseButton.SetActive(false);
            _pauseLogo.SetActive(true);
        }
    }

    public void DeactivationPause()
    {
        if (Time.timeScale == 0)
        {
            _pauseLogo.SetActive(false);
            Time.timeScale = 1;
            for (int i = 0; i < _uiButtons.Length; i++)
            {
                _uiButtons[i].SetActive(true);
            }
            _pauseButton.SetActive(true);
            _pauseLogo.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
  /*      if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (Time.timeScale == 0)
            {
                _pauseLogo.SetActive(false);
                Time.timeScale = 1;
                for (int i = 0; i < _uiButtons.Length; i++)
                {
                    _uiButtons[i].SetActive(true);
                }
            }
            if (Time.timeScale == 1)
            {
                _pauseLogo.SetActive(true);
                Time.timeScale = 0;
                for (int i = 0; i < _uiButtons.Length; i++)
                {
                    _uiButtons[i].SetActive(false);
                }
            }
        }*/
    }
}
