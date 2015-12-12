using UnityEngine;
using System.Collections;

public class SpawnController : MonoBehaviour
{
    public GameObject[] spawners;
    public int spawntimer = 1;
	float playerscale;




	// Use this for initialization
	void Start () {
		playerscale = GameObject.Find("player").GetComponent<Transform>().localScale.x; 
		InvokeRepeating("startspawner",spawntimer,spawntimer);
        
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void startspawner()
	{
		spawners[Random.Range(0,spawners.Length)].SendMessage("spawn",playerscale);
	}
}
