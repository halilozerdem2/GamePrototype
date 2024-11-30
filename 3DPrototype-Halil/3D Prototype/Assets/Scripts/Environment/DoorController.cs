using UnityEngine;

public class DoorController : MonoBehaviour
{
    [Header("Kap� Ayarlar�")]
    [SerializeField] private float openSpeed = 2f;       // Kap� a��lma h�z�
    [SerializeField] private float openAngle = 90f;     // Kap�n�n a��laca�� z eksenindeki a��

    private Vector3 closedRotation;  // Kap�n�n kapal� pozisyondaki rotasyonu
    private Vector3 targetRotation;  // Kap�n�n hedef rotasyonu
    private bool isPlayerNear = false; // Oyuncu kap�ya yakla�t���nda kontrol
    private bool isDoorOpen = false;  // Kap� a��k m�?

    private void Start()
    {
        // Kap�n�n ba�lang��taki rotasyonunu kaydet
        closedRotation = transform.rotation.eulerAngles;

        // Ba�lang��ta kap�y� kapal� pozisyona ayarla
        targetRotation = closedRotation;
        transform.rotation = Quaternion.Euler(closedRotation);
    }

    private void Update()
    {
        // E�er oyuncu kap�ya yakla�t�ysa ve kap� kapal�ysa a�
        if (isPlayerNear && !isDoorOpen)
        {
            OpenDoor();
        }
        // E�er oyuncu uzakla�t�ysa ve kap� a��ksa kapat
        else if (!isPlayerNear && isDoorOpen)
        {
            CloseDoor();
        }

        // Kap�y� hedef rotasyona do�ru hareket ettir
        transform.rotation = Quaternion.RotateTowards(
            transform.rotation,
            Quaternion.Euler(targetRotation),
            openSpeed * Time.deltaTime * 100f
        );
    }

    private void OpenDoor()
    {
        // Kap�y� a��k hale getir, sadece z ekseninde de�i�iklik yap
        targetRotation = new Vector3(closedRotation.x, closedRotation.y, closedRotation.z - openAngle);
        isDoorOpen = true;
    }

    private void CloseDoor()
    {
        // Kap�y� kapal� hale getir, ilk rotasyona geri d�n
        targetRotation = closedRotation;
        isDoorOpen = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Oyuncu kap�ya yakla��rsa
        {
            isPlayerNear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Oyuncu kap�dan uzakla��rsa
        {
            isPlayerNear = false;
        }
    }
}
