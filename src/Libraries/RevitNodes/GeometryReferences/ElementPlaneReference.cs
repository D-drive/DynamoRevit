namespace Revit.GeometryReferences
{
    /// <summary>
    /// A Reference to a plane extracted from a Revit ELement
    /// </summary>
    public class ElementPlaneReference : ElementGeometryReference
    {
        internal ElementPlaneReference(Autodesk.Revit.DB.Reference planeReference)
        {
            this.InternalReference = planeReference;
        }
    }
}
