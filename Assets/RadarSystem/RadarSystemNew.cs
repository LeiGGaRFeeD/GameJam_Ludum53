using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarSystemNew : MonoBehaviour
{
    // public static int chosedButton;
      [SerializeField] private GameObject _buttonOne;
     [SerializeField] private GameObject _buttonTwo;
     [SerializeField] private GameObject _buttonThree;
     [SerializeField] private GameObject _buttonFour;
    // Start is called before the first frame update
    public static int ButtonOneActive;
    public static int ButtonTwoActive;
    public static int ButtonThreeActive;
    public static int ButtonFourActive;
    void Start()
    {
   /*  if (chosedButton != 1)
        {
            chosedButton = 1;
        }   */
    }
    /*  public void ButtonChecker()
      {
          if (chosedButton == 1)
          {
              _buttonOne.SetActive(true);
              _buttonTwo.SetActive(false);
              _buttonThree.SetActive(false);
              _buttonFour.SetActive(false);
          }
          if (chosedButton == 2)
          {
              _buttonOne.SetActive(false);
              _buttonTwo.SetActive(true);
              _buttonThree.SetActive(false);
              _buttonFour.SetActive(false);
          }
          if (chosedButton == 3)
          {
              _buttonOne.SetActive(false);
              _buttonTwo.SetActive(false);
              _buttonThree.SetActive(true);
              _buttonFour.SetActive(false);
          }
          if (chosedButton == 4)
          {
              _buttonOne.SetActive(true);
              _buttonTwo.SetActive(false);
              _buttonThree.SetActive(false);
              _buttonFour.SetActive(true);
          }
      }

        // ButtonChecker();
         if (ButtonOneActive == 1)
          {
              _buttonOne.SetActive(true);
              _buttonTwo.SetActive(false);
              _buttonThree.SetActive(false);
              _buttonFour.SetActive(false);
          }
          if (ButtonOneActive == 2)
          {
              _buttonOne.SetActive(false);
              _buttonTwo.SetActive(true);
              _buttonThree.SetActive(false);
              _buttonFour.SetActive(false);
          }
          if (ButtonOneActive == 3)
          {
              _buttonOne.SetActive(false);
              _buttonTwo.SetActive(false);
              _buttonThree.SetActive(true);
              _buttonFour.SetActive(false);
          }
          if (ButtonOneActive == 4)
          {
              _buttonOne.SetActive(false);
              _buttonTwo.SetActive(false);
              _buttonThree.SetActive(false);
              _buttonFour.SetActive(true);
          }
   */
    // Update is called once per frame
    void Update()
    {
     
    }
}
