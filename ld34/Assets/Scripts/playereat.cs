using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playereat : MonoBehaviour {
	public AudioSource eating;
    private int Fisheaten;
    public int FishForNextLevel = 10;
    public Text myText;
	
    void Update()
	{
        if (Fisheaten == FishForNextLevel) 
        {
            SceneManager.LoadScene("Level2");
        }
	}
    
    public void SetText(string text)
    {
        myText.text = "eaten : " + Fisheaten +"/" + FishForNextLevel;
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        float newscale = transform.localScale.x;
        if (col.transform.localScale.x <= transform.localScale.x) 
        {

			if (col.gameObject.tag == "Fish")
			{
				SimplePool.Despawn(col.gameObject);
	            newscale++;
				eating.Play();
	            transform.localScale = new Vector3(newscale, newscale, newscale);
                Fisheaten++;
                myText.text = "eaten : " + Fisheaten + "/" + FishForNextLevel;
			}
        }
    }
}
