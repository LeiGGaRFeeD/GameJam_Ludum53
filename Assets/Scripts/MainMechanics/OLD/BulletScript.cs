using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private int _speed;
    private FireGun _firegun;
    public FireGun Firegun { set=>_firegun=value; }
  //  [SerializeField] private GameObject _effect;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Bang!");
    /*    if (collision.gameObject.GetComponent<PointDetector>() != null)
        {
          //  gameObject.GetComponent<PointDetector>().enabled = false;
          _firegun.enabled = false;
            collision.gameObject.GetComponent<FireGun>().enabled = true;
            collision.gameObject.GetComponent<PointDetector>().enabled = true;
            Destroy(gameObject);
        }*/
    if (collision.gameObject.GetComponent<FireGun>() != null)
        {
            collision.gameObject.GetComponent<FireGun>().enabled = true;
            _firegun.enabled = false;
            Destroy(gameObject);
        }
        if (collision.gameObject.GetComponent<FinishPoint>() != null)
        {
            collision.gameObject.GetComponent<FinishPoint>().enabled = true;
            _firegun.enabled = false;
            Destroy(gameObject);
        }


    }
    //   private void OnCollisionEnter2D(Collision2D col)
    //   {
    /*
    //if (col.gameObject.GetComponent<PlayerControl>() == false)
    //{

    Debug.Log("Touched!");
    gameObject.GetComponent<SpriteRenderer>().enabled = false;
    gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
    _speed = 0;
    Instantiate(_effect, gameObject.transform);



    gameObject.GetComponent<Collider2D>().enabled = false;
    InvokeRepeating("DestriyThis", 0.0f, 0);

              // Destroy(gameObject);
    // }
    */
    // }

    public void DestriyThis()
    {
        Destroy(gameObject);

    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{

    // }
    // Update is called once per frame
    void Update()
    {
        rb.velocity =  transform.up * _speed * Time.deltaTime;

    }
}
