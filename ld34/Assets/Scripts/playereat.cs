using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playereat : MonoBehaviour {
	public AudioSource eating;
    private int Fisheaten;
    public int FishForNextLevel = 10;
    public Text myText;

    void Start() 
    {
        float newScale = Playerscale.level*Playerscale.Scale;
        transform.localScale = new Vector3(newScale,newScale,newScale);
    }

    void Update()
	{
        if (Fisheaten == FishForNextLevel) 
        {
            Playerscale.speedincrease++;
            Playerscale.swapscene();
            SceneManager.LoadScene("nextlevel");
        }
	}
    
    public void SetText(string text)
    {
        myText.text = "eaten : " + Fisheaten +"/" + FishForNextLevel;
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.transform.localScale.x <= transform.localScale.x) 
        {

			if (col.gameObject.tag == "Fish")
			{
				SimplePool.Despawn(col.gameObject);
				Playerscale.level++;
				float newscale=Playerscale.level*Playerscale.Scale;
				eating.Play();
	            transform.localScale = new Vector3(newscale, newscale, newscale);
                Fisheaten++;
                myText.text = "eaten : " + Fisheaten + "/" + FishForNextLevel;
			}
        }
    }
}
