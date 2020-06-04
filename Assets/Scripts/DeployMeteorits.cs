using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployMeteorits : MonoBehaviour
{
    public GameObject Meteorit;
    public GameObject MeteoritSmall;
    public GameObject MeteoritBig;
    public float respawnTime = 4.0f;

    void Start()
    {
        Camera camera = gameObject.GetComponent<Camera>();
        StartCoroutine(MeteoritWave());
    }
    private void spawnEnemy()
    {
        GameObject a = Instantiate(Meteorit) as GameObject;
        a.transform.position = new Vector3(415, Random.Range(120, 134), -5.5f);

        GameObject b = Instantiate(MeteoritSmall) as GameObject;
        b.transform.position = new Vector3(415, Random.Range(120, 134), -5.5f);

        GameObject c = Instantiate(MeteoritBig) as GameObject;
        c.transform.position = new Vector3(415, Random.Range(120, 134), -5.5f);
    }

    IEnumerator MeteoritWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
