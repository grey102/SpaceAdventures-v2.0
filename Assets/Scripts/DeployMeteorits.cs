using System.Collections;
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
        a.transform.position += new Vector3(Random.Range(-7, -0.1f), 1, Random.Range(25f, 30));

        //GameObject b = Instantiate(MeteoritSmall) as GameObject;
        //b.transform.position += new Vector3(Random.Range(-7, 8), 1, 15.7f);

        GameObject c = Instantiate(MeteoritBig) as GameObject;
        c.transform.position += new Vector3(Random.Range(0.1f, 8), 1, Random.Range(25f, 30));
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
