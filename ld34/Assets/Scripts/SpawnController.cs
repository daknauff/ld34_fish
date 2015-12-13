using UnityEngine;
using System.Collections;

public class SpawnController : MonoBehaviour
{
    public GameObject[] spawners;
    public int spawntimer = 1;





	// Use this for initialization
	void Start () {       
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!IsInvoking("startspawner"))
		{
			Invoke("startspawner",(Random.value+Random.value+Random.value));
		}
	}

	void startspawner()
	{
		spawners[Random.Range(0,spawners.Length)].SendMessage("spawn");
	}
}
