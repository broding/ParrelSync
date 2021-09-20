namespace ParrelSync.NonCore
{
    using UnityEditor;
    using UnityEngine;

    /// <summary>
    /// A simple script to display feedback/star dialog after certain time of project being opened/re-compiled.
    /// Will only pop-up once unless "Remind me next time" are chosen.
    /// Removing this file from project wont effect any other functions.
    /// </summary>
    [InitializeOnLoad]
    public class AskFeedbackDialog
    {
        const string InitializeOnLoadCountKey = "ParrelSync_InitOnLoadCount", StopShowingKey = "ParrelSync_StopShowFeedBack";
        static AskFeedbackDialog()
        {   
            // Just no.
        }
    }
}
