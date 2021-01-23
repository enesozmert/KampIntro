using System;

namespace OOP3
{
    class FileLoggerSevice : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Tabanına Loglandı.");
        }
    }
}
