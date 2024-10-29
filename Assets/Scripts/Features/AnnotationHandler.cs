using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnnotationHandler : MonoBehaviour
{
    private List<string> annotations = new List<string>();

    // Adds a new annotation
    public void AddAnnotation(string annotation)
    {
        if (!string.IsNullOrEmpty(annotation))
        {
            annotations.Add(annotation);
            Debug.Log("Annotation added: " + annotation);
        }
    }

    // Edits an annotation at a specific index
    public void EditAnnotation(int index, string newAnnotation)
    {
        if (index >= 0 && index < annotations.Count && !string.IsNullOrEmpty(newAnnotation))
        {
            annotations[index] = newAnnotation;
            Debug.Log("Annotation edited at index " + index + ": " + newAnnotation);
        }
    }

    // Displays all annotations in the console or UI
    public void DisplayAnnotations()
    {
        foreach (var annotation in annotations)
        {
            Debug.Log("Annotation: " + annotation);
        }
    }

    // Removes an annotation at a specific index
    public void RemoveAnnotation(int index)
    {
        if (index >= 0 && index < annotations.Count)
        {
            annotations.RemoveAt(index);
            Debug.Log("Annotation removed at index " + index);
        }
    }
}
