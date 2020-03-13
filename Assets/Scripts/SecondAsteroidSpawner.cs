
using UnityEngine;

public class SecondAsteroidSpawner : MonoBehaviour
{
    public GameObject Asteroid;
    public GameObject rocket;

    private static bool over;

    public float spawningSpeed = 0.8f;
    
    


    void Start()
    {        
        InvokeRepeating("Spawner", 1f, spawningSpeed);        
    }

    void Spawner()
    {
        GameObject go = Instantiate(Asteroid) as GameObject;
        go.transform.position = new Vector2(Random.Range(-2.38f, 2.38f), 6f); 
    }
}
