using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loseHealth : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
      if(collision.gameObject.name=="finaltrump")
      {
        Health.health -= 1;
      }
      else if(collision.gameObject.name=="TowerToRight(Clone)"){
        Destroy(collision.gameObject);
        Destroy(gameObject);
      }
    }
}
