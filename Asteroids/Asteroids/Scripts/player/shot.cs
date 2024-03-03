using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    public List<GameObject> prefabs;
    public float interval = 2;
    private float cooldown = 0;

    void Update()
    {   
        cooldown -= Time.deltaTime;
        if( cooldown <= 0 ) {
            cooldown = interval;
            shotPistol();
        }
    }

    private void shotPistol()
    {
        int prefabIndex = prefabs.Count - 1;
        GameObject prefab = prefabs[prefabIndex];

        Quaternion rotation = prefab.transform.rotation;
        Vector2 position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);

        GameObject instantiatedPrefab = Instantiate(prefab, position, rotation);
        
        instantiatedPrefab.AddComponent<TemporaryPrefabDestroyer>();
    }
}
public class TemporaryPrefabDestroyer : MonoBehaviour
{

    void Update()
    {
        if (transform.position.x > 20f)
        {
            Destroy(gameObject);
        }
    }
}
