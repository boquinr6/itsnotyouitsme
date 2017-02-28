
using UnityEngine; 
using System.Collections;

public class spawnScript : MonoBehaviour { 

    // Variable to store the enemy prefab
	public GameObject enemy;
	public GameObject goodMessage;
//	Renderer rd;

    // Variable to know how fast we should create new enemies
	public float spawnTime = 1f;

    void Start() {
        
    }

    // New function to spawn an enemy
    void addEnemy() {
        // Get the renderer component of the spawn object
//		rd = GetComponent<Renderer>();

        // Position of the left edge of the spawn object
        // It's: (position of the center) minus (half the width)
//        float x1 = transform.position.x - rd.bounds.size.x/2;
//
//        // Same for the right edge
//        float x2 = transform.position.x + rd.bounds.size.x/2;

		Vector2 min = Camera.main.ViewportToWorldPoint (new Vector2 (0, 0));
		Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1, 1));

        // Randomly pick a point within the spawn object
//		Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);
//		spawnPoint = Camera.main.ViewportToWorldPoint(spawnPoint);

        // Create an enemy at the 'spawnPoint' position
//		Instantiate(enemy, spawnPoint, Quaternion.identity);
        GameObject anEnemy = Instantiate(enemy);
		GameObject aMessage = Instantiate(goodMessage);
		anEnemy.transform.position = new Vector2 (min.x, Random.Range (min.y + 3f, max.y));
		aMessage.transform.position = new Vector2 (min.x, Random.Range (min.y + 3f, max.y));
    } 

	public void ScheduleEnemySpawner() {
		// Call the 'addEnemy' function in 0 second
		// Then every 'spawnTime' seconds
		InvokeRepeating("addEnemy", 0, spawnTime);
	}

	public void UnscheduleEnemySpawner() {
		CancelInvoke ("addEnemy");
	
	}
}