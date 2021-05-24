// /*
//  *  Code given to the class by Professor Pisan in the Hero TNG assignment
//  */

// using UnityEngine;
// using System.Collections;
// using UnityEngine.UI;


// public class WorldBounds : MonoBehaviour {
//     public static WorldBounds sTheWorldBounds = null;
//     // public EggStatSystem mEggStat = null;

//     // public Text mGameStateEcho = null;  // Defined in UnityEngine.UI
   

//     #region World Bound support
//     private Bounds mWorldBound;  // this is the world bound
// 	private Vector2 mWorldMin;	// Better support 2D interactions
// 	private Vector2 mWorldMax;
// 	private Vector2 mWorldCenter;
// 	private Camera mMainCamera;
//     #endregion 

//     // This is called before any Start()
//     //     https://docs.unity3d.com/Manual/ExecutionOrder.html
//     void Awake()
//     {
//         // just so we know
//     }

//     // Use this for initialization
//     void Start () {
//         // Debug.Assert(mEggStat != null);

//         WorldBounds.sTheWorldBounds = this;  // Singleton pattern

//         #region world bound support
//         mMainCamera = Camera.main; // This is the default main camera
// 		mWorldBound = new Bounds(Vector3.zero, Vector3.one);
// 		UpdateWorldWindowBound();
//         #endregion
//     }

//     /* Update is called once per frame 
// 	void Update () {
// 		mMainCamera.transform.position += 0.1f * Vector3.one;
// 		mMainCamera.orthographicSize += 1.0f;
	
// 	} */

//     #region Game Window World size bound support
//     public enum WorldBoundStatus {
// 		CollideTop,
// 		CollideLeft,
// 		CollideRight,
// 		CollideBottom,
// 		Outside,
// 		Inside
// 	};
	
// 	/// <summary>
// 	/// This function must be called anytime the MainCamera is moved, or changed in size
// 	/// </summary>
// 	public void UpdateWorldWindowBound()
// 	{
// 		// get the main 
// 		if (null != mMainCamera) {
// 			float maxY = mMainCamera.orthographicSize;
// 			float maxX = mMainCamera.orthographicSize * mMainCamera.aspect;
// 			float sizeX = 2 * maxX;
// 			float sizeY = 2 * maxY;
// 			float sizeZ = Mathf.Abs(mMainCamera.farClipPlane - mMainCamera.nearClipPlane);
			
// 			// Make sure z-component is always zero
// 			Vector3 c = mMainCamera.transform.position;
// 			c.z = 0.0f;
// 			mWorldBound.center = c;
// 			mWorldBound.size = new Vector3(sizeX, sizeY, sizeZ);

// 			mWorldCenter = new Vector2(c.x, c.y);
// 			mWorldMin = new Vector2(mWorldBound.min.x, mWorldBound.min.y);
// 			mWorldMax = new Vector2(mWorldBound.max.x, mWorldBound.max.y);
// 		}
// 	}

// 	public Vector2 WorldCenter { get { return mWorldCenter; } }
// 	public Vector2 WorldMin { get { return mWorldMin; }} 
// 	public Vector2 WorldMax { get { return mWorldMax; }}
	
// 	public WorldBoundStatus ObjectCollideWorldBound(Bounds objBound)
// 	{
// 		WorldBoundStatus status = WorldBoundStatus.Inside;

// 		if (mWorldBound.Intersects (objBound)) {
// 			if (objBound.max.x > mWorldBound.max.x)
// 				status = WorldBoundStatus.CollideRight;
// 			else if (objBound.min.x < mWorldBound.min.x)
// 				status = WorldBoundStatus.CollideLeft;
// 			else if (objBound.max.y > mWorldBound.max.y)
// 				status = WorldBoundStatus.CollideTop;
// 			else if (objBound.min.y < mWorldBound.min.y)
// 				status = WorldBoundStatus.CollideBottom;
// 			else if ((objBound.min.z < mWorldBound.min.z) || (objBound.max.z > mWorldBound.max.z))
// 				status = WorldBoundStatus.Outside;
// 		} else 
// 			status = WorldBoundStatus.Outside;

// 		return status;
// 	}

//     public WorldBoundStatus ObjectClampToWorldBound(Transform t)
//     {
//         WorldBoundStatus status = WorldBoundStatus.Inside;
//         Vector3 p = t.position;

//         if (p.x > WorldMax.x)
//         {
//             status = WorldBoundStatus.CollideRight;
//             p.x = WorldMax.x;
//         }
//         else if (t.position.x < WorldMin.x)
//         {
//             status = WorldBoundStatus.CollideLeft;
//             p.x = WorldMin.x;
//         }

//         if (p.y > WorldMax.y)
//         {
//             status = WorldBoundStatus.CollideTop;
//             p.y = WorldMax.y;
//         }
//         else if (p.y < WorldMin.y)
//         {
//             status = WorldBoundStatus.CollideBottom;
//             p.y = WorldMin.y;
//         }

//         if ((p.z < mWorldBound.min.z) || (p.z > mWorldBound.max.z))
//         {
//             status = WorldBoundStatus.Outside;
//         }

//         t.position = p;
//         return status;
//     }
//     #endregion

//     // #region Game Stat Echo support
//     // public void DestroyAnEgg()
//     // {
//     //     mEggStat.DecEggCount();
//     // }

//     // public void UpdateGameState(string msg)
//     // {
//     //     mGameStateEcho.text = msg;
//     // }

//     // #endregion
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Meant to be a component of a camera
public partial class CameraSupport : MonoBehaviour
{
    private Camera mTheCamera;   // Will find this on the gameObject
    private Bounds mWorldBound;  // Computed bound from the camera

    public enum WorldBoundStatus
    {
        Outside = 0,
        CollideLeft = 1,
        CollideRight = 2,
        CollideTop = 4,
        CollideBottom = 8,
        Inside = 16
    };

    // Start is called before the first frame update
    void Awake()  // camera may be disabled by some in Start(), so init in Awake.
    {
        // mTheCamera = gameObject.GetComponent<Camera>();
        mTheCamera = Camera.main; // This is the default main camera
        Debug.Assert(mTheCamera != null); // if this is null, then, the script is not on a Camera and nothing works

        #region bound support
        mWorldBound = new Bounds();
        UpdateWorldWindowBound();
        #endregion
    }

    void Update()
    {
        // UpdateWorldWindowBound();
        //      No need to re-compute until world is actually changed
        //      GameManager (UserControlLogic) will call the camera manipulation functions
        //      which will triget WorldBound re-compute
    }

    public Bounds GetWorldBound() { return mWorldBound; }
    public Vector2 WorldCenter { get { return new Vector2((mWorldBound.min.x + mWorldBound.max.x)/2, (mWorldBound.min.y + mWorldBound.max.y)/2); } }
    public Vector2 WorldMin { get { return new Vector2(mWorldBound.min.x, mWorldBound.min.y); }} 
    public Vector2 WorldMax { get { return new Vector2(mWorldBound.max.x, mWorldBound.max.y); }}

    #region bound support

    private void UpdateWorldWindowBound()
    {
        // get the main 
        if (null != mTheCamera)
        {
            float maxY = mTheCamera.orthographicSize;
            float maxX = mTheCamera.orthographicSize * mTheCamera.aspect;
            float sizeX = 2 * maxX;
            float sizeY = 2 * maxY;

            // Make sure z-component is always zero
            Vector3 c = mTheCamera.transform.position;
            c.z = 0.0f;
            mWorldBound.center = c;
            mWorldBound.size = new Vector3(sizeX, sizeY, 1f);  // z is arbitrary!!
        }
    }

    // Cannot use the regular bounds intersect() and contains() function
    // Because we are not using the Z-values 
    private bool BoundsIntersectInXY(Bounds b1, Bounds b2)
    {
        return (b1.min.x < b2.max.x) && (b1.max.x > b2.min.x) &&  
               (b1.min.y < b2.max.y) && (b1.max.y > b2.min.y);
    }

    private bool BoundsContainsPointXY(Bounds b, Vector3 pt)
    {
        return ((b.min.x < pt.x) && (b.max.x > pt.x) &&
                (b.min.y < pt.y) && (b.max.y > pt.y));
    }

    public WorldBoundStatus CollideWorldBound(Bounds objBound, float region = 1f)
    {
        WorldBoundStatus status = WorldBoundStatus.Outside;
        Bounds b = new Bounds(transform.position, region * mWorldBound.size);

        if (BoundsIntersectInXY(b, objBound))
        {
            if (objBound.max.x > b.max.x)
                status |= WorldBoundStatus.CollideRight;
            if (objBound.min.x < b.min.x)
                status |= WorldBoundStatus.CollideLeft;
            if (objBound.max.y > b.max.y)
                status |= WorldBoundStatus.CollideTop;
            if (objBound.min.y < b.min.y)
                status |= WorldBoundStatus.CollideBottom;
            // not testing Z anymore!! if ((objBound.min.z < mWorldBound.min.z) || (objBound.max.z > mWorldBound.max.z))

            if (status == WorldBoundStatus.Outside)  // intersects and no bounds touch ==> Inside!
                status = WorldBoundStatus.Inside;  
        }

        return status;
    }

    public WorldBoundStatus ClampToWorldBound(Transform t, float region = 1f)
    {
        Vector3 p = t.position;
        WorldBoundStatus status = WorldBoundStatus.Outside;
        Bounds b = new Bounds(transform.position, region * mWorldBound.size);
                
        if (p.x > b.max.x) 
        {
            status |= WorldBoundStatus.CollideRight;
            p.x = b.max.x;
        }
        if (p.x < b.min.x)
        {
            status |= WorldBoundStatus.CollideLeft;
            p.x = b.min.x;
        }
        if (p.y > b.max.y)
        {
            status |= WorldBoundStatus.CollideTop;
            p.y = b.max.y;
        }
        if (p.y < b.min.y)
        {
            status |= WorldBoundStatus.CollideBottom;
            p.y = b.min.y;
        }
        
        t.position = p;
        return status;
    }
    #endregion
}