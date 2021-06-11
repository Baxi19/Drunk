using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAnimations : MonoBehaviour
{
    public NavMeshAgent agent;

    private Animator animator;
    private bool stoped = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (agent.velocity == new Vector3(0, 0, 0))
        {
            if (!stoped)
            {
                stoped = true;
                //animator.SetFloat("VelX", 0); 
                animator.SetFloat("VelY", 0); // 1 = front && -1 = back && 0 = stop
                Debug.Log("Stoped!");
            }
        }
        else
        {
            if (stoped)
            {
                stoped = false;
                //animator.SetFloat("VelX", 0);
                animator.SetFloat("VelY", 1);
                Debug.Log("Moving!");
                //Debug.Log(agent.velocity);
            }

        }




    }
}
