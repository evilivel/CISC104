using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball
{

    private GameObject GO;
    private PhysicMaterial bounce = new PhysicMaterial();



    public Ball()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        Rigidbody SRB = sphere.AddComponent<Rigidbody>();
        sphere.GetComponent<Collider>().material = bounce;
        SRB.mass = .0001f;
        SRB.drag = 0;
        SRB.angularDrag=0;
        sphere.tag = "ball"; 
        GO = sphere;

    }

    public Ball(float Mass, float Drag, float Adrag, float Size)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        Rigidbody SRB = sphere.AddComponent<Rigidbody>();
        sphere.transform.localScale = new Vector3(Size, Size, Size);
        sphere.GetComponent<Collider>().material = bounce;
        SRB.mass = Mass;
        SRB.drag = Drag;
        SRB.angularDrag = Adrag;
        sphere.tag = "ball"; 
        GO = sphere;


    }

    public GameObject GetGO ()
    {
        return GO;
    }
}