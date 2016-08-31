using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class basketMade : MonoBehaviour {

    public Text scoreText;
    public int count;
    // Use this for initialization
    void Start()
    {
        scoreText.text = "initialText";
        count = 0;
        setCountText();
    }

	void OnCollisionEnter ()
    {
        Debug.Log("Collision");
        Debug.Log("there was one");
        count = count + 1;
        setCountText();
	}

    void setCountText()
    {
        scoreText.text = "Count: " + count.ToString();
    }
	
	// Update is called once per frame
	void OnTriggerEnter ()
    {   
        Debug.Log("Trigger");
	}
}
