using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy_Ash : MonoBehaviour
{


    // Start is called before the first frame update

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Application.LoadLevel(Application.loadedLevel);
        }
   
    }
}
