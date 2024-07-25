// See https://aka.ms/new-console-template for more information

using CSharpDay6;
using static CSharpDay6.BasicMath;
using static CSharpDay6.Logger;

Console.WriteLine("Hello, World!");

BasicMath obj = new BasicMath();
MathOperation math = obj.Add;
double res = math.Invoke(1.0, 2.0);
Console.WriteLine("Addition result:" + res);

MathOperation math1 = obj.Sub;
double subres = math1.Invoke(5.0, 2.0);
Console.WriteLine("Subraction result:" + subres);

MathOperation math2 = obj.Mul;
double mulres = math2.Invoke(5.0, 2.0);
Console.WriteLine("Multiplication result:" + mulres);

MathOperation math3 = obj.Div;
double divres = math3.Invoke(500.0, 5.0);
Console.WriteLine("Division result:" + divres);


LoggingOperation del = (message) =>
{
    Console.WriteLine("[ALERT] " + message);
};

del.Invoke("triggering function");



PaymentProcessingApp app = new PaymentProcessingApp();

//delegate
PaymentHandler cardHandler = new PaymentHandler(app.ProcessVisaPayment);

PaymentProcessor processor = new PaymentProcessor();
bool isOk = processor.ProcessPayment(cardHandler,"1234 - 1111 - 2222 - 1234", 100.00);

if (!isOk)
{
    Console.WriteLine("[ALERT] Payment processing failed");
}
    
