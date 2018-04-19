using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallDeath : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health.isDead = true;
    }
}
