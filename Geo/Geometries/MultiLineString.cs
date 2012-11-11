using System.Collections.Generic;
using Geo.Interfaces;
using Geo.Json;

namespace Geo.Geometries
{
    public class MultiLineString : GeometryCollectionBase<MultiLineString, LineString>, IGeoJsonGeometry
    {
        public MultiLineString()
        {
        }

        public MultiLineString(IEnumerable<LineString> lineStrings) : base(lineStrings)
        {
        }

        public MultiLineString(params LineString[] lineStrings) : base(lineStrings)
        {
        }

        public override string ToWktString()
        {
            return BuildWktString<IWktPart>("MULTILINESTRING", geometry => geometry.ToWktPartString());
        }

        public string ToGeoJson()
        {
            return GeoJson.Serialize(this);
        }

        #region Equality methods

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(MultiLineString left, MultiLineString right)
        {
            if (ReferenceEquals(left, null) && ReferenceEquals(right, null))
                return true;
            return !ReferenceEquals(left, null) && !ReferenceEquals(right, null) && left.Equals(right);
        }

        public static bool operator !=(MultiLineString left, MultiLineString right)
        {
            return !(left == right);
        }

        #endregion
    }
}