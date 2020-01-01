﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using DominoOnlineOrdering.Models;
using System.Text;
using System.Xml.Linq;

namespace DominoOnlineOrdering.Services
{
    public class XmlDataAccessService
    {
        public static List<T> LoadItems<T>(string filePath)
        {
            var serializer = new XmlSerializer(typeof(List<T>));
            var itemList = new List<T>();
            if (File.Exists(filePath))
                using (var reader = new StreamReader(filePath))
                    itemList = (List<T>)serializer.Deserialize(reader);
            return itemList;
        }
    }
}
