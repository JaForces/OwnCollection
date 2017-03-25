namespace Citizen
{
    interface ICitizen
    {
        string Firstname { get; set; }
        string LastName { get; set; }
        string Passport { get; set; }
        string FullInfo();
    }
}