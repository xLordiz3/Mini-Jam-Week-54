using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class MemoryLights : MonoBehaviour
{
    public Light2D light;
    public float count;
    
    // Start is called before the first frame update
    void Start()
    {
;
        light = transform.GetComponent<Light2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(count < 100)
        {
            Up();
            count++;
        }

        if(count < 200 && count > 100)
        {
            Down();
            count++;
        }
       if(count >= 200)
        {
            count = 0;
        }        
  
    }
    void Up()
    {
            light.intensity += 0.05f;
            //light.volumeOpacity += 0.5; 
    }

    void Down()
    {
            light.intensity -= 0.05f;
           //light.volumeOpacity -= 0.5; 
  
    }
}
