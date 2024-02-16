using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class spheres : MonoBehaviour
{
    public GameObject sphere;

    public int sphereAmount = 200;

    float posx;
    float posy;
    float posz;

    bool didClone = false;

    List<GameObject> sphereList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        posx = sphere.transform.position.x;
        posy = sphere.transform.position.y;
        posz = sphere.transform.position.z;

        if (posy >= -7 && posy <= -6 && didClone == false) {
            Debug.Log("Collision Detected");

            sphereList = new List<GameObject>();

            for (int i = 0; i < sphereAmount; i++) {
                Debug.Log(i);
                float posx = Random.Range(30f,70f);
                float posy = Random.Range(-6f,6f);
                float posz = Random.Range(10f,30f);
                Vector3 newPos = new Vector3(posx, posy, posz);
                sphereList.Add(Instantiate(sphere, newPos, Quaternion.identity));
            } 
            
            didClone = true;           
        }
    }
}
