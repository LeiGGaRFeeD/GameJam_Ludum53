using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LoseSceneGoer : MonoBehaviour
{
    // Start is called before the first frame update
   // [SerializeField] private Button _fireButton;
    [SerializeField] private Button[] _activeDownButtons;
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
      //  if (collision.GetComponent<Signal>())
        {
        //    Debug.Log("You lose!");
         //   SceneManager.LoadScene("LoseScene");
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Signal>() != null)
        {
            /*  Debug.Log("You lose!");
              SceneManager.LoadScene("LoseScene");*/
           // Time.timeScale = 0;
            Destroy(other.gameObject);
            for (int i = 0; i < _activeDownButtons.Length; i++)
            {
                _activeDownButtons[i].enabled = false;
            }
            InvokeRepeating("LoseSceneDelayerd", 2.5f,0);
        }
    }
    public void LoseSceneDelayerd()
    {
        Debug.Log("You lose!");
        SceneManager.LoadScene("LoseScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
