﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {

	// Use this for initialization
	public PlayerController player1;
	public PlayerController player2;
	public GameObject sphere1;
	public GameObject sphere2;
	public GameObject win1;
	public GameObject win2;
	public GameObject windZ;

	public Text txtRef;
	//public Canvas can;

	void Start () {
		// txtRef = can.GetComponent<Text>();
		win1.SetActive(false);
		win2.SetActive(false);
		calcWind();
		sphere1.SetActive(true);
		sphere2.SetActive(false);
		player1.isActive = true;
		player2.isActive = false;

	}

	// Update is called once per frame
	void Update () {
		Scene currentScene = SceneManager.GetActiveScene ();

		// Retrieve the name of this scene.
		string sceneName = currentScene.name;

		if (sceneName == "fase1") {

			if (player1.switchP) {
				calcWind ();
				player1.switchP = false;
				player2.switchP = false;
				player1.isActive = false;
				player2.isActive = true;
				sphere1.SetActive (false);
				sphere2.SetActive (true);
			}
			if (player2.switchP) {
				calcWind ();
				player1.switchP = false;
				player2.switchP = false;
				player2.isActive = false;
				player1.isActive = true;
				sphere1.SetActive (true);
				sphere2.SetActive (false);
			}

			if (player2.transform.position.y < -100) {
				win1.SetActive (true);
				Application.LoadLevel ("fase2");
			}
			if (player1.transform.position.y < -100) {
				win2.SetActive (true);
				Application.LoadLevel ("fase2");
			}
		}

		if (sceneName == "fase2") {

			win1.SetActive(false);
			win2.SetActive(false);
			calcWind();
			sphere1.SetActive(true);
			sphere2.SetActive(false);
			player1.isActive = true;
			player2.isActive = false;


			if (player1.switchP) {
				calcWind ();
				player1.switchP = false;
				player2.switchP = false;
				player1.isActive = false;
				player2.isActive = true;
				sphere1.SetActive (false);
				sphere2.SetActive (true);
			}
			if (player2.switchP) {
				calcWind ();
				player1.switchP = false;
				player2.switchP = false;
				player2.isActive = false;
				player1.isActive = true;
				sphere1.SetActive (true);
				sphere2.SetActive (false);
			}

			if(player1.isActive == false && player2.isActive== false ){
				setPlayer1();
			}

			if (player2.transform.position.y < -100) {
				win1.SetActive (true);
				player1.isActive = false;
				player2.isActive = false;
				Application.LoadLevel ("fase3");
			}
			if (player1.transform.position.y < -100) {
				win2.SetActive (true);
				player1.isActive = false;
				player2.isActive = false;
				Application.LoadLevel ("fase3");
			}
		}



	}
	public void calcWind()
	{
		System.Random rnd = new System.Random();
		int windR = rnd.Next(-100, 100);
		txtRef.text = windR.ToString();
		player1.wind = windR/10;
		player2.wind = windR/10;
		WindZone wz = windZ.GetComponent<WindZone>();
		wz.windMain = Mathf.Abs((windR / 10));
		Transform wt = windZ.GetComponent<Transform>();
		if (windR > 0) wt.transform.position = new Vector3(-45,0,0);
		if (windR < 0) wt.transform.position = new Vector3(4.2f, 0, 0);

	}
	public void setPlayer1()
	{
		player1.isActive = true;
		player2.isActive = false;
	}
	public void setPlayer2()
	{
		player2.isActive = true;
		player1.isActive = false;
	}
}