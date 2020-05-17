using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletP;
    //public Animator animator;
    public float bulletForce = 20f;
    public bool right;
    // Start is called before the first frame update
    public void Start()
    {
       // animator = gameObject.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
            //animator.SetBool("shooting", true);
        }
        right = gameObject.GetComponent<PlayerController>().m_FacingRight;
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletP, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if(right)
        {
            rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
        }
        else
        {
            rb.AddForce(-(firePoint.right) * bulletForce, ForceMode2D.Impulse);       
        }
    }
}
