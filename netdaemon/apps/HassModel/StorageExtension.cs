using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.Persistance;

public interface IDataRepository
{
    void Save<T>(string id, T data);
    T? Get<T>(string id) where T : class;
}

public class DataRepository : IDataRepository
{
    private readonly string _dataStoragePath = "./apps/.storage";
    private readonly JsonSerializerOptions _jsonOptions;

    public DataRepository(string dataStoragePath)
    {
        _dataStoragePath = dataStoragePath;

        _jsonOptions = new JsonSerializerOptions();
    }

    /// <inheritdoc/>
    [SuppressMessage("", "CA1031")]
    public T? Get<T>(string id) where T : class
    {
        try
        {
            var storageJsonFile = Path.Combine(_dataStoragePath, $"{id}_store.json");

            if (!File.Exists(storageJsonFile))
                return null;

            using var jsonStream = File.OpenRead(storageJsonFile);

            return JsonSerializer.Deserialize<T>(jsonStream, _jsonOptions);
        }
        catch
        {
            // We ignore errors, we will be adding logging later see issue #403
        }
#pragma warning disable CS8603, CS8653
        return default;
#pragma warning restore CS8603, CS8653
    }

    /// <inheritdoc/>
    public void Save<T>(string id, T data)
    {
        if (data == null)
            throw new ArgumentNullException(nameof(data));

        SaveInternal<T>(id, data);
    }

    private void SaveInternal<T>(string id, T data)
    {
        var storageJsonFile = Path.Combine(_dataStoragePath, $"{id}_store.json");

        if (!Directory.Exists(_dataStoragePath))
        {
            Directory.CreateDirectory(_dataStoragePath);
        }

        using var jsonStream = File.Open(storageJsonFile, FileMode.Create, FileAccess.Write);

        JsonSerializer.Serialize(jsonStream, data);
    }
}

