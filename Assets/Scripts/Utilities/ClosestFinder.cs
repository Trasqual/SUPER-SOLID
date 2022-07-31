using UnityEngine;

public static class ClosestFinder
{
    public static Transform FindClosestTransform(Vector3 center, Component[] listOfObjects)
    {
        Transform closest = null;
        float closestDist = Mathf.Infinity;
        for (int i = 0; i < listOfObjects.Length; i++)
        {
            var dir = listOfObjects[i].transform.position - center;
            var dist = dir.sqrMagnitude;
            if(dist < closestDist)
            {
                closestDist = dist;
                closest = listOfObjects[i].transform;
            }
        }

        return closest;
    }
}
