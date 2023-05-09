using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ButtonOneChangeA()
    {
        //   RadarSystemNew.chosedButton = 1;
        RadarSystemNew.ButtonOneActive = 1;
        RadarSystemNew.ButtonTwoActive = 0;
        RadarSystemNew.ButtonThreeActive = 0;
        RadarSystemNew.ButtonFourActive = 0;
    }
    public void ButtonTwoChangeA()
    {
        //   RadarSystemNew.chosedButton = 2;
        // RadarSystemNew.ButtonOneActive = 2;
        RadarSystemNew.ButtonOneActive = 0;
        RadarSystemNew.ButtonTwoActive = 1;
        RadarSystemNew.ButtonThreeActive = 0;
        RadarSystemNew.ButtonFourActive = 0;
    }
    public void ButtonThreeChangeA()
    {
        //  RadarSystemNew.chosedButton = 3;
       // RadarSystemNew.ButtonOneActive = 3;
        RadarSystemNew.ButtonOneActive = 0;
        RadarSystemNew.ButtonTwoActive = 0;
        RadarSystemNew.ButtonThreeActive = 1;
        RadarSystemNew.ButtonFourActive = 0;
    }
    public void ButtonFourChangeA()
    {
        //  RadarSystemNew.chosedButton = 4;
      //  RadarSystemNew.ButtonOneActive = 4;
        RadarSystemNew.ButtonOneActive = 0;
        RadarSystemNew.ButtonTwoActive = 0;
        RadarSystemNew.ButtonThreeActive = 0;
        RadarSystemNew.ButtonFourActive = 1;
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Button active one: "+RadarSystemNew.ButtonOneActive);
        Debug.Log("Button active two: " + RadarSystemNew.ButtonTwoActive);

    }
}
