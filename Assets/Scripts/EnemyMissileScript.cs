using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMissileScript : MonoBehaviour
{
    GameManager gameManager;
    EnemyScript enemyScript;
    public Vector3 targetTileLocation;
    private int targetTile = -1;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        enemyScript = GameObject.Find("Enemy").GetComponent<EnemyScript>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ship"))
        {
            if (collision.gameObject.name == "Submarine") targetTileLocation.y += 0.3f;
            gameManager.EnemyHitPlayer(targetTileLocation, targetTile, collision.gameObject);
        }
        else
        {
            enemyScript.PauseAndEnd(targetTile);
        }
        Destroy(gameObject);
    }

    public void SetTarget(int target)
    {
        targetTile = target;
    }
}
