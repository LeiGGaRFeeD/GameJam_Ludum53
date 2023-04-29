using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private FireGun[] _firePlaces;
    [SerializeField] private Button _button;
    void Start()
    {
        _button.onClick.AddListener(ButtonActive);
    }
    public void ButtonActive()
    {
        for (int i = 0; i < _firePlaces.Length; i++)
        {
          if(  _firePlaces[i].enabled)
            {
                _firePlaces[i].FireNow();
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
