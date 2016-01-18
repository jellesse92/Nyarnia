using UnityEngine;
using System.Collections;

public class CatSpawner : MonoBehaviour {
	
	GameState gameState;
    public float spawnTimer;
    private float timer;
    public int cat_limit;
    private int cats_from_spawner = 0;
    public const int number_of_cats = 2;
    public GameObject[] cats = new GameObject[number_of_cats];
    public Transform spawnPoint;
    
	// Use this for initialization
	void Start () {
		timer = spawnTimer;
		gameState = GameObject.Find ("GameManager").GetComponent<GameState>();
	}
	
	// Update is called once per frame
	void Update () {
		if (gameState.inPlay) {
			timer -= Time.deltaTime;
			if (timer <= 0 & cats_from_spawner < cat_limit) {
				timer = spawnTimer;
				Instantiate (cats [Random.Range (0, 2)], spawnPoint.position, spawnPoint.rotation);
				cats_from_spawner++;
			}
		}
	}
}
