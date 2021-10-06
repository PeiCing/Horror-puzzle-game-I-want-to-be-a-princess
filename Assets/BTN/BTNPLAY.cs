using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTNPLAY : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void playGame(){
		Application.LoadLevel("testttttttttttttttttrt");
	}
	public void Quit (){
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}

}
