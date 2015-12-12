using UnityEngine;
using System.Collections;

public class HightLightEateble : MonoBehaviour {
	GameObject player;
	SpriteRenderer spriterenderer;
	Transform transforM;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("player");
		spriterenderer = GetComponent<SpriteRenderer>();
		spriterenderer.color=Color.white;


	
	}
	
	// Update is called once per frame
	void Update () {
		float playerscale = player.GetComponent<Transform>().localScale.x;
		float enemyscale = GetComponent<Transform>().localScale.x;


		if (playerscale >= enemyscale)
		{
			spriterenderer.color=Color.green;

		}
		else
		{
			spriterenderer.color=Color.white;
		}

	
	}
}
