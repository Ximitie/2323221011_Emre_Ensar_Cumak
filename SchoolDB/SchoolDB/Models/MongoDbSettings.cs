namespace SchoolDatabase.Models
{
    public class MongoDbSettings
    {
        // MongoDB bağlantı dizesi
        public string ConnectionString { get; set; } = string.Empty;

        // Kullanılacak veritabanının adı
        public string DatabaseName { get; set; } = string.Empty;
    }
}