
using UnityEngine;

public class asteroidMotion : MonoBehaviour
{
    
   
    
    

    
    void Update()
    {
        if (asteroidSpawner.asteroidSpeed < asteroidSpawner.asteroidMaxSpeed)
        {
            transform.Translate(new Vector2(0f, -1f) *  asteroidSpawner.asteroidSpeed);
            
        }
        if (asteroidSpawner.asteroidSpeed >= asteroidSpawner.asteroidMaxSpeed)
            transform.Translate(new Vector2(0f, -1f) *asteroidSpawner.asteroidMaxSpeed);

        
    }
}
