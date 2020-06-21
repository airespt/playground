using System.Diagnostics;

// Use these class methods to output debug logs.
// These methods only exist in the editor build
// and are stripped off for release builds.
// Can be forced always with MON_DEBUG in player settings.

  public static class Mon {
    // These combine as OR.
    [Conditional("UNITY_EDITOR"), Conditional("MON_DEBUG")]
    public static void Debug(string msg = null)
    {
      UnityEngine.Debug.Log(msg);
    }

  }
