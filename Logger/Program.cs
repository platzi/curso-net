ILogger consoleLogger = new ConsoleLogger();
consoleLogger.Log("Este es un mensaje de log en la consola");

ILogger fileLogger = new FileLogger();
fileLogger.Log("Este es un mensaje de log en un archivo");