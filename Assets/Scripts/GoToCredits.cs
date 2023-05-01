using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToCredits : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void AskForCredits()
    {
    //    Instantiate(_audioSource,gameObject.transform.position,gameObject.transform.rotation);
        InvokeRepeating("SceneGoer", 0.6f, 0);
    }
    private void SceneGoer()
    {
        SceneManager.LoadScene("Credits");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
