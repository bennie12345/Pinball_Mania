using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    private Vector3 startPos;
    private float newXPos = 0f;
    [SerializeField]private GameObject Enemy;
	[SerializeField]private float timeUntilSpawn = 0f;
    [SerializeField]private float secondsBetweenSpawn = 3f;
    // Use this for initialization
    void Start()
    {
        startPos = this.transform.position;
    }

    void SpawnEnemy()
    {

        GameObject myEnemy = Instantiate(Enemy) as GameObject;
		newXPos = Random.Range(transform.position.x - 5, transform.position.x + 6);
		myEnemy.transform.position = new Vector3(newXPos, startPos.y, startPos.z);
    }

    // Update is called once per frame
    void Update()
    {
		timeUntilSpawn += Time.deltaTime;

        if (timeUntilSpawn >= secondsBetweenSpawn)
        {
            timeUntilSpawn = 0;
            SpawnEnemy();
        }
    }
}
