﻿using UnityEngine;
using System.Collections;

public class InfoItem : MonoBehaviour {

    public float speed = 10f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }


    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Player") {
            InfoScreen.Instance.DisplayScreen();
        }
    }

}