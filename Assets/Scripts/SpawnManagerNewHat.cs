using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerNewHat : MonoBehaviour
{
    public DragAndDrop dragAndDrop;

    [SerializeField]
    private List<GameObject> newHat;

    [SerializeField]
    private Transform spawPos1;


    private void OnEnable()
    {
        dragAndDrop.NewHatPlaced += spawnNewGarment;
    }
    private void OnDisable()
    {
        dragAndDrop.NewHatPlaced -= spawnNewGarment;
    }

    void spawnNewGarment()
    {
        GameObject randomGarment = newHat[Random.Range(0, newHat.Count)];
        Vector3 spawn = new Vector3(spawPos1.transform.position.x, spawPos1.transform.position.y);
        GameObject refGarment = Instantiate(randomGarment, spawn, Quaternion.identity);
    }
}
