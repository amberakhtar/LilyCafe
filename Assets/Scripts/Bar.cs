using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;

public class Bar : MonoBehaviour


{

 





    public GameObject bar;
    public int time;
    bool isMaking = false;
    
 


    void Start()
    {
        //isMaking = true;
        AnimateBar();

    }

    // Update is called once per frame
    void Update()
    {
        //if (!isMaking) isMaking = true;
        //if (isMaking)
        //{
        //    AnimateBar();
        //}

    }

    public void AnimateBar()
    {
        LeanTween.scaleX(bar, 1, time);
        //Debug.Log("Coffee machine making coffee");
    }

    
}

