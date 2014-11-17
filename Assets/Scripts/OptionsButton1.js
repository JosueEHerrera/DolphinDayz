
function Update ()
{
    if ( Input.GetMouseButton(0)) {
        var hit : RaycastHit;
        var ray : Ray = Camera.main.ScreenPointToRay (Input.mousePosition);
        if (Physics.Raycast (ray, hit)) {
            if (hit.transform.tag == "options") {
                Application.LoadLevel (2);
            }
        }
    }
}