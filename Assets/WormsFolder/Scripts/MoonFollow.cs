using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonFollow : MonoBehaviour
{
    public GameObject Player;
    public GameObject Moon;

    public float offset;
    // Start is called before the first frame update
    void Start()
    {
        //finding the player
        Player = GameObject.Find("Player");
       
        //adjusting the offset by usinng the players position and multiplying it by -1
        offset = (Player.transform.position.x - transform.position.x) * -1; 
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //getting the moon to follow the player
        Moon.transform.position = new Vector2(Player.transform.position.x + offset, transform.position.y);    
    }
}
