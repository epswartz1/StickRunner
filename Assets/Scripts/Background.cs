﻿using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//speed -= (.01f * Time.deltaTime);
		transform.Translate((LevelControl.speed / 2) * Time.deltaTime, 0f, 0f);
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.name == "Player1")
		{
			Invoke("DestroySelf", 15);
		}
	}

	void DestroySelf()
	{
		Destroy(gameObject);
	}
}
