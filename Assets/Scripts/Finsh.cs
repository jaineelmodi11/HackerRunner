using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finsh : MonoBehaviour
{
    public float Hitpoints;
    public float MaxHitpoints = 10;
    public AudioSource audiosource;
    public AudioClip DeathSound;

    // Start is called before the first frame update
    void Start()
    {
        Hitpoints = MaxHitpoints;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            Hitpoints -= 1;

            if (Hitpoints == 1)
            {
                audiosource.PlayOneShot(DeathSound);
                
            }

            if (Hitpoints <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
                Destroy(gameObject);
                
            }
        }
    }
}
