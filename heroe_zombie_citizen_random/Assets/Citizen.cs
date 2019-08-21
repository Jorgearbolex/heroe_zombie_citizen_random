using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Citizen : MonoBehaviour
{
    public sCitizen citizen = new sCitizen();
    public static string[] cNames;

    private void Awake()
    {
        cNames = new string[]
        {
            "Mauricio Patricia",
            "Anaximandro Suarez",
            "Mario Alberto Juvenal Ultrasubliminal",
            "Silbestre Changón",
            "Eggie Huevard Cholesterrollinger",
            "Jean Kratoz Osorio",
            "Lion Scott Calvin",
            "Jaime Caningas y quiero Yogurt Light y ver Endgame",
            "La familia del mello sin aurora",
            "Jesús Padre Santo Bendito Adorado Amen",
            "La Virgen de Guadalupe",
            "Ironspiderman Segundo lll",
            "Brayánides de mileto",
            "Toñócrates",
            "Jerundiógenes de Sínope",
            "Mohamed Gonzales",
            "Adolf Hittler",
            "Joseph Stalin",
            "Madre Laura",
            "Jota Mario"
        };
        
    }
    
}

public struct sCitizen
{
    public string name;
    public int age;
}