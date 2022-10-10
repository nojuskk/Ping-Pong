using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 7f;
    private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float vertical = Input.GetAxisRaw("Vertical");
        rb2d.velocity = new Vector2(0, vertical * speed);
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -4.45f, 4.45f), 0);
	}
}
