using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public float firstFloat = 0;
    public float secondFloat = 2;
    public float thirdFloat = 5.3f;
    private float forthFloat = 364;

    public int firstInt = 1;
    public int secondInt = -3;


    public Color myColour = Color.black;
    public bool myBool = true;
    public char myChar = 'D';
    public Vector2 myVector2 = new Vector2(0,3);
    public Vector3 myVector3 = new Vector3(0,3,2);
    public Vector4 myVector4 = new Vector4(0,3, 0.1f,3);
    public List<float> myFloatList = new List<float>();
    public List<int> myIntList = new List<int>();
    public List<Color> myColourList = new List<Color>();
    public List<Vector3> MyVectorList = new List<Vector3>();



}
