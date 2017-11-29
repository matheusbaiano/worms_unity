using UnityEngine;
using System.Collections;


public class VoltarMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // OnClick () function changes scene
    // Remember that the scenes that the game will contain are in File-> Build Settings
    public void OnClick()
    {
        VarPlayer.contP1 = VarPlayer.contP2 = 0;
        Application.LoadLevel("menuScene");
    }
}
