using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    private Vector3 startPos;
    private float newXPos = 0f;
    [SerializeField]private float moveSpeed = 1f;
    [SerializeField]private float moveDistance = 20f;
    [SerializeField]private GameObject Enemy;
    [SerializeField]private float timeUntilSpawn = 0f;
    [SerializeField]private float startTime = 0f;
    [SerializeField]private float secondsBetweenSpawn = 3f;
    [SerializeField]private float offsetSpawner = 0f;
    // Use this for initialization
    void Start()
    {
        startPos = this.transform.position;
    }

    void SpawnEnemy()
    {

        GameObject myEnemy = Instantiate(Enemy) as GameObject;

        myEnemy.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        newXPos = offsetSpawner + Mathf.PingPong(Time.time * moveSpeed, moveDistance) - (moveDistance / 2f);

        transform.position = new Vector3(newXPos, startPos.y, startPos.z);

        timeUntilSpawn = Time.time - startTime;

        if (timeUntilSpawn >= secondsBetweenSpawn)
        {
            startTime = Time.time;
            timeUntilSpawn = 0;
            SpawnEnemy();
        }
    }
}
