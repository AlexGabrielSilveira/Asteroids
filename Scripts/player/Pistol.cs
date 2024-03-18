using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    public List<GameObject> prefabs;
    private float interval = 0.3f;
    private float cooldown = 0;

    void Update()
    {   
        cooldown -= Time.deltaTime;
        if( cooldown < 0 ) {
            cooldown = interval;

            var isPressingSpace = Input.GetKey(KeyCode.Space);

            if(isPressingSpace) {
                ShotPistol();
            }
        }
    }

    private void ShotPistol()
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
        if (transform.position.y > 10f)
        {
            Destroy(gameObject);
        }
    }
}
