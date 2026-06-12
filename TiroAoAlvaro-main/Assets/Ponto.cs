using UnityEngine;
using TMPro;

public class Ponto : MonoBehaviour
{
    float points = 0;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        scoreText.text = "0";
    }

    public void AddPoints()
    {
        points++;
        scoreText.text = points.ToString();
    }
}
