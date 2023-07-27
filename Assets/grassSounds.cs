using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grassSounds : MonoBehaviour
{
    public FirstPersonController fpc;
    public GameObject[] walking;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fpc.isWalking)
        {
            foreach (GameObject go in walking)
            {
                go.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject go in walking)
            {
                go.SetActive(false);
            }
        }
    }
}
