using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Image[] hearts;
    public Image[] emptyHearts;
    public int health;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        foreach(Image heart in hearts)
            {
                heart.enabled = true;
            }
            foreach(Image emptyHeart in emptyHearts)
            {
               emptyHeart.enabled = false;;
            }

    }

    // Update is called once per frame
    void Update()
    {
        health = player.GetComponent<PlayerController>().GetHealth();
        switch(health)
        {
            case 0:
                foreach(Image emptyHeart in emptyHearts)
                {
                   emptyHeart.enabled = true;
                }
                foreach(Image heart in hearts)
                {
                   heart.enabled = false;
                }                
                break;
            case 1:
                emptyHearts[1].enabled = true;
                hearts[1].enabled = false;
                break;
            case 2:
                emptyHearts[2].enabled = true;
                hearts[2].enabled = false;
                break;
            case 3:
                foreach(Image heart in hearts)
                {
                   heart.enabled = true;
                }
                foreach(Image emptyHeart in emptyHearts)
                {
                   emptyHeart.enabled = false;;
                }

                break;
        }
    }
}
