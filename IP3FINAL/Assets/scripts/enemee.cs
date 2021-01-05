using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemee : MonoBehaviour
{
    float timer = 0;
    float timeToMove = 0.5f;
    int numOfMovements = 0;
    float speed = 0.25f;
    public GameObject enemyProjectile;
    public GameObject enemyProjectileClone;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (GameManager.playGame)
        {
            if (timer > timeToMove && numOfMovements < 9)
            {
                transform.Translate(new Vector3(speed, 0, 0));
                timer = 0;
                numOfMovements++;
            }
            if (numOfMovements == 9)
            {
                transform.Translate(new Vector3(0, -0.5f, 0));
                numOfMovements = -1;
                speed = -speed;
                timer = 0;
            }
            fireEnemy();
        }
    }
    void fireEnemy()
    {
        if(Random.Range(0f, 775f) < 1)
        {
            enemyProjectileClone = Instantiate(enemyProjectile, new Vector3(enemy.transform.position.x, enemy.transform.position.y - 0.6f, 0), enemy.transform.rotation);
        }
    }
}
