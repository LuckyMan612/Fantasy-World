using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingAndRunning : MonoBehaviour
{
    public FirstPersonController fpc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!fpc.isWalking)
        {
            GetComponent<Animator>().enabled = false;
        }
        else if (fpc.isWalking)
        {
            GetComponent<Animator>().enabled = true;
        }
        if (fpc.isSprinting)
        {
            GetComponent<Animator>().speed = 0.5f;
        }
        else if (!fpc.isSprinting)
        {
            GetComponent<Animator>().speed = 0.3f;
        }
    }
}
