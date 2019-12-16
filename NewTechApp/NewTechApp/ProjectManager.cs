using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace NewTechApp
{
    public static class ProjectManager
    {
        private const string Name = @"\NoteApp.notes";

        private static string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        private static string File = Path + Name;

        public static void Save(Project project)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;

            using (StreamWriter streamWriter = new StreamWriter(File))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, project);
            }
        }

        public static void Load(Project project)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;

            using (StreamReader streamReader = new StreamReader(File))
            using (JsonReader reader = new JsonTextReader(streamReader))
            {
                project = (Project)serializer.Deserialize<Project>(reader);
            }
        }
    }
}
