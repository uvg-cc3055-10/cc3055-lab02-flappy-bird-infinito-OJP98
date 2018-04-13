using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    private float scrollingSpeed = 2f;        

    void Start()
    {
        gameObject.SetActive(true);
    }

    void Update()
    {

        if (GameController.instance.gameOver == false)
        {
            transform.Translate(Vector3.left * scrollingSpeed * Time.deltaTime);
            if (transform.position.x < -10)
            {
                Destroy(gameObject);
            }
        }
    }

    public void pickCoin()
    {          
        GameController.instance.score++;
        Destroy(gameObject);
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        pickCoin(); 
    }
}
