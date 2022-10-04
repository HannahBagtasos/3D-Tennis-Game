using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Vertical");
        float v = Input.GetAxisRaw("Horizontal");

        if(h!=0||v!=0)
        {
            transform.Translate(new Vector3(h,0,v)* speed* Time.deltaTime);
        }
    }
}
