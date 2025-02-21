using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // V Unity si pro InputSystem_Actions nech�me vygenerovat C# t��du. Usnadn� n�m to pr�ci
    MyActions actions; 

    // Fyzik�ln� t�lo
    Rigidbody2D body;

    // Prom�nn� jumpForce bude vid�t v editoru, proto�e je public
    public float jumpForce = 200;
    
    // Tohle se vol� p�i startu objektu
    void Start()
    {
        actions = new();    // Vytvo�en� akc�
        actions.Enable();   // Povolen� akc� (D�le�it�! Jinak to nefunguje)
        body = GetComponent<Rigidbody2D>(); // Z�sk�n� odkazu na fyziku
    }

    // Tohle se vol� p�i ka�d�m sn�mku
    void Update()
    {
        if (actions.Player.Jump.WasPerformedThisFrame()) // Nastala b�hem tohoto sn�mku akce Jump 
        {
            body.AddForceY(jumpForce);  // Pou�ij s�lu sm�rem nahoru
        }
    }
}
