using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class GameOverMiniGame2 : MonoBehaviour
{
    public GameObject Button_tiep;
    public AudioSource audioIncorrect;
    private InstanceVariables instanceGeneral;

    private void Start()
    {
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Opposite")
        {
            if (instanceGeneral.sound) audioIncorrect.PlayOneShot(audioIncorrect.clip);
            List<GameObject> newList = TaoNgauNhienObject.instantiatedObjects;
            Time.timeScale = 0;
            //object_panelThongDiepMini2.SetActive(true);
            Button_tiep.SetActive(true);
            foreach (var obj in newList)
            {
                if (obj != null)
                {
                    Destroy(obj);
                }
            }
            newList.Clear();
        }
    }
}
