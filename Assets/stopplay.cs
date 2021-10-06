using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class stopplay : MonoBehaviour
{
	public VideoPlayer vv = new VideoPlayer();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(vv.frame == (long)vv.frameCount){//!vv.isPlaying
			Debug.Log("END!!!!!!!!!!");
			vv.gameObject.SetActive(false);
		}
    }


}
