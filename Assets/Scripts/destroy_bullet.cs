using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_bullet : MonoBehaviour
{
 

    public float timer;

    void Update ()
    {
        timer += 1.0F * Time.deltaTime;
         if (timer >= 0.15)
            {
            GameObject.Destroy(this.gameObject);
            }
    }
}
