using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour {

    public GameManager gameManager;

    public void OnTriggerEnter(Collider col)
    {
        Destroy(col.gameObject);
        
        
        if (col.tag == "sick")
        {
            float staminaHit = col.GetComponent<Enemy>().staminaDamage;
            Stamina.stamina += staminaHit;
            float flavor = col.GetComponent<Enemy>().nutrients;
            Health.health += flavor;
            gameManager.SickDie();
        }
        else
        {
            float flavor = col.GetComponent<Enemy>().nutrients;
            Health.health += flavor;
            int scoreValue = col.GetComponent<Enemy>().scoreValue;
            Score.score += scoreValue;
            gameManager.EnemyDie();
        }
    }


}
