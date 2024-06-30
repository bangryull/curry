using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bullet;
    public GameObject player;
    
    public float spawnRate;
    private float t;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // (spawnRate)초 마다 총알 생성 
        t -= Time.deltaTime;
        if (t <= 0)
        {
            GameObject newBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            if(player != null) newBullet.GetComponent<Bullet>().SetTarget(player);
            
            t = spawnRate;
        }
    }
}
