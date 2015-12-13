using UnityEngine;
using System.Collections;


public class SpawnFish : MonoBehaviour {
	public float Scale= 0.25f;
	public int level=1;
	public GameObject[] Fishes;
	public Transform FishBowl;
	float playerscale;



    // Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
		playerscale = Playerscale.Scale * Playerscale.level;
	
	}
	public void spawn()
	{
		GameObject GO =(GameObject) SimplePool.Spawn (Fishes[Random.Range(0,Fishes.Length)],this.transform.position,Quaternion.identity);

		if (GO.tag=="Fish")
		{
			int minscale = Playerscale.level;
			int maxscale= Playerscale.level+8;

			float newscale= Random.Range(minscale,maxscale)*Scale;
			GO.transform.localScale= new Vector3(newscale,newscale,newscale);
            GO.transform.SetParent(FishBowl);
		}
	}

}
