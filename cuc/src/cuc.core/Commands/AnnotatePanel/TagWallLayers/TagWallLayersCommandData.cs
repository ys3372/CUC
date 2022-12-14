using Autodesk.Revit.DB;
using cuc.core;

namespace cuc.core
{
    public class TagWallLayersCommandData
    {

        #region public properties

        public bool Function { get; set; }

        public bool Name { get; set; }

        public bool Thickness { get; set; }

        public ElementId TextTypeId { get; set; }

        public LengthUnitType UnitType { get; set; }

        public int Decimals { get; set; }

        #endregion

        #region constructor
        public TagWallLayersCommandData()
        {

        }
        #endregion

    }
}
