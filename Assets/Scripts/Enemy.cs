using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    //PUBLIC VALS
    public int enemySpeed = 10;

    //PRIVATE VALS
    private bool faceRight = true;
    private float moveX = 1f;



    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {

      if(GetComponent<Renderer>().isVisible){
        EnemyMove();
      }
    }

    void EnemyMove()
    {
        //IF something doesnt allow it to move forward then rotate
        if(gameObject.GetComponent<Rigidbody2D>().velocity == new Vector2(0, gameObject.GetComponent<Rigidbody2D>().velocity.y)){
            moveX = -1;
        }
        //DIRECTION
        //player dir
        if (moveX < 0.0f && faceRight == false)
        {
            FlipPlayer();
        }
        else if (moveX > 0.0f && faceRight == true)
        {
            FlipPlayer();
        }



        //PHYSICS
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(enemySpeed * moveX, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void FlipPlayer()
    {
        faceRight = !faceRight;

        Vector2 locScale = gameObject.transform.localScale;
        locScale.x *= -1;
        transform.localScale = locScale;
    }
}
