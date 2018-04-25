using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    private bool isAttacking = false;
    private float attackTimer = 0;
    private float CoolDown = 0.3f;

    public Collider2D attackTrigger;

    private void Awake()
    {
        attackTrigger.enabled = false;
    }

    private void Update()
    {
        if(Input.GetKeyDown("i") && !isAttacking){ // If the player presses i and he is not attacking...
            isAttacking = true; //... player attacks
            attackTimer = CoolDown; // ... attackTimer is set to 0.3f
            attackTrigger.enabled = true; // attackTrigger is enabled
        }

        // If the player is attacking...
        if(isAttacking){

            if(attackTimer > 0){ // ... and attackTimer has not reach zero
                attackTimer -= Time.deltaTime; // ... then the attack timer keeps counting

            }else{ // ... and the attackTimer has reached zero
                isAttacking = false; // ... then stop attacking
                attackTrigger.enabled = false; // attackTrigger is disabled
            }
        }
    }
}
