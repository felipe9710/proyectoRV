using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject zombie;
    public float posX;
    public float posZ;
    public int zombieCont;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnDrop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnDrop()
    {
        while(zombieCont < 5)
        {
            posX = Random.Range(0, 10);
            posZ = Random.Range(0, 10);
            Instantiate(zombie, new Vector3(posX, 0.35f, posZ), Quaternion.identity);
            yield return new WaitForSeconds(4.0f);
            zombieCont += 1;
        }

    }

}
