using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTornado : MonoBehaviour {

    public float speed = 254f;
    public float maxSpeed = 150f;
    public float speed_Multiplier = 1;

    private float lifeTime = 4f;

    private Rigidbody myBody;

    private Transform player;
    private Vector3 direction;
    

	// Use this for initialization
	void Awake () {
        myBody = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        direction = player.transform.forward;

    }

    private void Start()
    {
        DestroyObject(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update () {
        speed += speed_Multiplier;

        if (speed > maxSpeed)
        {
            speed = maxSpeed;
        }

        myBody.velocity = speed * Time.deltaTime * direction;
	}
}
