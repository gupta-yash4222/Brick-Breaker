using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{

    public float speed;
    public float leftEdge;
    public float rightEdge;
    public GameManager game;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*

        if(game.gameplay){
            return;
        }
        */

        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right*horizontal*Time.deltaTime*speed);

        if(transform.position.x < leftEdge){
            transform.position = new Vector2(leftEdge, transform.position.y);
        }
        if(transform.position.x > rightEdge){
            transform.position = new Vector2(rightEdge, transform.position.y);
        }
    }
}
