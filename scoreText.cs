using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoreText : MonoBehaviour
{

    public float speed;
    public Text score;
    public Text winText;

    private Rigidbody rb;
    private int count;

    void Start()
    {
        score = GetComponent<Text>();
    }

    void SetCountText()
    {
        score.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            winText.text = "You Win!";
        }
        Debug.Log(score.text);
    }
}