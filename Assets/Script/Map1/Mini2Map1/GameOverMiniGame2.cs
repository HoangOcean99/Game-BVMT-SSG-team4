using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class GameOverMiniGame2 : MonoBehaviour
{
    public GameObject Button_tiep;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Opposite")
        {
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
