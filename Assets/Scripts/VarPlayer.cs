using UnityEngine;
using System.Collections;

// Class that contains the OnClick () function, which is called by clicking the button
public class VarPlayer : MonoBehaviour{

    public static int player1Var =1;
    public static int player2Var =1;
    public static int contP1 = 0;
    public static int contP2 = 0;
	public static bool[] p1Select = new bool[6];
	public static bool[] p2Select = new bool[6];
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnGayvisonP1(){
		zerarSelect (p1Select);
		p1Select [2] = true;
        player1Var = 1;
        contP1++;
    }

    public void OnGayvisonP2()
    {
		zerarSelect (p2Select);
		p2Select [2] = true;
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

    public void OnLuanP1()
    {
        player1Var = 4;
        contP1++;
    }

    public void OnLuanP2()
    {
        player2Var = 4;
        contP2++;
    }

    public void OnChinaP1()
    {
        player1Var = 5;
        contP1++;
    }

    public void OnChinaP2()
    {
        player2Var = 5;
        contP2++;
    }

    public void OnJorgeP1()
    {
        player1Var = 6;
        contP1++;
    }

    public void OnJorgeP2()
    {
        player2Var = 6;
        contP2++;
    }

	public void zerarSelect(bool[] pSelect){
		for(int i = 0; i< pSelect.Length;i++){
			pSelect [i] = false;
		}
	}

}
