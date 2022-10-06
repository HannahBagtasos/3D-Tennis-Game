using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Transform TargetAim
    float speed = 3f;
    bool hitting;
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        if(Input.GetKeyDown(KeyCode.F))
        {
            hitting = true;
        }
        else if(Input.GetKeyUp(KeyCode.F))
        {
            hitting = false;
        }

        if(h!=0||v!=0)
        {
            transform.Translate(new Vector3(v ,0 ,h )* speed* Time.deltaTime);
        }
    }
}
