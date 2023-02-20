using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;
    public int Score;
    public struct PlayerStats
    {
    public int ammo;
    }
    public PlayerStats playerStats;
     void Start() {
        
        if(instance == null){
            instance = this;
        }
    playerStats = new PlayerStats();
    
    playerStats.ammo = 10;
        
    }
 
    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
   
}   
    