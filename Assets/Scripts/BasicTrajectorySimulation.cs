using UnityEngine;
using System.Collections.Generic;
using System.Linq;


/// <summary>
/// Controls the Laser Sight for the player's aim
/// </summary>
public class BasicTrajectorySimulation : MonoBehaviour
{
	public bool isOn;
	
    // Reference to the LineRenderer we will use to display the simulated path
    public LineRenderer sightLine;
	public Transform TargetIndicator;

    // Reference to a Component that holds information about fire strength, location of cannon, etc.
    //public PlayerFire playerFire;
	public Transform Player;
	public FireButton fireScript;
	public float fireForce = 10;
	
    // Number of segments to calculate - more gives a smoother line
    public int segmentCount = 20;

    // Length scale for each segment
    public float segmentScale = 1;

    // gameobject we're actually pointing at (may be useful for highlighting a target, etc.)
    private Collider _hitObject;
    public Collider hitObject { get { return _hitObject; } }
	
	void Start()
	{
		fireScript = GameObject.Find("Attack").GetComponent<FireButton>();	
		TargetIndicator.gameObject.SetActive(false);
	}
	
    void FixedUpdate()
    {
		if(isOn){
			fireForce = fireScript.OrizForce;
	        simulatePath();
		}else{
			TargetIndicator.gameObject.SetActive(false);
			sightLine.SetVertexCount(0);
		}
    }

    /// <summary>
    /// Simulate the path of a launched ball.
    /// Slight errors are inherent in the numerical method used.
    /// </summary>
    void simulatePath()
    {
		int loopPreventCount =0;
        List<Vector3> segments = new List<Vector3>();

        // The first line point is wherever the player's cannon, etc is
        Vector3 start = Player.position + (Player.forward * 1) + (Player.up * 1.5f);
			//new Vector3(Player.position.x,Player.position.y * 1.5f,Player.position.z * 1f);
		segments.Add(start); //playerFire.transform.position;

        // The initial velocity
        Vector3 segVelocity = (Player.forward + Player.up) * fireForce * Time.deltaTime;

        // reset our hit object
        _hitObject = null;
		
        while(loopPreventCount < 1000)
        {
            // Time it takes to traverse one segment of length segScale (careful if velocity is zero)
            float segTime = (segVelocity.sqrMagnitude != 0) ? segmentScale / segVelocity.magnitude : 0;

            // Add velocity from gravity for this segment's timestep
            segVelocity = segVelocity + Physics.gravity * segTime;

            // Check to see if we're going to hit a physics object
            RaycastHit hit;
            if (Physics.Raycast(segments.Last(), segVelocity, out hit, segmentScale))
            {
                // remember who we hit
                _hitObject = hit.collider;
				
				if(_hitObject.name=="Floor"){
	                // set next position to the position where we hit the physics object
	                segments.Add(segments.Last() + segVelocity.normalized * hit.distance);
	                // correct ending velocity, since we didn't actually travel an entire segment
	                segVelocity = segVelocity - Physics.gravity * (segmentScale - hit.distance) / segVelocity.magnitude;
	                // flip the velocity to simulate a bounce
	                /*if(_hitObject.name.Contains("Projectile")==false){
						segVelocity = Vector3.Reflect(segVelocity, hit.normal);
					}*/
					
					TargetIndicator.position = segments.Last();
					TargetIndicator.gameObject.SetActive(true);
					break;
				}
                /*
                 * Here you could check if the object hit by the Raycast had some property - was
                 * sticky, would cause the ball to explode, or was another ball in the air for
                 * instance. You could then end the simulation by setting all further points to
                 * this last point and then breaking this for loop.
                 */
            }
            // If our raycast hit no objects, then set the next position to the last one plus v*t
            else
            {
                segments.Add(segments.Last() + segVelocity * segTime);
            }
			
			loopPreventCount++;
        }

        // At the end, apply our simulations to the LineRenderer

        Color startColor = Color.red; //playerFire.nextColor;
        Color endColor = startColor;
        startColor.a = 1;
        endColor.a = 0;
        sightLine.SetColors(startColor, endColor);

        sightLine.SetVertexCount(segments.Count);
		int i=0;
        foreach(Vector3 pos in segments){
            sightLine.SetPosition(i, pos);
			i++;
		}
		
		segments = null;
    }
}