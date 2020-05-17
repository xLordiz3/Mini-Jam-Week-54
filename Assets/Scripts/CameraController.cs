using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float iV;
    public float mD;
    public float fD;
    public GameObject target;
    public Vector3 offset;
    Vector3 tP;
    // Start is called before the first frame update
    void Start()
    {
        tP = transform.position;
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 posNoZ = transform.position;
        posNoZ.z = target.transform.position.z;
        Vector3 tD = (target.transform.position - posNoZ);
        iV = tD.magnitude * 3f;
        tP = transform.position + (tD.normalized * iV * Time.deltaTime);
        if(Input.GetAxisRaw("Horizontal") == -1)
        {
            offset = new Vector3(-0.3f, 0.05f, 0f);
        }
        else
        {
            offset = new Vector3(0.25f, 0.05f, 0f);            
        }
        transform.position = Vector3.Lerp(transform.position, tP + offset, 0.25f);
    }
}
