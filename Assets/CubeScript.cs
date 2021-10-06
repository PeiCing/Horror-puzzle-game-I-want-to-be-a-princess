using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {

    Renderer R1;
    
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



            Debug.Log("fukkkkkkkkkkkkkkkkyyyyy");

			Destroy(this.gameObject);

        }
        
    }
}
