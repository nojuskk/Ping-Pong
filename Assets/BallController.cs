using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	private Rigidbody2D rb2d;
	private GameManager Gm;
	
	// Use this for initialization
	void Start () {
		Gm = FindObjectOfType<GameManager>();
		rb2d = GetComponent<Rigidbody2D>();
		rb2d.velocity = Vector2.zero;
	}
	
	// Update is called once per frame
	void Update () 
		{
		if(Input.GetKeyDown(KeyCode.Space)){
			rb2d.AddForce(new Vector2(500, 100));
		}

		rb2d.velocity = new Vector2(Mathf.Clamp(rb2d.velocity.x, -13.5f, 13.5f), Mathf.Clamp(rb2d.velocity.y, -4.5f, 4.5f));

		if(Mathf.Abs(rb2d.velocity.x) < 9.5f)
		{
			rb2d.velocity = new Vector2(rb2d.velocity.x * 1.5f, rb2d.velocity.y);
		}
		if(Mathf.Abs(rb2d.velocity.y) < 1.95f)
		{
			rb2d.velocity = new Vector2(rb2d.velocity.x, rb2d.velocity.y * 1.5f);
		}
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		rb2d.velocity = new Vector2(rb2d.velocity.x + Random.Range(-0.1f, 0.1f), rb2d.velocity.y + Random.Range(-0.1f, 0.1f));
	}

	void OnTriggerEnter2D(Collider2D coll){
		if(coll.gameObject.name.StartsWith("Right")){
			Gm.AddPlayerScore();
		}
		if(coll.gameObject.name.StartsWith("Left")){
			Gm.AddBotScore();
		}
		Gm.ResetBall();
	}
}
