using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // V Unity si pro InputSystem_Actions necháme vygenerovat C# tøídu. Usnadní nám to práci
    MyActions actions; 

    // Fyzikální tìlo
    Rigidbody2D body;

    // Promìnná jumpForce bude vidìt v editoru, protože je public
    public float jumpForce = 200;
    
    // Tohle se volá pøi startu objektu
    void Start()
    {
        actions = new();    // Vytvoøení akcí
        actions.Enable();   // Povolení akcí (Dùležité! Jinak to nefunguje)
        body = GetComponent<Rigidbody2D>(); // Získání odkazu na fyziku
    }

    // Tohle se volá pøi každém snímku
    void Update()
    {
        if (actions.Player.Jump.WasPerformedThisFrame()) // Nastala bìhem tohoto snímku akce Jump 
        {
            body.AddForceY(jumpForce);  // Použij sílu smìrem nahoru
        }
    }
}
