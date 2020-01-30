using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour
{
    public GameObject spinCubePrefab;

    void Start()
    {
        int totalCubes = 6;
        float totalDistance = 2.8f;

        // Linear Distribution
        // It looks unnaturally
        /*for (int i = 0; i < totalCubes; i++)
        {
            float perc = i / (float)totalCubes;

            float x = perc * totalDistance;
            float y = 5.0f;
            float z = 0.0f;

            var newCube = (GameObject)Instantiate(spinCubePrefab, new Vector3(x, y, z), Quaternion.identity);
            newCube.GetComponent<CubeScript>().SetSize(1.0f - perc);
            newCube.GetComponent<CubeScript>().rotateSpeed = 0; //perc;
        }*/

        // SIN Distribution
        for (int i = 0; i < totalCubes; i++)
        {
            float perc = i / (float)totalCubes;
            float sin = Mathf.Sin(perc * Mathf.PI / 2);

            float x = 1.7f + sin * totalDistance;
            float y = 5.0f;
            float z = 0.0f;

            var newCube = (GameObject)Instantiate(spinCubePrefab, new Vector3(x, y, z), Quaternion.identity);
            newCube.GetComponent<CubeScript>().SetSize(.5f * (1.0f - perc));
            newCube.GetComponent<CubeScript>().rotateSpeed = .2f + perc * 4.0f;
        }
    }

    void Update()
    {
        
    }
}
