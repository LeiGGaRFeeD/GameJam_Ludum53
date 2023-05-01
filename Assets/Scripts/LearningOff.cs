using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningOff : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _learningObj;
    void Start()
    {
        
    }
    public void OffLearn()
    {
        _learningObj.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
