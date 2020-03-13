
using UnityEngine;

public class asteroidSpawner : MonoBehaviour
{
    public GameObject Asteroid;
    public GameObject rocket;
    public static  float asteroidSpeed = 0.12f;
    public static float asteroidMaxSpeed = 0.25f;
   

    public float spawningSpeed = 1f;
    
    Vector2 rocketPosition;
    

    void Start()
    {
        asteroidSpeed = 0.08f;
        InvokeRepeating("Spawner", 2f, spawningSpeed);
        
    }
    
    void Spawner()
    {
        
      


            

            GameObject go = Instantiate(Asteroid) as GameObject;
            
            go.transform.position = new Vector2(Random.Range(rocketPosition.x - 0.1f, rocketPosition.x + 0.1f), 6f);
            


        

    }
    void Update()
    {
        rocketPosition = rocket.transform.position;
        asteroidSpeed = asteroidSpeed + 0.00005f;
        Debug.Log(asteroidSpeed);

    }



}
