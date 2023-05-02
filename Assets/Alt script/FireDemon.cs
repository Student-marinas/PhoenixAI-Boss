using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireDemon : MonoBehaviour
{
    private int HP = 100;
    public Animator animator;
    public Slider healthBar;

    public GameObject Tornado;
    public Transform tornadoPoint;

    void Update()
    {
        healthBar.value = HP;
    }
    
    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;
        if(HP <= 0)
        {
            animator.SetTrigger("die");
        }
        else
        {
            animator.SetTrigger("damage");
        }
    }

}
