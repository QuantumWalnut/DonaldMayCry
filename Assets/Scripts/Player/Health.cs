using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {

    public static bool isDead = false;
    public static int health = 5;

    private int maxHealth = 5;


    //healthbar
    public GameObject hairth1, hairth2, hairth3, hairth4, hairth5;

	// Use this for initialization
	void Start () {
        isDead = false;

        //show health
        hairth1.gameObject.SetActive(true);
        hairth2.gameObject.SetActive(true);
        hairth3.gameObject.SetActive(true);
        hairth4.gameObject.SetActive(true);
        hairth5.gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        
        //UPDATE HEALTH
        if (health > maxHealth){
            health = maxHealth;
        }


        if(health == 5){
            hairth1.gameObject.SetActive(true);
            hairth2.gameObject.SetActive(true);
            hairth3.gameObject.SetActive(true);
            hairth4.gameObject.SetActive(true);
            hairth5.gameObject.SetActive(true);

        }else if (health == 4)
        {
            hairth1.gameObject.SetActive(true);
            hairth2.gameObject.SetActive(true);
            hairth3.gameObject.SetActive(true);
            hairth4.gameObject.SetActive(true);
            hairth5.gameObject.SetActive(false);
        }else if (health == 3)
        {
            hairth1.gameObject.SetActive(true);
            hairth2.gameObject.SetActive(true);
            hairth3.gameObject.SetActive(true);
            hairth4.gameObject.SetActive(false);
            hairth5.gameObject.SetActive(false);
        }else if (health == 2)
        {
            hairth1.gameObject.SetActive(true);
            hairth2.gameObject.SetActive(true);
            hairth3.gameObject.SetActive(false);
            hairth4.gameObject.SetActive(false);
            hairth5.gameObject.SetActive(false);
        }else if (health == 1)
        {
            hairth1.gameObject.SetActive(true);
            hairth2.gameObject.SetActive(false);
            hairth3.gameObject.SetActive(false);
            hairth4.gameObject.SetActive(false);
            hairth5.gameObject.SetActive(false);
        }else if (health == 0)
        {
            isDead = true;
            health = 5;
        }




        //DIE
        if(isDead){
            StartCoroutine("Die");
            health = 5;
        }
	}

    IEnumerator Die(){
        SceneManager.LoadScene("Main");

        yield return null;
    }

}
