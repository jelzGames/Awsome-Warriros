using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PeopleWalk : MonoBehaviour {

    public Transform[] walkPoints;
    public float walk_Speed = 1f;
    public bool isIdle;

    private int walk_index;

    private NavMeshAgent navAgent;
    private Animator anim;

    

	// Use this for initialization
	void Awake () {
        anim = GetComponent<Animator>();
        navAgent = GetComponent<NavMeshAgent>();

    }

    private void Start()
    {
        if (isIdle)
        {
            anim.Play("Idle");
        }
        else
        {
            anim.Play("Walk");
        }
    }

    // Update is called once per frame
    void Update () {
		if (!isIdle)
        {
            ChooseWalkPoint();
        }
	}

    void ChooseWalkPoint()
    {
        if (navAgent.remainingDistance <= 0.1f)
        {
            navAgent.SetDestination(walkPoints[walk_index].position);

            if (walk_index == walkPoints.Length - 1)
            {
                walk_index = 0;
            }
            else
            {
                walk_index++;
            }
        }
    }
}
