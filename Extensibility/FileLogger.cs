using System.IO;

namespace Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            /*
             * streamWriter use file resource and file resource is not managed by Common Language Runtime (CLR)
             * means we need to dispose the resource once we finish using that
             */
            //var streamWriter = new StreamWriter(_path, true);
            //streamWriter.WriteLine(message);

            /*
             * there is exception handling mechanism inside this code
             * if something goes wrong ie exception goes wrong, compiler will make sure to close the file handle by calling dispose method on the streamWriter
             * when we use using block, the compiler auto includes call to dispose()
             */

            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }
    }
}
