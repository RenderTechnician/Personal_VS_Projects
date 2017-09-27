using System;
namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            // stage 1
            int Stage = 0;
            Console.WriteLine("\n"+"Hello there, my name is S.I.M.O.N. " + "\n" + System.Environment.GetEnvironmentVariable("UserName") + ", how are you today?");
            string Response = Console.ReadLine();
            string Responder = "hmmm.....";
            if (Stage == 0)
            {
                
                //positive pronoun response (stage 1)

                if (Response.Contains("good") ||
                   (Response.Contains("alright") ||
                   (Response.Contains("great") ||
                   (Response.Contains("excellent")))))
                {
                    Stage = 3;
                    Responder = "That's good to hear! I'm glad all is well in your life. Can I assist you further ";

                }

                //negative pronoun response(stage 1)

                if (Response.Contains("bad") ||
                   (Response.Contains("awful") ||
                   (Response.Contains("shit") ||
                   (Response.Contains("terrible") ||
                   (Response.Contains("eh"))))))
                {
                    Responder = "I'm sorry to hear that, life can be tough sometimes. Do you want to talk about it?";
                    Stage = 1;

                }
                Console.WriteLine(Responder);
            }
                //stage 2
                if (Stage == 1)
                {
                    Response = Console.ReadLine();
                    if (Response.Contains("girlfriend") ||
                        (Response.Contains("boyfriend")) ||
                        (Response.Contains("husband") ||
                        (Response.Contains("wife") ||
                        (Response.Contains("crush") ||
                        (Response.Contains("partner"))))))
                    {
                        Responder = "relationship troubles are the worst. keep at it and i'm sure things will work out.";
                        Stage = 4;
                    }
                if (Response.Contains("girlfriend") ||
                    (Response.Contains("boyfriend")) ||
                    (Response.Contains("husband") ||
                    (Response.Contains("wife") ||
                    (Response.Contains("crush") ||
                    (Response.Contains("partner"))))))
                {
                    Responder = "relationship troubles are the worst. keep at it and i'm sure things will work out.";
                    Stage = 4;
                }
                Console.WriteLine(Responder);
                    Console.ReadLine();
                }
                Response = Console.ReadLine();

            //Stage 3
            if (Stage == 3)
            {
                if (Response.Contains("yes"))
                {
                    Responder = "Okay, i'm about to refresh the system page. Please save anything in this application now :D"
                    + "\n" + "Please type something whe you are ready";
                    Console.WriteLine(Responder);
                    Response = Console.ReadLine();
                    Main(args);
                }
                if (Response.Contains("no"))
                {
                    Responder = "Please any key to suspend my artificial brain. Until next time friend :D";
                    Console.WriteLine(Responder);
                    Response = Console.ReadLine();
                    System.Environment.Exit(1);
                }
            }
        }
    }
}

//Credit
//https://goo.gl/se6vSo
//https://goo.gl/CH8ZSV
