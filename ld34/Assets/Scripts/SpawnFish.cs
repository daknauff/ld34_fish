using UnityEngine;
using System.Collections;


public class SpawnFish : MonoBehaviour {
	public GameObject[] Fishes;



    // Use this for initialization
    void Start () {
	
	}

	// Update is called once per frame
	void Update () {

	
	}
	public void spawn(float playerscale)
	{
		GameObject GO =(GameObject) Instantiate(Fishes[Random.Range(0,Fishes.Length)],this.transform.position,Quaternion.identity);
		//float newscale= Random.value*Random.Range(3,10);
		if (GO.tag=="Fish")
		{
			int minscale=(int) playerscale - 3;
			int maxscale=(int) playerscale + 3;

			float newscale= Random.Range(Mathf.Clamp(minscale,1,10),Mathf.Clamp(maxscale,1,10));
		GO.transform.localScale= new Vector3(newscale,newscale,newscale);
		}
	}

}
