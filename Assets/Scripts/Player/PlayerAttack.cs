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
        if(Input.GetKeyDown("i") && !isAttacking){
            isAttacking = true;

            attackTimer = CoolDown;

            attackTrigger.enabled = true;
        }


        if(isAttacking){
            if(attackTimer > 0){
                attackTimer -= Time.deltaTime;
            }else{
                isAttacking = false;
                attackTrigger.enabled = false;
            }
        }



    }
}
