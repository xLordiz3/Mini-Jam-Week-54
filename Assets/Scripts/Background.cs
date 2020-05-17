using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{   
    private float length, startPos;
    private GameObject cam;
    public float parallaxEffect;

    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
        cam = GameObject.FindGameObjectWithTag("MainCamera");

        float cameraWidth = Mathf.Abs(Camera.main.ViewportToWorldPoint(Vector3.one).x - Camera.main.ViewportToWorldPoint(Vector3.zero).x);
        float size = cameraWidth / (length / transform.localScale.x);
        transform.localScale = new Vector3(size, size, 1);
    }

    void FixedUpdate()
    {
        float dist = (cam.transform.position.x * parallaxEffect);
        transform.position = new Vector3(startPos + dist, transform.position.y, transform.position.z);
    }
}
