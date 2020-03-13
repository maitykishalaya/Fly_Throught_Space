
using UnityEngine;

public class moveForward : MonoBehaviour
{
    public float speed = 50.0f;
    private Rigidbody2D rb;
    

    public GameObject explosion;

   
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.y));
    }

    
    void Update()
    {
        if (rb.transform.position.y > 5.36f)
        {
            Destroy(this.gameObject);
        }
    }
   

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Asteroids(Clone)")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
    }
}