using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmoney : MonoBehaviour
{
    public GameObject[] money;

    [SerializeField] float minTrans;
    [SerializeField] float maxTrans;
    public float timespawn;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMoney());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnMoney()
    {
        while(true)
        {
            var pointspawn = Random.Range(minTrans, maxTrans);

            var position = new Vector3(pointspawn, transform.position.y);

            GameObject gameObject = Instantiate(money[Random.Range(0, money.Length)],position,Quaternion.identity);

            yield return  new WaitForSeconds(timespawn);

            Destroy(gameObject,10f);
        }
    }
}
