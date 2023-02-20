using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class text : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    TextMeshProUGUI text_State;

    // Update is called once per frame
    void Update()
    {
         text_State.text = "Score = " + GameManager.instance.Score.ToString()+"\n" +"Ammo: " + GameManager.instance.playerStats.ammo.ToString();
    }
}
