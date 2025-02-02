using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FotoFinish : MonoBehaviour
{
    /*
     *  Erstelle eine coole Kamera-Einstellung f�r das Ende des Rennens,
     *  indem du mit der switchCamera()-Methode die Kamera wechselst und
     *  das Rennen in Slow-Motion abspielen l�sst, sobald ein Auto den
     *  Collider an diesem GameObject ber�hrt!
     *
     *  Experimentiere auch mit verschiedenen Varianten von Slow-Motion.
     *  Zum Beispiel, indem du die Zeitskala �ber einen bestimmten Zeitraum
     *  kontinuierlich ver�nderst oder das Spiel f�r einige Momente im
     *  Standbild l�sst, kurz bevor die Autos die Ziellinie �berqueren.
     *  Programmiere diese zeitlichen Verl�ufe mit geeigneten Mitteln!
     */

    [SerializeField] private Camera finishLineCamera;
    [SerializeField] private Camera carCamera;

    private void switchCamera()
    {
        finishLineCamera.enabled = true;
        carCamera.enabled = false;
    }
}
