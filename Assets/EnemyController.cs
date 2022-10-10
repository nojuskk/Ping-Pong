using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public float speed = 2f;
	public GameObject ball;

	// Use this for initialization
	void Start () {
		ball = GameObject.Find("Ball");
	}
	
	// Update is called once per frame
	void Update () {
		float ballYPos = ball.transform.position.y;
		float step = speed * Time.deltaTime;
		float currentYPos = Mathf.MoveTowards(transform.position.y, ballYPos, step);
		transform.position = new Vector3(transform.position.x, Mathf.Clamp(currentYPos, -4.45f, 4.45f), transform.position.z);
	}
}
