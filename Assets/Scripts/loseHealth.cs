using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loseHealth : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health.health -= 1;
    }
}
