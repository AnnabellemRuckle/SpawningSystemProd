using UnityEngine;

public class DayFactory : AbstractFactory
{
    public GameObject dayPrefab;

    public override GameObject CreateObject()
    {
        GameObject spawnedObject = Instantiate(dayPrefab);
        return spawnedObject;
    }
}
