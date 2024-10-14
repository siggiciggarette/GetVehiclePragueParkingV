//void GetVehicle ()
//Get regNr input- får vara max 10 tecken
string[] parkingSpaces = new string[100];

int choice = 0; //användbar för användaren park/remove

Console.WriteLine("Enter vehicle(s) registration number");
string regNumber = Console.ReadLine();
//fråga efter fordonstyp
//spara enskilt då två mc kan vara på samma plats

if (regNumber.Length >= 10 || regNumber == null || regNumber == " ")
{
    Console.WriteLine("Invalid registration number");
}
bool vehicleFound = false;
//leta igenom alla platser med en forloop om regnr är giltigt (100 platser)
for (int i = 0; i < parkingSpaces.Length; i++)
{
    //kontrollera att fordonet finns på en plats
    if (parkingSpaces[i] != null && parkingSpaces[i] == regNumber)
    {
        vehicleFound = true;
        Console.WriteLine($"Vehicle {regNumber} has been removed from space {i + 1}.");
        break;// varför +1? för att bli mer användarvänligt då arrays första element på index är 0
    }

}
// var vehicleFound = 0; för att hitta vehicle i search var för okänd variabeltyp
//Ta bort fordonet
parkingSpaces = null; //kan vara ett = bara
//fordonet finns inte
if (!vehicleFound)
{
    Console.WriteLine("Vehicle not found");

}
//hitta input i parkingSpaces
//ta bort det från parkingSpaces






