using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    public int damageAmount = 20;

    private void Start()
    {
        Destroy(gameObject, 10);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(transform.GetComponent<Rigidbody>());
        if(other.tag == "Demon")
        {
            transform.parent = other.transform;
            other.GetComponent<FireDemon>().TakeDamage(damageAmount);
            Debug.Log("Enemy hit");
        }
    }

}
