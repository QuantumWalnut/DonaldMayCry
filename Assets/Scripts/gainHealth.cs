using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gainHealth : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.gameObject.name=="finaltrump")
      {
        Health.health += 1;
        Destroy(gameObject);
      }
    }
}
