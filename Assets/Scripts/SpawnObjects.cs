using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject obstacle;
    public Transform ground;
    float Timer = 0;
    float lastRandom = 1000;
    // Update is called once per frame
    void Update()
    {
        if (Timer >= 20)
        {
            Timer = 0;
            float newRandom = Random.Range(-6.5f, 6.5f);
            while (lastRandom == newRandom)
            {
                newRandom = Random.Range(-6.5f, 6.5f);
            }
            lastRandom = newRandom;
            Instantiate(obstacle, new Vector3(newRandom, 1, ground.localScale.z - 15), Quaternion.identity);
        }
        Timer += Time.deltaTime * 100;
    }
}
