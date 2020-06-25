using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Tokuten : MonoBehaviour
{
    public Text Tensuu;
    private int score = 0;

    void Start()
    {
        score = 0;
        SetScore();
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(score);

        string yourTag = collision.gameObject.tag;
        if (yourTag == "SmallStarTag")
        {
            score += 5;
        }
        else if (yourTag == "LargeStarTag")
        {
            score += 10;
        }
        else if (yourTag == "SmallCloudTag")
        {
            score += 20;
        }
        else if (yourTag == "LargeCloudTag")
        {
            score += 30;
        }

        Debug.Log(yourTag);

        SetScore();
    }

    void SetScore()
    {
        this.Tensuu.text = score.ToString();
    }
}