using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectRestart : MonoBehaviour
{
    // Start is called before the first frame update
   

    // Update is called once per frame
    
        private void OnCollisionEnter(Collision other) 
        {
            if(other.gameObject.CompareTag("Exit"))GameManager.instance.GameOver();
        }
    
}
