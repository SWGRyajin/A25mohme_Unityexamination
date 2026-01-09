using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Momo : MonoBehaviour
{
    Animator momoAnimator;
    void Start()
    {
        momoAnimator animator = GetComponent<Animator>();
        
        momoAnimator.SetBool("jump", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("spacebar"))
        {
            momoAnimator.SetBool("jump", true);
        }
         
        if (Input.GetKeyDown("spacebar"))
        {
            momoAnimator.SetBool("spacebar", false);
        }  
    }
}
