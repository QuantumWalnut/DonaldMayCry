using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {

    public float speedX = 5f;
    float speedY = 0f;
    Rigidbody2D rb;





	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

	}





    void OnBecameInvisible()
    {
        //Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    
    }


	// Update is called once per frame
	void Update () {
        


        rb.velocity = new Vector2(speedX, speedY);

        if(speedX>0 ){
            //gameObject.transform.Rotate(0,0,45);
        }else{
            //gameObject.transform.Rotate(0,0,0);
        }
	}
}
