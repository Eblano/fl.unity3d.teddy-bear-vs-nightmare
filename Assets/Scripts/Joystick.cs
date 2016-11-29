// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.

using UnityEngine;
using System.Collections;

public class Joystick : MonoBehaviour {
//////////////////////////////////////////////////////////////
// Joystick.js
// Penelope iPhone Tutorial
//
// Joystick creates a movable joystick (via GUITexture) that
// handles touch input, taps, and phases. Dead zones can control
// where the joystick input gets picked up and can be normalized.
//////////////////////////////////////////////////////////////
 
// A simple class for bounding how far the GUITexture will move
 
static private Joystick[] joysticks;                  // A static collection of all joysticks
static private bool  enumeratedJoysticks = false;
static private float tapTimeDelta = 0.3f;              // Time allowed between taps
 
public Vector2 position;                              // [-1, 1] in x,y
public Vector2 deadZone = Vector2.zero;               // Control when position is output
public bool  normalize = false;                     // Normalize output after the dead-zone?
public int tapCount;                                  // Current tap count
 
private int lastFingerId= -1;                              // Finger last used for this joystick
private float tapTimeWindow;                          // How much time there is left for a tap to occur
private GUITexture gui;                               // Joystick graphic
private Rect defaultRect;                             // Default position / extents of the joystick graphic
private Boundary guiBoundary = new Boundary();            // Boundary for joystick graphic
private Vector2 guiTouchOffset;                       // Offset to apply to touch input
private Vector2 guiCenter;                            // Center of joystick graphic
 
void  Start (){
    // Cache this component at startup instead of looking up every frame
    gui = GetComponent< GUITexture >();
 
    // Store the default rect for the gui, so we can snap back to it
    defaultRect = gui.pixelInset;
 
    // This is an offset for touch input to match with the top left
    // corner of the GUI
    guiTouchOffset.x = defaultRect.width * 0.5f;
    guiTouchOffset.y = defaultRect.height * 0.5f;
 
    // Cache the center of the GUI, since it doesn't change
    guiCenter.x = defaultRect.x + guiTouchOffset.x;
    guiCenter.y = defaultRect.y + guiTouchOffset.y;
 
    // Let's build the GUI boundary, so we can clamp joystick movement
    guiBoundary.min.x = defaultRect.x - guiTouchOffset.x;
    guiBoundary.max.x = defaultRect.x + guiTouchOffset.x;
    guiBoundary.min.y = defaultRect.y - guiTouchOffset.y;
    guiBoundary.max.y = defaultRect.y + guiTouchOffset.y;
		
}
 
public void  Disable (){
    gameObject.active = false;
    enumeratedJoysticks = false;
}
 
public void  Reset (){
    // Release the finger control and set the joystick back to the default position
    gui.pixelInset = defaultRect;
    lastFingerId = -1;
		
}
 
public void  LatchedFinger (  int fingerId   ){
    // If another joystick has latched this finger, then we must release it
    if ( lastFingerId == fingerId )
        Reset();
}
 
#if (UNITY_IPHONE || UNITY_ANDROID)
void  Update (){
    if ( !enumeratedJoysticks )
    {
        // Collect all joysticks in the game, so we can relay finger latching messages
        joysticks = (Joystick[]) FindObjectsOfType(typeof( Joystick ));
        enumeratedJoysticks = true;
    }
 
    int count= Input.touchCount;
 
    // Adjust the tap time window while it still available
    if ( tapTimeWindow > 0 )
        tapTimeWindow -= Time.deltaTime;
    else
        tapCount = 0;
 
    if ( count == 0 )
        Reset();
    else
    {
        for(int i = 0;i < count; i++)
        {
            Touch touch = Input.GetTouch(i);
            Vector2 guiTouchPos = touch.position - guiTouchOffset;
 
            // Latch the finger if this is a new touch
            if ( gui.HitTest( touch.position ) && ( lastFingerId == -1 || lastFingerId != touch.fingerId ) )
            {
                lastFingerId = touch.fingerId;
 
                // Accumulate taps if it is within the time window
                if ( tapTimeWindow > 0 )
                    tapCount++;
                else
                {
                    tapCount = 1;
                    tapTimeWindow = tapTimeDelta;
                }
 
                // Tell other joysticks we've latched this finger
                foreach( Joystick j in joysticks )
                {
                    if ( j != this )
                        j.LatchedFinger( touch.fingerId );
                }
					
            }
 
            if ( lastFingerId == touch.fingerId )
            {
                // Override the tap count with what the iPhone SDK reports if it is greater
                // This is a workaround, since the iPhone SDK does not currently track taps
                // for multiple touches
                if ( touch.tapCount > tapCount )
                    tapCount = touch.tapCount;
 
                // Change the location of the joystick graphic to match where the touch is
                Rect PI = gui.pixelInset;
                PI.x = Mathf.Clamp( guiTouchPos.x, guiBoundary.min.x, guiBoundary.max.x );
                PI.y = Mathf.Clamp( guiTouchPos.y, guiBoundary.min.y, guiBoundary.max.y );
				gui.pixelInset = PI;
 
                if ( touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled )
                    Reset();
            }
        }
    }
 
    // Get a value between -1 and 1
    position.x = ( gui.pixelInset.x + guiTouchOffset.x - guiCenter.x ) / guiTouchOffset.x;
    position.y = ( gui.pixelInset.y + guiTouchOffset.y - guiCenter.y ) / guiTouchOffset.y;
 
    // Adjust for dead zone
    float absoluteX= Mathf.Abs( position.x );
    float absoluteY= Mathf.Abs( position.y );
 
    if ( absoluteX < deadZone.x )
    {
        // Report the joystick as being at the center if it is within the dead zone
        position.x = 0;
    }
    else if ( normalize )
    {
        // Rescale the output after taking the dead zone into account
        position.x = Mathf.Sign( position.x ) * ( absoluteX - deadZone.x ) / ( 1 - deadZone.x );
    }
 
    if ( absoluteY < deadZone.y )
    {
        // Report the joystick as being at the center if it is within the dead zone
        position.y = 0;
    }
    else if ( normalize )
    {
        // Rescale the output after taking the dead zone into account
        position.y = Mathf.Sign( position.y ) * ( absoluteY - deadZone.y ) / ( 1 - deadZone.y );
    }
}
#else
    void  OnMouseUp (){
        Reset();
        position.x = 0;
        position.y = 0;
 		
    }
  //  public virtual void
    void  OnMouseDrag (){
        if ( !enumeratedJoysticks )
    {
        // Collect all joysticks in the game, so we can relay finger latching messages
        joysticks = (Joystick[]) FindObjectsOfType(typeof( Joystick ));
        enumeratedJoysticks = true;
    }
 
    int count=1;// iPhoneInput.touchCount;
 
    // Adjust the tap time window while it still available
    if ( tapTimeWindow > 0 )
        tapTimeWindow -= Time.deltaTime;
    else
        tapCount = 0;
 
    if ( count == 0 )
        Reset();
    else
    {
        for(int i = 0;i < count; i++)
        {
            //iPhoneTouch touch = iPhoneInput.GetTouch(i);
 
            Vector3 touch_Vector3 =Input.mousePosition;
            Vector2 touch;
            touch.x=touch_Vector3.x;
            touch.y=touch_Vector3.y;
 
            Vector2 guiTouchPos;// = touch.position - guiTouchOffset;
            guiTouchPos.x=touch_Vector3.x-guiTouchOffset.x;
            guiTouchPos.y=touch_Vector3.y-guiTouchOffset.y;
 
    int touch_tapCount=1;
    int touch_fingerId=1;
            // Latch the finger if this is a new touch
            if ( gui.HitTest( Input.mousePosition ) && ( lastFingerId == -1 || lastFingerId != touch_fingerId ) )
            {
                lastFingerId =touch_fingerId;
 
                // Accumulate taps if it is within the time window
                if ( tapTimeWindow > 0 )
                    tapCount++;
                else
                {
                    tapCount = 1;
                    tapTimeWindow = tapTimeDelta;
                }
 
                // Tell other joysticks we've latched this finger
                foreach( Joystick j in joysticks )
                {
                    if ( j != this )
                        j.LatchedFinger(touch_fingerId); // touch.fingerId );
                }
            }
 
            if ( lastFingerId == touch_fingerId)
            {
                // Override the tap count with what the iPhone SDK reports if it is greater
                // This is a workaround, since the iPhone SDK does not currently track taps
                // for multiple touches
                if ( touch_tapCount > tapCount )
                    tapCount = touch_tapCount;
 
                // Change the location of the joystick graphic to match where the touch is
				Rect PI = gui.pixelInset;
                PI.x = Mathf.Clamp( guiTouchPos.x, guiBoundary.min.x, guiBoundary.max.x );
                PI.y = Mathf.Clamp( guiTouchPos.y, guiBoundary.min.y, guiBoundary.max.y );
				gui.pixelInset = PI;
 				
					
            //  if ( touch.phase == iPhoneTouchPhase.Ended || touch.phase == iPhoneTouchPhase.Canceled )
            //      Reset();
            }
        }
    }
 
    // Get a value between -1 and 1
    position.x = ( gui.pixelInset.x + guiTouchOffset.x - guiCenter.x ) / guiTouchOffset.x;
    position.y = ( gui.pixelInset.y + guiTouchOffset.y - guiCenter.y ) / guiTouchOffset.y;
 
    // Adjust for dead zone
    float absoluteX= Mathf.Abs( position.x );
    float absoluteY= Mathf.Abs( position.y );
 
    if ( absoluteX < deadZone.x )
    {
        // Report the joystick as being at the center if it is within the dead zone
        position.x = 0;
    }
    else if ( normalize )
    {
        // Rescale the output after taking the dead zone into account
        position.x = Mathf.Sign( position.x ) * ( absoluteX - deadZone.x ) / ( 1 - deadZone.x );
    }
 
    if ( absoluteY < deadZone.y )
    {
        // Report the joystick as being at the center if it is within the dead zone
        position.y = 0;
    }
    else if ( normalize )
    {
        // Rescale the output after taking the dead zone into account
        position.y = Mathf.Sign( position.y ) * ( absoluteY - deadZone.y ) / ( 1 - deadZone.y );
    }
 
    }
 
#endif
}