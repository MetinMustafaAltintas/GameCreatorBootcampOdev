using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveCamera : MonoBehaviour
{
	[SerializeField]
	private Camera[] cameras; 
	void Start()
    {
		
		cameras = FindObjectsOfType<Camera>(); // Burada sahnedeki t�m kameralar� al�yoruz

		for (int i = 1; i < cameras.Length; i++) // Burada ise ilk kamera hari� di�er kameralar� kapat�yoruz (NOT = En Son eklenen Kamera ilk kamera oluyor)
		{
			cameras[i].gameObject.SetActive(false); 
		}
	}

    void Update()
    {
		for (int i = 0; i < cameras.Length; i++) // Ka� Kamera varsa for ile d�n�yoruz
		{
			if (Input.GetKeyDown(KeyCode.Alpha1 + i)) 
			{
				foreach (Camera cam in cameras)
				{
					cam.gameObject.SetActive(false); // tekrardan t�m kameralar� kapat�p 
				}

				cameras[i].gameObject.SetActive(true); // burada ise bas�lan tu�a g�re olan kameray� a��yoruz
			}
		}
	}
}
