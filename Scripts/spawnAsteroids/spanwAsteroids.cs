using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spanwAsteroids : MonoBehaviour
{
    // Start is called before the first frame update
    public float interval = 1f;
    private float cooldown = 0;

    public List<GameObject> Asteroids;

    void Update()
    {
        cooldown -= Time.deltaTime;

        if( cooldown < 0) {
            cooldown = interval;

            int asteroidsIndex = Random.Range(0, Asteroids.Count);
            GameObject Asteroid = Asteroids[asteroidsIndex];

            Quaternion rotation = Asteroid.transform.rotation;

            var xOffset = Random.Range(-GameManager.Instance.gameWidth /2f, GameManager.Instance.gameWidth / 2f);
            Vector2 position = new Vector2(xOffset, 9f);

            Instantiate(Asteroid, position, rotation);
        }
    }
}
