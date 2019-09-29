
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;





public class SliderValue : MonoBehaviour

{

    public float speed = 10f;



    // Update is called once per frame

    void Update()

    {

        transform.Rotate(0, speed * Time.deltaTime, 0);// float with two decimals
     

    }
    public void AdjustSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

}