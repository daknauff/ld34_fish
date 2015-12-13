using UnityEngine;
using System.Collections;


public class spawnBaxkground : MonoBehaviour {


    void Update() 
    {
    
    
    }


    void OnBecameInvisible() 
    {
        float width = 9.14f;
        //calculate current position
        Vector3 backPos = gameObject.transform.position;
        //calculate new position

        float X = backPos.x + width * 4;
        float Y = backPos.y;
        //move to new position when invisible
        gameObject.transform.position = new Vector3(X, Y, 0f);
        //Vector3 oldpos = this.gameObject.transform.position;
        //oldpos.x += 2*18.25f;
        //this.gameObject.transform.position = oldpos;
    }

}
