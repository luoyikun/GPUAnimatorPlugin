using UnityEngine;

[System.Serializable]
public class GPUAnimation
{
    [System.NonSerialized]
    public string[] joints;
    [System.NonSerialized]
    public Skeleton[] clipJoints;
    [System.NonSerialized]
    public Color[] meshTexturePixels;
    public enum RootMotionMode { None, Baked, AppliedToTransform }

	public string animationName;

	public float playbackSpeed = 1;

	public WrapMode wrapMode = WrapMode.Default;
    public int startIndex;

	public GPUAnimationEvent[] events;
	public float length;
	[HideInInspector]
	public int frameSkip = 1;
	public int totalFrames = 0;

    public int loopStartFrame;

    [System.NonSerialized]
    public GPUAnimationFrameData[] verts;

    public bool isVertsAnimation = false;
    public int textureSize = 0;
    public int totalVerts = 0;

    private void OnEnable()
	{
	}
	
	public void FireEvents(int frame)
	{
		for (int i = 0; i < events.Length; i++)
		{
			if (events[i].frame == frame)
            {
                events[i].FireEvent();
            }
		}
	}

    public void FireFinishedEvents(int frame)
    {
    }

    public void Reset()
	{
	}
}

