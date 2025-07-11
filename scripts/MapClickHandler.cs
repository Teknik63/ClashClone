using UnityEngine;

public class MapClickHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Sol týklama
        {
            if (Camera.main == null)
            {
                Debug.LogError("Kamera Yok.");
                return;
            }

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                AreaIdentifier area = hit.collider.gameObject.GetComponent<AreaIdentifier>();
                if (area != null)
                {
                    int areaNumber = area.areaNumber;
                    Debug.Log("Alan " + areaNumber + " Týklandý!");
                    // Týklama sonrasý iþlemleri buraya ekleyin.
                }
                else
                {
                    Debug.LogWarning("Alan Numarasý içeren Collider Yok.");
                }
            }
        }
    }
}
