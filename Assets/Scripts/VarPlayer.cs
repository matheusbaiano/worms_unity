using UnityEngine;
using System.Collections;

// Class that contains the OnClick () function, which is called by clicking the button
public class VarPlayer : MonoBehaviour{

    public static int player1Var =1;
    public static int player2Var =1;
    public static int contP1 = 0;
    public static int contP2 = 0;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnGayvisonP1(){
        player1Var = 1;
        contP1++;
    }

    public void OnGayvisonP2()
    {
        player2Var = 1;
        contP2++;
    }

    public void OnAndersonP1()
    {
        player1Var = 2;
        contP1++;
    }

    public void OnAndersonP2()
    {
        player2Var = 2;
        contP2++;
    }

    public void OnMatheusP1()
    {
        player1Var = 3;
        contP1++;
    }

    public void OnMatheusP2()
    {
        player2Var = 3;
        contP2++;
    }
}
