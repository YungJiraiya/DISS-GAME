using System.Collections;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public Animation anim;
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f && GetComponentInParent<targetActive>().activeTarget == true)
        {
        Die();
        }
    }

    void Start()
    {
        anim = GetComponent<Animation>();
    }
    void Die()
    { 
        anim.Play("targetAnimation");
        GetComponentInParent<targetActive>().activeTarget = false;

        GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().setTarget();
        health = 50f;
    }

}
