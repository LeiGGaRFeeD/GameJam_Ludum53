using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameUIScript : MonoBehaviour
{
    // Start is called before the first frame update
    private int _uiButton;
    [SerializeField] private GameObject _onlyLeft;
    [SerializeField] private GameObject _onlyRight;
    [SerializeField] private GameObject _onlyMixed;
    [SerializeField] private GameObject _onlyStartBoat;
    [SerializeField] private GameObject _redLineOne;
    [SerializeField] private GameObject _redLineTwo;
    [SerializeField] private GameObject _redLineThree;
    [SerializeField] private GameObject _redLineFour;
    private int _lastPressed;
    void Start()
    {
        Changing(1);
        if (Time.timeScale == 1)
        {
            if (_lastPressed == 1)
            {
                ButtonForLeft();
            }
            if (_lastPressed == 2)
            {
                ButtonForRight();
            }
            if (_lastPressed == 3)
            {
                ButtonForMixed();
            }
            if (_lastPressed == 4)
            {
                ButtonStartBoat();
            }
        }
    }
    void Changing(int _state)
    {
        _onlyLeft.SetActive(_state==1);
        _onlyRight.SetActive(_state==2);
        _onlyMixed.SetActive(_state==3);
        _onlyStartBoat.SetActive(_state==4);
        _redLineOne.SetActive(_state==1);
        _redLineTwo.SetActive(_state==2);
        _redLineThree.SetActive(_state==3);
        _redLineFour.SetActive(_state==4);
    }
    public void ButtonForLeft()
    {
        Changing(1);
        _lastPressed = 1;
    }
    public void ButtonForRight()
    {
        Changing(2);
        _lastPressed = 2;
    }
    public void ButtonForMixed()
    {
        Changing(3);
        _lastPressed = 3;
    }
    public void ButtonStartBoat()
    {
        Changing(4);
        _lastPressed = 4;
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
            if (_lastPressed == 1)
            {
                ButtonForLeft();
            }
            if (_lastPressed == 2)
            {
                ButtonForRight();
            }
            if (_lastPressed == 3)
            {
                ButtonForMixed();
            }
            if (_lastPressed == 4)
            {
                ButtonStartBoat();
            }
        }
    }
}
