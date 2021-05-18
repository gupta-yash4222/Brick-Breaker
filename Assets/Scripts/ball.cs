using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

    public Rigidbody2D var;
    public bool inplay;
    public Transform paddle_pos;
    public Transform pd; 
    public float speed;
    public GameManager game;

    // Start is called before the first frame update
    void Start()
    {
        var = GetComponent<Rigidbody2D> ();

        var.AddForce(Vector2.up*speed);


        
    }

    // Update is called once per frame
    void Update()
    {

        if(game.gameplay){
            return;
        }

        if(!inplay){
            transform.position = paddle_pos.position;
        }

        if(Input.GetButtonDown("Jump") && !inplay){
            inplay = true;
            var.AddForce(Vector2.up*speed);
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("region")){
            Debug.Log("LMAO DED");
            var.velocity = Vector2.zero;
            inplay = false;
            game.UpdateLives(-1);
        }
    }

    void OnCollisionEnter2D(Collision2D other){
        if(other.transform.CompareTag("brick")){
            Destroy(other.gameObject);
            game.UpdateScore(1);
        }

        
        if(other.transform.CompareTag("paddle")){
            Debug.Log("Collision met");
            Vector2  direction = transform.position - pd.position;
            direction.Normalize();
            var.velocity = Vector2.zero;
            var.AddForce(direction*speed);
        }
        
    }
}
