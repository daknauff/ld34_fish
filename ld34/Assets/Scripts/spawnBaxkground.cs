using UnityEngine;
using System.Collections;


public class spawnBaxkground : MonoBehaviour {


    void Update() 
    {
    
    
    }


    void OnBecameInvisible() 
    {
        Vector3 oldpos = this.gameObject.transform.position;
        oldpos.x += 2*18.25f;
        this.gameObject.transform.position = oldpos;
    }

}
