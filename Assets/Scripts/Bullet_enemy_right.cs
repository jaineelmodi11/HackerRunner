using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet_enemy_right : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;
    Vector2 mousePos;
    private float nextActionTime = 2.0f;
    public float period = 0.5f;

    // Update is called once per frame
    
    void Update()
    {
      if (Time.time > nextActionTime ) {
        nextActionTime += period;
        Shoot();
    

    }


    void Shoot()
    {
    GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
    rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
    }
}
}