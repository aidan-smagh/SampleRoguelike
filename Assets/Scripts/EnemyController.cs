using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class EnemyController : MonoBehaviour
{
     [SerializeField] Transform target;
     [SerializeField] float attackDistance;
     private NavMeshAgent mAgent;
     private Animator mAnimator;
     private float mDistance;

     void Start()
    {
        mAgent = GetComponent<NavMeshAgent>();
        mAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        //distance between the enemy and player
        mDistance = Vector3.Distance(mAgent.transform.position, target.position);
        if (mDistance < attackDistance)
        {
            mAgent.isStopped = true;
            mAnimator.SetBool("Attack", true);
        }
        else
        {
            mAgent.isStopped = false;
            mAnimator.SetBool("Attack", false);
            mAgent.destination = target.position;
        }

        void OnAnimatorMove()
        {
            if (mAnimator.GetBool("Attack") == false)
            {
                mAgent.speed = (mAnimator.deltaPosition / Time.deltaTime).magnitude;
            }
        }
    }
}
