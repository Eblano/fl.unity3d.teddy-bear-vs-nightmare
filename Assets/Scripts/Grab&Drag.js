var grabbed : Transform;
var grabDistance : float = 10.0f;
 
var useToggleDrag : boolean; // Didn't know which style you prefer. 
 
 
#if (UNITY_IPHONE || UNITY_ANDROID)

function Update () {
    if (useToggleDrag)
        UpdateToggleDrag();
    else
        UpdateHoldDrag();
}
 
// Toggles drag with mouse click
function UpdateToggleDrag () {
    if (Input.GetMouseButtonDown(0)) 
        Grab();
    else if (grabbed)
        Drag();
}
 
// Drags when user holds down button
function UpdateHoldDrag () {
    if (Input.GetMouseButton(0)) 
        if (grabbed)
            Drag();
        else 
            Grab();
    else
        grabbed = null;
}
 
function Grab() {
    if (grabbed) 
       grabbed = null;
    else {
        var hit : RaycastHit;
        var ray : Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, hit))   {       
        	if(hit.transform.tag != "Wall" && hit.transform.tag != "Terrain")
            {
                grabbed = hit.transform;
                }
                }
    }
}
 
function Drag() {
    var ray : Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    var position : Vector3 = transform.position + transform.forward * grabDistance;
    var plane : Plane = new Plane(-transform.forward, position);
    var distance : float;
    if (plane.Raycast(ray, distance)) {
        grabbed.position = ray.origin + ray.direction * distance;
        grabbed.rotation = transform.rotation;
    }
}
 
// This drag wasn't like the OP wanted.
function OldDrag() {
    var ray : Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    grabbed.position = ray.origin + ray.direction * grabDistance;
}

#else

function Update () {
    if (useToggleDrag)
        UpdateToggleDrag();
    else
        UpdateHoldDrag();
}
 
// Toggles drag with mouse click
function UpdateToggleDrag () {
    if (Input.GetMouseButtonDown(0)) 
        Grab();
    else if (grabbed)
        Drag();
}
 
// Drags when user holds down button
function UpdateHoldDrag () {
    if (Input.GetMouseButton(0)) 
        if (grabbed)
            Drag();
        else 
            Grab();
    else
        grabbed = null;
}
 
function Grab() {
    if (grabbed) 
       grabbed = null;
    else {
        var hit : RaycastHit;
        var ray : Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, hit))   {       
        	if(hit.transform.tag != "Wall" && hit.transform.tag != "Terrain")
            {
                grabbed = hit.transform;
                }
                }
    }
}
 
function Drag() {
    var ray : Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    var position : Vector3 = transform.position + transform.forward * grabDistance;
    var plane : Plane = new Plane(-transform.forward, position);
    var distance : float;
    if (plane.Raycast(ray, distance)) {
        grabbed.position = ray.origin + ray.direction * distance;
        grabbed.rotation = transform.rotation;
    }
}
 
// This drag wasn't like the OP wanted.
function OldDrag() {
    var ray : Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    grabbed.position = ray.origin + ray.direction * grabDistance;
}

#endif