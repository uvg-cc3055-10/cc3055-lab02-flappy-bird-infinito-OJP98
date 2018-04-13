using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BirdScript : MonoBehaviour {

    public float jumpForce = 200f;
    private Rigidbody2D rb;
    public string score;
    public Text scoreTxt;
    public Coin coin;

    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        if (Input.GetButtonDown("Jump")) {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpForce);
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {                       
        score = GameController.instance.score.ToString();        
        scoreTxt.text = "Score: " + score;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameController.instance.gameOver = true;
    }              

}
