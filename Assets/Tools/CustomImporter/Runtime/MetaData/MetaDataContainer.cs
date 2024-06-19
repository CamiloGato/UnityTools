using System.Collections.Generic;
using UnityEngine;

namespace Tools.CustomImporter.Runtime.MetaData
{
    [CreateAssetMenu(fileName = "MetaDataContainer", menuName = "CustomImporter/MetaDataContainer", order = 0)]
    public class MetaDataContainer : ScriptableObject
    {
        public List<PartData> parts;
    }
}