using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject Player;
    Player player1;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        player1 = Player.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RightDown()
    {
        player1.right = true;
    }

    public void RightUp()
    {
        player1.right = false;
    }
    public void LeftDown()
    {
        player1.left = true;
    }

    public void LeftUp()
    {
       player1.left = false;
    }

   
}
