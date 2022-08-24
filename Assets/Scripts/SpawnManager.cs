using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public DragAndDrop dragAndDrop;

    [SerializeField]
    private List<GameObject> newBottom;
    [SerializeField]
    private List<GameObject> newTop;
    [SerializeField]
    private List<GameObject> newHat;
    [SerializeField]
    private Transform spawPos1, spawPos2, spawPos3, spawPos4, spawPos5, spawPos6;


    private void OnEnable()
    {
        dragAndDrop.IsPlaced += spawnNewGarment;
    }
    private void OnDisable()
    {
        dragAndDrop.IsPlaced -= spawnNewGarment;
    }


    void spawnNewGarment()
    {
        GameObject randomGarment = newBottom[Random.Range(0, newBottom.Count)];
        Vector3 spawn = new Vector3(spawPos1.transform.position.x, spawPos1.transform.position.y);
        GameObject refGarment = Instantiate(randomGarment, spawn, Quaternion.identity);
    }

    //TODO få en funktion att kanna av vilken av plagg katogorierna som är tomma och spawna ny med hjälp av event. 
}
