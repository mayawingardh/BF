using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerNewHat : MonoBehaviour
{
    //public DragAndDrop dragAndDrop;

    //[SerializeField]
    //private List<GameObject> newHat;

    //[SerializeField]
    //private Transform spawPos1;


    public void spawnNewGarment(List<GameObject> garment, Transform spawnPos )
    {
        GameObject randomGarment = garment[Random.Range(0, garment.Count)];
        Vector3 spawn = new Vector3(spawnPos.transform.position.x, spawnPos.transform.position.y);
        GameObject refGarment = Instantiate(randomGarment, spawn, Quaternion.identity);
    }
}
