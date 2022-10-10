using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Text PlayerPointsText;
	public Text BotPointsText;

	private int playerPoints;
	private int botPoints;

	private GameObject ball;

	// Use this for initialization
	void Start () {
		playerPoints = 0;
		botPoints = 0;
		ball = GameObject.Find("Ball");

	}
	
	// Update is called once per frame
	void Update () {
		PlayerPointsText.text = playerPoints.ToString();
		BotPointsText.text = botPoints.ToString();

	}

	public void AddPlayerScore(){
		playerPoints++;
	}
	public void AddBotScore(){
		botPoints++;
	}
	public void ResetBall(){
		ball.transform.position = Vector3.zero;
		ball.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
	}
}
