// See https://aka.ms/new-console-template for more information


FileLogger fileLogger = new FileLogger();
fileLogger.WriteLog();

DatabaseLogger databaseLogger = new DatabaseLogger();
databaseLogger.WriteLog();

SmsLogger smsLogger = new(); // C# 9.0 ile gelen bir özellik. Class ismini tekrar yazmadan obje oluşturabilir.
smsLogger.WriteLog();


LogManager logManager = new LogManager(new FileLogger());
logManager.WriteLog();