using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootBeam : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform player;

    int remainingBullets;


    private void Start()
    {
         remainingBullets = 2000;
    }

    public void shootBullet()
    {
        if (remainingBullets > 0)
        {
            GameObject go = Instantiate(bulletPrefab) as GameObject;
            go.transform.position = player.transform.position + new Vector3(0f, 1f, -3f);
            remainingBullets--;
        }
    } 

}
