using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveCamera : MonoBehaviour
{
	[SerializeField]
	private Camera[] cameras; 
	void Start()
    {
		
		cameras = FindObjectsOfType<Camera>(); // Burada sahnedeki tüm kameralarý alýyoruz

		for (int i = 1; i < cameras.Length; i++) // Burada ise ilk kamera hariç diðer kameralarý kapatýyoruz (NOT = En Son eklenen Kamera ilk kamera oluyor)
		{
			cameras[i].gameObject.SetActive(false); 
		}
	}

    void Update()
    {
		for (int i = 0; i < cameras.Length; i++) // Kaç Kamera varsa for ile dönüyoruz
		{
			if (Input.GetKeyDown(KeyCode.Alpha1 + i)) 
			{
				foreach (Camera cam in cameras)
				{
					cam.gameObject.SetActive(false); // tekrardan tüm kameralarý kapatýp 
				}

				cameras[i].gameObject.SetActive(true); // burada ise basýlan tuþa göre olan kamerayý açýyoruz
			}
		}
	}
}
