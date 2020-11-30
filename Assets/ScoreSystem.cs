using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField]
    private Text ScoreText;
    public int Score;
    [SerializeField]
    public string ScoreString;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PointUp()
    {
        Score = Score + 1;
        if(ScoreString == null)
        {
            ScoreString = "Wynik: ";
        }
        ScoreText.text = ScoreString + Score.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
