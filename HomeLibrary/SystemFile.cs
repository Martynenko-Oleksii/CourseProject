using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace HomeLibrary
{
    // Клас для взаємодії з файловою системою.
    static class SystemFile
    {
        // Зчитування даних із заданого файлу.
        public static object Read(string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter binForm = new BinaryFormatter();
                    return binForm.Deserialize(fs);
                }
            }
            catch (FileNotFoundException)
            {
                return null;
            }

        }

        // Запис даних у заданий файл.
        public static void Write(string path, object obj)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter binForm = new BinaryFormatter();
                binForm.Serialize(fs, obj);
            }
        }
    }
}
