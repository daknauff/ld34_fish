using UnityEngine;
using System.Collections;

public class SubBoms : MonoBehaviour {
    public GameObject bomb;
    private float fireSpellStart = 0f;
    private float fireSpellCooldown = 3f; // 2 = two seconds 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Drop () {
        
       Instantiate(bomb, transform.position, Quaternion.identity);
	}

    void Update() 
    {

        if (Time.time > fireSpellStart + fireSpellCooldown)
        {
            fireSpellStart = Time.time;

            Drop();
        }
    }
}
