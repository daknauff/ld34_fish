using UnityEngine;
using System.Collections;


public class SpawnFish : MonoBehaviour {
	public GameObject[] Fishes;
	int playerscale=1;



    // Use this for initialization
    void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		playerscale = (int) GameObject.Find("player").GetComponent<Transform>().localScale.x;
	
	}
	public void spawn()
	{
		GameObject GO =(GameObject) SimplePool.Spawn (Fishes[Random.Range(0,Fishes.Length)],this.transform.position,Quaternion.identity);

		if (GO.tag=="Fish")
		{
			int minscale = playerscale;
			int maxscale= playerscale+4;

			float newscale= Random.Range(minscale,maxscale);
			GO.transform.localScale= new Vector3(newscale,newscale,newscale);
		}
	}

}
