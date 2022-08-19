using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public float queueTime;
    private float time = 0;
    public GameObject floor;

    public float height;
    // Start is called before the first frame update
    void Start()
    {
        queueTime = 1f;
        height = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > queueTime)
        {
            GameObject go = Instantiate(floor);
            go.transform.position = transform.position + new Vector3(Random.Range(-height, height), 0, 0);

            time = 0;

            Destroy(go, 10);
        }

        time += Time.deltaTime;
    }
}
