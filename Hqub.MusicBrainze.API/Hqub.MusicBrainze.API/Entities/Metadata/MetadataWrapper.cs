﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hqub.MusicBrainze.API.Entities.Metadata
{
    [XmlType(Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("metadata", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class MetadataWrapper
    {
        [XmlArray("artist-list")]
        [XmlArrayItem("artist")]
        public Collections.ArtistList Collection { get; set; } 
    }
}
