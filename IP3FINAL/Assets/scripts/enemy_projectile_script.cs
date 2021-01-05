using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_projectile_script : MonoBehaviour
{
    public GameObject enemyprojectil;
    Vector3 respawn = new Vector3(7, 4, 0);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -3 * Time.deltaTime, 0));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            collision.gameObject.transform.position = respawn;
            Destroy(enemyprojectil);
            GameManager.lives--;
            GameManager.playGame = false;
        }
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(enemyprojectil);
        }
    }
}
