using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hands : MonoBehaviour
{
    public FirstPersonController fpc;
    public GameObject rightHand;
    public GameObject leftHand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fpc.isWalking)
        {
            leftHand.GetComponent<Animator>().enabled = true;
            rightHand.GetComponent<Animator>().enabled = true;
        }
        else if (fpc.isSprinting)
        {
            leftHand.GetComponent<Animator>().speed = 1.5f;
            rightHand.GetComponent<Animator>().speed = 1.5f;
        }
        else
        {
            leftHand.GetComponent<Animator>().enabled = false;
            rightHand.GetComponent<Animator>().enabled = false;
        }

    }
}
