using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    //旋轉的角度上限。
    float rotationleft = 360;



    //每 frame 旋轉速度。
    float rotationspeed = 200;


    void Update()
    {


        //設定每個 frame 的旋轉速度。
        float rotation = rotationspeed * Time.deltaTime;


        //若最大旋轉值大於每個 frame的旋轉速度，最大旋轉值 -10 度。
        if (rotationleft > rotation)
        {
            rotationleft -= rotation;
        }


        //若最大旋轉值等於=10 也就是等於每個 frame 的旋轉速度。
        else
        {
            //每個Farm的旋轉速度=10。
            rotation = rotationleft;


            //最大旋轉值設成0。
            //rotationleft = 0;


        }


        //旋轉(每個 frame)。
        transform.Rotate(0, 0, rotation);
    }
}
