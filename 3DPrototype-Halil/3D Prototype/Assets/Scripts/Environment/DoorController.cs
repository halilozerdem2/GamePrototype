using UnityEngine;

public class DoorController : MonoBehaviour
{
    [Header("Kap� Ayarlar�")]
    [SerializeField] private float openDistance = 3f;  // Kap� a��lma mesafesi
    [SerializeField] private float openSpeed = 2f;     // Kap� a��lma h�z�
    [SerializeField] private float maxOpenAngle = 90f; // Kap�n�n a��laca�� maksimum a��

    private bool isPlayerNear = false;   // Oyuncu kap�ya yakla�t���nda kontrol
    private bool isDoorOpen = false;     // Kap� a��k m�?

    private Transform player; // Oyuncu referans�
    private float closedRotationZ;  // Kap�n�n kapal� hali Z rotasyonu
    private float openRotationZ;    // Kap�n�n a��k hali Z rotasyonu

    private void Start()
    {
        closedRotationZ = transform.rotation.eulerAngles.z; // Kap� ba�lang��ta kapal�
        openRotationZ = closedRotationZ + maxOpenAngle; // Kap� sa�a a��lacak (z ekseninde)
        player = Camera.main.transform; // Oyuncu kameray� kullan�yoruz
    }

    private void Update()
    {
        // E�er oyuncu kap�ya yak�nsa, kap�y� a�maya ba�la
        if (isPlayerNear && !isDoorOpen)
        {
            OpenDoor();
        }
        else if (!isPlayerNear && isDoorOpen)
        {
            CloseDoor();
        }
    }

    private void OpenDoor()
    {
        // Kap�y� z ekseninde yava��a a��yoruz
        float currentRotationZ = Mathf.LerpAngle(transform.rotation.eulerAngles.z, openRotationZ, Time.deltaTime * openSpeed);
        transform.rotation = Quaternion.Euler(0, 0, currentRotationZ);

        // Kap� tam a��ld���nda durur
        if (Mathf.Abs(transform.rotation.eulerAngles.z - openRotationZ) < 1f)
        {
            isDoorOpen = true;
        }
    }

    private void CloseDoor()
    {
        // Kap�y� z ekseninde yava��a kapat�yoruz
        float currentRotationZ = Mathf.LerpAngle(transform.rotation.eulerAngles.z, closedRotationZ, Time.deltaTime * openSpeed);
        transform.rotation = Quaternion.Euler(90,0, currentRotationZ);
        
        // Kap� tam kapand���nda durur
        if (Mathf.Abs(transform.rotation.eulerAngles.z - closedRotationZ) < 1f)
        {
            isDoorOpen = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // E�er oyuncu kap�ya yakla��rsa
        {
            isPlayerNear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // E�er oyuncu kap�dan uzakla��rsa
        {
            isPlayerNear = false;
        }
    }
}
