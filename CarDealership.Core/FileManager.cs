using System.Runtime.Serialization.Formatters.Binary;

namespace CarDealership.Core
{
    public static class FileManager
    {
        private const string FilePath = "CarList.txt";

        public static async Task<bool> Save(IEnumerable<Car> cars)
        {
            try
            {
                byte[] serializedData;

                using var memoryStream = new MemoryStream();

                var formatter = new BinaryFormatter();
                formatter.Serialize(memoryStream, cars.ToArray());
                serializedData = memoryStream.ToArray();

                using var fileStream = new FileStream(
                    FilePath,
                    FileMode.Create,
                    FileAccess.Write,
                    FileShare.None,
                    bufferSize: 4096,
                    useAsync: true);

                await fileStream.WriteAsync(serializedData, 0, serializedData.Length);

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return false;
        }

        public static async Task<IEnumerable<Car>> Load()
        {
            var cars = new List<Car>();

            using FileStream fileStream = new FileStream(
                FilePath,
                FileMode.Open,
                FileAccess.Read,
                FileShare.Read,
                bufferSize: 4096,
                useAsync: true);

            byte[] serializedData = new byte[fileStream.Length];
            await fileStream.ReadAsync(serializedData, 0, serializedData.Length);

            using MemoryStream memoryStream = new MemoryStream(serializedData);

            BinaryFormatter formatter = new BinaryFormatter();

            return (Car[])formatter.Deserialize(memoryStream);
        }
    }
}