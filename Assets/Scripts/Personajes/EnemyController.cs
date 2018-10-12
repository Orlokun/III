using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public int daño;


	// Use this for initialization
	void Start () {
        daño = 5;
	}
	
	// Update is called once per frame
	void Update () {
		// movimiento 
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject incomingObject = collision.gameObject;
        if (incomingObject.GetComponent<Player>())
        {
            EvaluatePlayerDamage(incomingObject);
        }
    }

    private void EvaluatePlayerDamage(GameObject objetoADañar)
    {
        Player pController = objetoADañar.GetComponent<Player>();

            pController.TakeDamage(daño);   
    }
}
