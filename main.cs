/* basic structure (optional)
namespace BK.TestEnv {
    class MainLogic {
        static void Main(string[] args) {
            Console.WriteLine(getText());
        }
        public static String getText() {
            return "Test-Text";
        }
    }
}
*/


/* Subscription notice
Random random = new();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

Console.WriteLine("DEBUG: "+daysUntilExpiration);
string subMsg = "";
switch(daysUntilExpiration) {
    case <=10 and >5:
        subMsg = "Your subscription will expire soon. Renew now!";
    break;
    case <=5 and >1:
        discountPercentage = 10;
        subMsg = $"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!";
    break;
    case 1:
        discountPercentage = 20;
        subMsg = $"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!";
    break;
    case 0:
        subMsg = "Your subscription has expired.";
    break;
}
Console.Write(subMsg);
*/


/* 1-3D array
int[] oneD = [1, 2, 3];
int[,] twoD = { {1,2}, {1,2} };
int[,,] threeD = {{{ 1, 2}, { 3, 4}}, {{ 1, 2}, { 3, 4}}};
twoD[0,0] = 2;
twoD[1,1] = 1;
*/


/* foreach array, get specific elements
string[] orders = [
    "B123",
    "C234",
    "A345",
    "C15",
    "B177",
    "G3003",
    "C235",
    "B179"
];
Array.ForEach(orders, e => Console.Write((e.StartsWith('B') ? e+'\n' : null)));
*/


/* Coinflip
Random rnd = new();
Console.WriteLine(rnd.Next(2) == 1 ? "Heads!" : "Tails!");
*/


/* System Acces condition
string perm = "Admin|Manager";
int lvl = 55;
string msg = "";
if(perm.Contains("Admin"))
    msg = lvl > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.";
else if(perm.Contains("Manager"))
    msg = lvl >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.";
else msg = "You do not have sufficient privileges.";
Console.WriteLine(msg);
*/


/* FizzBuzz loop
for(int i=0; i<=100; i++)
    Console.WriteLine(i+(i%3 == 0 && i%5 == 0 ? " FizzBuzz" : i%3 == 0 ? " Fizz" : i%5 == 0 ? " Buzz" : ""));
*/


/* RPG simulation
int hero = 20;
int monster = 20;
Random rnd = new();
int attack;
while(hero > 0) {
    attack = rnd.Next(1, 11);
    monster -= attack;
    if(monster<=0) {
        Console.WriteLine($"Hero\tattacked for:\t{attack}!\t~The Monster is dead!~");
        break;
    }
    Console.WriteLine($"Hero\tattacked for:\t{attack}!\tMonster: HP {monster}/10");
    attack = rnd.Next(1, 11);
    hero -= attack;
    if(hero<=0) {
        Console.WriteLine($"Monster\tattacked for:\t{attack}!\t~The Hero is dead!~");
        break;
    }
    Console.WriteLine($"Monster\tattacked for:\t{attack}!\tHero:\t HP {hero}/10");
    while(Console.ReadKey().Key != ConsoleKey.Enter);
}
*/


/* Input validation
string? input;
int value = 0;
Console.WriteLine("Enter an integer value between 5 and 10");
do {
    input = Console.ReadLine();
    if(!int.TryParse(input, out value))
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    else if(value < 5 || value > 10)
        Console.WriteLine($"You entered {input}. Please enter a number between 5 and 10.");
    else {
        Console.WriteLine($"Your input value ({input}) has been accepted.");
        break;
    }
} while(true);
*/
