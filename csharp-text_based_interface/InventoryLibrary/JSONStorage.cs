using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace InventoryLibrary
{
    public class JSONStorage
    {
        private Dictionary<string, BaseClass> objects = new Dictionary<string, BaseClass>();
        private const string directoryPath = "storage";
        private const string fileName = "inventory_manager.json";

        public JSONStorage()
        {
            // Créer le répertoire s'il n'existe pas
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }

        public Dictionary<string, BaseClass> All()
        {
            return objects;
        }

        public void New(BaseClass obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "Object cannot be null.");
            }

            string key = $"{obj.GetType().Name}.{obj.Id}";
            objects[key] = obj;
        }

        public void Save()
        {
            string json = JsonSerializer.Serialize(objects);
            string filePath = Path.Combine(directoryPath, fileName);
            File.WriteAllText(filePath, json);
        }

        public void Load()
        {
            string filePath = Path.Combine(directoryPath, fileName);
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The specified file does not exist.", filePath);
            }

            string json = File.ReadAllText(filePath);
            objects = JsonSerializer.Deserialize<Dictionary<string, BaseClass>>(json);
        }
    }
}
