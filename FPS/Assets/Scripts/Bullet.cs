using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float life = 3;
   

    void Awake()
    {
        // Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision) {
        //Check against targets and protect map objects
        if(collision.gameObject.tag != "Map" ){
            if(collision.gameObject.tag == "Friendly" ){
                //minus score
                GameManager.instance.Score--;    
                 Destroy(gameObject);
            }
            if(collision.gameObject.tag == "Enemy"){
                GameManager.instance.Score++;
                Destroy(collision.gameObject);
            }
            
        }else{
             Destroy(gameObject);
        }
        
       
    }
}
