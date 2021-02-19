using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GravityManager
{
    const float GravitationalConstant = -0.00000000006672f;

    public static List<GravityManagerNode> NodeCollection= new List<GravityManagerNode>();
    public static float timescale = 10000f;
   

    public static void RegisterCelestialBody(GravityManagerNode node)
    {
        if (!NodeCollection.Contains(node))
        {
            NodeCollection.Add(node);
        }
    }
    public static Vector2 GetForce(GravityManagerNode node)
    {
        Vector2 force=Vector2.zero;
        foreach (var _node in NodeCollection)
        {
            if (_node==node)
            {
                continue;
            }
            force += GravitationalConstant*(getdiffrence(node.transform.position, _node.transform.position).normalized * ((node.massKg* _node.massKg)))/(Mathf.Pow((getdiffrence(node.transform.position, _node.transform.position)).magnitude,2));
        }







        return force*node.massKg*timescale;
    }
    public static Vector2 getdiffrence(Vector2 A, Vector2 B) =>
        new Vector2(A.x - B.x, A.y - B.y);
    public static Vector2 ToVector2(Vector3 vector) => 
        new Vector2(vector.x, vector.y);
}
