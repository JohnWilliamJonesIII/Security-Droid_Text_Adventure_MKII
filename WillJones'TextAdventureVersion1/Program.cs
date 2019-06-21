using System;

namespace WillJones_TextAdventureVersion1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You wake up and find yourself in a dreary gray building. You wonder where you actually are, and why you woke up here.");
            Console.WriteLine("You pick yourself up off of the floor, and you notice the floor is metal. Where am I?, you think to yourself");
            Console.WriteLine("Suddenly, an extremely loud blaring noise snaps you back to reality.");
            Console.WriteLine("WARNING");
            Console.WriteLine("WARNING");
            Console.WriteLine("WARNING");
            Console.WriteLine("UNAUTHORIZED USER HAS BREACHED CONTAINMENT");
            Console.WriteLine("PROVIDE AUTHORIZATION OR FACE JUDICIAL PUNISHMENT");
            Console.WriteLine("A small droid scuttles out from underneath a hidden panel.");
            Console.WriteLine("With an aggressive whizz and a threatening hum, the robot asks in a surprisingly commanding tone:");
            Console.WriteLine("INTRUDER, DO YOU POSSESS A VISA FOR SECURITY ACCESS IN THIS AREA?");
            string response = Console.ReadLine();

            if (response == "Yes")
            {
                Console.WriteLine("PLEASE SWIPE YOUR SECURITY PASS ABOVE THE RED LINE PLEASE.");
                Console.WriteLine("IF YOU DO NOT COMPLY, LETHAL FORCE IS AUTHORIZED AND WILL BE ACTIVATED");
                Console.WriteLine("You notice that the little robot seems to be overheating, as there are little black puffs emanating from beneath its' plastic shell. Perhaps it's malfunctioning?");
                Console.WriteLine("DO YOU HAVE YOUR SECURITY PASS, ANSWER YES OR NO INTRUDER.");
                response = Console.ReadLine();
                if (response == "Yes")
                {
                Console.WriteLine("ERRORMACRO, PLEASE SWIPE CARD AGAIN MA'AM");
                Console.WriteLine("The robot suddenly flashes its photoreceptors in hues of red and blue.");
                Console.WriteLine("ERRORERRORERRORERRORERRORERROR CALLING FOR BACKUP ERRORERRORERRORERRORERRORERRORERROR");
                Console.WriteLine("The robot suddenly pops its head back, revealing a large hidden weapon.");
                Console.WriteLine("CRACKACRACKACRACKACRACKACRACKACRACKACRACKACRACKACRACKACRACKACRACKACRACKACRACKACRACKACRACKACRACKACRACKACRACKACRACKACRACKA");
                Console.WriteLine("You slump over, riddled with flechette shavings. You should have had your security pass.");
                Console.WriteLine("Congraulations, you've lost.");
                }


            }
            if (response == "No")
            {
                Console.WriteLine("THANK YOU SIR. CAN I HELP YOU IN ANY OTHER FASHION?");
                response = Console.ReadLine();
                if (response == "No")
                {
                Console.WriteLine("THANK YOU VISITOR, IF YOU REQUIRE ANY FUTHER ASSISTANCE, PLEASE BE SURE TO CONTACT MARGE AT CUSTOMS.");
                Console.WriteLine("The robot suddenly sputters, and before you can react, the droid shakes, and the last thing you see before your vision  turns dark is the bright flash of the droid's gun barrels.");
                Console.WriteLine("Congratulations, you've lost.");
                }

                if (response == "Yes")
                {
                Console.WriteLine("EXCELLENT. FOLLOW ME SIR, AND I WILL ESCORT YOU TO CUSTOMS TO RECEIVE A COMPLEMENTARY SUBWAY COOKIE, COURTESY OF SUBWAY: EAT FRESH.");
                Console.WriteLine("The droid begins to roll away, but suddenly it begins to fume with black smoke. It fizzles, and with a loud POP, explodes into tiny pieces.");
                Console.WriteLine("Do you walk towards the broken robot?");
                }

                response = Console.ReadLine();
                if (response == "Yes")
                {
                Console.WriteLine("Just as you crouch down to get a good look at the robot, suddenly the little pile of smoking metal and plastic that once asked for your security code again violently explodes, sending bits of white-hot metal and melted plastic into every crevice of your body.");
                Console.WriteLine("Good job, you won the Darwin Award. Also congratulations, you've lost.");

                }
                if (response == "No")
                {
                Console.WriteLine("You walk away from the broken robot, which is still sputtering black fog and sparks. ");
                Console.WriteLine("You walk down a corridor until you see a door. The door is creaked open, and a beam of light is shooting out from the   opening. ");
                Console.WriteLine("Do you walk through the door?");
                
                }

                    if (response == "Yes")
                    { 
                    Console.WriteLine("You walk through the door, leaving this bizzare place behind.");
                    Console.WriteLine("Congratulations, you've won!");
                    }

                    if (response == "No")
                    {
                    Console.WriteLine("You don't walk through the door, instead you close the door.");
                    Console.WriteLine("You hear the door very loudly click shut, and you instinctly know that you probably won't be able to open it again.");
                    Console.WriteLine("Just after closing the door, you realize that the beam of light shooting out of the door was the only thing keeping the corridor illuminated");
                    Console.WriteLine("Considering the fact that human beings don't possess night vision, it is entirely plausible that you just locked yourself in a room with no door and no way to see anything.");
                    Console.WriteLine("Congratulations, you lost.");
                    }






            }


        }
    }
}
