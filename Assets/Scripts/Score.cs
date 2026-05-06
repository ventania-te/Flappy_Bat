using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private float score = 0f;
    [SerializeField] private TextMeshProUGUI scoreText;

    //Aumentar a Dificuldade
    private int level = 1;
    private float proximolevel = 10f;

    void Update()
    {
        if(PlayerController.Instance.gameStarted)
        {
            sistemaPontos();
        }
    }


    private void sistemaPontos()
    {
        score += Time.deltaTime;
        scoreText.text = "Score: "  + Mathf.FloorToInt(score).ToString();
    }

    public int GanhaLevel()
    {
        if (score >= proximolevel)
        {
            level++;
            proximolevel += 10f;
        }
        return level;
    }
}
