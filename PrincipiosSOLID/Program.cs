public class EmailService
{
    public void SendEmail(string email, string message)
    {
        Console.WriteLine($"Sending Email to {email} : {message}");
    }
}

public class SMSService
{
    public void SendSMS(string phoneNumber, string message)
    {
        Console.WriteLine($"Sending SMS to {phoneNumber}: {message}");
    }
}

public class NotificationLogger
{
    public void LogNotification(string message)
    {
        Console.WriteLine($"Logging notification : {message}");
    }
}

public class NotificationService
{
    private readonly EmailService _emailService;
    private readonly SMSService _smsService;
    private readonly NotificationLogger _notificationLogger;

    public NotificationService(EmailService emailService, SMSService smsService, NotificationLogger notificationLogger)
    {
        _emailService = emailService;
        _smsService = smsService;
        _notificationLogger = notificationLogger;
    }

    public void SendEmailNotification(string email, string message)
    {
        _emailService.SendEmail(email, message);
        _notificationLogger.LogNotification($"Email sent to {email}.");
    }

    public void SendSMSNotification(string phoneNumber, string message)
    {
        _smsService.SendSMS(phoneNumber, message);
        _notificationLogger.LogNotification($"SMS sent to {phoneNumber}.");
    }
}



public class Program
{
    public static void Main(string[] args)
    {
        // Crear las instancias de los servicios
        var emailService = new EmailService();
        var smsService = new SMSService();
        var notificationLogger = new NotificationLogger();

        // Crear la instancia del servicio de notificación principal
        var notificationService = new NotificationService(emailService, smsService, notificationLogger);

        // Mostrar el menú al usuario
        Console.WriteLine("Seleccione el tipo de notificación:");
        Console.WriteLine("1. Email");
        Console.WriteLine("2. SMS");

        // Leer la selección del usuario
        string choice = Console.ReadLine();

        // Pedir al usuario que ingrese el mensaje
        Console.WriteLine("Ingrese el mensaje:");
        string message = Console.ReadLine();

        // Ejecución según la opción seleccionada
        if (choice == "1")
        {
            Console.WriteLine("Ingrese el correo electrónico:");
            string email = Console.ReadLine();
            notificationService.SendEmailNotification(email, message);
        }
        else if (choice == "2")
        {
            Console.WriteLine("Ingrese el número de teléfono:");
            string phoneNumber = Console.ReadLine();
            notificationService.SendSMSNotification(phoneNumber, message);
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }
    }
}
