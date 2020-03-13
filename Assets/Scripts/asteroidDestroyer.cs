
using UnityEngine;

public class asteroidDestroyer : MonoBehaviour
{
    public static int score = 0;
    private void Start()
    {
        score = 0;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Asteroids(Clone)")
        {
            Destroy(col.gameObject);
            score++;
        }
    }
}
