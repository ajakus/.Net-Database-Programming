using TicketOOP.Models;

namespace TicketOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var managing = new managing();
            var userRequest = managing.GetUserInput();

            TicketManager ticketManager = new TicketManager();
            while (userRequest != 'Q')
            {
                ticketManager.Process(userRequest);
                userRequest = menu.GetUserInput();
            }
        }
    }
}