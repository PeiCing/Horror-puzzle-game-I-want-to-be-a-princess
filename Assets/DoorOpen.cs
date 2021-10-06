using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    Renderer R1;

    //public Mode action = Mode.Activate;         // The action to accomplish
    public Object target;                       // The game object to affect. If none, the trigger work on this game object
    public GameObject source;
    //public int triggerCount = 1;
    //public bool repeatTrigger = false;


    void Start()
    {
        //R1 = gameObject.GetComponent<Renderer>(); //把R1指定為物件的Renderer
    }

    void Update()
    {
    }

    void HitByRaycast() //被射線打到時會進入此方法
    {




        if (Input.GetButtonUp("E")) //當按下鍵盤 E 鍵時
        {
            //GameObject aa = GameObject.Find("Canvas/Battery System/Fill Area/Fill");
            //if(aa.GetComponent<RectTransform>().offsetMax.x != 0){
            //aa.GetComponent<RectTransform>().offsetMax = new Vector2(aa.GetComponent<RectTransform>().offsetMax.x + 10, aa.GetComponent<RectTransform>().offsetMax.y);
            //}

            Object currentTarget = target ?? gameObject;

            GameObject targetGameObject = currentTarget as GameObject;

            if (targetGameObject != null)
            {
                targetGameObject.GetComponent<Animation>().Play();
            }

            Debug.Log("opennnnnnnnnnnnnnnn");

            //Destroy(this.gameObject);

            //this.gameObject.SetActive(false);

        }

    }
}
