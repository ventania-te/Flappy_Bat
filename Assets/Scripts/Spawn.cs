using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 2f;
    public Vector3 spawnPosition = new Vector3(14f, -2f, 0f);
    private float timer;

    //Dificuldade do Game
    public float MaximoY = -0.1f;
    public float MinimoY = -3f;

    private void Update()
    {
        if (PlayerController.Instance.gameStarted && !GameOver.Instance.IsGameOver)
        {
            timer -= Time.deltaTime;
            if (timer < 0f)
            {
                SpawnObstacle();
                timer = spawnInterval;
            }
        }
    }


     void SpawnObstacle()
    {
        spawnPosition.y = Random.Range(MinimoY, MaximoY);
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);  
    }
}
