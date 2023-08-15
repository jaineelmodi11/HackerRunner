using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float timer;

    void Update ()
    {
        timer += 1.0F * Time.deltaTime;
         if (timer >= 0.2)
            {
            GameObject.Destroy(gameObject);
            }
    }
    
    
}
