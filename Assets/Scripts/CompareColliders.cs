using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompareColliders : MonoBehaviour
{

    private Rigidbody playerRB;
    public Settings settingsScript;

  
    // Start is called before the first frame update

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame

    void Update()
    {

        
                
    }

    
    private void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.CompareTag("PowerUp"))
        {
            Destroy(other.gameObject);
            Debug.Log("Player has Power Up!!");
            
        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Debug.Log("Player has collided with enemy*!!");
            settingsScript.EndGame();
            
        }
    }

}
