
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionChecker : MonoBehaviour
{
    public Collider2D collision;
    public Rigidbody2D rb;
    public static bool isOver;
    void Start()
    {
        isOver = false;
    }
    public void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Asteroid")
        {
            
            
            rb.isKinematic = true;
            isOver = true;
            SceneManager.LoadScene(2);

            
        }
    }


}
