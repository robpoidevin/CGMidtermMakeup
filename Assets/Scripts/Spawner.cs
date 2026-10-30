using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject fireball;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator Spawn()
    {
        Instantiate(fireball,gameObject.transform);
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(Spawn());
    }
}
