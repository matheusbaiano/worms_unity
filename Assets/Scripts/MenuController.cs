using UnityEngine;
using System.Collections;

// Class that contains the OnClick () function, which is called by clicking the button
public class MenuController : MonoBehaviour {

	public static bool[] p1Circle = new bool[6];
	public static bool[] p2Circle = new bool[6];

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // OnClick () function changes scene
    // Remember that the scenes that the game will contain are in File-> Build Settings
    public void OnClick(){

		for (int i = 0; i < p1Circle.Length; i++) {
			if (VarPlayer.p1Select [i]) {
				p1Circle [i] = true;
			}
		}

        if(VarPlayer.contP1 > 0 && VarPlayer.contP2 > 0){
            Application.LoadLevel("fase1");
        }
	}
}
