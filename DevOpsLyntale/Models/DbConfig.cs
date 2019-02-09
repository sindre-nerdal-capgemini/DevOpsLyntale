

namespace DevOpsLyntale.Models
{
    public class DbConfig
    {
        public string Host { get; set; }
        public string Name { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public string ConnectionString => $"Host={Host};Database={Name};Username={User};Password={Password};";

    }
}
