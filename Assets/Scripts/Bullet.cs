using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject effect, player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            effect = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(effect, 1f);
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
    private void OnEnable() 
    {
        Invoke("Destroy", 3f);    
    }

    private void Destroy() 
    {
        Destroy(gameObject);    
    }
    private void OnDisable() 
    {
        CancelInvoke();    
    }
}
