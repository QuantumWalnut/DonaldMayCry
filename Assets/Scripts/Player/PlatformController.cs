using UnityEngine;
using System.Collections;
using System;

public class PlatformController : MonoBehaviour
{
    //PUBLIC VALS
    public int playerSpeed = 10;
    public float playerJumpF = 8000f;
    public GameObject bulletToLeft, bulletToRight;
    public float fireRate = 0.5f;
    float nextFire = 0f;

    //PRIVATE VALS
    private float moveOnX;
    public bool faceRight = true;
    Vector2 bulletPos;

    //Anim
    Animator anim;

    //
    public bool isGrounded;

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        //ANIMAAAATION

        /*States
         * 0 - IDLE
         * 1 - JUMP
         * 2 - RUN
         * 3 - SHOOT
         * 4 - MELEE
         * 5 - DEFEND
         */

        anim = gameObject.GetComponent<Animator>();

        if ((Input.GetKey("a") || Input.GetKey("d")) && isGrounded)
        {
            //player dir
            if (Input.GetKey("a") && faceRight == true)
            {
                FlipPlayer();

            }
            else if (Input.GetKeyDown("d") && faceRight == false)
            {
                FlipPlayer();

            }

            anim.SetInteger("State", 0);
            anim.SetInteger("State", 2);

        }
        else if (Input.GetKey("w") || !isGrounded) {


            anim.SetInteger("State", 1);



        } else if (Input.GetKey("j")){

            anim.SetInteger("State", 3);


        }else if (Input.GetKey("i"))
        {

            anim.SetInteger("State", 4);


        }else if (Input.GetKey("s"))
        {

            anim.SetInteger("State", 5);


        }else{
            anim.SetInteger("State", 0);
        }




        /*CONTROLS
         * Left - Right Arrows  ==> horizontal movement
         * Up Arrow             ==> jump
         * Space                ==> shoot
         */
        moveOnX = Input.GetAxis("Horizontal");

        if(Input.GetKeyDown("w")){
            Jump();
        }

        if(Input.GetKeyDown("j") && Time.time > nextFire){
            nextFire = Time.time + fireRate;
            Fire();
        }











        //physics
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveOnX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    private void Melee()
    {



    }



    private void Fire()
    {
        bulletPos = transform.position;

        if(faceRight){
            bulletPos += new Vector2(+1.321f, -0.266f);
            Instantiate(bulletToRight, bulletPos, new Quaternion(0,0,-90,0));
        }else{
            bulletPos += new Vector2(-1.206f, -0.266f);
            Instantiate(bulletToLeft, bulletPos, new Quaternion(0, 0, 90, 0));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground"){
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground"){
            isGrounded = false;
        }
    }




    void FlipPlayer()
    {
        gameObject.GetComponent<SpriteRenderer>().flipX = faceRight;
        faceRight = !faceRight;


    }







    void Jump(){
        if(isGrounded){
            //GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * playerJumpF, ForceMode2D.Impulse);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, playerJumpF), ForceMode2D.Impulse);
        }
    }






}
