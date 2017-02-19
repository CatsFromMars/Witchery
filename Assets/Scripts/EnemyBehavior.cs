using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour {
    [SerializeField]
    float speed = 5;
	// Use this for initialization
	void Start () {
        Debug.Log("Started!");
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("End");
        transform.Translate(transform.forward * Time.deltaTime * speed);
	}
}
